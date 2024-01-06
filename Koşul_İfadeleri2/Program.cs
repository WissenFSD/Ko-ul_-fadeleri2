// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");



// bir önceki derste sadece iki durumu yönetebildiğiniz koşul ifadesini öğrenmiştik.


// if ve else kullanarak daha çok sayıda koşul kontrol edilebilir.// 


// Örnek şablon
//if ()
//else if()
//else if()
//else if ()
//else


// basit hesap makinası örneği

Console.WriteLine("Hesap makinası hoşgeldiniz");
Console.WriteLine("1 sayıyı giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2 sayıyı giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("+ - * / giriniz");
char islem = Convert.ToChar(Console.ReadLine());
int sonuc = 0;
// + - * /
if (islem == '+')
    sonuc = sayi1 + sayi2;
else if (islem == '-')
    sonuc = sayi1 - sayi2;
else if (islem == '*')
    sonuc = sayi1 * sayi2;
else if (islem == '/')
{
    // bölen 0 olamaz kontrolü
    if (sayi2 != 0)
    {
        sonuc = sayi1 / sayi2;
    }
    else
    {

        Console.WriteLine("Bölüm 0 olamaz");
    }
}

Console.WriteLine(sonuc);


// Ekrandan bir not değeri alınız.
// not : 85 ile 100 arasında ise pekiyi
// not 70 ile 85 arasında ise iui
// not 60 ile 70 arasında ise orta
// not 45 ile 60 arasında ise geçer
// not 25 ile 45 arasında ise zayıf
// not 0 ile 25 arasında ise kalır   yazdıralım

// 

int not = 80;

if(not>=85 && not <= 100)
{
    Console.WriteLine("Pekiyi");
}
else if(not>=70 && not <= 84)
{

    Console.WriteLine("iyi");
}
else if (not >= 60 && not <= 69)
{

    Console.WriteLine("orta");
}
else if (not >= 45 && not <= 59)
{

    Console.WriteLine("geçer");
}
else if (not >= 25 && not <= 44)
{

    Console.WriteLine("kalır");
}
else if (not >= 0 && not <= 24)
{

    Console.WriteLine("sıfır");
}

// koşul ifadesinde else olmayabilir. Bu durumda koşul çalışmaya devam eder.
