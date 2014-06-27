using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }

            Console.WriteLine();

            LetterCount('i', "I love biscuits and gravy. It's the best breakfast ever.");
            Console.WriteLine();
            LetterCount('n', "Never gonna give you up. Never gonna let you down.");
            Console.WriteLine();
            LetterCount('s', "Sally sells seashells down by the seashore. She's from Sussex.");

            Console.WriteLine();

            TextStats("Where did you go to, if I may ask? said Thorin to Gandalf as they rode along. To look ahead, said he. And what brought you back in the nick of time? Looking behind, said he.");



            //keep the console open
            Console.ReadKey();
        }


        //FizzBuzz function
        static void FizzBuzz(int number)
        {
            //if number is divisible by 5 and 3 print number
            if (number % 5 != 0  && number % 3 != 0)
            {
                Console.WriteLine(number);
            }
            //if number is divisible by 5 and 3 print FizzBuzz
            else if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            //if number is divisible by 5 print Fizz
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            //if number is divisible by 3 print Buzz
            else if (number % 3 == 0 )
            {
                Console.WriteLine("Buzz");
            }
        }

        //LetterCount function
        static void LetterCount(char letter, string inString)
        {
            //counting lowercase letters starting at 0
            int lowerCount = 0;
            //counting UPPERCASE letters starting at 0
            int upperCount = 0;
            //creating a loop so we can go through each char
            for (int i = 0; i < inString.Length; i++)
            {
                //char needed is index of inString
                char letterNeeded = inString[i];
                //if letterNeeded is letter
                if (letterNeeded == letter)
                {
                    //add 1 to lowerCount
                    lowerCount++;
                }
                //if char is UPPERCASE
                if (char.IsUpper(letterNeeded))
                {
                    //add 1 to upperCount
                    upperCount++;
                }
            }
            //printing out what we need
            int totalCount = lowerCount + upperCount;
            Console.WriteLine("Input: " + inString);
            Console.WriteLine("Number of lowercase " + letter +"'s found: " + lowerCount);
            Console.WriteLine("Number of UPPERCASE " + letter +"'s found: " + upperCount);
            Console.WriteLine("Total Number of " + letter +"'s found: " + totalCount);
        }

        //TextStats function
        static void TextStats(string input)
        {

            List<string> wordList = input.Split(' ').ToList();
            //number of vowels
            int vowelNum = 0;
            //number of consonants
            int consonantNum = 0;
            //number of special characters
            int specialCharacters = 0;
            //counting my letters
            Console.WriteLine("My sentences have " + input.Count() + " characters");

            //counting my words
            Console.WriteLine("My sentences have " + wordList.Count() + " words");


            //setting a value for "longest"
            string longest = "";
            //setting a valut for "shortest"
            string shortest = "             ";

            //looping over words in wordList
            foreach (string word in wordList)
            {
                //if word is longer than longest length
                if (word.Length > longest.Length)
                {
                    //it's the longest word
                    longest = word;
                }

                //if word is shorter than shortest length
                if (word.Length < shortest.Length)
	            {
                    //it's the shortest word
                    shortest = word;
	            }
            }
      


            //counting my vowels
            //loop over each character of the string
            for (int i = 0; i < input.Length; i++)
            {
                //if letter is a vowel add to vowelNum
                char letter = input[i];
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    vowelNum++;
                }
                //if letter is a consonant add to consonantNum
                if (letter != 'a' && letter != 'e' && letter != 'i' && letter != 'o' && letter != 'u' && letter != ' ' && letter != '.' && letter != '?' && letter != ',')
                {
                    consonantNum++;
                }
                //if letter is a special character add to specialCharacters
                if (letter == ' ' || letter == '.' || letter == '?' || letter == ',')
                {
                    specialCharacters++;
                }
            }
            //printing to the console vowelNum, consonantNum, and specialCharacters
            Console.WriteLine("My sentences have " + vowelNum + " vowels");
            Console.WriteLine("My sentences have " + consonantNum + " consonants");
            Console.WriteLine("My sentences have " + specialCharacters + " special characters");
            Console.WriteLine("My longest word is " + longest);
            Console.WriteLine("My shortest word is " + shortest);
        }

    }
}
