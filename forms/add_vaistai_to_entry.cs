using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;

namespace forms
{
    public partial class add_vaistai_to_entry : Form
    {
        public int zurnalas_id;
        public add_vaistai_to_entry(int zur_id)
        {
            InitializeComponent();
            zurnalas_id = zur_id;
            refresh_list();
        }

        public void refresh_list(string where = "")
        {
            vaistai_to_add.Items.Clear();
            string sql = "select a.id, b.pavadinimas pav, b.matas, a.galiojimo_data, a.serija, a.turimas_kiekis from vaistai_siuntos a join vaistai b on b.id=a.vaistai_id where a.turimas_kiekis>0 ";
            if (where != "")
            {
                sql += "and " + search.search_box(where, new[] { "pav", "a.serija" });
            }
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
            m_dbConnection.Open();
            vaistai_to_add.BeginUpdate();
            using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
            {
                SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, conn);

                DataSet ds = new DataSet();
                sda.Fill(ds);
                string[] database_fields = { "pav", "matas", "galiojimo_data", "serija", "turimas_kiekis" };
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Tag = row["id"].ToString();
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
                    vaistai_to_add.Items.Add(lvi);
                }
            }
            m_dbConnection.Close();
            vaistai_to_add.EndUpdate();
        }

        private void vaistai_entry_search_Click(object sender, EventArgs e)
        {
            refresh_list(vaistai_add_search.Text);
        }

        private void vaistai_to_add_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vaistai_to_add.SelectedItems.Count > 0)
            {
                selected_vaistas.Text = vaistai_to_add.SelectedItems[0].SubItems[0].Text + " - " + vaistai_to_add.SelectedItems[0].SubItems[1].Text;
            } else
            {
                selected_vaistas.Text = "";
            }
        }

        private void add_selected_vaistai_Click(object sender, EventArgs e)
        {
            if (vaistai_to_add.SelectedItems.Count > 0)
            {
                double kiekis = double.Parse(sveikas_kiekis.Value.ToString() + "." + pirmas_kiekis.Value.ToString() + antras_kiekis.Value.ToString(), CultureInfo.InvariantCulture);
                double esamas_k = double.Parse(vaistai_to_add.SelectedItems[0].SubItems[4].Text);
                if (kiekis > esamas_k)
                {
                    MessageBox.Show("Jūsų nurodytas išrašomas kiekis per didelis.");
                }
                else if (kiekis > 0)
                {
                    if (DBupdate.RowExists("zurnalas_vaistai","zurnalas_id=" + zurnalas_id.ToString() + " and vaistai_id=" + vaistai_to_add.SelectedItems[0].Tag.ToString()))
                    {
                        DBupdate.update_fields_to_database("zurnalas_vaistai", "zurnalas_id=" + zurnalas_id.ToString() + " and vaistai_id=" + vaistai_to_add.SelectedItems[0].Tag.ToString(), new[] { "kiekis" }, new[] { "kiekis + " + kiekis.ToString().Replace(',', '.') });
                    }
                    else
                    {
                        DBupdate.add_new_to_database("zurnalas_vaistai", "zurnalas_id", zurnalas_id, new[] { "vaistai_id", "kiekis" }, new[] { vaistai_to_add.SelectedItems[0].Tag.ToString(), kiekis.ToString().Replace(',','.') });
                    }
                    DBupdate.quick_id_update_to_database("vaistai_siuntos", "id", vaistai_to_add.SelectedItems[0].Tag.ToString(), "turimas_kiekis", "round("+(esamas_k - kiekis).ToString().Replace(',', '.')+",2)");
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f != null)
                        {
                            if (f.Name == "Zurnalas_entry" && ((Zurnalas_entry)f).id == zurnalas_id)
                            {
                                ((Zurnalas_entry)f).update_vaistai();
                                break;
                            }
                        }
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nesuvestas skiriamas kiekis.");
                }
            }
        }
    }
}
