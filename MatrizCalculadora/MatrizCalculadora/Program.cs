using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizCalculadora

{
    
    class Menu : Matrices //indica que la clase matrices hereda los atributos y metodos a menu
    {
        public decimal[] matriz;
        public decimal[] otro;
        public decimal[] memoria;
        private int tamaño;
        ArrayList Coleccion;

        public void setTamaño(int miTamaño)
        {
            tamaño = miTamaño;
        }
        public int getTamaño()
        {
            return tamaño;
        }
        public Menu()
        {
            Coleccion = new ArrayList();
            Matrices matrizResultado = new Matrices(1, 1);
            matrizResultado.setNombre("R");
            Coleccion.Add(matrizResultado);
        }
        //metodos
        public int encontrarMatriz(string nombre)
        {
            int resultado = 1;
            for (int i = 0; i < Coleccion.Count; i++)
            {
                Matrices tmpMatriz = (Matrices)Coleccion[i];
                string dato = tmpMatriz.getNombre();
                if (nombre.Equals(dato))
                {
                    resultado = i;
                }
            }
            return resultado;
        }
        public void NombreMenu(string titu)
        {
            this.escribirLinea("   Menu" + "          " + titu);
        }
        public void Visualizacion(string opc1, string opc2, string opc3, string opc4, string opc5, string opc6, string opc7, string opc8, string opc9, string opc10, string opc11, string opc12)
        {
            this.escribirLinea(opc1); this.escribirLinea(opc2);
            this.escribirLinea(opc3); this.escribirLinea(opc4);
            this.escribirLinea(opc5); this.escribirLinea(opc6);
            this.escribirLinea(opc7); this.escribirLinea(opc8);
            this.escribirLinea(opc9); this.escribirLinea(opc10);
            this.escribirLinea(opc11); this.escribirLinea(opc12);
        }
        public void Visualizacion(string opc1, string opc2, string opc3, string opc4, string opc5)
        {
            this.escribirLinea(opc1);
            this.escribirLinea(opc2);
            this.escribirLinea(opc3);
            this.escribirLinea(opc4);
            this.escribirLinea(opc5);
        }
        public void Visualizacion(string opc1, string opc2, string opc3)
        {
            this.escribirLinea(opc1); this.escribirLinea(opc2);
            this.escribirLinea(opc3);

        }
        public void Visualizacion(string opc1)
        {
            this.escribir(opc1); this.escribirLinea("");
        }

        public void Instrucciones(string msg)
        {
            Console.Write(msg);
        }

        public void SeleccionPrincipal()
        {
            char tmpChar;
            do { tmpChar = Console.ReadKey(true).KeyChar; }
            while ((tmpChar != 'c') && (tmpChar != 'v') && (tmpChar != 'o') && (tmpChar != 'x'));
            switch (tmpChar)
            {
                case 'c': this.MenuC(); break;
                case 'v': this.MenuV(); break;
                case 'o': this.MenuO(); break;
                case 'x':
                    char tmpChar2;
                    do
                    {
                        Console.Clear();
                        this.Instrucciones("Presione de nuevo X para confirmar o C para cancelar...");
                        tmpChar2 = Char.Parse(Console.ReadKey(true).KeyChar.ToString().ToUpper());
                    }
                    while ((tmpChar2 != 'c') && (tmpChar2 != 'x'));
                    switch (tmpChar2)
                    {
                        case 'c': this.MenuP(); break;
                        case 'x': while (Console.ReadKey(true).Key != ConsoleKey.X == true) { } break;
                    }
                    break;
            }
        }
        public void SeleccionCrear()
        {
            char tmpChar;
            do { tmpChar = Console.ReadKey(true).KeyChar; }
            while ((tmpChar != 'a') && (tmpChar != 'p') && (tmpChar != 't') && (tmpChar != 'c') && (tmpChar != 's') && (tmpChar != 'i') && (tmpChar != 'z') && (tmpChar != 'j') && (tmpChar != 'm') && (tmpChar != 'n') && (tmpChar != 'k') && (tmpChar != 'x'));
            switch (tmpChar)
            {
                case 'a': this.MenuCA(); break;
                case 'p': this.MenuCP(); break;
                case 't': this.MenuCT(); break;
                case 'c': this.MenuCC(); break;
                case 's': this.MenuCS(); break;
                case 'i': this.MenuCI(); break;
                case 'j': this.MenuCJ(); break;
                case 'k': this.MenuCK(); break;
                case 'm': this.MenuCM(); break;
                case 'n': this.MenuCN(); break;
                case 'z': this.MenuCZ(); break;
                case 'x': this.MenuP(); break;
            }
        }
        public void SeleccionVer()
        {
            char tmpChar;
            do { tmpChar = Console.ReadKey(true).KeyChar; }
            while ((tmpChar != 'i') && (tmpChar != 't') && (tmpChar != 'x'));
            switch (tmpChar)
            {
                case 'i': this.MenuVI(); break;
                case 't': this.MenuVT(); break;
                case 'x': this.MenuP(); break;
            }
        }
        public void SeleccionOperaciones()
        {
            char tmpChar;
            do { tmpChar = Console.ReadKey(true).KeyChar; }
            while ((tmpChar != 's') && (tmpChar != 'r') && (tmpChar != 'm') && (tmpChar != 'a') && (tmpChar != 'x'));
            switch (tmpChar)
            {
                case 's': this.MenuOS(); break;
                case 'r': this.MenuOR(); break;
                case 'm': this.MenuOM(); break;
                case 'a': this.MenuOA(); break;
                case 'x': this.MenuP(); break;
            }
        }

        public void MenuP()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            this.NombreMenu("Principal");
            Console.ForegroundColor = ConsoleColor.Green;
            this.Visualizacion("        c)CREAR    v)VER    o)OPERACIONES    x)SALIR");
            this.Instrucciones("Seleccione la inicial en minuscula para las opciones");
            this.SeleccionPrincipal();
        }
        public void MenuO()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            this.NombreMenu("°°°°°°°°°°°°°°°°°°°°°°°°°°°OPERACIONES°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
            Console.ForegroundColor = ConsoleColor.Green;
            this.Visualizacion("S)Suma", "R)Resta", "M)Multiplicacion", "A)Asistente de inversa", "X)Salir");
            this.Instrucciones("Seleccione una letra para entrar a la opcion correspondiente: ");
            this.SeleccionOperaciones();
        }
        public void MenuOS()
        {
            try
            {
                Console.Clear();
                this.NombreMenu("Suma");
                Matrices primeraMatriz = new Matrices();
                Matrices segundaMatriz = new Matrices();
                Matrices resultadoMatriz = new Matrices();
                Operaciones miOperacion = new Operaciones();
                string nombre1, nombre2;
                Console.Clear();
                this.Instrucciones("Ingrese el nombre de la matriz 1: ");
                nombre1 = Console.ReadLine();
                for (int i = 0; i < Coleccion.Count; i++)
                {
                    Matrices tmpMatriz = (Matrices)Coleccion[i];
                    if (tmpMatriz.getNombre() == nombre1)
                    { this.setPosicion1(i); }
                }
                this.Instrucciones("Ingrese el nombre de la matriz 2: ");
                nombre2 = Console.ReadLine();
                for (int j = 0; j < Coleccion.Count; j++)
                {
                    Matrices tmpMatriz = (Matrices)Coleccion[j];
                    if (tmpMatriz.getNombre() == nombre2)
                    { this.setPosicion2(j); }
                }
                primeraMatriz = (Matrices)Coleccion[this.getPosicion1()];
                segundaMatriz = (Matrices)Coleccion[this.getPosicion2()];

                //se realiza la operacion
                resultadoMatriz = miOperacion.suma(primeraMatriz, segundaMatriz);

                Coleccion[0] = resultadoMatriz;
            }
            catch (Exception) { this.MenuOS(); }
            this.MenuO();
        }
        public void MenuOR()
        {
            try
            {
                Console.Clear();
                this.NombreMenu("Resta");
                Matrices primeraMatriz = new Matrices();
                Matrices segundaMatriz = new Matrices();
                Matrices resultadoMatriz = new Matrices();
                Operaciones miOperacion = new Operaciones();
                string nombre1, nombre2;
                Console.Clear();
                this.Instrucciones("Ingrese el nombre de la matriz 1: ");
                nombre1 = Console.ReadLine();
                for (int i = 0; i < Coleccion.Count; i++)
                {
                    Matrices tmpMatriz = (Matrices)Coleccion[i];
                    if (tmpMatriz.getNombre() == nombre1)
                    { this.setPosicion1(i); }
                }
                this.Instrucciones("Ingrese el nombre de la matriz 2: ");
                nombre2 = Console.ReadLine();
                for (int j = 0; j < Coleccion.Count; j++)
                {
                    Matrices tmpMatriz = (Matrices)Coleccion[j];
                    if (tmpMatriz.getNombre() == nombre2)
                    { this.setPosicion2(j); }
                }
                primeraMatriz = (Matrices)Coleccion[this.getPosicion1()];
                segundaMatriz = (Matrices)Coleccion[this.getPosicion2()];
                //se realiza la operacion
                resultadoMatriz = miOperacion.resta(primeraMatriz, segundaMatriz);
                Coleccion[0] = resultadoMatriz;
            }
            catch (Exception)
            { this.MenuOR(); }

            this.MenuO();
        }
        public void MenuOM()
        {
            try
            {
                Console.Clear();
                this.NombreMenu("Multiplicacion");
                Matrices primeraMatriz = new Matrices();
                Matrices segundaMatriz = new Matrices();
                Matrices resultadoMatriz = new Matrices();
                Operaciones miOperacion = new Operaciones();
                string nombre1, nombre2;
                Console.Clear();

                this.Instrucciones("Ingrese el nombre de la matriz 1: ");
                nombre1 = Console.ReadLine();
                for (int i = 0; i < Coleccion.Count; i++)
                {
                    Matrices tmpMatriz = (Matrices)Coleccion[i];
                    if (tmpMatriz.getNombre() == nombre1)
                    { this.setPosicion1(i); }
                }
                this.Instrucciones("Ingrese el nombre de la matriz 2: ");
                nombre2 = Console.ReadLine();
                for (int j = 0; j < Coleccion.Count; j++)
                {
                    Matrices tmpMatriz = (Matrices)Coleccion[j];
                    if (tmpMatriz.getNombre() == nombre2)
                    { this.setPosicion2(j); }
                }
                primeraMatriz = (Matrices)Coleccion[this.getPosicion1()];
                segundaMatriz = (Matrices)Coleccion[this.getPosicion2()];
                //se realiza la operacion
                resultadoMatriz = miOperacion.multiplicacion(primeraMatriz, segundaMatriz);
                Coleccion[0] = resultadoMatriz;
            }
            catch (Exception)
            { this.MenuOM(); }
            this.MenuO();
        }
        public void MenuOA()
        {
            Matrices matrizSeleccionada = new Matrices();
            Matrices matrizTemporal = new Matrices();
            Matrices matrizInversa = new Matrices();
            Operaciones miOperacion = new Operaciones();
            string nombre; int posicion;
            bool paseBool = true;
            Console.Clear();
            this.NombreMenu("Asistente para inversa");
            this.Instrucciones("Ingrese el nombre de la matriz : ");
            nombre = Console.ReadLine();
            posicion = this.encontrarMatriz(nombre);
            matrizSeleccionada = (Matrices)Coleccion[posicion];
            matrizSeleccionada.verContenido();
            matrizInversa = miOperacion.matrizAumentada(matrizSeleccionada);
            matrizInversa.verContenido();
            while (paseBool)
            {
                Console.Clear();
                this.NombreMenu("Asistente para inversa");
                Console.WriteLine();
                matrizTemporal = matrizInversa;
                matrizTemporal.verContenido();
                char tmpChar;
                Console.WriteLine();
                this.Visualizacion("m)Multiplicar un renglon por C", "n)Multiplicar un renglon por 1/C", "j)Multiplicar un renglon por C y sumarlo a otro", "z)Intercambiar un renglon por otro", "x)salir");
                tmpChar = Console.ReadKey(true).KeyChar;
                switch (tmpChar)
                {
                    case 'j': this.MenuAJI(matrizInversa); break;
                    case 'm': this.MenuAMI(matrizInversa); break;
                    case 'n': this.MenuANI(matrizInversa); break;
                    case 'z': this.MenuAZI(matrizInversa); break;
                    case 'x': paseBool = false; break;
                }
            }
            this.MenuO();
        }
        public void MenuAJI(Matrices matrizInversa)
        {
            try
            {
                Console.Clear();
                this.NombreMenu("Multiplicar un renglon por C y sumarlo a otro");
                int renglon1, renglon2, c;
                do
                {
                    this.Instrucciones("Indique el numero del primer renglon  (limite 0-" + (matrizInversa.getRenglon() - 1) + "): ");
                    renglon1 = Convert.ToInt32(Console.ReadLine());
                } while (renglon1 >= matrizInversa.getRenglon());
                do
                {
                    this.Instrucciones("Indique el numero del segundo renglon  (limite 0-" + (matrizInversa.getRenglon() - 1) + "): ");
                    renglon2 = Convert.ToInt32(Console.ReadLine());
                } while (renglon2 >= matrizInversa.getRenglon());
                this.Instrucciones("Indique la constante: ");
                c = Convert.ToInt32(Console.ReadLine());
                matrizInversa.setNombre("Multiplicacion del renglon: " + renglon1 + ", multiplicado  por: " + c + " y sumado a renglon: " + renglon2);
                for (int j = 0; j < matrizInversa.getColumna(); j++)
                {
                    matrizInversa.setElemento(renglon2, j, (matrizInversa.getElemento(renglon1, j) * c) + matrizInversa.getElemento(renglon2, j));
                }

            }
            catch (Exception)
            { this.MenuAJI(matrizInversa); }

        }
        public void MenuANI(Matrices matrizInversa)
        {
            try
            {
                this.NombreMenu("Multiplicar por 1/C");
                int renglon;
                double cc, tmp1, tmp2, tmp3, c;
                Console.Clear();
                do
                {
                    Console.Write("Indique el numero del renglon a multiplicar  (limite 0-" + (matrizInversa.getRenglon() - 1) + "): ");
                    renglon = Convert.ToInt32(Console.ReadLine());
                } while (renglon >= matrizInversa.getRenglon());
                this.Instrucciones("Indique la constante: ");
                c = Convert.ToDouble(Console.ReadLine());
                cc = 1 / c;
                matrizInversa.setNombre("Multiplicacion del renglon: " + renglon + ", multiplicado  por la inversa de : " + c);
                for (int i = 0; i < matrizInversa.getColumna(); i++)
                {
                    tmp1 = (matrizInversa.getElemento(renglon, i) * cc) * 100;
                    tmp2 = Math.Truncate(tmp1);
                    tmp3 = tmp2 / 100;
                    matrizInversa.setElemento(renglon, i, tmp3);
                }
            }
            catch (Exception)
            { this.MenuANI(matrizInversa); }

        }
        public void MenuAMI(Matrices matrizInversa)
        {
            try
            {
                this.NombreMenu("Multiplicar un renglon por C");
                int renglon, c;
                Console.Clear();
                do
                {
                    this.Instrucciones("Indique el numero del renglon a multiplicar  (limite 0-" + (matrizInversa.getRenglon() - 1) + "): ");
                    renglon = Convert.ToInt32(Console.ReadLine());
                } while (renglon >= matrizInversa.getRenglon());
                this.Instrucciones("Indique la constante: ");
                c = Convert.ToInt32(Console.ReadLine());
                matrizInversa.setNombre("Multiplicacion del renglon: " + renglon + ", multiplicado  por: " + c);
                for (int i = 0; i < matrizInversa.getColumna(); i++)
                {
                    matrizInversa.setElemento(renglon, i, matrizInversa.getElemento(renglon, i) * c);
                }
            }
            catch (Exception)
            { this.MenuAMI(matrizInversa); }

        }
        public void MenuAZI(Matrices matrizInversa)
        {
            try
            {
                this.NombreMenu("Intercambiar un renglon por otro");
                Console.Clear();
                int renglon1, renglon2;
                Matrices memoria = new Matrices(matrizInversa.getColumna());
                do
                {
                    this.Instrucciones("Indique el numero del primer renglon  (limite 0-" + (matrizInversa.getRenglon() - 1) + "): ");
                    renglon1 = Convert.ToInt32(Console.ReadLine());
                } while (renglon1 >= matrizInversa.getRenglon());
                do
                {
                    this.Instrucciones("Indique el numero del segundo renglon  (limite 0-" + (matrizInversa.getRenglon() - 1) + "): ");
                    renglon2 = Convert.ToInt32(Console.ReadLine());
                } while (renglon2 >= matrizInversa.getRenglon());
                matrizInversa.setNombre("intercambio de renglones " + renglon1 + " y " + renglon2);
                for (int i = 0; i < matrizInversa.getColumna(); i++)
                {
                    memoria.setElemento(i, matrizInversa.getElemento(renglon1, i));
                    matrizInversa.setElemento(renglon1, i, matrizInversa.getElemento(renglon2, i));
                    matrizInversa.setElemento(renglon2, i, memoria.getElemento(i));
                }
                /*
                    memoria[i] = otro[i];
                    otro[i] = matriz[i];
                    matriz[i] = memoria[i];
                 */
            }
            catch (Exception)
            { this.MenuAZI(matrizInversa); }
        }

        public void MenuV()
        {
            Console.Clear();
            this.NombreMenu("Ver");
            this.Visualizacion("i)Individual", "t)Todas", "x)Salir");
            this.Instrucciones("Seleccione una letra para entrar a la opcion correspondiente: ");
            this.SeleccionVer();
        }
        public void MenuVI()
        {
            string nombre;
            Console.Clear();
            this.NombreMenu("Individual");
            Console.WriteLine("NOTA: El nombre debe ser como lo guardo, de lo contrario no va a aparecer");
            this.Instrucciones("Ingrese el nombre de la matriz a buscar: ");
            nombre = Console.ReadLine();
            for (int i = 0; i < Coleccion.Count; i++)
            {
                Matrices tmpMatriz = (Matrices)Coleccion[i];
                if (tmpMatriz.getNombre() == nombre)
                { Console.Clear(); tmpMatriz.verContenido(); }
            }
            this.espera();
            this.MenuV();
        }
        public void MenuVT()
        {
            Console.Clear();
            this.NombreMenu("Todas");
            for (int i = 0; i < Coleccion.Count; i++)
            {
                Matrices tmpMatriz = (Matrices)Coleccion[i];
                tmpMatriz.verContenido();
            }
            this.espera();
            this.MenuV();
        }
        public void MenuC()
        {
            Console.Clear();
            this.NombreMenu("Crear");
            this.Visualizacion("A)Automatica", "p)Propia", "t)Tamaño",
                "c)Capturar", "s)Seleccionar", "i)Imprimir",
                "k)Capurar otro", ")Multiplicar por C", "n)Multiplicar por 1/C", "z)Intercambiar",
                "j)Multiplicar por c y sumar a otro", "x)Salir");
            this.Instrucciones("Seleccione una letra para entrar a la opcion correspondiente: ");
            this.SeleccionCrear();
        }
        public void MenuCA()
        {
            try
            {
                Matrices nuevaMatrizAuto;
                string tmpNombre;
                int renglones, columnas;
                bool automatica = true;
                Console.Clear();
                this.NombreMenu("Automatica");
                this.Instrucciones("Nombre de la matriz: ");
                tmpNombre = Console.ReadLine();
                this.Instrucciones("Numero de renglones: ");
                renglones = Convert.ToInt32(Console.ReadLine());
                this.Instrucciones("Numero de columnas: ");
                columnas = Convert.ToInt32(Console.ReadLine());
                nuevaMatrizAuto = new Matrices(renglones, columnas, automatica);
                nuevaMatrizAuto.setNombre(tmpNombre);
                Coleccion.Add(nuevaMatrizAuto);
            }
            catch (Exception)
            { this.MenuCA(); }
            this.MenuC();
        }
        public void MenuCP()
        {
            try
            {
                Matrices nuevaMatrizPrpia;
                string tmpNombre;
                int renglones, columnas;
                bool automatica = false;
                Console.Clear();
                this.NombreMenu("Propia");
                this.Instrucciones("Nombre de la matriz: ");
                tmpNombre = Console.ReadLine();
                this.Instrucciones("Numero de renglones: ");
                renglones = Convert.ToInt32(Console.ReadLine());
                this.Instrucciones("Numero de columnas: ");
                columnas = Convert.ToInt32(Console.ReadLine());
                nuevaMatrizPrpia = new Matrices(renglones, columnas, automatica);
                nuevaMatrizPrpia.setNombre(tmpNombre);
                Coleccion.Add(nuevaMatrizPrpia);
            }
            catch (Exception)
            { this.MenuCP(); }
            this.MenuC();
        }
        public void MenuCT()
        {
            try
            {
                int tamaño;
                Console.Clear();
                this.NombreMenu("Tamaño");
                this.Instrucciones("Indique el tamaño de la matriz: ");
                tamaño = Convert.ToInt32(Console.ReadLine());
                this.setTamaño(tamaño);
                this.MenuC();
            }
            catch (Exception)
            { this.MenuCT(); }
        }
        public void MenuCC()
        {
            try
            {
                Console.Clear();
                this.NombreMenu("Capturar");
                matriz = new decimal[this.getTamaño()];
                for (int i = 0; i < getTamaño(); i++)
                {
                    Console.Write("Ingrese el dato en la matriz [" + i + "]: ");
                    matriz[i] = Convert.ToInt32(Console.ReadLine());
                }
                this.MenuC();
            }
            catch (Exception)
            { this.MenuCC(); }
        }
        public void MenuCS()
        {
            try
            {
                int cambio;
                do
                {
                    Console.Clear();
                    this.NombreMenu("Seleccionar");
                    this.Instrucciones("Numero de la matriz que desea cambiar\t\tlimite: 0-" + (this.getTamaño() - 1));
                    Console.WriteLine();
                    cambio = Convert.ToInt32(Console.ReadLine());
                } while (cambio >= this.getTamaño());
                Console.Write("matriz [" + cambio + "]: ");
                matriz[cambio] = Convert.ToInt32(Console.ReadLine());
                this.MenuC();
            }
            catch (Exception)
            { this.MenuCS(); }
        }
        public void MenuCI()
        {
            try
            {
                Console.Clear();
                this.NombreMenu("Imprimir");
                if (this.getTamaño() != 0)
                {
                    try
                    {
                        Console.WriteLine("Matriz Original");
                        for (int i = 0; i < getTamaño(); i++)
                        {
                            Console.Write("matriz [" + i + "]: ");
                            Console.WriteLine(matriz[i]);
                        }
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("¡¡No hay nada capturado en la matriz!!");
                        Console.Write("Tecle cualquier letra para continuar.....");
                        Console.ReadKey();
                        this.MenuC();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    try
                    {
                        Console.WriteLine("Otra Matriz");
                        for (int j = 0; j < getTamaño(); j++)
                        {
                            Console.Write("matriz [" + j + "]: ");
                            Console.WriteLine(otro[j]);
                        }
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Matriz Original");
                        for (int i = 0; i < getTamaño(); i++)
                        {
                            Console.Write("matriz [" + i + "]: ");
                            Console.WriteLine(matriz[i]);
                        }
                        Console.Write("Tecle cualquier letra para continuar.....");
                        Console.ReadKey();
                        this.MenuC();
                    }
                    Console.Write("Tecle cualquier letra para continuar.....");
                    Console.ReadKey();
                    this.MenuC();
                }
                else
                {
                    Console.WriteLine("¡¡No hay nada capturado!!");
                    Console.Write("Tecle cualquier letra para continuar.....");
                    Console.ReadKey();
                    this.MenuC();
                }
            }
            catch (Exception)
            { this.MenuCI(); }
        }
        public void MenuCK()
        {
            try
            {
                Console.Clear();
                otro = new decimal[getTamaño()];
                this.NombreMenu("Capturar Otro");
                for (int i = 0; i < getTamaño(); i++)
                {
                    Console.Write("Ingrese el dato en la segunda matriz [" + i + "]: ");
                    otro[i] = Convert.ToInt32(Console.ReadLine());
                }
                this.MenuC();
            }
            catch (Exception)
            {
                this.MenuCK();
            }
        }
        public void MenuCM()
        {
            try
            {
                Console.Clear();
                int c;
                this.NombreMenu("Multiplicar por C");
                this.Instrucciones("Ingrese un numero a multiplicar: ");
                c = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < getTamaño(); i++)
                {
                    matriz[i] = matriz[i] * c;
                }
                this.MenuC();
            }
            catch (Exception)
            { this.MenuCM(); }
        }
        public void MenuCN()
        {
            try
            {
                Console.Clear();
                decimal c;
                decimal cd;
                decimal tmp1, tmp2, tmp3;
                this.NombreMenu("Multiplicar por 1/C");
                this.Instrucciones("Ingrese un numero a multiplicar: ");
                c = Convert.ToDecimal(Console.ReadLine());
                cd = 1 / c;
                for (int i = 0; i < getTamaño(); i++)
                {
                    tmp1 = (matriz[i] * cd) * 100;
                    tmp2 = Math.Truncate(tmp1);
                    tmp3 = tmp2 / 100;
                    matriz[i] = tmp3;
                }
                this.MenuC();
            }
            catch (Exception)
            { this.MenuCN(); }
        }
        public void MenuCJ()
        {
            try
            {
                Console.Clear();
                int c;
                this.NombreMenu("Multiplicar por C y sumar a otro");
                this.Instrucciones("Ingrese un numero a multiplicar: ");
                c = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < otro.Length; i++)
                {
                    otro[i] = (matriz[i] * c) + otro[i];
                }
                this.MenuC();
            }
            catch (Exception)
            { this.MenuCJ(); }
        }
        public void MenuCZ()
        {
            try
            {
                Console.Clear();
                memoria = new decimal[getTamaño()];
                this.NombreMenu("Intercambio de matrices");
                for (int i = 0; i < getTamaño(); i++)
                {
                    memoria[i] = otro[i];
                    otro[i] = matriz[i];
                    matriz[i] = memoria[i];
                }
                this.Instrucciones("Matrices intercambiadas....");
                Console.WriteLine();
                Console.Write("Tecle cualquier letra para continuar.....");
                Console.ReadKey();
                this.MenuC();
            }
            catch (Exception)
            { this.MenuCZ(); }
        }

    }//Class
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora de Matrices By 0s4k4";
            Menu miMatriz;
            miMatriz = new Menu();
            miMatriz.MenuP();
            //calcudora creada por 0s4k4(Jorge luis Piña)
        }
    }
}