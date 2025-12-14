
Console.WriteLine("Eribe tu tarjeta de credito");
string tarjeta = Console.ReadLine();

string Censura (string ptarjeta)
{
    string letrasCensuradas = "";
    string hashtags = "";
    if (ptarjeta.Length <= 4)
    {
        return ptarjeta;
    }
    else
    {
        for (int i = 0; i < ptarjeta.Length - 4; i++)
        {
            hashtags += "#";

        }
        for (int i = ptarjeta.Length - 4; i < ptarjeta.Length; i++)
        {
            letrasCensuradas += ptarjeta[i];
        }
        return hashtags + letrasCensuradas;
    }
        
}

string si = Censura (tarjeta);
Console.WriteLine(si);
