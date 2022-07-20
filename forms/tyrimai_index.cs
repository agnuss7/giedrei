using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace forms
{
    public partial class tyrimai_index : Form
    {
        private int id;
        private string sql = "select * from tyrimai where id=";
        public tyrimai_index(int k=0)
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
                    kiti_tyrimai_zym.Text = row["pavadinimas"].ToString();
                    kiti_tyrimai_kodas.Text = row["kodas"].ToString();
                    kiti_tyrimai_antraste.Text = row["antraste"].ToString();
                }

                m_dbConnection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validation.MandatoryTextFieldsNotEmpty(new[] { kiti_tyrimai_zym.Text, kiti_tyrimai_antraste.Text }))
            {
                string[] fields = { "pavadinimas", "kodas","antraste" };
                string[] values = { kiti_tyrimai_zym.Text,kiti_tyrimai_kodas.Text,kiti_tyrimai_antraste.Text };

                if (id > 0)
                {
                    DBupdate.update_fields_to_database_strings("tyrimai", "id=" + id.ToString(), fields, values);
                }
                else
                {
                    int new_id = DBupdate.GenerateId("tyrimai", "id");
                    DBupdate.add_new_to_database("tyrimai", "id", new_id, fields, values);
                }


                foreach (Form f in Application.OpenForms)
                {
                    if (f != null)
                    {
                        if (f.Name == "Zurnalas")
                        {
                            ((Zurnalas)f).kiti_load_all(3);
                            break;
                        }
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Žymuo ir antraštė yra būtini laukai.");
            }
        }
    }
}
