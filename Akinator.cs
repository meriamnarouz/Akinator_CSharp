/*
 * Description: This project works similar to the Akinator game but on a small scale.
 * 				The computer guesses which one of eight given marvel characters the 
 * 				user is thinking of based on their answers to questions. 				
 */


using System;

public class Akinator
{
    public static void Main(string[] args)
    {
        // male character list: thor, iron man, captain america, dr strange
        // female character list: black widow, wasp, wanda, gomora

        // is your character male?
        // if yes then does he have a goatee?
        // if yes then does he have a cloak? if yes to all then dr strange
        // if yes to the first but no to the rest then captain america
        // if yes to first and second but no to the third then iron man
        // if yes to first but no to the second and yes to the third then thor

        // if character is female (meaning no to q1) then
        // can your character fly?
        // if yes then is a characteristic of your character red or green?
        // if yes to both then wanda
        // if no to both then black widow
        // if yes to flying but no to red or green then wasp
        // if no to flying but yes to last one then gomora

        // initialize variables
        int answer1 = 0;
        int answer2 = 0;
        int answer3 = 0;

        Console.WriteLine("WELCOME TO SORT OF AKINATOR!\nCATEGORY: MARVEL\n\n" +
            "I will guess which of these 8 marvel characters\n" +
            "you are thinking about based on three questions:\n");

        // ask question 1
        Console.Write("\nPlease enter 1 for 'yes' or 0 for 'no' to the following questions:" +
            "\nIs your character male? ");
        answer1 = Convert.ToInt32(Console.ReadLine());

        // based on the first answer, we ask different follow-up questions
        if (answer1 == 1)
        {
            // if the answer to q1 is yes then we ask questions about the men
            Console.Write("\nDoes he have a goatee? ");
            answer2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDoes he have a cloak? ");
            answer3 = Convert.ToInt32(Console.ReadLine());

            if (answer2 == 1 && answer3 == 1)
            {
                // if he has a goatee and a cloak
                Console.WriteLine("\nYour character is Doctor Strange!");
            }
            else if (answer2 == 1 && answer3 == 0)
            {
                // if he has a goatee but no cloak
                Console.WriteLine("\nYour character is Iron Man!");
            }
            else if (answer2 == 0 && answer3 == 1)
            {
                // if he has a cloak but no goatee
                Console.WriteLine("\nYour character is Thor!");
            }
            else
            {
                // if he does not have a cloak or goatee
                Console.WriteLine("\nYour character is Captain America!");
            }
        }
        else
        {
            // else we ask questions about the women
            Console.Write("\nCan she fly? ");
            answer2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIs one of her characteristics the color red or green? ");
            answer3 = Convert.ToInt32(Console.ReadLine());

            if (answer2 == 1 && answer3 == 1)
            {
                // if she can fly and has red or green as a characteristic
                Console.WriteLine("\nYour character is Wanda Maximoff!");
            }
            else if (answer2 == 1 && answer3 == 0)
            {
                // if she can fly but no red or green
                Console.WriteLine("\nYour character is The Wasp aka Hope Pym!");
            }
            else if (answer2 == 0 && answer3 == 1)
            {
                // if she can't fly but yes red or green
                Console.WriteLine("\nYour character is Gomora!");
            }
            else
            {
                // if she can't fly and there is no red or green
                Console.WriteLine("\nYour character is Black Widow!");
            }
        }
    }
}
