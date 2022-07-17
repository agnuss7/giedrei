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
    public partial class vaistai_select : Form
    {
        public int siunta_id = 0;
        public int vaistas_id = 0;
        public vaistai_select(int siunta_id, int vaistas_id=0)
        {
            InitializeComponent();
            this.siunta_id = siunta_id;
            this.vaistas_id = vaistas_id;
            load_table(vaistas_id);
        }
        public void load_table(int new_vaist_id=0,string where="")
        {
            vaistas_id=new_vaist_id;
            string sql = "select * from vaistai"+where;

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
            m_dbConnection.Open();
            using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
            {
                SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                vaistai_list.Items.Clear();
                vaistai_list.BeginUpdate();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Tag = row["id"].ToString();
                    lvi.Text = row["pavadinimas"].ToString();
                    lvi.SubItems.Add(row["matas"].ToString());
                    vaistai_list.Items.Add(lvi);
                }
                this.vaistai_list.EndUpdate();
            }
            m_dbConnection.Close();
            if (vaistas_id > 0 && vaistai_list.Items.Count > 0)
            {
                int list_id = 0;
                foreach (ListViewItem it in vaistai_list.Items)
                {
                    if (it.Tag.ToString() == vaistas_id.ToString())
                    {
                        list_id = it.Index;
                        break;
                    }
                }
                vaistai_list.Items[list_id].Focused = true;
                vaistai_list.Items[list_id].Selected = true;
                vaistai_list.Items[list_id].EnsureVisible();
                vaistai_list.Select();
            }
        }
        private void vaistai_select_pick_button_Click(object sender, EventArgs e)
        {
            if (vaistai_list.SelectedItems.Count > 0)
            {
                int sel_id=Convert.ToInt32(vaistai_list.SelectedItems[0].Tag.ToString());
                foreach(Form f in Application.OpenForms)
                {
                    if (f != null)
                    {
                        MessageBox.Show(f.Name);
                        if (f.Name =="vaistu_siunta" && ((vaistu_siunta)f).id == siunta_id)
                        {
                            ((vaistu_siunta)f).set_vaistas(sel_id);
                            break;
                        }
                    }
                }
                this.Close();
            }
        }

        private void vaistai_select_search_button_Click(object sender, EventArgs e)
        {
            string where = "";
            if (vaistai_select_search_box.Text != "")
            {
                where = " where " + search.search_box(vaistai_select_search_box.Text, new[] { "pavadinimas", "matas" });
            }
            load_table(vaistas_id,where);
        }

        private void vaistai_select_new_button_Click(object sender, EventArgs e)
        {
            new_vaistas deriv = new new_vaistas(siunta_id);
            deriv.Show();
        }
    }
}
