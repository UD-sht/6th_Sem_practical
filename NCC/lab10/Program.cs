class Program
    {       
        static void Main(string[] args)
        {
            string fileLoc = @"/home/uday/Documents/6th_Sem/Practical(6th_sem)/NCC/lab9/file1.txt";
            if (File.Exists(fileLoc))
            {
                using (StreamWriter sw = new StreamWriter(fileLoc))
                {
                    sw.Write("Hello World..............");
                }
            }
            Console.WriteLine("Write is Success");           
            Console.ReadLine();
        }
    }
