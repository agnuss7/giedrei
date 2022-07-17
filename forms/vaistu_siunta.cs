using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class vaistu_siunta : Form
    {
        public int id=0;
        public int vaistas_id=0;

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
                        e_siunta_gautas_kiekis.Text = row["gautas_kiekis"].ToString();
                        e_siunta_turimas_kiekis.Text = row["turimas_kiekis"].ToString();
                    }
                }
                m_dbConnection.Close();
            }
            else
            {
                e_siunta_add_sveikas.Enabled = false;
                e_siunta_add_2.Enabled = false;
                e_siunta_add_1.Enabled = false;
                e_siunta_add_button.Enabled = false;
                e_siunta_kiekis_pokytis.Enabled = false;
                e_siunta_gautas_kiekis.Visible = false;
            }
        }

        

        private void e_siunta_select_vaistas_button_Click(object sender, EventArgs e)
        {

        }

        private void e_siunta_save()
        {
            string[] fields = { "vaistai_id", "gavimo_data","dokumentas","serija","galiojimo_data","turimas_kiekis","gautas_kiekis"};
            string[] values = { vaistas_id.ToString(), e_siunta_gavimo_data.Value.ToString("yyyy-MM-dd"),e_siunta_dokumentas.Text,e_siunta_serija.Text, e_siunta_galiojimo_data.Value.ToString("yyyy-MM-dd"),e_siunta_turimas_kiekis.Text,"" };
            if (vaistas_id > 0)
            {
                if (id > 0)
                {
                    values[6] = e_siunta_gautas_kiekis.Text;
                    DBupdate.update_fields_to_database_strings("vaistai_siuntos", "id=" + id.ToString(), fields, values);
                }
                else
                {
                    string k = e_siunta_gautas_kiekis_sveikas.Value.ToString() + "." + e_siunta_gautas_kiekis_1.Value.ToString() + e_siunta_gautas_kiekis_2.Value.ToString();
                    values[6] = k;
                    DBupdate.add_new_to_database("vaistai_siuntos", "id", DBupdate.GenerateId("vaistai_siuntos", "id"), fields, values);
                }
            }
        }

        private void e_siunta_save_button_Click(object sender, EventArgs e)
        {
            e_siunta_save();
            this.Close();
        }
    }
}
