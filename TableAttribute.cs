using System.Reflection;

namespace API_Example
{
    [AttributeUsage(
AttributeTargets.Class,
AllowMultiple = false,
Inherited = false)]
    public class TableAttribute : Attribute
    {
    }

    public static class TableControl
    {
        public static bool Dogrula(object dogrulanacakOrnek)
        {
            string trCharacters = "ıİçÇüÜöÖşŞğĞ";
            Type dogrulamacakTur = dogrulanacakOrnek.GetType();
            if(dogrulamacakTur.Name.Contains(trCharacters))
            {
                Console.WriteLine("Tablo ismi Türkçe karakter içeremez!");
            }
            foreach(char c in dogrulamacakTur.Name)
            {
                if(Char.IsLetterOrDigit(c) is false)
                {
                    Console.WriteLine("Tablo ismi özel karakter içeremez!");
                }
            }
                return true;
        }
    }
}
