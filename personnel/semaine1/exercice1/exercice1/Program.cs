namespace exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var values = OpenCSV("C:\\Users\\po01imj\\test\\PlaceDuMarcheCSV.csv");
            int peachSellers = 0;
            int temp = 0;
            int[] watermelonSellers = new int[values[0].Count];
            for (int i = 0; i < values[2].Count; i++)
            {
                string fruit = values[2][i];
                if (fruit == "Pêches")
                {
                    peachSellers++;
                }
                else if (fruit == "Pastèques")
                {
                    watermelonSellers[i] = int.Parse(values[3][i]);
                }
            }
            Console.WriteLine($"there are {peachSellers} peach sellers");
            Console.WriteLine($"there are {watermelonSellers.Max()} watermelon sellers");
        }
        static List<List<string>> OpenCSV(string link) 
        {
            using (var reader = new StreamReader(link))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                List<string> listC = new List<string>();
                List<string> listD = new List<string>();
                List<string> listE = new List<string>();
                List<string> listF = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listA.Add(values[0]);
                    listB.Add(values[1]);
                    listC.Add(values[2]);
                    listD.Add(values[3]);
                    listD.Add(values[4]);
                    listD.Add(values[5]);
                }

                return new List<List<string>> { listA, listB, listC, listD, listE, listF};
            }
        }
    }
}
