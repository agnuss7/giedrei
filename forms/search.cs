using System;

namespace forms
{
    public static class search
    {
        public static string search_box(string s, string[] text_data)
        {
            string final = "";
            s = validation.TransformedText(s);
            if (s != "")
            {
                string[] words = s.Split(' ');
                foreach (string c in words)
                {
                    final += "(";
                    foreach (string d in text_data)
                    {
                        final += "lower(" + d + ") like '%" + c.ToLower() + "%' or ";
                    }
                    final = final.Substring(0, final.Length - 4) + ") and ";
                }
                final = final.Substring(0, final.Length - 5);
            }
            return final;
        }
        
    }
}
