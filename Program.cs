using System.Net.Security;
using System.Reflection;

// enum AlertLevel
// {
//     CodeRed,
//     CodeBlue,
//     CodeYellow
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         AlertLevel currentAlert = AlertLevel.CodeYellow;

//         Console.WriteLine($"🚨 EMERGENCY ALERT:  {currentAlert} ({(int)currentAlert})");

//         string alertMessage = "";
//         string responseInstruction = "";

//         switch (currentAlert)
//         {
//             case AlertLevel.CodeRed:
//                 alertMessage = "🔥 Fire or explosion risk!";
//                 responseInstruction = "Evacuate immediately  and contact emergency services";
//                 break;

//             case AlertLevel.CodeBlue:
//                 alertMessage = "🩺 Medical or severe weather emergency!";
//                 responseInstruction = "Evacuate immediately  and contact emergency services";
//                 break;

//             case AlertLevel.CodeYellow:
//                 alertMessage = "⚠️ General caution or system alert!";
//                 responseInstruction = "Evacuate immediately  and contact emergency services";
//                 break;

//         }

//         Console.WriteLine(alertMessage);

//         string[] cities = { "Lagos", "Abuja", "Kano", "Port Harcourt" };

//         Console.WriteLine("\n Affected Cities and Insructions: ");
//         foreach (var city in cities)
//         {
//             Console.WriteLine($" -{city}: {responseInstruction}");
//         }

//         Console.WriteLine("\n Stay calm Follow Official guidiance.");
//     }
// }

//  Game Difficulty Selector

enum Difficulty
{
    Easy,
    Medium,
    Hard
}
       class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Game Difficulty Levels:");

        foreach (Difficulty level in Enum.GetValues(typeof(Difficulty)))
        {
            string message = "";

            switch (level)
            {

                case Difficulty.Easy:
                    message = "For Beginners. No Stress";
                    break;
                case Difficulty.Medium:
                    message = "Enemies get stronger";
                    break;
                case Difficulty.Hard:
                    message = "Only legends survive";
                    break;
            }

            Console.WriteLine($" -{level} ({(int)level}): {message}");
        }

        Console.WriteLine("\n Available Characters: ");
        string[] characters = { "Warriors", "Mage", "Archer" };

        foreach (var character in characters)
        {
            string performance = "";


            switch (character)
            {

                case "Warrior":
                    performance = "Survives on all levels";
                    break;
                case "Mage":
                    performance = "Struggles on Hard";
                    break;
                case "Archer":
                    performance = "Great on Easy and Medium";
                    break;
            }

            Console.WriteLine($" -{character} -> {performance}");
        }

    }
}