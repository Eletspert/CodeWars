Console.WriteLine("Escribe un numero: ");
int p = Convert.ToInt32(Console.ReadLine());


bool Narcissistic(int value)
{
    string valor =  Convert.ToString(value);
    int toint = 0;
    double suma = 0;
    
    for (int i = 0; i < valor.Length;i++)
    {
        toint = valor[i]-'0';
        suma +=  Math.Pow(toint,valor.Length);
    }

    if (suma == value)
    {
        return true;
        
    }
    return false;
}

bool respuesta = Narcissistic(p);

Console.WriteLine(respuesta);
