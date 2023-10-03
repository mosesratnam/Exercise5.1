namespace Exercise5._1;

class Program
{
    static void Main(string[] args)
    {
        #nullable disable

        string sentence = "Current sentence: ";
        string userWord;
        bool userInput = true;

        Console.WriteLine("Welcome to Exercise 5.1 - Pre Learning!");
        Console.WriteLine("=======================================");
        Console.WriteLine();

        while (userInput)
        {
            Console.Write("Enter a word: ");
            userWord = Console.ReadLine();
            if (userWord != ""){
                sentence += String.Format(" {0}", userWord);
                Console.WriteLine(sentence);
            } else {
                userInput = false;
            }
        }
    }
}
