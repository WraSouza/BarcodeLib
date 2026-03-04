using System.Text.RegularExpressions;

namespace BarcodeLib.Validator
{
    public class BarcodeValidator
    {
        public static bool TryValidate(string codigo)
        { 
            if (string.IsNullOrWhiteSpace(codigo))
                return false;
            
            if (!Regex.IsMatch(codigo, @"^[a-zA-Z0-9]+$"))
                return false;
           
            return true;
        }
    }
}
