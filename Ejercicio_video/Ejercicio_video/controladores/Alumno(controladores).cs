using Ejercicio_video.entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_video.controladores
{
    internal class Alumno_controladores_
    {
        // Arreglo
        private Alumno[] alumnos = new Alumno[100];
        private int contador = 0;

        // listar todos los alumnos
        public Alumno[] ListarTodo() { return alumnos; }

        // listar Alumno
        public void Resgistrar(Alumno alumno)
        {
            alumnos[contador] = alumno;
            contador++;
        }

        // Eliminar alumnos 
        public void EliminarAlumno(string codigo)
        {
            int posicion = Array.FindIndex(alumnos, alumno => alumno != null && alumno.Codigo == codigo);

            if (posicion >= 0)
            {
                for (int i = posicion; i < contador - 1; i++)
                {
                    alumnos[i] = alumnos[i + 1];
                }

                alumnos[contador - 1] = null;
                contador--;
            }
        }

        // Metodo comparacion
        private class MetodoComparacion : IComparer<Alumno>
        {
            public int Compare(Alumno x, Alumno y)
            {
                if (x.Promedio < y.Promedio) return -1;
                else if (x.Promedio == y.Promedio) return 0;
                else return 1;
            }
        }

        // Ordenar alumnos por promedio
        public Alumno[] Ordenar()
        {
            Array.Sort(alumnos, 0, contador, new MetodoComparacion());
            return alumnos;
        }
        // BUSCAR ALUMNO SEGUN SU CODIGO
        public Alumno[] BuscarPorCodigo(string codigo)
        {
            return Array.FindAll(alumnos, alumno => alumno != null && alumno.Codigo == codigo);

        }
    }


}