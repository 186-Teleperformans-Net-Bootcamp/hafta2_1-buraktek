namespace API_Example
{
    [AttributeUsage(
AttributeTargets.Property,
AllowMultiple = false,
Inherited = false)]
    public class ColumnAttribute:Attribute
    {
    }
    public static class ColumnControl
    {
        public static bool Dogrula(object dogrulanacakOrnek)
        {
            Type dogrulamacakTur = dogrulanacakOrnek.GetType();
            foreach (var item in dogrulamacakTur.GetProperties())
            {
                object[] zorunluAlanOznitelikleri = item.GetCustomAttributes(typeof(ReqireddAttribute), true);
                if (zorunluAlanOznitelikleri.Length != 0)
                {
                    string alanDegeri = item.GetValue(dogrulanacakOrnek) as string;
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
