using System;

namespace Hamming
{
    public class Hamming
    {
        public static int Distance(string original, string current)
        {
            int hammingDistance = 0;

            

            if(original==null)
            {
                throw (new ArgumentNullException("original")); 
            }

            else if(current==null){
                throw (new ArgumentNullException("current"));
            }

            int length1=original.Length;
            int length2=current.Length;
            
            if(length1 != length2)
            {
                 throw new ArgumentException("Hamming Distance can only be calculated over strings of equal length");
            }

            else{

            for (int i = 0; i <length1; i++)
            {
                if(original[i]!=current[i])
                {
                    hammingDistance++;
                }
            }
            }
            
            return hammingDistance;
        
        }
    }
}
