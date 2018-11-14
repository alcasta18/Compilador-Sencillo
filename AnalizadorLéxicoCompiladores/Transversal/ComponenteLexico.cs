using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLéxicoCompiladores.Transversal
{
    public class ComponenteLexico
    {
        public String Lexema { get; set; }
        public String Categoria { get; set; }
        public int NumeroLinea { get; set; }
        public int PosicionInicial { get; set; }
        public int PosicionFinal { get; set; }

        public static ComponenteLexico crear(String lexema, String categoria, int nroLinea, int posInicial, int posFinal)
        {
            ComponenteLexico retorno = new ComponenteLexico();
            retorno.Lexema = lexema;
            retorno.Categoria = categoria;
            retorno.NumeroLinea = nroLinea;
            retorno.PosicionInicial = posInicial;
            retorno.PosicionFinal = posFinal;
            return retorno;
        }
        public static ComponenteLexico crear(String lexema, String categoria)
        {
            return crear(lexema, categoria, 0, 0, 0);
        }

        public ComponenteLexico clonar()
        {
            return crear(this.Lexema, this.Categoria, this.NumeroLinea, this.PosicionInicial, this.PosicionFinal);
        }
    }
}
