using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGitHub
{
    internal static class Program
    {
        public static int i = 0;
        static void Main(string[] args)
        {
            i=5;
            //Console.WriteLine("Purpose of this program is to test GitHub repository");
            //CheckMyName("Yajur");
            Console.WriteLine(CodeForFun.NumberToWords(1000000000));
            CodeForFun.AnagramFinder(new string[] {"RAT", "BAT", "TAR"});
        }

        static void CheckMyName(string name)
        {
            var text = "Yajur is awesome. Yejur likes to play basketball. Yujur is a baller Y.";
            var myName = name; //"";
            List<string> hits = new List<string>();
            //string[] hits = new string[5];
            string temp;
            for (var i = 0; i < text.Length; i++)
            {
                //if (text[i] == 'Y', 'y') {
                if (text[i] == 'y' || text[i] == 'Y')
                {
                    Console.WriteLine(i);

                    // Traverse next n characters where n = name.length


                    temp = string.Empty;
                    for (var j = i; j < i + myName.Length; j++)
                    {
                        if (j == text.Length)
                        {
                            break;
                        }                        
                        //newArray.push('Yajur');
                        temp += text[j].ToString();
                        //newArray[0];

                    }
                    Console.WriteLine();
                    hits.Add(temp);
                }
            }

            foreach (var c in hits) //Loop
            {
                Console.WriteLine(c);
            }

            var temp1 = text.Where(c => c.Equals("Y") || c.Equals("y"));
        }
    }
}
