using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizCalculadora

{
    class Matrices
    {
        public double[,] arreglo;
        public double[] reglonArreglo;
        private int renglon;
        private int columna;
        private string nombre;
        private int posicion1;
        private int posicion2;

        public Matrices()
        {
            arreglo = new double[12, 15];
            renglon = 12;
            columna = 15;
            nombre = "R";
        }
        public Matrices(int ren, int col)
        {
            arreglo = new double[ren, col];
            renglon = ren;
            columna = col;
        }
        public Matrices(int ren)
        {
            reglonArreglo = new double[ren];
            renglon = ren;
        }
        public Matrices(int ren, int col, bool esAutomatica)
        {
            arreglo = new double[ren, col];
            Random G = new Random();

            renglon = ren;
            columna = col;
            if (esAutomatica)
            {
                for (int i = 0; i < renglon; i++)
                {
                    for (int j = 0; j < columna; j++)
                    {
                        arreglo[i, j] = G.Next(10, 100);
                    }//i
                }//j
            }
            else
            {
                for (int i = 0; i < renglon; i++)
                {
                    for (int j = 0; j < columna; j++)
                    {
                        Console.Write("Ingrese el datos de la matriz [ " + i + " , " + j + " ] :  ");
                        arreglo[i, j] = Convert.ToDouble(Console.ReadLine());
                    }//i
                }//j
            }//if
        }//constructor
        //setter
        public void setRenglon(int miRenglon)
        {
            renglon = miRenglon;
        }
        public void setColumna(int miColumna)
        {
            columna = miColumna;
        }
        public void setNombre(string minombre)
        {
            nombre = minombre; ;
        }
        public void setPosicion1(int miPosicion1)
        {
            posicion1 = miPosicion1;
        }
        public void setPosicion2(int miPosicion2)
        {
            posicion2 = miPosicion2;
        }
        public void setElemento(int ren, int col, double elemento)
        {
            arreglo[ren, col] = elemento;
        }
        public void setElemento(int ren, double elemento)
        {
            reglonArreglo[ren] = elemento;
        }
        //getter
        public int getRenglon()
        {
            return renglon;
        }
        public int getColumna()
        {
            return columna;
        }
        public string getNombre()
        {
            return nombre;
        }
        public int getPosicion1()
        {
            return posicion1;
        }
        public int getPosicion2()
        {
            return posicion2;
        }
        public double getElemento(int ren, int col)
        {
            return arreglo[ren, col];
        }
        public double getElemento(int ren)
        {
            return reglonArreglo[ren];
        }
        public void verContenido()
        {
            Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°° Matriz: " + this.getNombre() + "°°°°°°°°°°°°°°°°°°°°°°");
            for (int i = 0; i < this.getRenglon(); i++)
            {
                for (int j = 0; j < this.getColumna(); j++)
                {
                    Console.Write(arreglo[i, j] + "\t");
                }//i
                Console.WriteLine();
            }//j
            Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°° Fin de Matriz: " + this.getNombre() + "°°°°°°°°°°°°°°°°°°°°°°°");
        }
        public void espera()
        {
            Console.Write("°°°°°°°°°°°°°°°°°°°°°Pulse cualquier tecla para continuar°°°°°°°°°°°°°°°°°°");
            Console.ReadKey();
        }
        public void escribirLinea(string linea)
        {
            Console.WriteLine(linea);

        }



        public void escribir(string info)
        {
            Console.WriteLine(info);

        }






    }
}