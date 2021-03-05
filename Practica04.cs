﻿using System;
using System.Linq;
using System.Text;

namespace package
{
    class Practica04
    {
        static void Main(string[] args)
        {

            //instancia entre la clase Practica04 y la clase ClaseObjetos.
            ClaseObjeto co = new ClaseObjeto();

            /* ejercicio 1
            #region ejercicio1

            int[]numeros = new int[4];
            int sm;

            for(int i=0; i < numeros.Length; i++){
                Console.WriteLine("Ingrese 4 numeros por teclado: ");
                sm = int.Parse(Console.ReadLine());
                numeros[i]=sm;
            }
            int sc = numeros[0]+numeros[1]+numeros[2]+numeros[3];
            int aritmetica = sc/4;

            Console.WriteLine("La media aritmetica es "+aritmetica+" y los numeros ingresados son "+numeros[0]+" "+numeros[1]+" "+numeros[2]+" "+numeros[3]);


             #endregion
            */

            //ejercicio 2

            /*#region ejercicio 2

            float[]array1 = new float[5];
            float sm2;

            for(int j=0; j < array1.Length; j++){
            Console.WriteLine("Ingrese 5 numeros reales: ");
            sm2 = float.Parse(Console.ReadLine());
            array1[j]=sm2;
            }
            Console.WriteLine("Los numeros ingresado de forma contraria son:"+array1[4]+", "+array1[3]+", "+array1[2]+", "+array1[1]+", "+array1[0]);

             #endregion
            */

            //ejercicio 3
            /*
            #region ejercicio 3
            int[] CantidadDias  = {31,30,28};
            int[] NumeroMes     = {0,1,2,3,4,5,6,7,8,9,10,11,12};

            //Clasificación de los meses según su cantidad de días.
            NumeroMes[1] =  CantidadDias[0];     NumeroMes[4] =  CantidadDias[1];   NumeroMes[2] = CantidadDias[2];
            NumeroMes[3] =  CantidadDias[0];     NumeroMes[6] =  CantidadDias[1];
            NumeroMes[5] =  CantidadDias[0];     NumeroMes[9] =  CantidadDias[1];
            NumeroMes[7] =  CantidadDias[0];     NumeroMes[11] = CantidadDias[1];
            NumeroMes[8] =  CantidadDias[0];     
            NumeroMes[10] = CantidadDias[0];
            NumeroMes[12] = CantidadDias[0];

            int sc = 0;
            Console.WriteLine("Ingrese el numero relacionado con su mes (1-12): ");
            sc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El numero relacionado al mes {0} tiene {1} dias",sc,NumeroMes[sc]);
            #endregion
            */
            //ejercicio 4
            /*
            #region ejercicio4
            int []array2 = new int[10];
            int nm;

            for(int i=0; i < array2.Length; i++){
            Console.WriteLine("Ingrese un numero: ");
            nm = int.Parse(Console.ReadLine());
            array2[i]=nm;
            }
            Console.WriteLine("El numero Mayor es: "+array2.Max());
            #endregion
            */

            //ejercicio 5
            /*
            #region ejercicio 5
            string[]nombres = new string[100];
            string nm2;
            string acumulador = null;


            do{
             Console.WriteLine("Ingrese un nombre: ");
             nm2 = Console.ReadLine();
             acumulador = acumulador +" \n"+ nm2;
             Console.WriteLine("Presione la barra espaciadora para continuar, y ENTER para salir");  
            //la barra espaciadora es para que me permita seguir insertando numeros, ya que si doy ENTER el ReadKey me finaliza la ejecución del proceso. :(
            }while(Console.ReadKey().Key != ConsoleKey.Enter);{
            Console.WriteLine("Los nombres ingresados fueron: "+ acumulador);
            }
            #endregion
            */

            //ejercicio 6

            bool salir = false;
            int seleccion;

            string[] ficheros = new string[1];
            int[] anchura = new int[1];
            int[] altura = new int[1];
            float[] tamaño = new float[1];

            while (!salir)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1. añadir datos de un nuevo fichero");
                Console.WriteLine("2. ver todas las fichas");
                Console.WriteLine("3. buscar ficha: ");
                Console.WriteLine("4. Salir");
                Console.WriteLine("------------------------------------");

                seleccion = Convert.ToInt32(Console.ReadLine());

                switch (seleccion)
                {

                    case 1:
                        for (int bc1 = 0; bc1 < ficheros.Length; bc1++)
                        {
                            Console.WriteLine("Ingrese el nombre del fichero: ");
                            string aaf1 = Console.ReadLine();
                            ficheros[bc1] = aaf1;
                        }

                        for (int bv = 0; bv < altura.Length; bv++)
                        {
                            Console.WriteLine("Ingrese la anchura en pixeles de la imagen: ");
                            int aaf2 = Convert.ToInt32(Console.ReadLine());
                            anchura[bv] = aaf2;
                        }

                        for (int bc3 = 0; bc3 < anchura.Length; bc3++)
                        {
                            Console.WriteLine("Ingrese la altura en pixeles de la imagen: ");
                            int aaf3 = Convert.ToInt32(Console.ReadLine());
                            altura[bc3] = aaf3;
                        }

                        for (int bc4 = 0; bc4 < tamaño.Length; bc4++)
                        {
                            Console.WriteLine("Ingrese el tamaño en KB de la imagen: ");
                            float aaf4 = float.Parse(Console.ReadLine());
                            tamaño[bc4] = aaf4;
                        }
                        break;

                    case 2:
                        Console.WriteLine("-----ESTADISTICAS-----");
                        for (int z = 0; z < ficheros.Length; z++)
                        {
                            Console.WriteLine(" - Nombre del fichero: " + ficheros[z]);
                        }
                        for (int z1 = 0; z1 < anchura.Length; z1++)
                        {
                            Console.WriteLine(" - Anchura del fichero: " + anchura[z1]);
                        }
                        for (int z2 = 0; z2 < altura.Length; z2++)
                        {
                            Console.WriteLine(" - Altura del fichero:  " + altura[z2]);
                        }
                        for (int z3 = 0; z3 < tamaño.Length; z3++)
                        {
                            Console.WriteLine(" - Tamaño en KB de los ficheros: " + tamaño[z3]+" KB");
                        }
                        Console.WriteLine("--------------------");
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el nombre del fichero que desee buscar: ");
                        string buscarfichero = Console.ReadLine();
                        if (buscarfichero == ficheros[0])
                        {
                            Console.WriteLine("Información del fichero: ");
                            Console.WriteLine(" - Nombre del fichero: " + ficheros[0]);
                            Console.WriteLine(" - Anchura del fichero: " + anchura[0]);
                            Console.WriteLine(" - Altura del fichero:  " + altura[0]);
                            Console.WriteLine(" - Tamaño en KB de los ficheros: " + tamaño[0]);
                        }
                        else
                        {
                            Console.WriteLine("No se ha encontrado el fichero con el nombre " + buscarfichero);
                        }
                        break;

                    case 4:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Debe elegir un numero entre (1-4).");
                        break;

                }
            }

