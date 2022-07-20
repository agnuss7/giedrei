using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace forms
{
    public partial class laikytojai_index : Form
    {
        private int id;
        private string sql = "select * from laikytojai where id=";
        public laikytojai_index(int k=0)
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
                    kiti_laikytojai_adresas.Text = row["adresas"].ToString();
                    kiti_laikytojai_pavarde.Text = row["pavarde"].ToString();
                    kiti_laikytojai_tel.Text = row["telefonas"].ToString();
                    kiti_laikytojai_vardas.Text = row["vardas"].ToString();
                }

                m_dbConnection.Close();
            }
        }

        private void kiti_laikytojai_button_Click(object sender, EventArgs e)
        {
            if (validation.MandatoryTextFieldsNotEmpty(new[] { kiti_laikytojai_vardas.Text,kiti_laikytojai_pavarde.Text }))
            {
                string[] fields = { "vardas","pavarde","adresas","telefonas" };
                string[] values = { kiti_laikytojai_vardas.Text, kiti_laikytojai_pavarde.Text,kiti_laikytojai_adresas.Text,kiti_laikytojai_tel.Text };

                if (id > 0)
                {
                    DBupdate.update_fields_to_database_strings("laikytojai", "id=" + id.ToString(), fields, values);
                }
                else
                {
                    int new_id = DBupdate.GenerateId("laikytojai", "id");
                    DBupdate.add_new_to_database("laikytojai", "id", new_id, fields, values);
                }


                foreach (Form f in Application.OpenForms)
                {
                    if (f != null)
                    {
                        if (f.Name == "Zurnalas")
                        {
                            ((Zurnalas)f).kiti_load_all(4);
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
