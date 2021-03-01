using System;
using System.Linq;
using System.Text;

namespace package
{
    class Practica04
    {
        static void Main(string[] args)
        {


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
 #region ejercicio3
  int[] dias = new int[4];
  dias [1] =31;
  dias [2]=30;
  dias [3]=28;

  int[] meses = new int[13];
  meses[1]=dias [1];
  meses[2]=dias [3];
  meses[3]=dias [1];
  meses[4]=dias [2];
  meses[5]=dias [1];
  meses[6]=dias [2];
  meses[7]=dias [1];
  meses[8]=dias [1];
  meses[9]=dias [2];
  meses[10]=dias [1];
  meses[11]=dias [2];
 meses[12]=dias [1];

  int mes=0;

  Console.WriteLine("Inserte un numero: ");
  mes = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("el numero {0} tiene {1} dias ",mes,meses[mes]);
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


//ejercicio 7 
string palabra = "";
string extraer = "";

Console.WriteLine("Ingrese el nombre que desee deletrear: ");
palabra = Console.ReadLine();

for(int e=0; e <= palabra.Length - 1; e++){

extraer = palabra.Substring(e, 1);
Console.Write(" "+ " "+extraer);

}


        }
    }
}
