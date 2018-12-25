using System;
using System.Text;

public static class ReverseString
{
    public static string Reverse(string input)
    {        
        if (String.IsNullOrEmpty(input))
        {
            return String.Empty;
        }

        var charactersInput = input.ToCharArray();

        for (var i = 0; i < charactersInput.Length / 2; i++)
        {
            var temp = input[i];
            charactersInput[i] = input[input.Length - i - 1];
            charactersInput[input.Length - i - 1] = temp;
        }

        return new String(charactersInput);
    }
}