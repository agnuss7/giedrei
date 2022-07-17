using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class Zurnalas_entry : Form
    {
       // public string[] database_fields = { "reg_data", "vardas", "pavarde", "adresas", "rusis", "lytis", "amzius", "zenklinimo_nr", "pastebejimo_data", "vaistai", "bukle", "diagnoze", "paslaugos", "baigtis", "tyrimai" };
      //  public string[] list_fields = { "Registravimo data", "Savininko vardas", "Pavarde", "Adresas", "Gyvūno rūšis", "Lytis", "Amžius (metais)", "Ženklinimo numeris", "Ligos pastebėjimo data", "Skirti vaistai", "Būklė", "Diagnozė", "Skirtos paslaugos", "Ligos baigtis", "Atlikti tyrimai" };

        public int id;
        public int gyv_id=0;
        public int klient_id=0;
        public bool new_entry = false;
        public bool clicked_save = false;
        delegate void info_updater(DataRow r);
        public Zurnalas_entry(int id=0)
        {
            this.id = id;
            InitializeComponent();
            if (this.id > 0)
            {
                
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
                m_dbConnection.Open();

                using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
                {
                    //SQLiteDataAdapter sda = new SQLiteDataAdapter("select f.*,group_concat(j.pavadinimas) tyrimai from (select a.id, a.reg_data,b.vardas,b.pavarde,b.adresas,c.rusis,c.lytis,c.amzius,c.zenklinimo_nr, a.pastebejimo_data, group_concat(e.pavadinimas) vaistai,a.bukle,a.diagnoze,a.paslaugos,a.baigtis from zurnalas a join laikytojai b on b.id=a.laikytojo_id join gyvunas c on c.id=a.gyvuno_id join zurnalas_vaistai xx on xx.zurnalas_id=a.id join vaistai_siuntos s on s.id=xx.vaistai_id join vaistai e on e.id=s.vaistai_id group by a.id) f join zurnalas_tyrimai t on t.zurnalas_id=f.id join tyrimai j on j.id=t.tyrimai_id where f.id = "+this.id.ToString()+" group by f.id", conn); // MyTable (ID varchar(20), Name varchar(50) ,Score int)
                    SQLiteDataAdapter sda = new SQLiteDataAdapter("select a.reg_data,b.id klient_id,b.vardas,b.pavarde,b.adresas,b.telefonas, c.id gyv_id,c.vardas gyv_vardas, c.veisle, c.isvaizda, c.rusis,c.lytis,c.amzius,c.pasas,c.zenklinimo_nr, a.pastebejimo_data, a.bukle,a.diagnoze,a.paslaugos,a.baigtis from zurnalas a join laikytojai b on b.id=a.laikytojo_id join gyvunas c on c.id=a.gyvuno_id where a.id = " + this.id.ToString(), conn); // MyTable (ID varchar(20), Name varchar(50) ,Score int)

                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        // klientas
                        klientas_info_fill(row);

                        //augintinis
                        augintinis_info_fill(row);

                        //zurnalas
                        zurnalas_info_fill(row);
                        gyv_id = (int)row["gyv_id"];
                        klient_id = (int)row["klient_id"];
                    }
                }
                m_dbConnection.Close();
                update_info_section("select b.id,a.pavadinimas, a.matas, b.galiojimo_data, c.kiekis, b.serija from zurnalas_vaistai c join vaistai_siuntos b on b.id=c.vaistai_id join vaistai a on a.id=b.vaistai_id where c.zurnalas_id=" + this.id.ToString(), new info_updater(vaistai_info_fill));
                update_info_section("select a.id,a.pavadinimas, a.antraste, a.kodas, b.kiekis from zurnalas_tyrimai b join tyrimai a on a.id=b.tyrimai_id where b.zurnalas_id=" + this.id.ToString(), new info_updater(tyrimas_info_fill));
                clicked_save = true;
            }
            else
            {
                new_entry = true;
                this.id = create_new_entry();
            }
            update_info_section("select * from tyrimai", new info_updater(populate_tyrimai));
        }

        public int create_new_entry()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
            m_dbConnection.Open();
            int newid = DBupdate.GenerateId("zurnalas", "id");
            string sql = "insert into zurnalas (id) values (" + newid.ToString()+")";
            using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
            {
                using (SQLiteCommand sqlcmd = new SQLiteCommand(sql, conn))
                {
                    sqlcmd.ExecuteNonQuery();
                }

            }
            m_dbConnection.Close();
            return newid;
        }

        public void populate_tyrimai(DataRow row)
        {
            e_tyrimai_select.Items.Add(row["pavadinimas"].ToString() + "_ " + row["antraste"].ToString());
        }

        public void update_klient_info()
        {
            update_info_section("select a.vardas, a.pavarde, a.adresas, a.telefonas from laikytojai a where a.id=" + this.klient_id.ToString(), klientas_info_fill);
        }

        public void update_gyv_info()
        {
            update_info_section("select a.vardas gyv_vardas, a.rusis, a.lytis, a.zenklinimo_nr,a.isvaizda,a.amzius,a.veisle,a.pasas from gyvunas a where a.id=" + this.gyv_id.ToString(), augintinis_info_fill);
        }

        private void update_info_section(string sql, info_updater f){

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
            m_dbConnection.Open();

            using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
            {
                SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, conn); 

                DataSet ds = new DataSet();
                sda.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    f(row);
                }
            }
            m_dbConnection.Close();
        }

        private void klientas_info_fill(DataRow row)
        {
            e_vardas.Text = row["vardas"].ToString();
            e_pavarde.Text = row["pavarde"].ToString();
            e_adresas.Text = row["adresas"].ToString();
            e_telefonas.Text = row["telefonas"].ToString();
        }

        private void augintinis_info_fill(DataRow row)
        {
            e_gyv_vardas.Text = row["gyv_vardas"].ToString();
            e_rusis.Text = row["rusis"].ToString();
            e_amzius.Text = row["amzius"].ToString();
            e_veisle.Text = row["veisle"].ToString();
            e_isvaizda.Text = row["isvaizda"].ToString();
            e_pasas.Text = row["pasas"].ToString();
            e_zenk.Text = row["zenklinimo_nr"].ToString();
            e_lytis.Text = (bool)(row["lytis"]) ? "Patinas" : "Patelė";
        }

        private void zurnalas_info_fill(DataRow row)
        {
            e_reg_data.Value = DateTime.Parse(row["reg_data"].ToString());
            e_simp_data.Value = DateTime.Parse(row["pastebejimo_data"].ToString());
            e_baigtis.Text = row["baigtis"].ToString();
            e_bukle.Text = row["bukle"].ToString();
            e_diagnoze.Text = row["diagnoze"].ToString();
            e_paslaugos.Text = row["paslaugos"].ToString();
        }

        private void vaistai_info_fill(DataRow row)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Tag = row["id"].ToString();
            string[] database_fields = { "pavadinimas","matas","galiojimo_data","kiekis","serija"};
            for (int i = 0; i < database_fields.Length; i++)
            {
                if (i > 0)
                {
                    lvi.SubItems.Add(row[database_fields[i]].ToString()); 
                }
                else
                {
                    lvi.Text = row[database_fields[i]].ToString();
                }
            }
            e_vaistai.Items.Add(lvi);
        }
        private void tyrimas_info_fill(DataRow row)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Tag = row["id"].ToString();
            string[] database_fields = { "pavadinimas", "kodas", "antraste", "kiekis" };
            for (int i = 0; i < database_fields.Length; i++)
            {
                if (i > 0)
                {
                    lvi.SubItems.Add(row[database_fields[i]].ToString());
                }
                else
                {
                    lvi.Text = row[database_fields[i]].ToString();
                }
            }
            e_tyrimai.Items.Add(lvi);
        }

        private void zur_save_Click(object sender, EventArgs e)
        {
            clicked_save = true;
            DBupdate.update_fields_to_database("zurnalas", "id=" + this.id.ToString(), new[] { "reg_data", "pastebejimo_data", "bukle", "diagnoze", "paslaugos", "baigtis" }, new[] { "'"+ e_reg_data.Value.ToString("yyyy-MM-dd")+ "'", "'"+e_simp_data.Value.ToString("yyyy-MM-dd")+ "'", "'" + e_bukle.Text + "'", "'" + e_diagnoze.Text + "'", "'" + e_paslaugos.Text + "'", "'" + e_baigtis.Text + "'" });
        }

        private void e_select_savininkas_Click(object sender, EventArgs e)
        {
            laikytojas_select deriv = new laikytojas_select(id,klient_id);
            deriv.Show();
        }

        private void e_edit_augintinis_Click(object sender, EventArgs e)
        {
            augintinis_select deriv = new augintinis_select(id, gyv_id);
            deriv.Show();
        }

        private void e_tyrimas_add_Click(object sender, EventArgs e)
        {
            if (e_tyrimai_select.SelectedItem != null)
            {
                string kodas = e_tyrimai_select.SelectedItem.ToString().Remove(e_tyrimai_select.SelectedItem.ToString().IndexOf('_'));
                string tyr_id = DBupdate.GetValueFrom("tyrimai", "id", "pavadinimas='" + kodas + "'");
                if (tyr_id != "")
                {
                    if (DBupdate.RowExists("zurnalas_tyrimai","tyrimai_id="+tyr_id+" and zurnalas_id=" + id.ToString()))
                    {
                        if (DBupdate.RowExists("zurnalas_tyrimai", "tyrimai_id=" + tyr_id + " and zurnalas_id=" + id.ToString() + " and kiekis is null"))
                        {
                            DBupdate.update_fields_to_database("zurnalas_tyrimai", "tyrimai_id=" + tyr_id + " and zurnalas_id=" + id.ToString(), new[] { "kiekis" }, new[] { "2" });
                        } else
                        {
                            DBupdate.update_fields_to_database("zurnalas_tyrimai", "tyrimai_id=" + tyr_id + " and zurnalas_id=" + id.ToString(), new[] { "kiekis" }, new[] { "kiekis+1" });
                        }
                    }
                    else
                    {
                        DBupdate.add_new_to_database("zurnalas_tyrimai","zurnalas_id",id,new[] { "tyrimai_id" },new[] { tyr_id });
                    }
                }
                e_tyrimai.Items.Clear();
                update_info_section("select a.id,a.pavadinimas, a.antraste, a.kodas, b.kiekis from zurnalas_tyrimai b join tyrimai a on a.id=b.tyrimai_id where b.zurnalas_id=" + this.id.ToString(), new info_updater(tyrimas_info_fill));
            }
        }

        private void e_tyrimas_remove_Click(object sender, EventArgs e)
        {
            if (e_tyrimai_select.SelectedItem != null)
            {
                string kodas = e_tyrimai_select.SelectedItem.ToString().Remove(e_tyrimai_select.SelectedItem.ToString().IndexOf('_'));
                string tyr_id = DBupdate.GetValueFrom("tyrimai", "id", "pavadinimas='" + kodas + "'");
                if (tyr_id != "")
                {
                    if (DBupdate.RowExists("zurnalas_tyrimai", "tyrimai_id=" + tyr_id + " and zurnalas_id=" + id.ToString()))
                    {
                        if (DBupdate.RowExists("zurnalas_tyrimai", "tyrimai_id=" + tyr_id + " and zurnalas_id=" + id.ToString() + " and (kiekis is null or kiekis=1)"))
                        {
                            DBupdate.delete_from_database("zurnalas_tyrimai", "tyrimai_id=" + tyr_id + " and zurnalas_id=" + id.ToString());
                        }
                        else
                        {
                            DBupdate.update_fields_to_database("zurnalas_tyrimai", "tyrimai_id=" + tyr_id + " and zurnalas_id=" + id.ToString(), new[] { "kiekis" }, new[] { "kiekis-1" });
                        }
                    }
                }
                e_tyrimai.Items.Clear();
                update_info_section("select a.id,a.pavadinimas, a.antraste, a.kodas, b.kiekis from zurnalas_tyrimai b join tyrimai a on a.id=b.tyrimai_id where b.zurnalas_id=" + this.id.ToString(), new info_updater(tyrimas_info_fill));
            }
        }

        private void e_add_vaistai_Click(object sender, EventArgs e)
        {
            add_vaistai_to_entry deriv = new add_vaistai_to_entry(this.id);
            deriv.Show();
        }

        public void update_vaistai()
        {
            e_vaistai.Items.Clear();
            update_info_section("select b.id,a.pavadinimas, a.matas, b.galiojimo_data, c.kiekis, b.serija from zurnalas_vaistai c join vaistai_siuntos b on b.id=c.vaistai_id join vaistai a on a.id=b.vaistai_id where c.zurnalas_id=" + this.id.ToString(), new info_updater(vaistai_info_fill));

        }

        private void e_remove_vaistai_Click(object sender, EventArgs e)
        {
            if (e_vaistai.SelectedItems.Count > 0)
            {
                DBupdate.quick_id_update_to_database("vaistai_siuntos", "id", e_vaistai.SelectedItems[0].Tag.ToString(), "turimas_kiekis", "turimas_kiekis+" + e_vaistai.SelectedItems[0].SubItems[3].Text);
                DBupdate.delete_from_database("zurnalas_vaistai", "zurnalas_id=" + this.id.ToString() + " and vaistai_id=" + e_vaistai.SelectedItems[0].Tag.ToString());
                update_vaistai();
            }
        }

        public void e_on_close(Object sender, FormClosingEventArgs e)
        {
            if(new_entry && (!clicked_save || klient_id==0 || gyv_id==0))
            {
                String laukai = "";
                if (klient_id == 0)
                {
                    laukai += "laikytojo";
                }
                if (gyv_id == 0)
                {
                    if (laukai.Length > 0)
                    {
                        laukai += ", augintinio";
                    }
                    else
                    {
                        laukai += "augintinio";
                    }
                }
                if (!clicked_save)
                {
                    if (laukai.Length > 0)
                    {
                        laukai += " ir žurnalo (neišsaugota)";
                    }
                    else
                    {
                        laukai += "žurnalo (neišsaugota)";
                    }
                }
                laukai += ".";
                DialogResult res = MessageBox.Show("Yra neįrašytų/neišsaugotų būtinų sekcijų: "+laukai+" Ar norite išeiti neišsaugoję šio įrašo?", "Dėmesio", MessageBoxButtons.YesNo);
                if ((int)res == 6)
                {
                    if (DBupdate.RowExists("zurnalas_vaistai", "zurnalas_id=" + this.id.ToString()))
                    {
                        e.Cancel = true;
                        MessageBox.Show("Dėmesio! Trynimas negalimas, nes buvo skirti vaistai! Atšaukite vaistų skyrimus, kad išvengti neatitikimų.");
                    }
                    else
                    {
                        DBupdate.delete_from_database("zurnalas", "id=" + this.id.ToString());
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            } else if (!clicked_save)
            {
                DialogResult res = MessageBox.Show("Žurnalo sekcija buvo pakeista ir neišsaugota. Ar norite išsaugoti šį įrašą prieš išeidami?", "Dėmesio", MessageBoxButtons.YesNoCancel);
                if ((int)res == 6)
                {
                    DBupdate.update_fields_to_database("zurnalas", "id=" + this.id.ToString(), new[] { "reg_data", "pastebejimo_data", "bukle", "diagnoze", "paslaugos", "baigtis" }, new[] { "'"+e_reg_data.Value.ToString("yyyy-MM-dd")+ "'", "'"+e_simp_data.Value.ToString("yyyy-MM-dd")+ "'", "'"+e_bukle.Text+ "'", "'"+e_diagnoze.Text+ "'", "'"+e_paslaugos.Text+ "'", "'"+e_baigtis.Text+ "'" });
                }
                else if ((int)res == 2)
                {
                    e.Cancel = true;
                }
            }
        }

        public void change_saved_status(object sender, EventArgs e)
        {
            clicked_save = false;
        }

        public void reload_main_f_table(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f != null)
                {
                    if (f.Name == "Zurnalas")
                    {
                        ((Zurnalas)f).LoadDataFromDB();
                        break;
                    }
                }
            }
        }
    }
}
