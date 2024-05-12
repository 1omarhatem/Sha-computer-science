using System.IO;


internal class Program

{
    private static void Main(string[] args)
    {
        //To Creat file

        //string file_name = "Case one.txt"; //Give var to name file

        //FileStream fs = new FileStream(file_name, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        //fs.Close();

        //if (File.Exists(file_name))
        //{

        //    Console.WriteLine("Done");
        //}
        //else { 
        //    Console.WriteLine("error");
        //      }

        //-------------------------------------------------------------------------

        //To read file 

        //string File_name = "Case one.txt";      //give the name of file which you want read
        //string line;                            //this for reading

        //StreamReader MY = new StreamReader(File_name); //this funcation for read

        //while (true) { 
        //line = MY.ReadLine(); //to read line
        //    if (line == null) break;
        //    Console.WriteLine(line);
        //}

        //--------------------------------------------------------------------------

        {
            string line;
            string filename1, filename2;
            Console.WriteLine("Enter the name of file1: ");
            filename1 = Console.ReadLine();
            Console.WriteLine("Enter the name of file2: ");
            filename2 = Console.ReadLine();

            StreamReader file1 = new StreamReader(filename1);
            StreamWriter file2 = new StreamWriter(filename2);

            while ((line = file1.ReadLine()) != null)
            {
                file2.WriteLine(line);
            }
            file1.Close();
            file2.Flush();
            file2.Close();
            Console.ReadLine();





        }
    }
}