using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public object Test(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            var reversed =new string(charArray);
            if (reversed == word)
            {
                return true;
            } 
            return false;
        }
    }
}
