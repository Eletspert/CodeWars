Console.WriteLine("Escribe una palabra: ");
string w = Console.ReadLine();

string ToWeirdCase(string w)
{
    if (w == "")
    {
        return string.Empty;
    }
    string[] strings = w.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string result = null;
    string word = null;
    for (int i = 0; i < strings.Length; i++)
    {
        
        word = strings[i];
        

        for (int j = 0; j < word.Length; j++)
        {   
            if (j == 0 && i > 0)
            {
                result += " ";
            }
            if (j == 0 || j % 2 == 0)
            {
                result += char.ToUpper(word[j]);
            }
            else if (j % 2 == 1)
            {
                result += char.ToLower(word[j]);
            }
        }
        
        word = null;
    }

    return result;
}


string result = ToWeirdCase(w);
Console.WriteLine(result);
