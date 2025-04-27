#region Verilmis ededin reqemlerinin hasilin tapan algo 1 ci tapsiriq:
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;

while (a > 0)
{
    b *= a % 10;
    a = a / 10;

}
Console.WriteLine(b);
#endregion
#region Super marketde aksiya algoritmi
int mehsulucuz = Convert.ToInt32(Console.ReadLine());
int mehsul2 = Convert.ToInt32(Console.ReadLine());
int mehsul3 = Convert.ToInt32(Console.ReadLine());

int cem = mehsulucuz + mehsul2 + mehsul3;
int enkicik = mehsulucuz;

if (enkicik > mehsul2)
{
    enkicik = mehsul2;
}
if (enkicik > mehsul3)
{
    enkicik = mehsul3;
}
Console.WriteLine(cem - mehsulucuz);
#endregion
#region Tapsiriq 3. verilen ededin 3 e bolunen cut eded ve ya tek eded olmasi
int eded = Convert.ToInt32(Console.ReadLine());
if (eded%6==0)
{
    Console.WriteLine("3 e bolunen cut ededdir");
}
if (eded % 15== 0)
{
    Console.WriteLine("3 e bolunen tek ededdir");
}
else
    Console.WriteLine("3 e bolunmur");
#endregion
#region Tapsiriq 4: n ededinin sade ve ya murekkeb eded olmasi
int n = Convert.ToInt32.(Console.ReadLine());

if (n%6==0)
{
    Console.WriteLine("n murekkeb ededdir.");

}
if (n%15)
{
    Console.WriteLine("n sade ededdir.");
}
#endregion
#region X,Y,Z ededlerinden en kiciyini tapmaq
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());

int kicikolan = x;
if (kicikolan > y)
{
    kicikolan = y;
}
if (kicikolan > z)
{
    kicikolan = z;
}
Console.WriteLine(kicikolan);
#endregion
#region Verilmis ededin 3 e ve 7 ye bolunub bolunmemesini tapan algo
int verileneded = Convert.ToInt32(Console.ReadLine());

if (verileneded % 21 == 0)
{
    Console.WriteLine("bu eded 3 e ve 7 ye bolunur");

}
else
{
    Console.WriteLine("bu eded 3 e ve 7 ye bolunmur");
}
#endregion
#region verilen 3 ededden musbet olanlarin sayini tapan algo
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());

int sum = 0;

if (x > 0)
{
    sum += x;
}
if (y > 0)
{
    sum += y;
}
if (z > 0)
{
    sum += z;
}
Console.WriteLine(sum);
#endregion
#region Verilmis M den N e qeder ededlerin cemi
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

int cem = 0;

for (int i=M; i < N; i++)
{
    cem += i;
}
Console.WriteLine(cem);
#endregion
#region Birden M e dek ededlerden 15 e bolunenlerin sayi
int M = Convert.ToInt32(Console.ReadLine());
int toplam = 0;
for (int i = 1; i < M; i++)
{
    if (i % 15 == 0)
    {
        toplam += i;
    }
}
Console.WriteLine(toplam);
#endregion
#region 1 bir ve  M arasi 21 e bolunenlerin en kicik ortaq boluneni
int M = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int sayi = 0;
for (int i = 1; i < M; i++)
{
    if (i % 15 == 0)
    {
        sum += i;

    }
    if (i % 21 == 0)
    {

        sayi += 1;
    }
}
    Console.WriteLine(sum);
        Console.WriteLine(sayi);
#endregion
#region Verilmis N ededinin reqemleri ceminin tapilmasi
int N = Convert.ToInt32(Console.ReadLine());

int reqemcemi = 0;

while (N > 0)
{
  reqemcemi += N % 10;
  N = N / 10;
}
Console.WriteLine(reqemcemi);
#endregion






