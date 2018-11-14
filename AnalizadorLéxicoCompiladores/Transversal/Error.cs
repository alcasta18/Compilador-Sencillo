using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLéxicoCompiladores.Transversal
{
    public class Error
    {
        public String Lexema { get; set; }
        public String TipoError { get; set; }
        public String Causa { get; set; }
        public String Solucion { get; set; }
        public int NumeroLinea { get; set; }
        public int PosicionInicial { get; set; }
        public int PosicionFinal { get; set; }

        public static Error Crear(String lexema, String TipoError, String Causa, String Solucion, int NumeroLinea, int PosicionInicial, int PosicionFinal)
        {
            Error retorno = new Error();
            retorno.Lexema = lexema;
            retorno.TipoError = TipoError;
            retorno.Causa = Causa;
            retorno.Solucion = Solucion;
            retorno.NumeroLinea = NumeroLinea;
            retorno.PosicionInicial = PosicionInicial;
            retorno.PosicionFinal = PosicionFinal;

            return retorno;
        }
    }
}
