namespace Fornecedores.Bussines.Models.Validations.Documentos
{
    public class Utils
    {
        public static string ApenasNumeros(string valor)
        {
            var onlyNumer = string.Empty;
            foreach (var s in valor)
            {
                if(char.IsDigit(s))
                {
                    onlyNumer += s;
                }
            }
            return onlyNumer;
        }
    }
}