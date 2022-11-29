using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario1357
{
    internal class RegisterLenght
    {
        public string ConvertToRegisterLenght(object obj, int lenght)
        {
            // Convierte el objeto recibo a string.
            string toConvert = obj.ToString();

            // Elimina caracteres de tipo "." y ","
            if (toConvert.Contains(","))
            {
                toConvert = toConvert.Replace(",", "");
            }

            if (toConvert.Contains("."))
            {
                toConvert = toConvert.Replace(".", "");
            }

            // Verifica que el largo del registro a convertir no sea mas grande
            // que el especificado.

            if(toConvert.Length > lenght) throw new Exception("Largo erroneo");
            
            // Convierte el objeto al formato de registro del txt.
            while (toConvert.Length < lenght)
            {
                toConvert = "0" + toConvert;
            }

            return toConvert;
        }
    }
}
