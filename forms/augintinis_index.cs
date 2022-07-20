using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace forms
{
    public partial class augintinis_index : Form
    {
        private int id;
        private string[] fields={"rusis", "lytis","zenklinimo_nr", "amzius", "vardas", "veisle", "pasas", "isvaizda" };
        private string sql = "select * from gyvunas where id=";
        public augintinis_index(int id=0)
        {
            this.id = id;
            InitializeComponent();
            if (this.id > 0)
            {
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
                m_dbConnection.Open();

                using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
                {
                    SQLiteDataAdapter sda = new SQLiteDataAdapter(sql+this.id.ToString(), conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    DataRow row = ds.Tables[0].Rows[0];
                    new_gyv_amzius.Text = row["amzius"].ToString();
                    new_gyv_vardas.Text = row["vardas"].ToString();
                    new_gyv_veisle.Text = row["veisle"].ToString();
                    new_gyv_rusis.Text = row["rusis"].ToString();
                    new_gyv_pasas.Text = row["pasas"].ToString();
                    new_gyv_zenk_nr.Text = row["zenklinimo_nr"].ToString();
                    new_gyv_isvaizda.Text = row["isvaizda"].ToString();
                    if ((bool)row["lytis"])
                        new_gyv_lytis.SelectedIndex = 0; 
                    else
                        new_gyv_lytis.SelectedIndex = 1;

                }

                m_dbConnection.Close();
            }
        }

        private void gyv_kurti_Click(object sender, EventArgs e)
        {
            if (new_gyv_lytis.SelectedItem != null && validation.MandatoryTextFieldsNotEmpty(new[] { new_gyv_vardas.Text, new_gyv_rusis.Text }))
            {
                if (id > 0)
                {
                    DBupdate.update_fields_to_database_strings("gyvunas", "id=" + id.ToString(), new[] { "vardas", "rusis", "veisle", "isvaizda", "lytis", "zenklinimo_nr", "amzius", "pasas" }, new[] { new_gyv_vardas.Text, new_gyv_rusis.Text, new_gyv_veisle.Text, new_gyv_isvaizda.Text, ((new_gyv_lytis.SelectedItem.ToString() == "Patinas") ? "1" : "0"), new_gyv_zenk_nr.Text, new_gyv_amzius.Text, new_gyv_pasas.Text });
                }
                else
                {
                    int new_id = DBupdate.GenerateId("gyvunas", "id");
                    DBupdate.add_new_to_database("gyvunas", "id", new_id, new[] { "vardas", "rusis", "veisle", "isvaizda", "lytis", "zenklinimo_nr", "amzius", "pasas" }, new[] { new_gyv_vardas.Text, new_gyv_rusis.Text, new_gyv_veisle.Text, new_gyv_isvaizda.Text, ((new_gyv_lytis.SelectedItem.ToString() == "Patinas") ? "1" : "0"), new_gyv_zenk_nr.Text, new_gyv_amzius.Text, new_gyv_pasas.Text });
                }


                foreach (Form f in Application.OpenForms)
                {
                    if (f != null)
                    {
                        if (f.Name == "Zurnalas")
                        {
                            ((Zurnalas)f).kiti_load_all(1);
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
