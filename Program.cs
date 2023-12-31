using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Iphone iphone = new("1","15","56185151",256);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("DIO");

    }

}