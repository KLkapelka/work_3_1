using System;
using System.IO;

class work_3_1
{
    static void Main()
    {

        string[] lines = File.ReadAllLines("input.txt"); 
        int[] conditions = lines[0].Split(' ').Select(int.Parse).ToArray(); 
        int n = int.Parse(lines[1]); 
        string[] tickets = lines.Skip(2).ToArray(); 

        using (StreamWriter writer = new StreamWriter("output.txt"))
        {
            foreach (var i in tickets) 
            {
                int[] ticketNumbers = i.Split(' ').Select(int.Parse).ToArray(); 
                int count = ticketNumbers.Count(num => conditions.Contains(num));

                if (count >= 3)
                    writer.WriteLine("Lucky");
                else
                    writer.WriteLine("Unlucky"); 
            }
        }
    }
}