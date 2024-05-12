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


        //string line;
        //string filename1, filename2;
        //Console.WriteLine("Enter the name of file1: ");
        //filename1 = Console.ReadLine();
        //Console.WriteLine("Enter the name of file2: ");
        //filename2 = Console.ReadLine();

        //StreamReader file1 = new StreamReader(filename1);
        //StreamWriter file2 = new StreamWriter(filename2);

        //while ((line = file1.ReadLine()) != null)
        //{
        //    file2.WriteLine(line);
        //}
        //file1.Close();
        //file2.Flush();
        //file2.Close();
        //Console.ReadLine();

        //---------------------------------------------------------------------------

        ////To merage file
        //string fileone = "Case one.txt";
        //string filetwo = "Case two.txt";
        //string file = "Case Merge.txt";

        //if (File.Exists(fileone) && File.Exists(filetwo))
        //{
        //    //Acsses file
        //    FileStream ST1 = new FileStream(fileone, FileMode.Open, FileAccess.Read);
        //    FileStream ST2 = new FileStream(filetwo, FileMode.Open, FileAccess.Read);
        //    //Create file
        //    FileStream ST = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
        //    //reading file
        //    StreamReader S1 = new StreamReader(ST1);
        //    StreamReader S2 = new StreamReader(ST2);

        //    //Write
        //    StreamWriter S3 = new StreamWriter(ST);

        //    string line;

        //    while ((line = S1.ReadLine()) != null)
        //    {
        //        S3.WriteLine(line);

        //    }

        //    while ((line = S2.ReadLine()) != null)
        //    {
        //        S3.WriteLine(line);

        //    }
        //    S1.Close();
        //    S2.Close();
        //    S3.Close();



        //    Console.WriteLine("done");

        //}
        //else
        //{
        //    Console.WriteLine("Erroe");
        //}


    }
}




