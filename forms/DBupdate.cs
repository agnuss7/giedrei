﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
namespace forms
{
    public static class DBupdate
    {
        public static void quick_id_update_to_database(string destDB, string whereIDname, string whereID, string updateIDname, string updateID)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
            m_dbConnection.Open();

            string sql = "update " + destDB + " set " + updateIDname + "=" + updateID + " where " + whereIDname + "=" + whereID;
            using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
            {
                using (SQLiteCommand sqlcmd = new SQLiteCommand(sql, conn))
                {
                    sqlcmd.ExecuteNonQuery();
                }

            }
            m_dbConnection.Close();
        }
        public static void add_new_to_database(string databaseName, string idName, int idValue,string[] fieldNames, string[] fieldValues)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
            m_dbConnection.Open();
            string fieldsNames = " ("+idName;
            foreach (string fld in fieldNames)
            {
                fieldsNames += "," + fld;
            }

            fieldsNames += ")";
            string values = "("+idValue.ToString();
            foreach(string val in fieldValues)
            {
                values += ",'" + validation.TransformedText(val)+"'";
            }
            values += ")";
            string sql = "insert into " + databaseName + fieldsNames+" values "+values;
            MessageBox.Show(sql);
            using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
            {
                using (SQLiteCommand sqlcmd = new SQLiteCommand(sql, conn))
                {
                    sqlcmd.ExecuteNonQuery();
                }

            }
            m_dbConnection.Close();
        }
        public static int GenerateId(string database, string IdField)
        {
            int id = 0;
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
            m_dbConnection.Open();

            string sql = "select max(" + IdField + ")+1 id from " + database;
            using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
            {
                SQLiteCommand sda = new SQLiteCommand(sql, conn);
                id= Int32.Parse(sda.ExecuteScalar().ToString());
            }
            m_dbConnection.Close();
            if (id > 0)
            {
                return id;
            }
            else
            {
                return 1;
            }
        }
        public static string GetValueFrom(string table, string field, string where)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
            m_dbConnection.Open();
            string ret="";
            string sql = "select " + field + " from " + table + " where " + where;
            SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, m_dbConnection); 

            DataSet ds = new DataSet();
            sda.Fill(ds);
            ret = ds.Tables[0].Rows[0][field].ToString();
            m_dbConnection.Close();
            return ret;
        }
        public static Boolean RowExists(string table, string where)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=duomenys.db");
            m_dbConnection.Open();
            string ret = "";
            string sql = "select 1 from " + table + " where " + where;
            using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
            {
                SQLiteCommand sda = new SQLiteCommand(sql, conn);
                ret = sda.ExecuteScalar().ToString();
            }
            m_dbConnection.Close();
            if (ret != "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}