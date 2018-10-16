using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstonePigLatin
{
    class Program
    {
        static void Main (string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Enter a line to be translated:");
                string sentence = Console.ReadLine();
                string PigLatin = GetSentenceInPigLatin(sentence);//pulling method
                Console.WriteLine(PigLatin);
                Console.WriteLine("Continue? (y/n)");
                answer = Console.ReadLine();
            } while (answer.Equals("y", StringComparison.InvariantCultureIgnoreCase));
        }

        private static string GetSentenceInPigLatin(string sentence)//method
        {
            string vowel = "aeiou";
            
            {
                StringBuilder sb = new StringBuilder();
                StringBuilder consonant = new StringBuilder();//stringbuilder for consonants
                string lower = sentence.ToLower();//making sure it lower case

                //seeing if the first letter is a vowel
                if (vowel.Contains(lower[0].ToString()))
                {
                    sb.Append(lower);//everything is lower case
                    sb.Append("way");//moving way to the end of the word if a vowel if the first letter
                    return sb.ToString();
                }
                else
                {
                    for (int i = 0; i < lower.Length; i++)
                    {
                        if (!vowel.Contains(lower[i].ToString()))//check if the first letter doesn't have a vowel
                        {
                            consonant.Append(lower[i]);//checking for consonants until you get to a vowel
                        }
                        else
                        {
                            sb.Append(lower.Substring(i));
                            sb.Append(consonant);//move the consonants to the end and add "ay"
                            sb.Append("ay");
                            break;//stop loop
                        }
                    }
                    return sb.ToString();
                }
            }

        }
    }
}
