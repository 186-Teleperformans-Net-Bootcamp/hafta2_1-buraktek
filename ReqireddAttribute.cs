using System.Reflection;

namespace API_Example
{
    [AttributeUsage(
        AttributeTargets.Property,
        AllowMultiple = false,
        Inherited = true)]
    public class ReqireddAttribute : Attribute { }

    public static class ReqiredControl
    {
        public static bool Dogrula(object dogrulanacakOrnek)
        {
            Type dogrulamacakTur = dogrulanacakOrnek.GetType();
            foreach(var item in dogrulamacakTur.GetProperties())
            {
                object[] zorunluAlanOznitelikleri = item.GetCustomAttributes(typeof(ReqireddAttribute), true);
                if (zorunluAlanOznitelikleri.Length != 0)
                {
                    string[] str = item.ToString().Split(" ");
                    string alanDegeri = "";//property ismi kontrol ediliyor. value olması lazım bak
                    if (str[0] == "System.String")
                    {
                        alanDegeri = item.GetValue(dogrulanacakOrnek) as string;
                    }
                    else
                    {
                        alanDegeri = item.GetValue(dogrulanacakOrnek).ToString();
                    }
                    if (string.IsNullOrEmpty(alanDegeri))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
