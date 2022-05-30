using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Example.Controllers
{
    public static class DateExtention
    {
        public static string Ago(this DateTime dt, DateTime date)
        {
            string msg = DateTime.Now.Subtract(date).Days.ToString() + " gün " + DateTime.Now.Subtract(date).Hours.ToString() + " saat " +
                DateTime.Now.Subtract(date).Minutes.ToString() + " dakika önce";
            return msg;
        }
    }
}
