using System;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Windows.Forms;

namespace forms
{
    public partial class vaistu_siunta : Form
    {
        public int id=0;
        public int vaistas_id=0;
        public bool needs_saving = false;

        public vaistu_siunta(int siuntos_id=0)
        {
            InitializeComponent();
            id = siuntos_id;
            if (id > 0)
            {
                e_siunta_gautas_kiekis_1.Enabled = false;
                e_siunta_gautas_kiekis_2.Enabled = false;
                e_siunta_gautas_kiekis_sveikas.Enabled = false;
                string sql = "select b.id vaistai_id, b.pavadinimas, b.matas,a.gavimo_data,a.dokumentas,a.serija,a.gautas_kiekis,a.turimas_kiekis,a.galiojimo_data from vaistai_siuntos a join vaistai b on b.id=a.vaistai_id where a.id="+id.ToString();
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
                m_dbConnection.Open();

                using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
                {
                    SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    DataRow row = ds.Tables[0].Rows[0];
                    if (row != null)
                    {
                        vaistas_id = Convert.ToInt32(row["vaistai_id"].ToString());
                        e_siunta_dokumentas.Text = row["dokumentas"].ToString();
                        e_siunta_serija.Text = row["serija"].ToString();
                        e_siunta_pavadinimas.Text = row["pavadinimas"].ToString();
                        e_siunta_matas.Text = row["matas"].ToString();
                        e_siunta_gavimo_data.Value = (DateTime)row["gavimo_data"];
                        e_siunta_galiojimo_data.Value = (DateTime)row["galiojimo_data"];
                        e_siunta_group.Visible = false;
                        e_siunta_gautas_kiekis.Text = row["gautas_kiekis"].ToString().Replace('.',',');
                        e_siunta_turimas_kiekis.Text = row["turimas_kiekis"].ToString().Replace('.', ',');
                    }
                }
                m_dbConnection.Close();
                needs_saving = false;
            }
            else
            {
                id = -1;
                e_siunta_add_sveikas.Enabled = false;
                e_siunta_add_2.Enabled = false;
                e_siunta_add_1.Enabled = false;
                e_siunta_add_button.Enabled = false;
                e_siunta_kiekis_pokytis.Enabled = false;
                e_siunta_gautas_kiekis.Visible = false;
                needs_saving = true;
            }
        }

        

        private void e_siunta_select_vaistas_button_Click(object sender, EventArgs e)
        {
            vaistai_select deriv = new vaistai_select(id,vaistas_id);
            deriv.Show();
        }

        private void e_siunta_save()
        {
            string[] fields = { "vaistai_id", "gavimo_data","dokumentas","serija","galiojimo_data","turimas_kiekis","gautas_kiekis"};
            string[] values = { vaistas_id.ToString(), e_siunta_gavimo_data.Value.ToString("yyyy-MM-dd"),e_siunta_dokumentas.Text,e_siunta_serija.Text, e_siunta_galiojimo_data.Value.ToString("yyyy-MM-dd"),e_siunta_turimas_kiekis.Text.Replace(',','.'),"" };

            if (vaistas_id > 0)
            {
                if (id > 0)
                {
                    values[6] = e_siunta_gautas_kiekis.Text.Replace(',', '.');
                    DBupdate.update_fields_to_database_strings("vaistai_siuntos", "id=" + id.ToString(), fields, values);
                }
                else
                {
                    string k = e_siunta_gautas_kiekis_sveikas.Value.ToString() + "." + e_siunta_gautas_kiekis_1.Value.ToString() + e_siunta_gautas_kiekis_2.Value.ToString();
                    values[6] = k;
                    DBupdate.add_new_to_database("vaistai_siuntos", "id", DBupdate.GenerateId("vaistai_siuntos", "id"), fields, values);
                }
            }
            needs_saving = false;

        }

        private void make_likes(object sender, EventArgs e)
        {
            e_siunta_turimas_kiekis.Text = e_siunta_gautas_kiekis_sveikas.Value.ToString() + "," + e_siunta_gautas_kiekis_1.Value.ToString() + e_siunta_gautas_kiekis_2.Value.ToString();
        }

