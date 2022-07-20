using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace forms
{
    public partial class laikytojas_select : Form
    {
        public int zurnalas_id;
        private int selected_laikytojas_id;
        public laikytojas_select(int zurnalas_id, int selected_laikytojas_id = 0)
        {
            this.zurnalas_id = zurnalas_id;
            this.selected_laikytojas_id = selected_laikytojas_id;
            InitializeComponent();
            LoadFromDB(selected_laikytojas_id);
        }
        public void LoadFromDB(int selected=0, string where="")
        {
            string sql = "select * from laikytojai";
            if (where != "")
            {
                sql += " where " + where;
            }
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
            m_dbConnection.Open();
            string[] database_fields = { "vardas", "pavarde", "adresas", "telefonas" };
            using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
            {
                SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, conn); 
                DataSet ds = new DataSet();
                sda.Fill(ds);
                select_laikytojas.Items.Clear();
                select_laikytojas.BeginUpdate();
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
                    select_laikytojas.Items.Add(lvi);
                }
                this.select_laikytojas.EndUpdate();
            }
            m_dbConnection.Close();
            if (selected > 0 && select_laikytojas.Items.Count>0)
            {
                int list_id=0;
                foreach (ListViewItem it in select_laikytojas.Items)
                {
                    if (it.Tag.ToString() == selected.ToString())
                    {
                        list_id = it.Index;
                        break;
                    }
                }
                select_laikytojas.Items[list_id].Focused = true;
                select_laikytojas.Items[list_id].Selected = true;
                select_laikytojas.Items[list_id].EnsureVisible();
                select_laikytojas.Select();
            }
        }

        private void laikytojas_select_ieskoti_Click(object sender, EventArgs e)
        {
            string[] fields = { "vardas","pavarde","adresas","telefonas"};
            string where = search.search_box(laikytojas_select_searchbox.Text,fields);
            LoadFromDB(selected_laikytojas_id,where);
        }

        private void laikytojas_select_select_Click(object sender, EventArgs e)
        {
            if (select_laikytojas.SelectedItems.Count > 0)
            {
                DBupdate.quick_id_update_to_database("zurnalas", "id", this.zurnalas_id.ToString(), "laikytojo_id", select_laikytojas.SelectedItems[0].Tag.ToString());
                foreach (Form f in Application.OpenForms)
                {
                    if (f != null)
                    {
                        if (f.Name == "Zurnalas_entry" && ((Zurnalas_entry)f).id == zurnalas_id)
                        {
                            ((Zurnalas_entry)f).klient_id = Int32.Parse(select_laikytojas.SelectedItems[0].Tag.ToString());
                            ((Zurnalas_entry)f).update_klient_info();
                            break;
                        }
                    }
                }
                this.Close();
            }
        }

        private void laikytojas_select_new_Click(object sender, EventArgs e)
        {
            create_new_laikytojas deriv = new create_new_laikytojas(zurnalas_id);
            deriv.Show();
        }
    }
}
