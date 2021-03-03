using System;

namespace package
{
    class ClaseObjeto
    {
public void TablaMultiplicar()
{
   int tbl=0;
while(tbl != -1)
{
   Console.WriteLine("Ingrese un numero: ");
    tbl = Convert.ToInt32(Console.ReadLine());

if(tbl==-1)
{
    continue;
}
Console.WriteLine("Tabla del "+tbl);
for(int h = 1; h <= 12; h++){
    int mp = tbl * h;

Console.WriteLine(tbl+" X "+h+" = "+mp);
        }
    }  
}


    }

}