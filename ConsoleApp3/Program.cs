// Ödül kazanımını belirlemek için bir sayaç yeleştirdim
int ödülsayacı = 0;
// Karşılama ve yarışma bilgilendirme mesajı
Console.WriteLine("Kim Milyoner Olmak İster Yarışmasına Hoşgeldiniz");
Console.WriteLine("Büyük Ödülü Kazanma Kurallarımız ;\n Tarafınıza 3 Adet Soru Sorulacaktır. \n Bu Sorular 2 Şıklı Olacaktır. \n Cevaplarınızı Şık Belirterek Vermeniz Gerekmektedir.\n Sorulan 3 Adet Sorunun 2 Tanesine Doğru Cevap Verilmesi Halinde Büyük Ödülün Sahibi Olacaksınız.\n Başarılar \n İlk Sorumuz Geliyor");

//Soru 1
Console.WriteLine("\n \n Soru: Hangi Gezegen Güneş Sistemi'nde En Büyük Olanıdır? \n A) Jupiter \n B) Mars");
string answer1 = Console.ReadLine().ToLower();


if (answer1 == "a")
{
    Console.WriteLine("Doğru Cevap Tebrikler \n \n Bir Sonraki Soru Geliyor");
    //Cevap doğru verildiği takdirde sayacımızı bir arttırıyoruz
    ödülsayacı++;
}

else
{
    Console.WriteLine("Yanlış Cevap \n \n Bir sonraki soru geliyor");
}

// Soru 2
Console.WriteLine("\n \n İstanbul Hangi Kıtalarda Yer Alır ? \n A) Avrupa Ve Asya \n B) Afrika Ve Asya");

string answer2 = Console.ReadLine().ToLower();

if (answer2 == "a")
{

    Console.WriteLine("Doğru Cevap Tebrikler \n \n Bir Sonraki Soru Geliyor ");
    ödülsayacı++;
}

else
{
    Console.WriteLine("Yanlış Cevap");
}

// 2 soruyada doğru cevap verilmesi durumunda kalan soruyu yarışmacıya göstermeden ödülü takdim ediyoruz.
if (ödülsayacı == 2)
{
    Console.WriteLine("Büyük Ödülü Kazandınız");
}
else if (ödülsayacı == 0)
{
    Console.WriteLine("Malesef Yarışmadan Elendiniz");
}
else
{
    //Soru 3
    Console.WriteLine(" Dna'nın Yapı Taşı Olan Nükleotidler Aşağıdakilerden Hangisini İçermez? \n \n A) Fosfat Grubu \n B) İyot");
}


string answer3 = Console.ReadLine().ToLower();
if (answer3 == "b")
{
    Console.WriteLine("Doğru Cevap \n Büyük Ödülü Kazandınız");
    ödülsayacı++;
}
// Yarışma Genelinde 2 soruya doğru cevap verilmemesi durumunda yarışmacıya veda ediyoruz.
else
{
    Console.WriteLine("Yanlış Cevap \n Malesef Yarışmadan Elendiniz");
}