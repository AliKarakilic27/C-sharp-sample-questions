
// Örnek Sorular ( C# başlangıç ve if else ile ilgili sorular)

/*

// 1) Yarıçapı klavyeden alınan bir diairenin alanını bulan program:

int dAlan, dYarıçap;

Console.Write("Dairenin Yarıçapını Giriniz: ");
dYarıçap=Convert.ToInt32(Console.ReadLine());

dAlan = 3 * (dYarıçap * dYarıçap);

Console.Write("Dairenin Alanı: " + dAlan);

*/

/*

// 2) Yarıçapı ve yüksekliği klavyeden girilen silindirin hacmini bulan program:

int yarıçap, yükseklik, hacim;

Console.Write("Yarıçap uzunluğunu giriniz: ");
yarıçap=Convert.ToInt32(Console.ReadLine());

Console.Write("Yüksekliği giriniz: ");
yükseklik=Convert.ToInt32(Console.ReadLine());

hacim = 3 * yarıçap * (2 * yükseklik);

Console.Write("Silindirin hacmi: " + hacim);

*/

/*

// 3) Klavyeden girilen iki basamaklı bir tam sayının basamaklarının karelerinin toplamını bulan program:

int x, y, z, i;

Console.Write("X sayısını giriniz: ");
x = Convert.ToInt32(Console.ReadLine());

y = x % 10;
z = x % 10;
i = (y * y) + (z * z);

Console.Write("Sonuç: " + i);

*/

/*

// 4) Klavyeden girilen sayının tek veya çift olduğunu bulan program:

int sayı;

Console.Write("Sayıyı giriniz: ");
sayı=Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if(sayı % 2 == 0)
{
    Console.Write("Girdiğiniz sayı çifttir.");
}
else
{
    Console.Write("Girdiğiniz sayı tektir.");
}

*/

/*

// 5) Klavyeden girilen iki farklı sayıdan büyük olanı ekrana yazdıran program:

int sayı1, sayı2;

Console.Write("Birinci sayıyı giriniz: ");
sayı1=Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayıyı giriniz: ");
sayı2 = Convert.ToInt32(Console.ReadLine());

if (sayı1 > sayı2)
{
    Console.WriteLine(sayı1);
}
else
{
    Console.WriteLine(sayı2);
}

*/

/*

// 6) Klavyeden x ve y giriliyor x'in y'nin tam katı olup olmadığını bulan program:

int x, y;

Console.Write("X sayısını yazınız: ");
x=Convert.ToInt32(Console.ReadLine());

Console.Write("Y sayısını yazınız: ");
y=Convert.ToInt32(Console.ReadLine());

if(x % y == 0)
{
    Console.WriteLine("X sayısı Y sayısının tam katıdır.");
}
else
{
    Console.WriteLine("X sayısı Y sayısının tam katı değildir.");
}

*/

/*

// 7) Klavyeden girilen sayının mutlak değerini bulan programram:

int sayı;

Console.Write("Sayıyı giriniz:");
sayı=Convert.ToInt32(Console.ReadLine());

if (sayı < 0)
{
    sayı = sayı * (-1);
    Console.Write("Girilen sayının mutlak değeri: "+sayı);
}
else
{
    Console.Write("Girilen sayı negatif değildir.");
}

*/

/*

// 8) Klavyeden girilen x'e göre y'nin ve z'nin değerini bulan program:

//  x<0     y = (x*x) + (2*x)       z = 3*x                     
//  x>=0    y = x                   z = (x*x)+10             

int x, y, z;

Console.Write("X sayısını giriniz: ");
x=Convert.ToInt32(Console.ReadLine());

if (x < 0)
{
    y = (x * x) + (2 * x);
    z = 3 * x;
    Console.Write("Girilen sayı sıfırdan küçük ise: " + y);

}
else if (x >= 0)
{
    y = x;
    z = (x * x) + 10;
    Console.Write("Girilen sayı sıfırdan büyük ya da eşit ise: " + z);
}

*/

/*

// 9) Klavyeden A ve B giriliyor a>b  a<b  a=b a ile b arasındaki büyüklük ilişkisini bulan program:

int a, b;

Console.Write("A sayısını girin: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("B sayısını girin: ");
b = Convert.ToInt32(Console.ReadLine());


if (a > b)

{                                                                          
    Console.Write("A sayısı B sayısından büyüktür: " + a);
}
else if (a < b)

{
    Console.Write("B sayı A sayısından küçüktür: " + b);
}

else

{
    Console.Write("A sayısı B sayısına eşit. ");
}

*/

/*

// 10) Klavyeden girilen sayının 0 ile 100 arasında olduğunu gösteren program:

int sayı;

Console.Write("Bir sayı giriniz: ");
sayı=Convert.ToInt32(Console.ReadLine());

if(sayı> 0 && sayı < 100)
{

    Console.Write("Girilen sayı 0 ile 100 arasındadır. "+sayı);
}
else
{
    Console.Write("Girilen sayı 0 ile 100 arasında değildir. " + sayı);
}

*/

