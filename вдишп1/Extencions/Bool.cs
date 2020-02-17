using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using вдишп1.Models;

namespace вдишп1.Extencions
{
    public static class Bool
    {
        public static bool Greate(string Exist,string value)
        {
            int Existvalue = Convert.ToInt32(Exist);
            int restriction = Convert.ToInt32(value);
            return Existvalue <= restriction;
        }

        public static bool OnlyGreate(string Exist, string value)
        {
            int Existvalue = Convert.ToInt32(Exist);
            int restriction = Convert.ToInt32(value);
            return Existvalue < restriction;
        }

        public static bool Equal(string Exist, string value)
        {
            int Existvalue = Convert.ToInt32(Exist);
            int restriction = Convert.ToInt32(value);
            return Existvalue == restriction;
        }

        public static bool Menshe(string Exist, string value)
        {
            int Existvalue = Convert.ToInt32(Exist);
            int restriction = Convert.ToInt32(value);
            return Existvalue >= restriction;
        }
        
        public static bool EqualsDate(this Transport t, string startdate, string timy, string enddate = null)
        {
            string[] start = startdate.Split(new char[] { '.' });
            string startday = start[0];
            string startmonth = start[1];
            string startyear = start[2];

            string[] excist = t.Startdate.Split(new char[] { '.' });
            string excistday = excist[0];
            string excistmonth = excist[1];
            string excistyear = excist[2];

            string restrictionTimy = timy.Split(new char[] { ':' })[0];

            string excisttimy = t.StartTimy.Split(new char[] { ':' })[0];

            if (!Menshe(excistyear, startyear)) return false;
            if (Equal(excistmonth, startmonth))
            {
                if (Equal(excistday, startday))
                {
                    if (Equal(excisttimy, restrictionTimy))
                    {
                        return true;
                    }
                    else if (!Menshe(excisttimy, restrictionTimy)) return false;
                    else if (Menshe(excisttimy, restrictionTimy)) return true;
                }
                else if (!Menshe(excistday, startday)) return false;
                else if (Menshe(excistday, startday)) return true;
            }
            else if (!Menshe(excistmonth, startmonth)) return false;
            else if (!Menshe(excistmonth, startmonth)) return true;
            return true;
        }

        public static bool TimyStrict(this Transport t,int start,int end)
        {
            string excisttimy = t.StartTimy.Split(new char[] { ':' })[0];

            if (!Menshe(excisttimy, start.ToString())) return false;
            if (!OnlyGreate(excisttimy, end.ToString())) return false;
            return true;
        }
    }
}
