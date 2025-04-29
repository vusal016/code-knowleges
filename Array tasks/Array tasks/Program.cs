#region Verilmis arrayin elementleri cemini yazdir
using System;

int[] array= { 12,25,45,76,88};
int cem = 0;

for (int i = 0; i < array.Length; i++)
{
    cem += array[i];
}

Console.WriteLine(cem);
#endregion
#region Verilmis int arrayin en boyuk deyere sahib elementleri cemin tapmaq
int [] verilen = { 34, 15, 57, 90 };
int boyukler = 0;
int enboyuk = verilen[0];
for (int i = 0; i < verilen.Length; i++)
{
    if (verilen[i] > enboyuk)
    {
        enboyuk = verilen[i];
    }
}
        
        boyukler += enboyuk;
    

Console.WriteLine(boyukler);
#endregion

#region Verilmiş int Arrayın ən böyük dəyərə sahib elementini tapın
int[] array= { 34, 15, 57, 90 };
int enboyuk = array[0];

for (int i = 0;i<array.Length; i++)
{
    if (array[i] > enboyuk)
    {
        enboyuk = array[i];

    }
}
Console.WriteLine(enboyuk);
#endregion
#region Verilmiş Arrayın ilk və son elementlərinin cəmini tapın
int[] array= { 34, 15, 57, 90 };

int cem = array[0] + array[array.Length-1];
Console.WriteLine(cem);
#endregion
#region Verilmiş müsbət tam n ədədinin 2-nin qüvvəti olub-olmamasını tapın
int n = 10;

while (n % 2 == 0)
{
    n = n / 2;
}

if (n == 1)
{
    Console.WriteLine("tapildi"); 
}
else
{
    Console.WriteLine("tapilmadi");
}
#endregion
#region Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın.
int verileneded = Convert.ToInt32(Console.ReadLine());
int mertebesayi = 0;
if (verileneded == 0)
{
    Console.WriteLine("bir mertebeli");
}
else
{
    while (verileneded != 0)
    {

        verileneded += verileneded / 10;
        mertebesayi++;
    }
}
Console.WriteLine(mertebesayi);
#endregion
#region son task
int[] array = { 10, 20, 30, 40, 50, 60, 70 };
int n = Convert.ToInt32(Console.ReadLine()); 

int left = 0;
int right = array.Length - 1;
int index = -1;

while (left <= right)
{
    int mid = (left + right) / 2;

    if (array[mid] == n)
    {
        index = mid;
        break;
    }
    else if (array[mid] < n)
    {
        left = mid + 1;
    }
    else
    {
        right = mid - 1;
    }
}

Console.WriteLine(index);
#endregion
