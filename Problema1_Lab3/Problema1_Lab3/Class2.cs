using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problema1_Lab3
{
    public class Utilidades
    {
        public static bool EstaCorreoValido(String correo)
        {
            if (EstaEnBlanco(correo))
            {
                return false;
            }

            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(correo, patron);
        }

        public static bool EstaEnBlanco(String texto)
        {
            return string.IsNullOrWhiteSpace(texto);
        }
    }
}
