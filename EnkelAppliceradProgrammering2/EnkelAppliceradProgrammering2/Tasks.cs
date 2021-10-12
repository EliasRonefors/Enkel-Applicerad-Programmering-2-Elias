using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace EnkelAppliceradProgrammering2
{
    static class Tasks
    {
        // Detta är Del 1
        public class Part1
        {
            public float ANSWER = 0x0;

            public void Task1()
            {
                /*
                 * Uppgift 1
                 * Du ska skapa två stycken heltal som heter numberOne och numberTwo. I numberOne så ska du 
                 * sätta i värdet 44 och i numberTwo värdet 97. Sedan ska du i ANSWER sätta in differensen 
                 * (subtraktion) av numberOne och numberTwo.
                */
                int numberOne = 44;
                int numberTwo = 97;




                // Ersätt 0x0 med ditt resultat
                ANSWER = numberOne-numberTwo;
            }

            public void Task2()
            {
                /*
                 * Uppgift 2
                 * Du ska skapa ett nytt heltal, numberThree, och i den ska du förvara värdet 20. Sedan ska
                 * du räkna ut numberOne * numberTwo och sedan addera numberThree till det resultatet.
                 * I ANSWER sätter du sedan in resultatet av uträkningen.
                */
                int numberOne = 44;
                int numberTwo = 97;
                int numberThree = 20;
                



                // Ersätt 0x0 med ditt resultat
                ANSWER = numberOne*numberTwo+numberThree ;
            }

            public void Task3()
            {
                /*
                 * Du ska presentera resultatet från den första uppgiften, men värdet får inte lov att vara 
                 * negativt. Så istället för -53 så ska resultatet presentera 53. Där finns en inbyggd metod 
                 * för detta och du hittar den bland mattefunktionerna.
                */
                int numberOne = 44;
                int numberTwo = 97;
                int negativInt = numberOne - numberTwo;
                negativInt = System.Math.Abs(negativInt);



                // Ersätt 0x0 med ditt resultat
                ANSWER = negativInt;
            }

            public void Task4()
            {
                /*
                 * Du ska skapa två flyttal (decimaltal), decimalOne och decimalTwo. I decimalOne ska du förvara 
                 * värdet 15.3 och i decimalTwo ska du förvara värdet 3.8. 
                 * I ANSWER ska du sätta in summan (addition) av decimalOne och decimalTwo
                 */
                float decimalOne = 15.3F;
                float decimalTwo = 3.8F;



                // Ersätt 0x0 med ditt resultat
                ANSWER = decimalOne+decimalTwo;
            }

            public void Task5()
            {
                /*
                 * Med hjälp av resultatet från den förra uppgiften (nummer 4) så ska du dividera det med värdet 
                 * i decimalTwo. I ANSWER ska du presentera resultatet av denna uträkning med endast två decimaler. 
                 * Exempel på det är då 1,23. I det värdet är där endast två decimaler. För att hitta hur man får ut 
                 * endast två decimaler
                 */
                float decimalOne = 15.3F;
                float decimalTwo = 3.8F;
                


                // Ersätt 0x0 med ditt resultat
                ANSWER = (float)Math.Round((decimalOne + decimalTwo) / decimalTwo, 2);
            }
        }

        // Detta är del 2
        public class Part2
        {
            public string ANSWER = "";

            public void Task1()
            {
                /*  
                 *  Uppgift 1
                 *  Du har två strängar “glass” och “hund”. Du ska lägga ihop dessa strängarna med hjälp av 
                 *  funktioner som hjälper er att lägga ihop dem. Termen kallas för “Concatenate” på engelska 
                 *  och översätts till “länka samman” eller sammanfoga. Det ska vara ett mellanrum mellan orden, 
                 *  så det blir “glass hund” och inte “glasshund”.
                 *  Presentera resultatet av din concat i variabeln ANSWER.
                */
                string glass = "glass";
                string hund = "hund";



                // Ersätt allt på högersidan med ditt resultat
                ANSWER = string.Concat(glass, " ", hund);
            }

            public void Task2()
            {
                /* 
                * Uppgift 2
                * Du har nu en sträng, “glass” och en siffra 57. Du ska lägga ihop dessa så det blir en kombinerad
                * sträng “glass 57”. Där ska vara ett mellanrum mellan ordet och siffran.
                * Presentera resultatet av din concat i variabeln ANSWER. 
               */
                string glass = "glass";
                string femtiosju = "57";

                

                // Ersätt allt på högersidan med ditt resultat
                ANSWER = string.Concat(glass, " ", femtiosju);


                //Menade du att 57 skulle vara en int?
            }

            public void Task3()
            {
                /*
                 * Uppgift 3
                 * Du har tre variabler att använda dig av:
                 *      • informationString, “You currently have [numberOfFood] [foodName] left.”
                 *      • numberOfFood, innehåller värdet 4
                 *      • foodName, “burgers”
                 *      
                 * Den första variablen är en string som du senare ska formatera, och det förväntas då att du sätter 
                 * in de två andra variablerna i luckorna som är markerade med []. För att göra detta behöver du använda 
                 * den inbyggda String.Format()-verktygen, kolla i material för mer info.
                 * Presentera resultatet av format-operationen i ANSWER.
                */
                string informationString = "You currently have {0} {1} left";
                string numberOfFood = "4";
                string foodName = "burgers";


                informationString = string.Format(informationString, numberOfFood, foodName);

                // Ersätt allt på högersidan med ditt resultat
                ANSWER = informationString;
            }

            public void Task4()
            {
                /*
                 * Uppgift 4
                 * Personerna “Kim” och “Alex” pratar ofta i telefon med varandra, ungefär 7 minuter varje dag. Du ska 
                 * skriva ut som att “[person1] and [person2] talks on the phone [timmar] hours yearly”. Du måste alltså 
                 * räkna ut hur många timmar de pratar med varandra på ett år (365 dagar), och sedan presentera resultatet. 
                 * Du måste använda dig av sträng-formatering för denna uppgiften.
                 * Presentera resultatet i ANSWER.
                */
                string Kim = "Kim";
                string Alex = "Alex";
                //!!!!!!!!!!!!!!!!!!!!!!!!! lite onödigt att skapa strings för dessa ovan men jaja.
                string text = "{0} and {1} talks on the phone {2} hours yearly";
                float hours = (float)Math.Round((7F * 365F) / 60F, 1);


                text = string.Format(text, Kim, Alex, hours);








                //!!!!!!!!!!!!!!!!!!!!!! Du har gjort ett avrundingsfel i dina autotester. Det blir närmare 42,6 än 42,5





                ANSWER = text;
            }
        }

        // Detta är del 3
        public class Part3
        {
            public string ANSWER = "";

            public void Task1()
            {
                /*
                 * Uppgift 1
                 * https://docs.google.com/document/d/1pCzvPGhbw5drESKos6mhW4BJm34NPaVgO6F_ZlAB4Aw/edit#heading=h.3ncfbn5c0hz9
                */
                string text = "Den {0}:e {1}, {2} så är temperaturen {3}°F på en station som är {4} feet över havsnivån.";
                int meter = 150;
                int celsius = 27;
                int tidTimme = 13;
                int tidMinut = 30;
                bool överTolv = false;

                string tidString = "";


                if (tidTimme > 12)
                {
                    tidTimme = tidTimme - 12;
                    tidString= tidTimme.ToString();
                    överTolv = true;
                }
                else
                {
                    tidString = tidTimme.ToString();
                }
                tidString = string.Concat(tidString + "." + tidMinut);
                if (överTolv == true)
                {
                    tidString = string.Concat(tidString + "pm");
                }
                else
                {
                    tidString = string.Concat(tidString + "am");
                }

                //celsius till fahrenheit
                int fahrenheit = (int)(celsius * 1.8 + 32);

                //meter till feet
                int feet = (int)(meter * 3.28);


                text = string.Format(text, "12", "juni", tidString,fahrenheit, feet);

                // Ersätt allt på högersidan med ditt resultat
                ANSWER = text;
            }

            public void Task2()
            {
                /*
                 * Uppgift 2
                 * https://docs.google.com/document/d/1pCzvPGhbw5drESKos6mhW4BJm34NPaVgO6F_ZlAB4Aw/edit#heading=h.uas1xhykx4zf
                 */
                string text = "Den {0}:e {1}, {2} så är temperaturen {3}°F på en station som är {4} feet över havsnivån.";
                bool överTolv = false;
                string tidString = "";

                Console.SetCursorPosition(0, 34);
                Console.WriteLine("Vilken dag är det?");
                string dag = Console.ReadLine();
                Console.WriteLine("Vilken tid är det?");
                string tid24 = Console.ReadLine();
                Console.WriteLine("Vilken temperatur är det?");
                int celsius = int.Parse(Console.ReadLine());
                Console.WriteLine("Hur högt över hav är mätaren?");
                int meter = int.Parse(Console.ReadLine());

                string tidTimmeString = string.Concat(tid24[0], tid24[1]);
                string tidMinutString = string.Concat(tid24[3], tid24[4]);
                int tidTimme = int.Parse(tidTimmeString);
                int tidMinut = int.Parse(tidMinutString);

                if (tidTimme > 12)
                {
                    tidTimme = tidTimme - 12;
                    överTolv = true;
                }

                tidString = string.Concat(tidTimme + "." + tidMinut);
                if (överTolv == true)
                {
                    tidString = string.Concat(tidTimme + "pm");
                }
                else
                {
                    tidString = string.Concat(tidTimme + "am");
                }

                //celsius till fahrenheit
                int fahrenheit = (int)(celsius * 1.8 + 32);

                //meter till feet
                int feet = (int)(meter * 3.28);

                text = string.Format(text, dag, "juni", tidString, fahrenheit, feet);

                ANSWER = text;
            }
        }


        /// <summary>
        /// Du behöver inte tänka på denna metoden. Denna hjälper dig att köra programmet och verifiera att
        /// allting är fixat :)
        /// </summary>
        public static void Main(string[] args)
        {
            Part1Tests.Run();

            Console.SetCursorPosition(ConsoleHelperFunctions.CONSOLE_X, ConsoleHelperFunctions.CONSOLE_Y++);
            Console.Write("\nIfall allt är grönt så har du förmodligen lyckats :)");
            Console.Write("\n\nEnd of execution. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
