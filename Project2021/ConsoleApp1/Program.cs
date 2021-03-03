using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[\d|\.]\s[S|R|Q|C|M|P]\d{3}";//@"^\d{5}$"
            // Create a Regex  
            Regex rg = new Regex(pattern);

            Console.OutputEncoding = Encoding.UTF8;
            int counter = 0;
            string line;
            string fileName = @"D:\Project2021\doc.txt";
            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(fileName);
            while ((line = file.ReadLine()) != null)
            {
             //   System.Console.WriteLine(line);
                MatchCollection matchedAuthors = rg.Matches(line);
                //for (int count = 0; count < matchedAuthors.Count; count++)
                //    Console.WriteLine(matchedAuthors[count].Value);
                if (matchedAuthors.Count > 0)
                {
                    line = line.Trim();
                    string x = line.Split(" ")[0];

                    //Console.WriteLine(x);
                    string strShow = "<li>" + line.Substring(x.Length).Trim() + "</li>";
                    Console.WriteLine(strShow);//8.9. Q090 Location Usage Status Query库位使用状态查询

                }
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();




            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello World!");
            return;
            //try
            //{
            //    // Open the text file using a stream reader.
            //    using (var sr = new StreamReader(@"D:\Project2021\doc.txt"))
            //    {
            //        // Read the stream as a string, and write the string to the console.
            //     //   Console.WriteLine(sr.ReadToEnd());
            //        int k = 0;
            //        foreach (var line in sr.ReadToEnd())
                        
            //        {
            //            k++;
            //            if (k > 10) break;
            //            Console.WriteLine(line);
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("The file could not be read:");
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}
