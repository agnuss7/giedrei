using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace forms
{
    public partial class Zurnalas : Form
    {


        public string[] database_fields = { "reg_data", "vardas", "pavarde", "adresas", "gyv_vardas", "rusis", "veisle", "lytis", "amzius", "zenklinimo_nr", "pasas", "pastebejimo_data", "vaistai", "bukle", "diagnoze", "paslaugos", "baigtis", "tyrimai" };
        public string[] list_fields = { "Registravimo data", "Savininko vardas", "Pavardė", "Adresas", "Gyvūno vardas", "Gyvūno rūšis", "Veislė", "Lytis", "Amžius (metais)", "Ženklinimo numeris", "Paso numeris", "Ligos pastebėjimo data", "Skirti vaistai", "Būklė", "Diagnozė", "Skirtos paslaugos", "Ligos baigtis", "Atlikti tyrimai" };
        public Zurnalas()
        {
            InitializeComponent();
            LoadZurnalasData();
            foreach (ColumnHeader h in zurnalas_list.Columns)
                h.Width = 150;

            LoadSiuntosDataFromDB();
            kiti_load_all();
        }

        //pagrindinis zurnalas -------------------

        private void LoadZurnalasData()
        {
            foreach (string column_name in list_fields)
                this.zurnalas_list.Columns.Add(column_name);

            LoadDataFromDB();
        }


        private void zurnalas_list_DoubleClick(object sender, EventArgs e)
        {
            if (zurnalas_list.SelectedItems.Count > 0)
            {
                Zurnalas_entry deriv = new Zurnalas_entry(Int32.Parse(zurnalas_list.SelectedItems[0].Tag.ToString()));
                deriv.Show();
            }
        }

        public void LoadDataFromDB()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
            m_dbConnection.Open();

            using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
            {
                string sql = "select f.*,group_concat(j.pavadinimas) tyrimai from (select a.id, a.reg_data,b.vardas,b.pavarde,b.adresas,c.vardas gyv_vardas, c.rusis,c.veisle,c.lytis,c.amzius,c.zenklinimo_nr, c.pasas,a.pastebejimo_data, group_concat(e.pavadinimas) vaistai,a.bukle,a.diagnoze,a.paslaugos,a.baigtis from zurnalas a join laikytojai b on b.id=a.laikytojo_id join gyvunas c on c.id=a.gyvuno_id left join zurnalas_vaistai xx on xx.zurnalas_id=a.id left join vaistai_siuntos s on s.id=xx.vaistai_id left join vaistai e on e.id=s.vaistai_id group by a.id) f left join zurnalas_tyrimai t on t.zurnalas_id=f.id left join tyrimai j on j.id=t.tyrimai_id group by f.id";
                string where = "";
                if (main_reg_data_1.Checked)
                {
                    where += "reg_data>='" + main_reg_data_1.Value.ToString("yyyy-MM-dd") + "'";
                }
                if (main_reg_data_2.Checked)
                {
                    if (where != "")
                    {
                        where += " and ";
                    }
                    where += "reg_data<='" + main_reg_data_2.Value.ToString("yyyy-MM-dd") + "'";
                }
                if (main_simp_data_1.Checked)
                {
                    if (where != "")
                    {
                        where += " and ";
                    }
                    where += "pastebejimo_data>='" + main_simp_data_1.Value.ToString("yyyy-MM-dd") + "'";
                }
                if (main_simp_data_2.Checked)
                {
                    if (where != "")
                    {
                        where += " and ";
                    }
                    where += "pastebejimo_data<='" + main_simp_data_2.Value.ToString("yyyy-MM-dd") + "'";
                }
                if (main_search_box.Text != "")
                {
                    if (where != "")
                    {
                        where += " and ";
                    }
                    where += search.search_box(main_search_box.Text, new[] { "vardas", "pavarde", "adresas", "rusis", "zenklinimo_nr", "vaistai", "tyrimai", "bukle", "diagnoze", "paslaugos", "baigtis", "gyv_vardas", "veisle", "pasas" });
                }
                if (where != "")
                {
                    sql = "select * from (" + sql + ") where " + where;
                }
                SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                zurnalas_list.Items.Clear();
                zurnalas_list.BeginUpdate();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Tag = row["id"].ToString();
                    for (int i = 0; i < database_fields.Length; i++)
                    {
                        if (i > 0)
                        {
                            if (database_fields[i] == "lytis")
                            {
                                if ((bool)row[database_fields[i]])
                                {
                                    lvi.SubItems.Add("Patinas");
                                }
                                else
                                {
                                    lvi.SubItems.Add("Patelė");
                                }
                            }
                            else if (database_fields[i] == "pastebejimo_data")
                            {
                                lvi.SubItems.Add(row[database_fields[i]].ToString() != "" ? ((DateTime)row[database_fields[i]]).ToString("yyyy-MM-dd") : "");
                            }
                            else
                            {
                                lvi.SubItems.Add(row[database_fields[i]].ToString());
                            }
                        }
                        else
                        {
                            lvi.Text = row[database_fields[i]].ToString() != "" ? ((DateTime)row[database_fields[i]]).ToString("yyyy-MM-dd") : "";
                        }
                    }
                    zurnalas_list.Items.Add(lvi);
                }
                this.zurnalas_list.EndUpdate();
            }

            m_dbConnection.Close();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            if (zurnalas_list.SelectedItems.Count > 0)
            {
                Zurnalas_entry deriv = new Zurnalas_entry(Int32.Parse(zurnalas_list.SelectedItems[0].Tag.ToString()));
                deriv.Show();
            }
        }

        private void zurnalas_new_button_Click(object sender, EventArgs e)
        {
            Zurnalas_entry deriv = new Zurnalas_entry();
            deriv.Show();
        }

        private void main_search_button_Click(object sender, EventArgs e)
        {
            LoadDataFromDB();
        }

        private void zurnalas_eksport_button_Click(object sender, EventArgs e)
        {
            string to_excel = "";
            string delim = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;
            
            foreach (ColumnHeader h in zurnalas_list.Columns)
            {
                to_excel += h.Text + delim;
            }
            to_excel = to_excel.Substring(0, to_excel.Length - delim.Length);
            to_excel += "\n";
            foreach (ListViewItem lvl in zurnalas_list.Items)
            {
                foreach (ListViewItem.ListViewSubItem s in lvl.SubItems)
                {
                    to_excel += "=\"" + s.Text + "\"" + delim;
                }
                to_excel = to_excel.Substring(0, to_excel.Length - delim.Length);
                to_excel += "\n";
            }
            try
            {
                StreamWriter sr = new StreamWriter(Application.StartupPath + "\\zurnalas" + DateTime.Now.ToString("yyyy-MM-dd HH.mm") + ".csv",false,System.Text.Encoding.UTF8);
                
                sr.WriteLine(to_excel);
                sr.Close();
            }
            catch (Exception er)
            {
                Console.WriteLine("Exception: " + er.Message);
            }
        }

        //---------------------------------------------------------------------------------------------



        //vaistu siuntos -------------------------------

        private void siuntos_search_button_Click(object sender, EventArgs e)
        {
            LoadSiuntosDataFromDB();
        }

        private string generate_where_for_siuntos()
        {
            string where = "";
            if (siuntos_gavimo_data_1.Checked)
            {
                where += "gavimo_data>='" + siuntos_gavimo_data_1.Value.ToString("yyyy-MM-dd") + "'";
            }
            if (siuntos_gavimo_data_2.Checked)
            {
                if (where != "")
                {
                    where += " and ";
                }
                where += "gavimo_data<='" + siuntos_gavimo_data_2.Value.ToString("yyyy-MM-dd") + "'";
            }
            if (siuntos_galiojimo_data_1.Checked)
            {
                if (where != "")
                {
                    where += " and ";
                }
                where += "galiojimo_data>='" + siuntos_galiojimo_data_1.Value.ToString("yyyy-MM-dd") + "'";
            }
            if (siuntos_galiojimo_data_2.Checked)
            {
                if (where != "")
                {
                    where += " and ";
                }
                where += "galiojimo_data<='" + siuntos_galiojimo_data_2.Value.ToString("yyyy-MM-dd") + "'";
            }
            if (siuntos_empty_show.Checked)
            {
                if (where != "")
                {
                    where += " and ";
                }
                where += "turimas_kiekis>0";
            }
            if (siuntos_search_box.Text != "")
            {
                if (where != "")
                {
                    where += " and ";
                }
                where += search.search_box(siuntos_search_box.Text, new[] { "pavadinimas", "matas", "dokumentas", "serija" });
            }
            return where;
        }

        public void LoadSiuntosDataFromDB()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
            m_dbConnection.Open();

            using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
            {
                string sql = "select b.id, a.pavadinimas,a.matas,b.gavimo_data,b.dokumentas,b.serija,b.gautas_kiekis,b.turimas_kiekis,b.galiojimo_data from vaistai_siuntos b join vaistai a on a.id=b.vaistai_id";
                string where = generate_where_for_siuntos();
                if (where != "")
                {
                    sql += " where " + where;
                }
                SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                siuntos_list.Items.Clear();
                siuntos_list.BeginUpdate();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Tag = row["id"].ToString();
                    lvi.Text = row["pavadinimas"].ToString();
                    foreach (string f in new[] { "matas", "gavimo_data", "dokumentas", "serija", "gautas_kiekis", "turimas_kiekis", "galiojimo_data" })
                    {
                        if (f == "gavimo_data" || f == "galiojimo_data")
                        {
                            lvi.SubItems.Add(((DateTime)row[f]).ToString("yyyy-MM-dd"));
                        }
                        else
                        {
                            lvi.SubItems.Add(row[f].ToString());
                        }
                    }
                    siuntos_list.Items.Add(lvi);
                }
                this.siuntos_list.EndUpdate();
            }

            m_dbConnection.Close();
        }

        private void siuntos_edit_button_Click(object sender, EventArgs e)
        {
            if (siuntos_list.SelectedItems.Count > 0)
            {
                vaistu_siunta deriv = new vaistu_siunta(Convert.ToInt32(siuntos_list.SelectedItems[0].Tag.ToString()));
                deriv.Show();
            }
        }

        private void siuntos_new_button_Click(object sender, EventArgs e)
        {
            vaistu_siunta deriv = new vaistu_siunta();
            deriv.Show();
        }

        private string get_connected_zurnalas_entry(string delim)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
            m_dbConnection.Open();
            DataSet ds = new DataSet();
            using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
            {
                string sql = "select b.id, a.pavadinimas,a.matas,b.gavimo_data,b.dokumentas,b.serija,b.gautas_kiekis,b.turimas_kiekis,b.galiojimo_data from vaistai_siuntos b join vaistai a on a.id=b.vaistai_id";
                string where = generate_where_for_siuntos();
                if (where != "")
                {
                    sql += " where " + where;
                }
                SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, conn);
                sda.Fill(ds);
            }

            m_dbConnection.Close();
            string s = "";
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                m_dbConnection.Open();
                DataSet ds2 = new DataSet();
                using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
                {
                    string sql2 = "select * from zurnalas_vaistai a join zurnalas b on a.zurnalas_id=b.id join laikytojai c on c.id=b.laikytojo_id where a.vaistai_id=" + row["id"].ToString();

                    SQLiteDataAdapter sda = new SQLiteDataAdapter(sql2, conn);
                    sda.Fill(ds2);
                }
                m_dbConnection.Close();
                foreach (string f in new[] { "pavadinimas", "matas", "gavimo_data", "dokumentas", "serija", "gautas_kiekis", "turimas_kiekis", "galiojimo_data" })
                {
                    if (f == "gavimo_data" || f == "galiojimo_data")
                    {
                        if (row[f].ToString() != "") s += (((DateTime)row[f]).ToString("yyyy-MM-dd"));
                        s += delim;
                    }
                    else
                    {
                        s += (row[f].ToString()) + delim;
                    }

                }
                if (ds2.Tables[0].Rows.Count == 0) s += delim + delim + delim +delim+ delim +delim+ "\n";
                int k = 0;
                foreach (DataRow r in ds2.Tables[0].Rows)
                {
                    if (k > 0) s += delim + delim + delim + delim + delim + delim + delim + delim;
                    foreach (string v in new[] { "reg_data", "vardas", "pavarde", "telefonas", "kiekis" })
                    {
                        if (v == "reg_data")
                        {
                            if (r[v].ToString() != "") s += (((DateTime)r[v]).ToString("yyyy-MM-dd"));
                            s += delim;
                        }
                        else
                        {
                            s += r[v].ToString() + delim;
                        }
                    }
                    s = s.Substring(0, s.Length - delim.Length);
                    s += "\n";
                    k++;
                }
            }
            return s;

        }

        private void export_button_Click(object sender, EventArgs e)
        {
            string to_excel = "";
            string delim = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;
            get_connected_zurnalas_entry(delim);
            foreach (ColumnHeader h in siuntos_list.Columns)
            {
                to_excel += h.Text + delim;
            }
            to_excel += "Registravimo data" + delim + "Vardas" + delim + "Pavardė"+delim+"Telefonas"+delim+"Išrašytas kiekis"+"\n";
            try
            {
                StreamWriter sr = new StreamWriter(Application.StartupPath + "\\Vaistu_siuntos" + DateTime.Now.ToString("yyyy-MM-dd HH.mm") + ".csv", false, System.Text.Encoding.UTF8);
                sr.WriteLine(to_excel+get_connected_zurnalas_entry(delim));
                sr.Close();
            }
            catch (Exception er)
            {
                Console.WriteLine("Exception: " + er.Message);
            }
        }

        // --------------------------------

        // kitos lenteles

        public void kiti_load_all(int mode = 0)
        {
            if (mode == 0)
            {
                kiti_abstraktus("select * from vaistai", new[] { "id", "pavadinimas", "matas" }, o_vaistai_list);
                kiti_abstraktus("select * from tyrimai", new[] { "id", "pavadinimas", "antraste", "kodas" }, o_tyrimai_list);
                kiti_abstraktus("select * from laikytojai", new[] { "id", "vardas", "pavarde", "adresas", "telefonas" }, o_savininkai_list);
                kiti_abstraktus("select * from gyvunas", new[] { "id", "vardas", "rusis", "veisle", "zenklinimo_nr", "pasas", "amzius" }, o_augintiniai_list);
            }
            else if (mode == 1)
            {
                kiti_abstraktus("select * from gyvunas", new[] { "id", "vardas", "rusis", "veisle", "zenklinimo_nr", "pasas", "amzius" }, o_augintiniai_list);
            }
            else if (mode == 2)
            {
                kiti_abstraktus("select * from vaistai", new[] { "id", "pavadinimas", "matas" }, o_vaistai_list);
            }
            else if (mode == 3)
            {
                kiti_abstraktus("select * from tyrimai", new[] { "id", "pavadinimas", "antraste", "kodas" }, o_tyrimai_list);
            }
            else
            {
                kiti_abstraktus("select * from laikytojai", new[] { "id", "vardas", "pavarde", "adresas", "telefonas" }, o_savininkai_list);
            }
        }

        public void kiti_abstraktus(string sql, string[] fields, ListView kiti_list)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
            m_dbConnection.Open();

            using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
            {
                SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                kiti_list.Items.Clear();
                kiti_list.BeginUpdate();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Tag = row[fields[0]].ToString();
                    lvi.Text = row[fields[1]].ToString();
                    for (int i = 2; i < fields.Length; i++)
                    {
                        lvi.SubItems.Add(row[fields[i]].ToString());
                    }
                    kiti_list.Items.Add(lvi);
                }
                kiti_list.EndUpdate();
            }

            m_dbConnection.Close();
        }

        private void o_augintiniai_new_button_Click(object sender, EventArgs e)
        {
            augintinis_index deriv = new augintinis_index();
            deriv.Show();
        }

        private void o_augintiniai_edit_button_Click(object sender, EventArgs e)
        {
            if (o_augintiniai_list.SelectedItems.Count > 0)
            {
                augintinis_index deriv = new augintinis_index(Convert.ToInt32(o_augintiniai_list.SelectedItems[0].Tag.ToString()));
                deriv.Show();
            }
        }

        private void o_vaistai_new_button_Click(object sender, EventArgs e)
        {
            vaistai_index deriv = new vaistai_index();
            deriv.Show();
        }

        private void o_vaistai_edit_button_Click(object sender, EventArgs e)
        {
            if (o_vaistai_list.SelectedItems.Count > 0)
            {
                vaistai_index deriv = new vaistai_index(Convert.ToInt32(o_vaistai_list.SelectedItems[0].Tag.ToString()));
                deriv.Show();
            }
        }

        private void o_tyrimai_new_button_Click(object sender, EventArgs e)
        {
            tyrimai_index deriv = new tyrimai_index();
            deriv.Show();
        }

        private void o_tyrimai_edit_button_Click(object sender, EventArgs e)
        {
            if (o_tyrimai_list.SelectedItems.Count > 0)
            {
                tyrimai_index deriv = new tyrimai_index(Convert.ToInt32(o_tyrimai_list.SelectedItems[0].Tag.ToString()));
                deriv.Show();
            }
        }

        private void o_savininkai_new_button_Click(object sender, EventArgs e)
        {
            laikytojai_index deriv = new laikytojai_index();
            deriv.Show();
        }

        private void o_savininkai_edit_button_Click(object sender, EventArgs e)
        {
            if (o_savininkai_list.SelectedItems.Count > 0)
            {
                laikytojai_index deriv = new laikytojai_index(Convert.ToInt32(o_savininkai_list.SelectedItems[0].Tag.ToString()));
                deriv.Show();
            }
        }

        private void tab_changed(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    LoadDataFromDB();
                    break;
                case 1:
                    LoadSiuntosDataFromDB();
                    break;
                case 2:
                    kiti_load_all();
                    break;
            }
        }

        private void isAllowedToClose(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count > 1)
            {
                MessageBox.Show("Yra atidarytų įrašų langų!");
                e.Cancel = true;
            }
        }

        
    }
}
