# C-Sharp-Projects
I have a few programs from this repository that I would like to show off, whether I think they are cool to really well functioning.
# Exception Handling
This program is super simple, it is meant to catch any error and handle it in a proper matter. It only has the user enter their age (or you can just use any number) and if you dont enter in a whole number that is above zero, it will not work and it will have you re-enter a proper whole number.
```
    static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age");
                int userinput1 = Convert.ToInt32(Console.ReadLine());
                if (userinput1 < 0)
                {
                    Console.WriteLine("Please enter a number that is not negative or not zero.");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine(userinput1);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter your age in numerical values and only a whole number.");
                Console.ReadLine();
                return;
            }
        }
```
If you were to run this code you cannot enter in negative numbers, numbers with decimals, or strings. 
# Student Daily Report (Form to fill out)
This program I built as well, this was something I built for a school exercise and although you it is not doing anything with the info, it can be later used to be stored into a database or some entry logging program. I would probably use this for some sort of web form.
```
static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine(); 

                Console.WriteLine("What course are you on?");
                string course = Console.ReadLine();

                    Console.WriteLine("What page number?");
                    int page = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Do you need help with anything? Please anwser 'true' or 'false'.");                     
                        bool help = Convert.ToBoolean(Console.ReadLine());

                            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
                            string positive = Console.ReadLine();

                                Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
                                string feedback = Console.ReadLine();

                                    Console.WriteLine("How many hours did you study today?");
                                    int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your anwsers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
```
All it does is ask you questions about how you did for your studying / working for the day. Which can be useful info for our instructors so they can properly help you.
# Casino Program
I have this program that I built that you are able to play BlackJack. There is a lot of code so I am only going to show a few lines of code showing some of the important bits.
These lines of code show off the beginning of the program that ask you your name and how much money you brought with you.
```
static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";
            Guid identifier = Guid.NewGuid(); 

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name", casinoName);
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }
```
This next part shows off the part where the card values are displayed out
```
private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };
```
There is a lot more code to this program but there are some of the cool parts of the program.
# Conclusion
All these programs I spent some time thinking on some more simple than other some more complext than others. I thought all of these programs were pretty cool and even made a game of blackjack.



