class Program
    {       
        static void Main(string[] args)
        {
            string fileLoc = @"/home/uday/Documents/6th_Sem/Practical(6th_sem)/NCC/lab9/file1.txt";
            if (File.Exists(fileLoc))
            {
                using (TextReader tr = new StreamReader(fileLoc))
                {
                    Console.WriteLine(tr.ReadLine());
                }
            } 
            Console.ReadLine();
        }
    }
