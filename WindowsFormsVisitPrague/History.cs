using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsVisitPrague
{
    static class History
    {
        static public List<string> history_list = new List<string>();

        public static void add_history(string s)
        {
            history_list.Add(s);


        }

    }
}
