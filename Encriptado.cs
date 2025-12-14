Console.WriteLine("Escribe algo w: ");
string input  = Console.ReadLine();


string EncryptThis (string input)
{
    int result= 0;
    string resultString = null;
    string[] array = input.Split(' ');
    
    for (int i = 0;i < array.Length;i++)
    {
        string palabra = array[i];
        for (int j = 0; j < palabra.Length; j++)
        {
            if (j == 0)
            {
                result += Convert.ToInt32(palabra[j]);
                resultString += result;
            }
            else if (j == 1)
            {
                resultString += palabra[palabra.Length - 1];
            }
            else if (j == palabra.Length - 1)
            {

                resultString += palabra[1];
            }
            else
            {
                resultString += palabra[j];
            }
            result = 0;

            

        }
        resultString += " ";
    }
    
    return $"{resultString}";
}

string resultado = EncryptThis (input);
Console.WriteLine(resultado);
