using Novacode;
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{


    class Prog2
    {
        public Prog2() { }

        public void method1()
        {
            Console.WriteLine("method 1...");
            string fileName = @"D:\Project2021\doc.docx";
            DocX wordDocument = DocX.Load(fileName);

        }

    }

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


        public string id { get; set; }
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

            //Prog2 p2 = new Prog2();
            //p2.method1();

            //return;
            string pathName = @"D:\Project2021\json\";
            string fileName = @"D:\Project2021\doc.txt";
            M1(fileName, pathName);

        }



        static void M1(string fileName, string pathName)
        {

            string pattern = @"[\d|\.]\s[S|R|Q|C|M|P]\d{3}";//@"^\d{5}$"
            // Create a Regex  
            Regex rg = new Regex(pattern);

            Console.OutputEncoding = Encoding.UTF8;
            int counter = 0;
            string line;
            //   string fileName = @"D:\Project2021\doc.txt";
            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(fileName);


            int int作业目的 = 0;
            string str作业目的 = "";

            Ten ten = new Ten();

            while ((line = file.ReadLine()) != null)
            {

                if (line.Contains("Operation purpose"))
                {

                    // to dump last obj


                    //Console.WriteLine("1--" + ten.item1);
                    //Console.WriteLine("2--" + ten.item2);
                    //Console.WriteLine("3--" + ten.item3);
                    //Console.WriteLine("4--" + ten.item4);



                    //ten = new Ten();
                    ten.intItem1 = counter;


                    //int作业目的 = counter;
                    //str作业目的 = "";
                }


                if (line.Contains("Description"))
                {
                    ten.intItem2 = counter;
                }

                if (line.Contains("Roles"))
                {
                    ten.intItem3 = counter;
                }
                if (line.Contains("Precondition"))
                {
                    ten.intItem4 = counter;
                }
                if (line.Contains("Input"))
                {
                    ten.intItem5 = counter;
                }
                if (line.Contains("Output"))
                {
                    ten.intItem6 = counter;
                }
                if (line.Contains("Abnormal handle"))
                {
                    ten.intItem7 = counter;
                }
                if (line.Contains("Steps"))
                {
                    ten.intItem8 = counter;
                }
                if (line.Contains("Post condition"))
                {
                    ten.intItem9 = counter;
                }
                if (line.Contains("Remark"))
                {
                    ten.intItem10 = counter;
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
                    ten.item1 += line;
                    //      Console.WriteLine(ten.item1);
                }

                if (counter == 1 + ten.intItem2)
                {
                    ten.item2 = line + "<br>";
                }
                if (counter == 2 + ten.intItem2)
                {
                    ten.item2 += line;
                    //    Console.WriteLine(ten.item2);
                }

                if (counter == 1 + ten.intItem3)
                {
                    ten.item3 = line + "<br>";
                }
                if (counter == 2 + ten.intItem3)
                {
                    ten.item3 += line;
                    //    Console.WriteLine("3--" + ten.item3);
                    //Console.WriteLine("what is intItem4 " + ten.intItem4);

                }

                if (counter == 1 + ten.intItem4 || counter == 2 + ten.intItem4)
                {
                    ten.item4 += line + "<br>";

                }

                if (counter > ten.intItem5 && ten.intItem5 > 0 && ten.intItem6 == 0)
                {
                    ten.item5 += line + "<br>";

                }
                if (counter > ten.intItem6 && ten.intItem6 > 0 && ten.intItem7 == 0)
                {
                    ten.item6 += line + "<br>";

                }
                if (counter > ten.intItem7 && ten.intItem7 > 0 && ten.intItem8 == 0)
                {
                    ten.item7 += line + "<br>";

                }
                if (counter > ten.intItem8 && ten.intItem8 > 0 && ten.intItem9 == 0)
                {
                    ten.item8 += line + "<br>";

                }
                if (counter > ten.intItem9 && ten.intItem9 > 0 && ten.intItem10 == 0)
                {
                    ten.item9 += line + "<br>";

                }

                if (counter == 1 + ten.intItem10 || counter == 2 + ten.intItem10)
                {
                    ten.item10 += line + "<br>";

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



                    //Console.WriteLine("1--" + ten.item1);
                    //Console.WriteLine("2--" + ten.item2);
                    //Console.WriteLine("3--" + ten.item3);
                    //Console.WriteLine("4--" + ten.item4);
                    //Console.WriteLine("5--" + ten.item5);
                    //Console.WriteLine("6--" + ten.item6);
                    //Console.WriteLine("7--" + ten.item7);
                    //Console.WriteLine("8--" + ten.item8);
                    //Console.WriteLine("9--" + ten.item9);
                    //Console.WriteLine("10--" + ten.item10);

                    Console.WriteLine("\n");

                    if (ten.intItem1 > 0)
                    {

                        var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(ten);
                        Console.WriteLine(id);
                        Console.WriteLine(jsonString);
                        System.IO.File.WriteAllText(pathName+ten.id+".json", jsonString);
                    }

                    ten = new Ten();
                    ten.id = id;

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
