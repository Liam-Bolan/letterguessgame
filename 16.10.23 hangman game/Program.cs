using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _16._10._23_hangman_game
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.Write("Player 1 please enter a 4 letter word: ");
            
            string fourLW = Console.ReadLine();
            
            Console.Write("Player 2 please try and guess a letter in the word: ");
            
            char letter = Console.ReadLine()[0];

            if (letter == fourLW[0])
            {
                Console.WriteLine("That is a correct letter");
                letter = Console.ReadLine()[0];
            }
            if (letter == fourLW[1])
            {
                Console.WriteLine("That is a correct letter");
                letter = Console.ReadLine()[1];
            }
            if (letter == fourLW[2])
            {
                Console.WriteLine("That is a correct letter");
                letter = Console.ReadLine()[2];
            }
            if (letter == fourLW[3])
            {
                Console.WriteLine("That is a correct letter");
                letter = Console.ReadLine()[3];
            }
            




        }  

}
}