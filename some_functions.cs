using System;
using System.Collections;
using System.Collections.Generic;

namespace hangman

{
    internal class some_functions
    {
        static Array check(string answer, string usrGuess)
        {
            List<Int32> positions = new List<Int32>();
            positions.Add(-1);
            for (int i = 0; i < answer.Length; i++)
            {
                if (System.Convert.ToChar(usrGuess) == System.Convert.ToChar(answer[i]))
                {
                    if (positions[0] == -1)
                    {
                        positions[0] = i;
                    }
                    else
                    {
                        positions.Add(i);
                    }
                }
               
            }

            int[] positionsArray = positions.ToArray();
            return positionsArray;
            
        }
        static bool CheckIfDead(int NumOfWrongs){
            if (NumOfWrongs >= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(check("William","i"));
            foreach(var item in check("william","w"))
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}