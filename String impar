
Console.WriteLine("Escribe algo w:");
string str = Console.ReadLine();

string solution (string str)
{
    string result = null;
    for (int i = 0; i < str.Length; i += 2)
    {


        if (i + 1 < str.Length)
        {
            result += $"{str[i]}{str[i + 1]}";
        }
        else
        {
            result += $"{str[i]}_";
            break;
        }
        if (i+2 < str.Length )
        {
            result += ", ";
        }
        
    }


    return result;
}


string ss = solution (str);
Console.WriteLine(ss);
