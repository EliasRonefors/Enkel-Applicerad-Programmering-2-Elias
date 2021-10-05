using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EnkelAppliceradProgrammering2
{
    [TestClass]
    public class Part1Tests
    {
        const float ANSWER11 = -53;
        const float ANSWER12 = 4288;
        const float ANSWER13 = 53;
        const float ANSWER14 = 19.1f;
        const float ANSWER15 = 5.03f;


        public static void Run()
        {
            Del1();
            Part2Tests.Del2();
            Part3Tests.Del3();
        }

        private static void Del1()
        {
            Tasks.Part1 part = new Tasks.Part1();
            Console.WriteLine("DEL 1");

            Console.Write("Uppgift 1 Körs... ");
            part.Task1();

            ConsoleHelperFunctions.PrintResult(1, part.ANSWER);
            ConsoleHelperFunctions.PrintResult(ANSWER11.Equals(part.ANSWER));

            Console.Write("\nUppgift 2 Körs... ");
            part.Task2();

            ConsoleHelperFunctions.PrintResult(2, part.ANSWER);
            ConsoleHelperFunctions.PrintResult(ANSWER12.Equals(part.ANSWER));

            Console.Write("\nUppgift 3 Körs... ");
            part.Task3();

            ConsoleHelperFunctions.PrintResult(3, part.ANSWER);
            ConsoleHelperFunctions.PrintResult(ANSWER13.Equals(part.ANSWER));

            Console.Write("\nUppgift 4 Körs... ");
            part.Task4();

            ConsoleHelperFunctions.PrintResult(4, part.ANSWER);
            ConsoleHelperFunctions.PrintResult(ANSWER14.Equals(part.ANSWER));

            Console.Write("\nUppgift 5 Körs... ");
            part.Task5();

            ConsoleHelperFunctions.PrintResult(5, part.ANSWER);
            ConsoleHelperFunctions.PrintResult(ANSWER15.Equals(part.ANSWER));

            Console.Write("\nDEL 1 FÄRDIG\n");
        }


        

        [TestMethod]
        public void Uppgift1_1()
        {
            Tasks.Part1 part = new Tasks.Part1();
            part.Task1();
            Assert.AreEqual(ANSWER11, part.ANSWER);
        }

        [TestMethod]
        public void Uppgift1_2()
        {
            Tasks.Part1 part = new Tasks.Part1();
            part.Task2();
            Assert.AreEqual(ANSWER12, part.ANSWER);
        }

        [TestMethod]
        public void Uppgift1_3()
        {
            Tasks.Part1 part = new Tasks.Part1();
            part.Task3();
            Assert.AreEqual(ANSWER13, part.ANSWER);
        }

        [TestMethod]
        public void Uppgift1_4()
        {
            Tasks.Part1 part = new Tasks.Part1();
            part.Task4();
            Assert.AreEqual(ANSWER14, part.ANSWER);
        }

        [TestMethod]
        public void Uppgift1_5()
        {
            Tasks.Part1 part = new Tasks.Part1();
            part.Task5();
            Assert.AreEqual(ANSWER15, part.ANSWER);
        }
    }

    public static class ConsoleHelperFunctions
    {
        public static int CONSOLE_X = 0;
        public static int CONSOLE_Y = 23;

        public static void PrintResult(object task, object result)
        {
            int lastX = Console.CursorLeft, lastY = Console.CursorTop;

            Console.SetCursorPosition(CONSOLE_X, CONSOLE_Y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Uppgift {task}: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(result);

            CONSOLE_Y = Console.CursorTop + 1;

            Console.SetCursorPosition(lastX, lastY);
        }


        public static void PrintEstimate(bool result)
        {
            string resultat = GetEstimateResult(result);
            SetConsoleColor(result);
            Console.Write(resultat);
            ResetConsoleColor();
        }

        private static string GetEstimateResult(bool result)
        {
            if (result == true)
                return "Kanske implementerad.";
            return "INTE IMPLEMENTERAD";

        }

        public static void PrintResult(bool result)
        {
            string resultat = GetResult(result);
            SetConsoleColor(result);
            Console.Write(resultat);
            ResetConsoleColor();
        }

        private static string GetResult(bool result)
        {
            if (result == true)
                return "LYCKATS";
            return "MISSLYCKATS";
        }

        private static void SetConsoleColor(bool state)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (state)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }

        private static void ResetConsoleColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    [TestClass]
    public class Part2Tests
    {
        const string ANSWER21 = "glass hund";
        const string ANSWER22 = "glass 57";
        const string ANSWER23 = "You currently have 4 burgers left";
        const string ANSWER24 = "Kim and Alex talks on the phone 42,6 hours yearly";


        public static void Del2()
        {
            Tasks.Part2 part = new Tasks.Part2();

            Console.WriteLine("\nDel 2");

            Console.Write("Uppgift 1 Körs... ");
            part.Task1();

            ConsoleHelperFunctions.PrintResult(1, part.ANSWER);
            ConsoleHelperFunctions.PrintResult(ANSWER21.Equals(part.ANSWER));

            Console.Write("\nUppgift 2 Körs... ");
            part.Task2();

            ConsoleHelperFunctions.PrintResult(2, part.ANSWER);
            ConsoleHelperFunctions.PrintResult(ANSWER22.Equals(part.ANSWER));

            Console.Write("\nUppgift 3 Körs... ");
            part.Task3();

            ConsoleHelperFunctions.PrintResult(3, part.ANSWER);
            ConsoleHelperFunctions.PrintResult(ANSWER23.Equals(part.ANSWER));

            Console.Write("\nUppgift 4 Körs... ");
            part.Task4();

            ConsoleHelperFunctions.PrintResult(4, part.ANSWER);
            ConsoleHelperFunctions.PrintResult(ANSWER24.Equals(part.ANSWER));

            Console.WriteLine("\nDEL 2 FÄRDIG\n");
        }


        [TestMethod]
        public void Uppgift2_1()
        {
            Tasks.Part2 part2 = new Tasks.Part2();
            part2.Task1();
            Assert.AreEqual(ANSWER21, part2.ANSWER);
        }

        [TestMethod]
        public void Uppgift2_2()
        {
            Tasks.Part2 part2 = new Tasks.Part2();
            part2.Task2();
            Assert.AreEqual(ANSWER22, part2.ANSWER);
        }

        [TestMethod]
        public void Uppgift2_3()
        {
            Tasks.Part2 part2 = new Tasks.Part2();
            part2.Task3();
            Assert.AreEqual(ANSWER23, part2.ANSWER);
        }

        [TestMethod]
        public void Uppgift2_4()
        {
            Tasks.Part2 part2 = new Tasks.Part2();
            part2.Task4();
            Assert.AreEqual(ANSWER24, part2.ANSWER);
        }
    }

    public class Part3Tests
    {
        const string DEFAULT_TEXT = "INSERT YOUR ANSWER HERE";

        public static void Del3()
        {
            Tasks.Part3 part = new Tasks.Part3();
            Console.WriteLine("DEL 3");

            Console.Write("Uppgift 1 Körs... ");
            part.Task1();

            ConsoleHelperFunctions.PrintResult(1, part.ANSWER);
            ConsoleHelperFunctions.PrintEstimate(!part.ANSWER.Equals(DEFAULT_TEXT));


            Console.Write("\nUppgift 2 Körs... ");
            part.Task2();

            ConsoleHelperFunctions.PrintResult(2, part.ANSWER);
            ConsoleHelperFunctions.PrintEstimate(!part.ANSWER.Equals(DEFAULT_TEXT));

            Console.Write("\nDEL 3 FÄRDIG\n");
        }
    }
}
