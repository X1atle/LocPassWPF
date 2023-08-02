using System;
using System.Text;

public class PasswordGenerator
{
    private const string UppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string LowercaseChars = "abcdefghijklmnopqrstuvwxyz";
    private const string NumericChars = "0123456789";
    private const string SpecialChars = "!@#$%^&*()_-+=<>?/[]{}|";

    public static string GeneratePassword(int length = 12)
    {
        if (length < 8)
            throw new ArgumentException("Password length should be at least 8 characters.");

        StringBuilder password = new StringBuilder();
        Random random = new Random();

        // Ensure that the password contains at least one character from each category
        password.Append(GetRandomCharFromCategory(UppercaseChars, random));
        password.Append(GetRandomCharFromCategory(LowercaseChars, random));
        password.Append(GetRandomCharFromCategory(NumericChars, random));
        password.Append(GetRandomCharFromCategory(SpecialChars, random));

        // Fill the remaining characters randomly from all categories
        for (int i = password.Length; i < length; i++)
        {
            string allChars = UppercaseChars + LowercaseChars + NumericChars + SpecialChars;
            password.Append(GetRandomCharFromCategory(allChars, random));
        }

        // Shuffle the characters to increase randomness
        string shuffledPassword = ShuffleString(password.ToString(), random);

        return shuffledPassword;
    }

    private static char GetRandomCharFromCategory(string charCategory, Random random)
    {
        int index = random.Next(0, charCategory.Length);
        return charCategory[index];
    }

    private static string ShuffleString(string input, Random random)
    {
        char[] charArray = input.ToCharArray();
        int n = charArray.Length;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            char value = charArray[k];
            charArray[k] = charArray[n];
            charArray[n] = value;
        }
        return new string(charArray);
    }
}