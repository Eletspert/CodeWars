Console.WriteLine("Escribe una oracion: ");
string oracion = Console.ReadLine();

void palabras(string pOracion )
{
    string [] pPalabras = pOracion.Split(' ');
    

   for (int i = 0; i < pPalabras.Length; i++)
    {
        if (pPalabras[i].Length >= 5)
        {
            string GuardarPalabra = pPalabras[i];
            for (int j = pPalabras[i].Length; j > 0; j--)
            {

                char palabraReversa = GuardarPalabra[j-1];
                Console.Write(palabraReversa);
            }
            Console.Write(" ");
        }
        else 
            {
            Console.Write($"{pPalabras[i]} ");
            }
    }
}

palabras(oracion);
