// See https://aka.ms/new-console-template for more information
Console.WriteLine(CountWord("    ass 225  awe awuuee"));


 int CountWord(string text)
{
    if (string.IsNullOrEmpty(text)) return 0;
    else
    {
        int wordCount = 0;
        bool currentCharIsAWord = false;
        for (int index = 0; index < text.Length; index++)
        {
            if (IsCharacter(text[index]))
            {
                currentCharIsAWord = true;
                if (index < text.Length - 1) continue;
            }

            if (currentCharIsAWord)
            {
                wordCount++;
                currentCharIsAWord = false;
            }
        }

        return wordCount;
    }
}

bool IsCharacter(char character)
{
    if (character >= 'a' && character <= 'z')
    {
        return true;
    }
    if (character >= 'A' && character <= 'Z')
    {
        return true;
    }
    return false;
}