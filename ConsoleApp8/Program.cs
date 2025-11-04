using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        public static void RunMission1()
        {
            Console.WriteLine("RunMission1() is not implemented yet.");

        }
        public static void RunMission2()
        {
            Dictionary<string, int> highScores = new Dictionary<string, int>();
            highScores.Add("NinjaMan", 9500);
            highScores.Add("CodeQueen", 12000);
            highScores.Add("PixelPal", 7200);
            highScores["NinjaMan"] = 9900;
            if (highScores.ContainsKey("Shadow"))
                Console.WriteLine("Grade: " + highScores["Shadow"]);
            else
                Console.WriteLine("Player 'Shadow' has no score yet.");
            foreach (var pair in highScores)
            {
                Console.WriteLine($" {pair.Key} : {pair.Value}");
            }

            highScores.Remove("PixelPal");

        }

        public static void RunMission3()
        {
            List<string> comments = new List<string>();

            Console.WriteLine("RunMission3() is not implemented yet.");
        }
        public static void RunChallengeMission()
        {
            List<string> comments = new List<string>() { "What a great article!", "Buy Bitcoin now!!!", "This really helped me, thanks", "Amazing offer just for you", "How do I sign up?" };
            int i = 0;
            while (true)
            {
                if (comments[i].Contains("offer") || comments[i].Contains("Bitcoin"))
                    comments.RemoveAt(i);
                else
                    i++;
                if (i >= comments.Count)
                    break;

            }
            Console.WriteLine("Filtered Comments:");
            foreach (var comment in comments)
            {
                Console.WriteLine(comment);
            }



        }
        static void Main(string[] args)
        {
            Console.WriteLine("--- Mission 1: SocialApp (User Class Test) ---");
            RunMission1();

            Console.WriteLine("\n--- Mission 2: High Scores ---");
            RunMission2();

            Console.WriteLine("\n--- Mission 3: Console Piano ---");
            RunMission3();

            Console.WriteLine("\n--- Challenge Mission: Spam Filter ---");
            RunChallengeMission();
        }
    }
}
