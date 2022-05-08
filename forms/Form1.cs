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
    public partial class Zurnalas : Form
    {
        public string[] database_fields = { "reg_data", "vardas", "pavarde", "adresas", "rusis", "lytis", "amzius", "zenklinimo_nr", "pastebejimo_data", "vaistai", "bukle", "diagnoze", "paslaugos", "baigtis", "tyrimai"};
        public string[] list_fields = { "Registravimo data", "Savininko vardas", "Pavarde", "Adresas", "Gyvūno rūšis", "Lytis", "Amžius (metais)", "Ženklinimo numeris", "Ligos pastebėjimo data", "Skirti vaistai", "Būklė", "Diagnozė", "Skirtos paslaugos", "Ligos baigtis", "Atlikti tyrimai" };
        public Zurnalas()
        {
            InitializeComponent();
            LoadZurnalasData();
        }

        private void LoadZurnalasData()
        {
            foreach(string column_name in list_fields)
            this.zurnalas_list.Columns.Add(column_name);
            
            LoadDataFromDB();
        }
        

        

        private void zurnalas_list_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  if (zurnalas_list.SelectedItems.Count > 0)
           //     label1.Text = zurnalas_list.SelectedItems[0].Tag.ToString();
        }
        private void zurnalas_list_DoubleClick(object sender, EventArgs e)
        {
            if (zurnalas_list.SelectedItems.Count > 0)
                label1.Text = zurnalas_list.SelectedItems[0].Tag.ToString();
        }
        private void zurnalas_list_ColumnClick(object sender, EventArgs e)
        {
            //zurnalas_list.Columns["Registravimo data"].
        }
        private void LoadDataFromDB()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
            m_dbConnection.Open();

            using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
            {
                SQLiteDataAdapter sda = new SQLiteDataAdapter("select f.*,group_concat(j.pavadinimas) tyrimai from (select a.id, a.reg_data,b.vardas,b.pavarde,b.adresas,c.rusis,c.lytis,c.amzius,c.zenklinimo_nr, a.pastebejimo_data, group_concat(e.pavadinimas) vaistai,a.bukle,a.diagnoze,a.paslaugos,a.baigtis from zurnalas a join laikytojai b on b.id=a.laikytojo_id join gyvunas c on c.id=a.gyvuno_id join zurnalas_vaistai xx on xx.zurnalas_id=a.id join vaistai_siuntos s on s.id=xx.vaistai_id join vaistai e on e.id=s.vaistai_id group by a.id) f join zurnalas_tyrimai t on t.zurnalas_id=f.id join tyrimai j on j.id=t.tyrimai_id group by f.id", conn); // MyTable (ID varchar(20), Name varchar(50) ,Score int)
                DataSet ds = new DataSet();
                sda.Fill(ds);
                zurnalas_list.Items.Clear();
                zurnalas_list.BeginUpdate();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Tag= row["id"].ToString();
                    for (int i =0;i<database_fields.Length;i++)
                    {
                        if (i > 0)
                        {
                            if (database_fields[i] != "lytis")
                                lvi.SubItems.Add(row[database_fields[i]].ToString());
                            else
                            {
                                if ((bool)row[database_fields[i]]) {
                                    lvi.SubItems.Add("Patinas");
                                }
                                else
                                {
                                    lvi.SubItems.Add("Patelė");
                                }
                            }
                        }
                        else
                        {
                            lvi.Text = row[database_fields[i]].ToString();
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

        private void reload_button_Click(object sender, EventArgs e)
        {
            LoadDataFromDB();
        }

        private void zurnalas_new_button_Click(object sender, EventArgs e)
        {
            Zurnalas_entry deriv = new Zurnalas_entry();
            deriv.Show();
        }
    }
}
