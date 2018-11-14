using AnalizadorLéxicoCompiladores.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLéxicoCompiladores.AnalisisLexico
{
    public class analizadorLexico
    {
        private int nroLineaActual = 0;
        private String contenidoLineaActual = null;
        private int puntero = 0;
        private String caracterActual = null;
        private string lexema = null;
        private int estadoActual = 0;
        private bool continuar = false;
        private String categoria = null;

        private void cargarNuevaLinea()
        {
            nroLineaActual = nroLineaActual + 1;
            Linea linea = Archivo.obtenerInstancia().obtenerLinea(nroLineaActual);
            if (linea.contenido.Equals("@EOF@"))
            {
                nroLineaActual = nroLineaActual - 1;
            }
            contenidoLineaActual = linea.contenido;
            puntero = 1;
        }

        private void leerSiguienteCaracter()
        {
            if ("@EOF@".Equals(contenidoLineaActual))
            {
                caracterActual = "@EOF@";
            }
            else if (puntero > contenidoLineaActual.Length)
            {
                caracterActual = "@FL@";
                puntero = puntero + 1;

            }
            else
            {
                caracterActual = contenidoLineaActual.Substring(puntero - 1, 1);
                puntero = puntero + 1;
            }          
        }

        private void devolverPuntero()
        {
            puntero = puntero - 1;
        }

        private void reiniciar()
        {
            lexema = "";
            estadoActual = 0;
            continuar = true;
        }
        public ComponenteLexico analizar()
        {
            ComponenteLexico componente = null;
            if (contenidoLineaActual == null)
            {
                cargarNuevaLinea();
            }
            reiniciar();
            while (continuar)
            {
                switch (estadoActual)
                {
                    case 0:
                        leerSiguienteCaracter();
                        while (" ".Equals(caracterActual))
                        {
                            leerSiguienteCaracter();
                        }
                        if (char.IsLetter(caracterActual.ToCharArray()[0]) | "$".Equals(caracterActual) | "_".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 4;
                        }
                        else if (char.IsDigit(caracterActual.ToCharArray()[0]))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 1;
                        }
                        else if ("+".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 5;
                        }
                        else if ("-".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 6;
                        }
                        else if ("*".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 7;
                        }
                        else if ("/".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 8;
                        }
                        else if ("%".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 9;
                        }
                        else if ("(".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 10;
                        }
                        else if (")".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 11;
                        }
                        else if ("@EOF@".Equals(caracterActual))
                        {
                            estadoActual = 12;
                        }
                        else if ("=".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 19;
                        }
                        else if ("<".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 20;
                        }
                        else if (">".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 21;
                        }
                        else if (":".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 22;
                        }
                        else if ("!".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 30;
                        }                        
                        else if ("@FL@".Equals(caracterActual))
                        {
                            estadoActual = 13;
                        }
                        else /*if ("OTRO".Equals(caracterActual))*/
                        {
                            estadoActual = 18;
                        }
                        break;
                    case 1:
                        leerSiguienteCaracter();
                        if (char.IsDigit(caracterActual.ToCharArray()[0]))
                        {
                            lexema = lexema + caracterActual;
                        }
                        else if (",".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 2;
                        }
                        else /*if ("OTRO".Equals(caracterActual))*/
                        {
                            estadoActual = 14;
                        }
                        break;
                    case 2:
                        leerSiguienteCaracter();
                        if (char.IsDigit(caracterActual.ToCharArray()[0]))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 3;
                        }
                        else /*if ("OTRO".Equals(caracterActual))*/
                        {
                            estadoActual = 17;
                        }
                        break;
                    case 3:
                        leerSiguienteCaracter();
                        if (char.IsDigit(caracterActual.ToCharArray()[0]))
                        {
                            lexema = lexema + caracterActual;
                        }
                        else /*if ("OTRO".Equals(caracterActual))*/
                        {
                            estadoActual = 15;
                        }
                        break;
                    case 4:
                        leerSiguienteCaracter();
                        if (char.IsLetter(caracterActual.ToCharArray()[0]) | char.IsDigit(caracterActual.ToCharArray()[0]) | "$".Equals(caracterActual) | "_".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                        }
                        else /*if ("OTRO".Equals(caracterActual))*/
                        {
                            estadoActual = 16;
                        }
                        break;
                    case 5:
                        componente = ComponenteLexico.crear(lexema, "SUMA");
                        AgregarComponente(componente);
                        continuar = false;
                        break;
                    case 6:
                        componente = ComponenteLexico.crear(lexema, "RESTA");
                        AgregarComponente(componente);
                        continuar = false;
                        break;
                    case 7:
                        componente = ComponenteLexico.crear(lexema, "MULTIPLICACION");
                        AgregarComponente(componente);
                        continuar = false;
                        break;
                    case 8:
                        componente = ComponenteLexico.crear(lexema, "DIVISION");
                        AgregarComponente(componente);
                        continuar = false;
                        break;
                    case 9:
                        componente = ComponenteLexico.crear(lexema, "MODULO");
                        AgregarComponente(componente);
                        continuar = false;
                        break;
                    case 10:
                        componente = ComponenteLexico.crear(lexema, "PARENTESIS ABRE");
                        AgregarComponente(componente);
                        continuar = false;
                        break;
                    case 11:
                        componente = ComponenteLexico.crear(lexema, "PARENTESIS CIERRA");
                        AgregarComponente(componente);
                        continuar = false;
                        break;
                    case 12:
                        componente = ComponenteLexico.crear(lexema, "FIN DE ARCHIVO");
                        AgregarComponente(componente);
                        continuar = false;
                        break;
                    case 13:
                        //componente = ComponenteLexico.crear(lexema, "SALTO DE LINEA");
                        contenidoLineaActual = null;
                        //AgregarComponente(componente);
                        //continuar = false;
                        estadoActual = 0;
                        cargarNuevaLinea();
                        break;
                    case 14:
                        devolverPuntero();
                        componente = ComponenteLexico.crear(lexema, "NUMERO ENTERO");
                        AgregarComponente(componente);
                        continuar = false;
                        break;
                    case 15:
                        devolverPuntero();
                        componente = ComponenteLexico.crear(lexema, "NUMERO DECIMAL");
                        AgregarComponente(componente);
                        continuar = false;
                        break;
                    case 16:
                        devolverPuntero();
                        componente=TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexema);
                        if (componente == null)
                        {
                            componente = ComponenteLexico.crear(lexema, "IDENTIFICADOR");
                        }

                        AgregarComponente(componente);
                        continuar = false;
                        break;
                    case 17:
                        //LO QUE SE ESPERABA NUMERO DECIMAL
                        devolverPuntero();
                        componente = ComponenteLexico.crear("1,0", "Número decimal Dummy", nroLineaActual, puntero-lexema.Length, puntero-1);
                        TablaSimbolos.ObtenerInstancia().agregar(componente);                        
                        ManejadorDeErrores.obtenerManejadorDeErrores().ReportarError
                            (Error.Crear(lexema, "LEXICOS", "Numero Decimal no valido espereba un numero decimal", 
                            "Verifique el numero decimal que esta tratando de compilar", nroLineaActual, puntero - lexema.Length, puntero - 1));
                        
                        continuar = false;
                        break;
                    case 18:
                        //ERROR DE SIMBOLO NO VALIDO
                        ManejadorDeErrores.obtenerManejadorDeErrores().ReportarError(Error.Crear(lexema,"LEXICOS","Simbolo no valido","Verofique el simbolo que esta tratando de ingresar",nroLineaActual,puntero-lexema.Length,puntero-1));
                        categoria = "SIMBOLO NO VALIDO";                        
                        continuar = false;
                        break;
                    case 19:
                        componente = ComponenteLexico.crear(lexema, "IGUAL QUE");
                        AgregarComponente(componente);
                        continuar = false;
                        break;
                    case 20:
                        leerSiguienteCaracter();
                        if (">".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 23;
                        }
                        else if ("=".Equals(caracterActual)) {
                            lexema = lexema + caracterActual;
                            estadoActual = 24;
                        }
                        else /*if ("OTRO".Equals(caracterActual))*/
                        {
                            estadoActual = 25;
                        }
                        break;
                    case 21:
                        leerSiguienteCaracter();
                        if ("=".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 26;
                        }
                        else
                        {
                            estadoActual = 27;
                        }
                        break;
                    case 22:
                        leerSiguienteCaracter();
                        if ("=".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 28;
                        }
                        else
                        {
                            estadoActual = 29;
                        }
                        break;
                    case 23:
                        componente = ComponenteLexico.crear(lexema, "DIFERENTE QUE");
                        AgregarComponente(componente);
                        continuar = false;
                        break;
                    case 24:
                        componente = ComponenteLexico.crear(lexema, "MENOR O IGUAL QUE");
                        AgregarComponente(componente);
                        continuar = false;
                        break;
                    case 25:
                        componente = ComponenteLexico.crear(lexema, "MENOR QUE");
                        AgregarComponente(componente);
                        devolverPuntero();
                        continuar = false;
                        break;
                    case 26:
                        componente = ComponenteLexico.crear(lexema, "MAYOR O IGUAL QUE");
                        AgregarComponente(componente);
                        continuar = false;
                        break;
                    case 27:
                        componente = ComponenteLexico.crear(lexema, "MAYOR QUE");
                        AgregarComponente(componente);
                        devolverPuntero();
                        continuar = false;
                        break;
                    case 28:
                        componente = ComponenteLexico.crear(lexema, "ASIGNACION");
                        AgregarComponente(componente);
                        continuar = false;
                        break;
                    case 29:
                        //LO QUE SE ESPERABA
                        devolverPuntero();
                        componente = ComponenteLexico.crear(":=", "Asignacion Dummy", nroLineaActual, puntero - lexema.Length, puntero - 1);
                        TablaSimbolos.ObtenerInstancia().agregar(componente);
                        ManejadorDeErrores.obtenerManejadorDeErrores().ReportarError
                           (Error.Crear(lexema, "LEXICOS", "Asignacion no valida espereba :=",
                           "Verifique la asignacion que esta tratando de compilar", nroLineaActual, puntero - lexema.Length, puntero - 1));

                        continuar = false;
                        break;
                    case 30:
                        leerSiguienteCaracter();                       
                        if ("=".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 31;
                        }
                        else
                        {
                            estadoActual = 32;
                        }
                        break;
                    case 31:
                        componente = ComponenteLexico.crear(lexema, "DIFERENTE QUE");
                        AgregarComponente(componente);
                        continuar = false;
                        break;
                    case 32:
                        //lo que se esperaba
                        devolverPuntero();
                        componente = ComponenteLexico.crear("!=", "Diferente que Dummy", nroLineaActual, puntero - lexema.Length, puntero - 1);
                        TablaSimbolos.ObtenerInstancia().agregar(componente);
                        ManejadorDeErrores.obtenerManejadorDeErrores().ReportarError
                           (Error.Crear(lexema, "LEXICOS", "Diferente no valido espereba un !=",
                           "Verifique el operador != que esta tratando de compilar", nroLineaActual, puntero - lexema.Length, puntero - 1));

                        continuar = false;
                        break;

                }
            }
            return componente;
        }

        private void AgregarComponente(ComponenteLexico componente)
        {            
            componente.NumeroLinea = nroLineaActual;
            componente.PosicionInicial = puntero - lexema.Length;
            componente.PosicionFinal = puntero - 1;          
            TablaSimbolos.ObtenerInstancia().agregar(componente);
        }
    }
}
