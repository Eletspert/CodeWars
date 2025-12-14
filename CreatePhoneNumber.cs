int[] n = {1,2,3,4,5,6,7,8,9,0 };


string CreatePhoneNumber (int[] numbers)
{
    string result = null;
    for (int i = 0;i<numbers.Length;i++)
    {
        if (i == 0 )
        {
            result += "(";
        }
        else if ( i == 3)
        {
            result += ") ";
        }
        else if (i == 6)
        {
            result += "-";
        }

        result += numbers[i];
    }

    return result;
}

string resull = CreatePhoneNumber(n);
Console.WriteLine(resull);
