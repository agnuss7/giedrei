using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SQLite;
namespace forms
{
    public partial class augintinis_select : Form
    {
        public int zurnalas_id;
        private int selected_augintinis_id;
        public augintinis_select(int zurnalas_id, int selected_augintinis_id = -1)
        {
            this.zurnalas_id = zurnalas_id;
            this.selected_augintinis_id = selected_augintinis_id;
            InitializeComponent();
            LoadFromDB(selected_augintinis_id);
        }
        public void LoadFromDB(int selected = -1, string where = "")
        {
            string sql = "select * from gyvunas";
            if (where != "")
            {
                sql += " " + where;
            }
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
            m_dbConnection.Open();
            string[] database_fields = { "vardas", "rusis", "veisle", "zenklinimo_nr", "lytis","isvaizda","pasas","amzius" };
            using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
            {
                SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                select_augintinis.Items.Clear();
                select_augintinis.BeginUpdate();
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
                    select_augintinis.Items.Add(lvi);
                }
                this.select_augintinis.EndUpdate();
            }
            m_dbConnection.Close();
            if (selected > -1 && select_augintinis.Items.Count > 0)
            {
                int list_id = 0;
                foreach (ListViewItem it in select_augintinis.Items)
                {
                    if (it.Tag.ToString() == selected.ToString())
                    {
                        list_id = it.Index;
                        break;
                    }
                }
                select_augintinis.Items[list_id].Focused = true;
                select_augintinis.Items[list_id].Selected = true;
                select_augintinis.Items[list_id].EnsureVisible();
                select_augintinis.Select();
            }
        }

        

        private void augintinis_select_ieskoti_Click(object sender, EventArgs e)
        {
            string[] fields = { "vardas", "rusis", "veisle", "zenklinimo_nr", "isvaizda", "pasas", "amzius" };
            string where = search.search_box(augintinis_select_searchbox.Text, fields);
            LoadFromDB(selected_augintinis_id, where);
        }

        private void augintinis_select_select_Click(object sender, EventArgs e)
        {
             if (select_augintinis.SelectedItems.Count > 0)
            {
                DBupdate.quick_id_update_to_database("zurnalas", "id", this.zurnalas_id.ToString(), "gyvuno_id", select_augintinis.SelectedItems[0].Tag.ToString());
                foreach (Form f in Application.OpenForms)
                {
                    if (f != null)
                    {
                        if (f.Name == "Zurnalas_entry" && ((Zurnalas_entry)f).id == zurnalas_id)
                        {
                            ((Zurnalas_entry)f).gyv_id = Int32.Parse(select_augintinis.SelectedItems[0].Tag.ToString());
                            ((Zurnalas_entry)f).update_gyv_info();
                            break;
                        }
                    }
                }
                this.Close();
            }
        }

        private void augintinis_select_new_Click(object sender, EventArgs e)
        {
            create_new_augintinis deriv = new create_new_augintinis(zurnalas_id);
            deriv.Show();
        }
    }
}
