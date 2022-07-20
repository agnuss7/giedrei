using System;
using System.Windows.Forms;

namespace forms
{
    public partial class new_vaistas : Form
    {
        public int siunta_id=0;
        public new_vaistas(int siunta_id=0)
        {
            InitializeComponent();
            this.siunta_id = siunta_id;
        }

        private void new_vaistas_saugoti_Click(object sender, EventArgs e)
        {
            if (validation.MandatoryTextFieldsNotEmpty(new[] { new_vaistas_matas.Text, new_vaistas_pavadinimas.Text }))
            {
                int new_id = DBupdate.GenerateId("vaistai", "id");
                DBupdate.add_new_to_database("vaistai", "id", new_id, new[] { "pavadinimas", "matas" }, new[] { new_vaistas_pavadinimas.Text, new_vaistas_matas.Text });
                if (siunta_id > 0 || siunta_id==-1)
                {
                    foreach(Form f in Application.OpenForms)
                    {
                        if (f != null)
                        {
                            if(f.Name == "vaistai_select" && ((vaistai_select)f).siunta_id == siunta_id)
                            {
                                ((vaistai_select)f).load_table(new_id);
                                break;
                            }
                        }
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Pavadinimas ir matas yra būtini laukai!");
            }
        }
    }
}
