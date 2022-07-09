using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms
{
    public static class validation
    {
        public static bool ContainsIllegal(string text)
        {
            if(text.Contains("%") || text.Contains("'"))
            {
                return true;
            }
            return false;
        }
        public static string TransformedText(string textbox)
        {
            string temp = textbox;
            //if (temp.Contains("%"))
            //{
                //temp=temp.Replace("%", "%%");
            //}
            if (temp.Contains("'"))
            {
                temp=temp.Replace("'", "''");
            }
            
            return temp;
        }
        public static bool MandatoryTextFieldsNotEmpty(string[] fields)
        {
            foreach (string f in fields)
            {
                if (f == "")
                {
                    return false;
                }
            }
            return true;
        }
    }
}
