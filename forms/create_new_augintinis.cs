using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class create_new_augintinis : Form
    {
        public int zurnalas_id;

        public create_new_augintinis(int id)
        {
            this.zurnalas_id = id;
            InitializeComponent();
        }

        private void gyv_kurti_Click(object sender, EventArgs e)
        {
            if (new_gyv_lytis.SelectedItem!=null && validation.MandatoryTextFieldsNotEmpty(new[] { new_gyv_vardas.Text, new_gyv_rusis.Text }))
            {
                
                int new_id = DBupdate.GenerateId("gyvunas", "id");
                DBupdate.add_new_to_database("gyvunas", "id", new_id, new[] { "vardas", "rusis", "veisle", "isvaizda", "lytis","zenklinimo_nr","amzius","pasas"}, new[] { new_gyv_vardas.Text, new_gyv_rusis.Text, new_gyv_veisle.Text, new_gyv_isvaizda.Text,((new_gyv_lytis.SelectedItem.ToString()=="Patinas") ? "1":"0"),new_gyv_zenk_nr.Text,new_gyv_amzius.Text,new_gyv_pasas.Text});
                foreach (Form f in Application.OpenForms)
                {
                    if (f != null)
                    {
                        if (f.Name == "augintinis_select" && ((augintinis_select)f).zurnalas_id == zurnalas_id)
                        {
                            ((augintinis_select)f).LoadFromDB(new_id);
                            break;
                        }
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Vardas, rūšis ir lytis yra būtini laukai.");
            }
        }

        
    }
}
