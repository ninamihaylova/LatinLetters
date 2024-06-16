class LatinLetters
{
   public static void Main(string[]args)
   {

       char startLetter = char.Parse(Console.ReadLine());
       char endLetter = char.Parse(Console.ReadLine());

        

        for (char letter = startLetter; letter <= endLetter; letter++)
        {
            Console.Write($"{letter  } ");
        }
   }
   }