        public void set_vaistas(int vaist_id)
        {
            this.vaistas_id = vaist_id;
            e_siunta_pavadinimas.Text=DBupdate.GetValueFrom("vaistai","pavadinimas","id="+vaistas_id.ToString());
            e_siunta_matas.Text = DBupdate.GetValueFrom("vaistai", "matas", "id=" + vaistas_id.ToString());
            needs_saving = true;
        }
        private void e_siunta_save_button_Click(object sender, EventArgs e)
        {
            if (vaistas_id > 0)
            {
                if (needs_saving)
                    e_siunta_save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nepasirinktas vaistas");
            }
        }

        private void set_unsaved(object sender, EventArgs e)
        {
            needs_saving = true;
        }

        public void before_close(Object sender, FormClosingEventArgs e)
        {
            if (needs_saving)
            {
                if (vaistas_id > 0)
                {
                    DialogResult res = MessageBox.Show("Yra neišsaugotų laukų. Ar norite išsaugoti šį įrašą prieš išeidami?", "Dėmesio", MessageBoxButtons.YesNoCancel);
                    if ((int)res == 6)
                    {
                        e_siunta_save();
                    }
                    else if ((int)res == 2)
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    DialogResult res = MessageBox.Show("Nepasirinktas vaistas. Ar norite išeiti neišsaugoję įrašo?", "Dėmesio", MessageBoxButtons.YesNo);
                    if ((int)res != 6)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }



        private void e_siunta_add_button_Click(object sender, EventArgs e)
        {
            if (e_siunta_kiekis_pokytis.SelectedItem != null)
            {
                double vykdymo_kiekis = double.Parse(e_siunta_add_sveikas.Value.ToString() + "." + e_siunta_add_1.Value.ToString() + e_siunta_add_2.Value.ToString(), CultureInfo.InvariantCulture);
                double turimas_kiekis = double.Parse(e_siunta_turimas_kiekis.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                double gautas_kiekis = double.Parse(e_siunta_gautas_kiekis.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                if (vykdymo_kiekis > 0)
                {
                    switch (e_siunta_kiekis_pokytis.SelectedIndex)
                    {
                        case 0:
                            if (turimas_kiekis >= vykdymo_kiekis && gautas_kiekis>=vykdymo_kiekis)
                            {
                                e_siunta_turimas_kiekis.Text = String.Format("{0:0.##}", (turimas_kiekis - vykdymo_kiekis)).Replace(".", ",");
                                e_siunta_gautas_kiekis.Text = String.Format("{0:0.##}", (gautas_kiekis - vykdymo_kiekis)).Replace(".", ",");
                            }
                            else
                            {
                                MessageBox.Show("Per didelis kiekis atimti.");
                            }
                            break;
                        case 1:
                            e_siunta_turimas_kiekis.Text = String.Format("{0:0.##}", (vykdymo_kiekis+turimas_kiekis)).Replace(".",",");
                            e_siunta_gautas_kiekis.Text = String.Format("{0:0.##}", (vykdymo_kiekis + gautas_kiekis)).Replace(".", ",");
                            break;
                        case 2:
                            if (turimas_kiekis >= vykdymo_kiekis)
                            {
                                e_siunta_turimas_kiekis.Text = String.Format("{0:0.##}", (turimas_kiekis-vykdymo_kiekis)).Replace(".", ",");
                            }
                            else
                            {
                                MessageBox.Show("Per didelis kiekis atimti.");
                            }
                            break;
                        case 3:
                            e_siunta_turimas_kiekis.Text = String.Format("{0:0.##}", (turimas_kiekis + vykdymo_kiekis)).Replace(".", ",");
                            break;
                    }
                    needs_saving = true;
                }
                else
                {
                    MessageBox.Show("Nepasirinktas kiekis.");
                }
            }
        }

        private void reload_main_f_table(object sender, FormClosedEventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f != null)
                {
                    if (f.Name == "Zurnalas")
                    {
                        ((Zurnalas)f).LoadSiuntosDataFromDB();
                        break;
                    }
                }
            }
        }
    }
}