            //for( bc = 0; bc < ficheros.Length; bc++){}




            //ejercicio 7 
            /*
            #region ejercicio 7
            string palabra = "";
            string extraer = "";

            Console.WriteLine("Ingrese el nombre que desee deletrear: ");
            palabra = Console.ReadLine();

            for(int e=0; e <= palabra.Length - 1; e++){

            extraer = palabra.Substring(e, 1);
            Console.Write(" "+ " "+extraer);
            }
            #endregion
            */

            //ejercicio 8
            /*
            #region ejercicio 8
            float[]altura = {5.5F,5.7F,5.1F,6.0F,6.2F};

            float AlturaPromedio = (altura[0]+altura[1]+altura[2]+altura[3]+altura[4])/5;

            Console.WriteLine("El promedio de estatura son: "+AlturaPromedio);
            Console.WriteLine("Las alturas que estan por encima del promedio son: ");
            for(int m=0; m < altura.Length; m++){

            if(altura[m]> AlturaPromedio){
            Console.WriteLine(altura[m]);
                }
            }

            Console.WriteLine("Las alturas que estan por debajo del promedio son");
            for(int n=0; n < altura.Length; n++){
            if(altura[n]< AlturaPromedio ){
            Console.WriteLine(altura[n]);
                }
            }
            #endregion
            */

            //ejercicio 9
            //co.TablaMultiplicar();

            //ejercicio 10
            //co.DatosPersona();


        }
    }

}

