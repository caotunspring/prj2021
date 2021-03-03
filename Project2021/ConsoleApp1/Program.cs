using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{

    class Ten
    {
        public int intItem1 { get; set; }
        public int intItem2 { get; set; }
        public int intItem3 { get; set; }
        public int intItem4 { get; set; }
        public int intItem5 { get; set; }
        public int intItem6 { get; set; }
        public int intItem7 { get; set; }
        public int intItem8 { get; set; }
        public int intItem9 { get; set; }
        public int intItem10 { get; set; }


        public string item1 { get; set; }
        public string item2 { get; set; }
        public string item3 { get; set; }
        public string item4 { get; set; }
        public string item5 { get; set; }
        public string item6 { get; set; }
        public string item7 { get; set; }
        public string item8 { get; set; }
        public string item9 { get; set; }
        public string item10 { get; set; }

    }
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


            int int作业目的 = 0;
            string str作业目的 = "";

            Ten ten= new Ten();

            while ((line = file.ReadLine()) != null)
            {

                if (line.Contains("Operation purpose")){

                    ten = new Ten();
                    ten.intItem1 = counter;
                    ten.item1 = "";


                    //int作业目的 = counter;
                    //str作业目的 = "";
                }

                if (counter == 1 + ten.intItem1)
                {
                    //str作业目的 = line + "<br>";
                    ten.item1 = line + "<br>";

                    //    Console.WriteLine(str作业目的);
                }
                if (counter == 2 + ten.intItem1)
                {
                    //str作业目的 += line ;
                    ten.item1 += line ;
                    Console.WriteLine(ten.item1);
                }



                //   System.Console.WriteLine(line);
                MatchCollection matchedAuthors = rg.Matches(line);
                //for (int count = 0; count < matchedAuthors.Count; count++)
                //    Console.WriteLine(matchedAuthors[count].Value);
                if (matchedAuthors.Count > 0)
                {
                    line = line.Trim();
                    string x = line.Split(" ")[0];
                    string id = line.Split(" ")[1];

                    //Console.WriteLine(x);
                    string strShow = "<li>" + line.Substring(x.Length).Trim() + "</li>";
                    Console.WriteLine(strShow);//8.9. Q090 Location Usage Status Query库位使用状态查询
                    Console.WriteLine(id);//8.9. Q090 Location Usage Status Query库位使用状态查询



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
