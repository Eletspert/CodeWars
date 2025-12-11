string numbers = "1 2 3 4 5 6 8 9 10";


string HighAndLow(string numbers)
{
    string[] numeros = numbers.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    int menor = Convert.ToInt32(numeros[0]);
    int mayor = Convert.ToInt32(numeros[0]);
    foreach (string n in numeros)
    {
        int a = Convert.ToInt32(n);
        if (menor > a)
        {
           menor = a;
        }
        else if (mayor < a)
        {
            mayor = a;
        }
    }
    return $"{mayor} {menor}";
}

string eu = HighAndLow(numbers);

Console.WriteLine(eu);
