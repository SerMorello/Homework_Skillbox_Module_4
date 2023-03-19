using System.Diagnostics.Tracing;

internal class Program
{

    private static void Main(string[] args)
    {
        string userText = Console.ReadLine();
        userSplitText(userText);
    }

    //static void splitText(string text)
    //{
    //    string[] arr = text.Split();
    //    printArr(arr);
    //}

    private static void printArr(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    static void userSplitText(string text)
    {
        int count = 0;
        text = text + ' ';

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ' ')
            {
                count++;
            }
        }

        string[] textArr = new string[count];
        string word = "";
        int countArr = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != ' ')
            {
                word = word + text[i];
            }
            else
            {
                textArr[countArr] = word;
                word = "";
                countArr++;
            }
 
        }
        printArr(textArr);
    }
}