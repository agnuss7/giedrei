using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace forms
{
    public partial class vaistai_index : Form
    {
        private int id;
        private string sql = "select * from vaistai where id=";
        public vaistai_index(int k=0)
        {
            id = k;
            InitializeComponent();
            if (id > 0)
            {
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
                m_dbConnection.Open();

                using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
                {
                    SQLiteDataAdapter sda = new SQLiteDataAdapter(sql + this.id.ToString(), conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    DataRow row = ds.Tables[0].Rows[0];
                    kiti_vaistai_pav.Text = row["pavadinimas"].ToString();
                    kiti_vaistai_matas.Text = row["matas"].ToString();
                }

                m_dbConnection.Close();
            }
        }

        private void kiti_vaistai_button_Click(object sender, EventArgs e)
        {
            if (validation.MandatoryTextFieldsNotEmpty(new[] { kiti_vaistai_matas.Text, kiti_vaistai_pav.Text }))
            {
                string[] fields = { "pavadinimas", "matas"};
                string[] values = { kiti_vaistai_pav.Text, kiti_vaistai_matas.Text };

                if (id > 0)
                {
                    DBupdate.update_fields_to_database_strings("vaistai", "id=" + id.ToString(), fields, values);
                }
                else
                {
                    int new_id = DBupdate.GenerateId("vaistai", "id");
                    DBupdate.add_new_to_database("vaistai", "id", new_id, fields,values);
                }


                foreach (Form f in Application.OpenForms)
                {
                    if (f != null)
                    {
                        if (f.Name == "Zurnalas")
                        {
                            ((Zurnalas)f).kiti_load_all(2);
                            break;
                        }
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Pavadinimas ir matas yra būtini laukai.");
            }
        }
    }
}
