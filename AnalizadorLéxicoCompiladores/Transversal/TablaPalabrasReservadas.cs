using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLéxicoCompiladores.Transversal
{
    public class TablaPalabrasReservadas
    {
        private static TablaPalabrasReservadas INSTANCIA = new TablaPalabrasReservadas();
        private Dictionary<String, ComponenteLexico> tablaPalabrasReservadas = new Dictionary<string, ComponenteLexico>();

        //inicializador de la tabla con las palabras reservadas.
        private TablaPalabrasReservadas()
        {
            tablaPalabrasReservadas.Add("Para", ComponenteLexico.crear("Para", "Palabra reservada Para"));
            tablaPalabrasReservadas.Add("Entero", ComponenteLexico.crear("Entero", "Palabra reservada entero"));
            tablaPalabrasReservadas.Add("FinPara", ComponenteLexico.crear("FinPara", "Palabra reservada FinPara"));
            tablaPalabrasReservadas.Add("Mientras", ComponenteLexico.crear("Mientras", "Palabra reservada Mientras"));
            tablaPalabrasReservadas.Add("Real", ComponenteLexico.crear("Real", "Palabra reservada Real"));
            tablaPalabrasReservadas.Add("finMientras", ComponenteLexico.crear("FinMientras", "Palabra reservada finMientras"));
        }

        public static TablaPalabrasReservadas ObtenerInstancia()
        {
            return INSTANCIA;
        }

        public ComponenteLexico obtenerPalabraReservada(String palabra)
        {
            ComponenteLexico retorno = null;
            if (tablaPalabrasReservadas.ContainsKey(palabra))
            {
                retorno = tablaPalabrasReservadas[palabra].clonar();
            }
            return retorno;
        }
    }
}