/*

// 11) Klavyeden girilen 0 ile 1000 arasındaki sayıların kaç basamak olduğunu bulan program:

int sayı;

Console.Write("Bir sayı giriniz: ");
sayı=Convert.ToInt32(Console.ReadLine());

if(sayı>=0 && sayı <= 9)
{
    Console.Write("Girilen sayı bir basamaklıdır. " + sayı);
}else if(sayı>=10 && sayı <= 99)
{
    Console.Write("Girilen sayı iki basamaklıdır. " + sayı);
}else if(sayı>=100 && sayı <= 999)
{
    Console.Write("Girilen sayı üç basamaklıdır. " + sayı);
}
else
{
    Console.Write("İstenen aralık dışında bir sayı girdiniz: " + sayı);
}

*/

/*

// 12) y = (k*x) + t klavyeden girilen x'e göre y'nin feğerini bulan program:
// x<0 k = 2 t = 0   0<=x<=5 k = -1  t = 10  x>5 k = 3 t = -20

int x, y, k, t;

Console.Write("X sayısını giriniz: ");
x=Convert.ToInt32(Console.ReadLine());

if (x < 0)
{
    k = 2;
    t = 0;

}if(x>= 0 && x <= 5) {

    k = -1;
    t = 10;
}
else
{
    k = -3;
    t = -20;
}

y = (k * x) + t;
Console.Write("y: " + y);

*/

/*

// 13) Klavyeden girilen üç kenar uzunluğun üçgen oluşturup oluşturmadığını bulan programn:

// Üçgen olmanın şartı iki kenar toplamının üçüncü kenardan daha büyük olması gerekir

int x, y, z;

Console.Write("x kenarın uzunluğunu giriniz: ");
x =Convert.ToInt32(Console.ReadLine());

Console.Write("y kenarın uzunluğunu giriniz: ");
y =Convert.ToInt32(Console.ReadLine());

Console.Write("z kenarın uzunluğunu giriniz:");
z =Convert.ToInt32(Console.ReadLine());

if (x + y > z)
{
    Console.Write("Bu bir üçgendir.");
} else if (x + z > y)
{
    Console.Write("Bu bir üçgendir.");
} else if (y + z > x)
{
    Console.Write("Bu bir üçgendir.");
}
else
{
    Console.Write("Bu bir üçgen değildir.");
}

*/

/*

// 14) Klavyeden girilen üç kenar uzunluğun eşkenar üçgen oluşturup oluşturmadığını bulan programn:

// Tüm kenar uzunlukları  birbirine eşit olan geometrik şekle eşkenar üçgen denir.

int a, b,c;

Console.Write("a kenarın uzunluğunu giriniz: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("b kenarın uzunluğunu giriniz: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("c kenarın uzunluğunu giriniz:");
c = Convert.ToInt32(Console.ReadLine());

if(a==b && a==c && b == c)
{
    Console.Write("Bu bir eşkenar üçgendir.");
}
else
{
    Console.Write("Eşkenar üçgen değildir.");
}

*/

/*

// 15) Klavyeden girilen üç sayıdan en büyüğünü bulan program:

int sayı1, sayı2, sayı3;

Console.Write("Birinci sayıyı giriniz: ");
sayı1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayıyı giriniz: ");
sayı2= Convert.ToInt32(Console.ReadLine());

Console.Write("Üçüncü sayıyı giriniz:");
sayı3 = Convert.ToInt32(Console.ReadLine());

if (sayı1 > sayı2) { }
if (sayı1 > sayı3)
{
    Console.Write("Girilen sayılar arasında sayı bir en büyüğüdür. " + sayı1);
}if (sayı2 > sayı1) { }
 if (sayı2 > sayı3)
{
    Console.Write("Girilen sayılar arasında sayı iki en büyüğüdür. " + sayı2);
}
else
{
    Console.Write("Girilen sayılar arasında sayı üç en büyüğüdür. " + sayı3);
}

 */

/*

// 16) Klavyeden girilen notun harf aralığını bulan program:

int not;

Console.Write("Notunuzu giriniz: ");
not=Convert.ToInt32(Console.ReadLine());

if(not>=0 && not<=20)
{
    Console.Write("Harf aralığınız: FF");
}if(not>20 && not <= 40)
{
    Console.Write("Harf aralığınız: DD");
}if(not>40 && not <= 60)
{
    Console.Write("Harf aralığınız: CC");
}if(not>60 && not <= 80)
{
    Console.Write("Harf aralığınız: BB");
}if(not>80 && not <= 100)
{
    Console.Write("Harf aralığınız: AA");
}

*/

