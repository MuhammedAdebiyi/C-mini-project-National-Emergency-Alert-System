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
        Console.WriteLine((int)Difficulty.Easy);
        Console.WriteLine((int)Difficulty.Medium); 
        Console.WriteLine((int)Difficulty.Hard);  

    }
}