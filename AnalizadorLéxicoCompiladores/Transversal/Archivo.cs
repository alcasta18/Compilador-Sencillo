using System.Collections.Generic;

namespace AnalizadorLéxicoCompiladores
{
    public class Archivo
    {
        private static Archivo INSTANCIA=new Archivo();
        private List<Linea> lineas = new List<Linea>();
        private Archivo() { }
        public void agregarLinea(Linea linea)
        {
            lineas.Add(linea);
        }
        public Linea obtenerLinea(int NroLinea)
        {
            Linea lineaReturn = null;
            if (NroLinea > lineas.Count)
            {
                lineaReturn = new Linea();
                lineaReturn.numeroLinea = NroLinea;
                lineaReturn.contenido = "@EOF@";
            }
            else
            {
                lineaReturn = lineas[NroLinea - 1];
            }
            return lineaReturn;
        }
        public static Archivo obtenerInstancia()
        {
            return INSTANCIA;
        }

        public void LimpiarLineas()
        {
            lineas.Clear();
        }
    }
}
