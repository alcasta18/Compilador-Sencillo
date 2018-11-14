using AnalizadorLéxicoCompiladores.AnalisisLexico;
using AnalizadorLéxicoCompiladores.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLéxicoCompiladores.AnalisisSintactico
{
    class AnalizadorSintactico
    {
        private ComponenteLexico componenteLexico;
        private analizadorLexico analizadorlexico = new analizadorLexico();
        private Stack<Double> pilaCalculos = new Stack<Double>();

        public void analizar()
        {
            try
            {
                componenteLexico = analizadorlexico.analizar();
                operacion();

                if (ManejadorDeErrores.obtenerManejadorDeErrores().ProgramaTieneErrores())
                {
                    MessageBox.Show("El programa no esta bien escrito");
                }
                else
                {
                    if (componenteLexico.Categoria.Equals("FIN DE ARCHIVO"))
                    {
                        MessageBox.Show("EL PROGRAMA ESTA BIEN ESCRITO");
                        MessageBox.Show("Resultado operacion es: " + pilaCalculos.Pop());
                    }
                    else
                    {
                        MessageBox.Show("El programa no esta bien escrito");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("El programa no esta bien escrito " + ex.Message);
            }
        }

        public void operacion()
        {
            multiDivision();
            restoOperacion();
        }

        private void multiDivision()
        {
            valor();
            restoMultiDivision();
        }

        private void restoOperacion()
        {
            if ("SUMA".Equals(componenteLexico.Categoria))
            {
                avanzar("SUMA");
                operacion();
                double derecho = pilaCalculos.Pop();
                double izquierdo = pilaCalculos.Pop();
                pilaCalculos.Push(izquierdo + derecho);
            }
            else if ("RESTA".Equals(componenteLexico.Categoria))
            {
                avanzar("RESTA");
                operacion();
                double derecho = pilaCalculos.Pop();
                double izquierdo = pilaCalculos.Pop();
                pilaCalculos.Push(izquierdo - derecho);
            }
        }

        private void valor()
        {
            if("NUMERO ENTERO".Equals(componenteLexico.Categoria) || "NUMERO DECIMAL".Equals(componenteLexico.Categoria)|| "IDENTIFICADOR".Equals(componenteLexico.Categoria))
            {
                pilaCalculos.Push(Double.Parse(componenteLexico.Lexema));
                avanzar(componenteLexico.Categoria);                
            }
            else if ("PARENTESIS ABRE".Equals(componenteLexico.Categoria))
            {
                pilaCalculos.Push(Double.Parse(componenteLexico.Lexema));
                avanzar("PARENTESIS ABRE");
                operacion();
                avanzar("PARENTESIS CIERRA");
            }
            else
            {
                //manejador de errores
                ManejadorDeErrores.obtenerManejadorDeErrores().ReportarError
                           (Error.Crear(componenteLexico.Categoria + " " + componenteLexico.Lexema, "SINTACTICOS", "Esperaba un identificador, un numero decimal, o un parentesis que abre",
                           "Verifique la estructura del programa fuente", componenteLexico.NumeroLinea, componenteLexico.PosicionInicial, componenteLexico.PosicionFinal));
                throw new Exception("no es posible continuar con el analisis");
            }

        }       
        private void restoMultiDivision()
        {
            if("MULTIPLICACION".Equals(componenteLexico.Categoria))
            {
                avanzar("MULTIPLICACION");
                multiDivision();
                Double derecho = pilaCalculos.Pop();
                Double izquierdo = pilaCalculos.Pop();
                pilaCalculos.Push(izquierdo * derecho);
            }
            else if ("DIVISION".Equals(componenteLexico.Categoria))
            {
                avanzar("DIVISION");
                multiDivision();
                Double derecho = pilaCalculos.Pop();
                Double izquierdo = pilaCalculos.Pop();
                if (derecho == 0)
                {
                    MessageBox.Show("No se puede dividir por Cero");
                }
                else
                {
                pilaCalculos.Push(izquierdo / derecho);
                }
            }
        }
        //pide el siguiente componenete al analizador lexico
        private void avanzar(String categoriaGramatical)
        {
            if (!categoriaGramatical.Equals(componenteLexico.Categoria))
            {
                //manejador de errores
                ManejadorDeErrores.obtenerManejadorDeErrores().ReportarError
                           (Error.Crear(componenteLexico.Categoria + " " + componenteLexico.Lexema, "SINTACTICOS", "Esperaba " + categoriaGramatical + " y recibi " + componenteLexico.Categoria,
                           "Verifique la estructura del programa fuente", componenteLexico.NumeroLinea, componenteLexico.PosicionInicial, componenteLexico.PosicionFinal));
            }
            componenteLexico = analizadorlexico.analizar();
        }



    }
}
