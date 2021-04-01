using System;
using System.Collections;

namespace ConsoleApp2
{
    class Program
    {


        int contadoraprob = 0;

        int contador = 0;
        int posicion = 0;

        static void Main(string[] args)
        {

            int[] notas = new int[5];

            notas[0] = 10;
            notas[1] = 15;
            notas[2] = 20;
            notas[3] = 0;
            notas[4] = 5;

            Console.WriteLine("los desaprobados son " + cuentaDesaprobados(notas));
            mensajeAprobados(notas);
            desaprobados(notas);
            promediodesaprobados(notas);
            ordenarmayoramenor(notas);
            Console.WriteLine("los aprobados son " + cuentaaprobados(notas));
            aprobados(notas);
        }


        static int cuentaDesaprobados(int[] notas)
        {
            int contador = 0;
            int posicion = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < 13)
                {
                    contador++;
                    posicion = i;
                }
            }
            return contador;
        }


        static void mensajeAprobados(int[] notas)
        {
            int contador = 0;
            int posicion = 0;
           int contadoraprob=0;

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < 11)
                {
                    contador++;
                    posicion = i;
                }

                if (notas[i] > 11)
                {
                    contadoraprob++;
                    posicion = i;
                }
            }
            if (contadoraprob > contador)
            {
                Console.WriteLine("hay suficientes aprobados ");
            }
            else
                Console.WriteLine("los desaprobados son mas que los aprobados ");
        }

        static void desaprobados(int[] notas)
        {
            ArrayList desaprobados = new ArrayList();

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < 13)
                {

                    desaprobados.Add(notas[i]);

                }
            }

            foreach (var item in desaprobados)
            {
                Console.Write(item);
                Console.Write(' ');

            }
            Console.WriteLine("");
        }

        static void promediodesaprobados(int[] notas)
        {
            float sumadesaprobados = 0;
            float promediodesaprobados = 0;
            float cuentadesaprobados = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < 13)
                {
                    sumadesaprobados += notas[i];
                    cuentadesaprobados++;
                }
            }
            promediodesaprobados = (sumadesaprobados) / cuentadesaprobados;
            Console.WriteLine("el promedio de desaprobados es: " + promediodesaprobados);
        }


        static void ordenarmayoramenor(int[] notas)
        {
            int temp;
            for (int i = 0; i < notas.Length - 1; i++)
            {
                for (int j = i + 1; j < notas.Length; j++)
                {
                    if (notas[i] < notas[j])
                    {
                        temp = notas[i];
                        notas[i] = notas[j];
                        notas[j] = temp;
                    }

                }

            }


            foreach (var item in notas)
            {
                Console.WriteLine(item);
                Console.WriteLine(' ');
            }



        }


        static int cuentaaprobados(int[] notas)
        {
            int contador = 0;
            int posicion = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] > 13)
                {
                    contador++;
                    posicion = i;
                }
            }
            return contador;
        }
        static void aprobados(int[] notas)
        {
            ArrayList aprobados = new ArrayList();

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] > 13)
                {

                    aprobados.Add(notas[i]);

                }
            }

            foreach (var item in aprobados)
            {
                Console.WriteLine(item);
            }

        }

    }
}
