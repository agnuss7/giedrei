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
    public partial class create_new_laikytojas : Form
    {
        public int zurnalas_id;
        public create_new_laikytojas(int id)
        {
            this.zurnalas_id = id;
            InitializeComponent();
        }


        private void new_create_laikytojas_Click(object sender, EventArgs e)
        {

            if (validation.MandatoryTextFieldsNotEmpty(new[] {new_laik_vardas.Text, new_laik_pavarde.Text })){
                int new_id = DBupdate.GenerateId("laikytojai", "id");
                DBupdate.add_new_to_database("laikytojai","id", new_id, new[] { "vardas", "pavarde", "adresas", "telefonas" },new[] { new_laik_vardas.Text, new_laik_pavarde.Text, new_adresas.Text, new_telefonas.Text });
                foreach (Form f in Application.OpenForms)
                {
                    if (f != null)
                    {
                        if (f.Name == "laikytojas_select" && ((laikytojas_select)f).zurnalas_id == zurnalas_id)
                        {
                            ((laikytojas_select)f).LoadFromDB(new_id);
                            break;
                        }
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Vardas ir pavardė yra būtini laukai.");
            }
        }
    }
}
