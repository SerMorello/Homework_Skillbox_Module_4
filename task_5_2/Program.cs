internal class Program
{
    private static void Main(string[] args)
    {
        string userText = Console.ReadLine();
        reverseString(userText);
    }

    private static string[] splitText(string? userText)
    {
        string[] text = userText.Split();
        return text;
    }

    private static void reverseString(string text)
    {
        string[] textArr = splitText(text);

        string resultString = "";

        for (int i = textArr.Length-1; i >= 0; i--)
        {
            resultString += textArr[i] + " ";
        }
        Console.WriteLine(resultString);
       
    }
}