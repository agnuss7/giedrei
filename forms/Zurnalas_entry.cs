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
                    SQLiteDataAdapter sda = new SQLiteDataAdapter("select f.*,group_concat(j.pavadinimas) tyrimai from (select a.id, a.reg_data,b.vardas,b.pavarde,b.adresas,c.rusis,c.lytis,c.amzius,c.zenklinimo_nr, a.pastebejimo_data, group_concat(e.pavadinimas) vaistai,a.bukle,a.diagnoze,a.paslaugos,a.baigtis from zurnalas a join laikytojai b on b.id=a.laikytojo_id join gyvunas c on c.id=a.gyvuno_id join zurnalas_vaistai xx on xx.zurnalas_id=a.id join vaistai_siuntos s on s.id=xx.vaistai_id join vaistai e on e.id=s.vaistai_id group by a.id) f join zurnalas_tyrimai t on t.zurnalas_id=f.id join tyrimai j on j.id=t.tyrimai_id where f.id = " + this.id.ToString() + " group by f.id", conn); // MyTable (ID varchar(20), Name varchar(50) ,Score int)

                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        e_vardas.Text = row["vardas"].ToString();
                        e_reg_data.Value = DateTime.Parse(row["reg_data"].ToString());
                    }
                }
                m_dbConnection.Close();
            }
        }
        
    }
}
