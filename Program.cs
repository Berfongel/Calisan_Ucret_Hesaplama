// See https://aka.ms/new-console-template for more information

int calisma_saati, saatlik_ücret,ücret_hesaplama;

Console.WriteLine("Çalışma saatini giriniz : ");
calisma_saati = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Saatlik ücretinizi giriniz : ");
saatlik_ücret = Convert.ToInt32(Console.ReadLine());

if (calisma_saati < 40)
{
    ücret_hesaplama = calisma_saati * saatlik_ücret;
    Console.WriteLine("Ödenecek tutar : " + ücret_hesaplama);

}
else 
{
    ücret_hesaplama = calisma_saati * saatlik_ücret*2;
    Console.WriteLine("Ödenecek tutar : " +ücret_hesaplama);


}