using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLéxicoCompiladores.Transversal
{
    public class ManejadorDeErrores
    {
        private static ManejadorDeErrores INSTANCIA = new ManejadorDeErrores();
        private Dictionary<String, List<Error>> mapaErrores = new Dictionary<string, List<Error>>();

        private ManejadorDeErrores()
        {
            mapaErrores.Add("LEXICOS", new List<Error>());
            mapaErrores.Add("SINTACTICOS", new List<Error>());
            mapaErrores.Add("SEMANTICOS", new List<Error>());
        }

        public static ManejadorDeErrores obtenerManejadorDeErrores()
        {
            return INSTANCIA;
        }

        public void ReportarError (Error error)
        {
            if (mapaErrores.ContainsKey(error.TipoError))
            {
                mapaErrores[error.TipoError].Add(error);
            }
        }

        public Boolean hayErrores(String Tipoerror)
        {
            if (mapaErrores.ContainsKey(Tipoerror))
            {
                return mapaErrores[Tipoerror].Count > 0;
            }else
            {
                return false;
            }
        }

        public Boolean ProgramaTieneErrores()
        {
            return hayErrores("LEXICOS") || hayErrores("SEMANTICOS") || hayErrores("SINTACTICOS");
        }

       public List<Error> obtenerErrorres(String TipoError)
        {
            if (mapaErrores.ContainsKey(TipoError))
            {
                return mapaErrores[TipoError];
            }
            else
            {
                return new List<Error>();
            }
        }

        public List<Error> obtenerTodosErrores()
        {
            return mapaErrores.Values.SelectMany(simbolo => simbolo).ToList();
        }

        public void limpiarManejador()
        {
            mapaErrores["LEXICOS"].Clear();
            mapaErrores["SINTACTICOS"].Clear();
            mapaErrores["SEMANTICOS"].Clear();
        }
    }
}
