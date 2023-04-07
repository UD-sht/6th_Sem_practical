class Program
    {       
        static void Main(string[] args)
        {
            string fileLoc = @"file1.txt";
            FileStream fs;
            if (!File.Exists(fileLoc))
            {
                using (fs = File.Create(fileLoc))
                {

                }
            }
            Console.WriteLine("File Created");
            Console.ReadLine();
        }
    }
