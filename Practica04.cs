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
ClaseTablaMultiplicar cmp = new ClaseTablaMultiplicar();

cmp.TablaMultiplicar();





        }
    }
}
