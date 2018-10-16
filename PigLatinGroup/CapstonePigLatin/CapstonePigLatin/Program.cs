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
                string PigLatin = GetSentenceInPigLatin(sentence);
                Console.WriteLine(PigLatin);
                Console.WriteLine("Continue? (y/n)");
                answer = Console.ReadLine();
            } while (answer.Equals("y", StringComparison.InvariantCultureIgnoreCase));
        }

        private static string GetSentenceInPigLatin(string sentence)
        {
            string vowel = "aeiou";
            
            {
                StringBuilder sb = new StringBuilder();
                StringBuilder consonant = new StringBuilder();
                string lower = sentence.ToLower();

                //seeing if the first letter is a vowel
                if (vowel.Contains(lower[0].ToString()))
                {
                    sb.Append(lower);
                    sb.Append("way");
                    return sb.ToString();
                }
                else
                {
                    for (int i = 0; i < lower.Length; i++)
                    {
                        if (!vowel.Contains(lower[i].ToString()))
                        {
                            consonant.Append(lower[i]);
                        }
                        else
                        {
                            sb.Append(lower.Substring(i));
                            sb.Append(consonant);
                            sb.Append("ay");
                            break;
                        }
                    }
                    return sb.ToString();
                }
            }

        }
    }
}
