using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizCalculadora

{
    class Operaciones
    {
        public Matrices suma(Matrices matrizA, Matrices matrizB)
        {
            Matrices resultado;
            resultado = new Matrices(matrizA.getRenglon(), matrizA.getColumna());
            resultado.setNombre("Suma de " + matrizA.getNombre() + "+" + matrizB.getNombre());
            for (int i = 0; i < matrizA.getRenglon(); i++)
            {
                for (int j = 0; j < matrizA.getColumna(); j++)
                {
                    resultado.setElemento(i, j, matrizA.getElemento(i, j) + matrizB.getElemento(i, j));
                }//i
                Console.WriteLine("");
            }//j
            return resultado;
        }
        public Matrices resta(Matrices matrizA, Matrices matrizB)
        {
            Matrices resultado;
            resultado = new Matrices(matrizA.getRenglon(), matrizA.getColumna());
            resultado.setNombre("Resta de " + matrizA.getNombre() + " - " + matrizB.getNombre());
            for (int i = 0; i < matrizA.getRenglon(); i++)
            {
                for (int j = 0; j < matrizA.getColumna(); j++)
                {
                    resultado.setElemento(i, j, matrizA.getElemento(i, j) - matrizB.getElemento(i, j));
                }//i
                Console.WriteLine("");
            }//j
            return resultado;
        }
        public Matrices multiplicacion(Matrices matrizA, Matrices matrizB)
        {
            Matrices resultado;
            resultado = new Matrices(matrizA.getRenglon(), matrizB.getColumna());
            resultado.setNombre("Multiplicacion  de " + matrizA.getNombre() + " * " + matrizB.getNombre());
            int tope = matrizA.getColumna();
            double tmp = 0;
            for (int i = 0; i < tope; i++)
            {
                for (int j = 0; j < tope; j++)
                {
                    tmp = 0;
                    for (int k = 0; k < tope; k++)
                    {
                        tmp = tmp + (matrizA.getElemento(k, i) * matrizB.getElemento(j, k));
                    }
                    resultado.setElemento(j, i, tmp);
                }
            }
            return resultado;
        }

        public Matrices matrizAumentada(Matrices seleccionada)
        {
            Matrices resultado = new MatrizCalculadora.Matrices(seleccionada.getRenglon(), seleccionada.getColumna() + seleccionada.getColumna());
            resultado.setNombre("Aumentada");
            for (int i = 0; i < seleccionada.getRenglon(); i++)
            {
                for (int j = 0; j < seleccionada.getColumna(); j++)
                {
                    resultado.setElemento(i, j, seleccionada.getElemento(i, j));
                }//i
            }//j
            for (int t = 0; t < seleccionada.getColumna(); t++)
            {
                resultado.setElemento(t, seleccionada.getColumna() + t, 1);
            }//i
            return resultado;
        }
    }

}