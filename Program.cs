    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using static System.Formats.Asn1.AsnWriter;
class Program {

    public static void Main(string[] args) {

        // Welcome message
        Console.WriteLine("Hello and Welcome to the Kennel Club!");
        Console.ReadLine();
        // Initialize the kennel and add dogs
        Kennel main = new Kennel();
        Dog temp = new Dog("Scout", 12, 18, 54, "Whippet", 68, "Male");
        main.Dogs.Add(temp);
        temp = new Dog("Max", 9, 32, 75, "Grayhound", 68, "Male");
        main.Dogs.Add(temp);
        temp = new Dog("Milo", 11, 29, 60, "Dalmatian", 68, "Male");
        main.Dogs.Add(temp);
        temp = new Dog("Stirling", 9, 24, 60, "Vizsla", 67, "Male");
        main.Dogs.Add(temp);
        temp = new Dog("Daisy", 8, 35, 76, "Borzoi", 66, "Female");
        main.Dogs.Add(temp);
        // Main program loop
        while (true) {
            // Display main menu options
            main.PrintMainInfo();
            // Main Menu Options
            if (int.TryParse(Console.ReadLine(), out int input)) { }
                Console.Clear();
                switch (input) {
                    case 1:
                        // Kennel owner introduction
                        Console.Clear();
                        Console.WriteLine("Greetings, I am Mohsain, the proprietor of this esteemed kennel. Currently, our kennel is home to five exceptional dogs, each possessing unique qualities. Should you wish to acquaint yourself with them, kindly explore the second option. \nMoreover, our kennel club offers an engaging opportunity for patrons to participate in dog races, where placing bets can\n yield financial rewards. Enjoy the experience!");
                        Console.WriteLine("Press any key to continue..");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                
                    case 2:
                        // Dog information option
                        while (true) {
                            Console.Clear();
                            Console.WriteLine("Here are my beautiful dogs:");
                            main.PrintDogsNames();
                            Console.WriteLine("Press the Dogs number to see the information or press 0 to go back to the main menu!");
                            if (int.TryParse(Console.ReadLine(), out int subInput)) {
                                Console.Clear();
                                // Dog information Second-menu
                                switch (subInput) {

                                    case 0:
                                        break;
                                    case 1:
                                    case 2:
                                    case 3:
                                    case 4:
                                    case 5:
                                        main.Dogs[subInput - 1].PrintInfo();
                                        break;
                                    default:
                                        Console.WriteLine("Invalid input.");
                                        break;
                                }
                                // Press 0 for exit 

                                if (subInput == 0)
                                    break;

                                Console.Write("Press any key to continue...");
                                Console.ReadKey();

                            }
                        }
                        break;


                    case 3:
                        // The racing Option in Main Menu
                        bool validInpt = true;
                        while (validInpt) {
                            Console.Clear();
                            Console.WriteLine("Welcome to the racing Platfrom");
                            main.RacingDistance();
                            Console.WriteLine("\nPress 0 to get back to Main Menu!");
                        if (int.TryParse(Console.ReadLine(), out int subInput2)) { }
                            Console.Clear(); Console.Clear();
                            switch (subInput2) {

                                case 0:
                                    break;

                                case 1:
                                    Console.WriteLine("[Sprint Race]");
                                    break;
                                case 2:
                                    Console.WriteLine("[Standard Race]");
                                    break;
                                case 3:
                                    Console.WriteLine("[Long-distance race]");
                                    break;
                                default:
                                    Console.WriteLine("Invalid input.");
                                    validInpt = false;
                                    continue;
                            }
                            // Press 0 for exit 

                            if (subInput2 == 0) {
                                break;
                            }

                            Console.WriteLine("Choose one our dogs by pressing their number:");
                            main.PrintDogsNames();
                            Console.WriteLine("Press 0 to reselect Racing track");
                        if (int.TryParse(Console.ReadLine(), out int subInput3)) { }
                            // Continue to the Racing Simulation 
                            switch (subInput3) {

                                case 0:
                                    Console.Clear();

                                    break;

                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                    main.RacingDogs(main.Dogs[subInput2 - 1].Name);
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;

                                default:
                                    Console.WriteLine("Invalid input.");
                                    break;
                            }

                            if (subInput2 == 0)
                                break;


                        }
                        break;
                    case 4:
                        // Exit option
                        Console.Clear();
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid input.");
                        break;
                }
            
        }
    }
}


    class Dog {
 
        public string Name { get; set; }    
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; } 
        public string Breed { get; set; }   
        public int MaxSpeed { get; set; }

        public string Sex { get; set; }
    // Dog constructor
    public Dog(string name, int age, int weight, int height, string breed, int maxspeed, string sex) {
            Name = name;
            Age = age;  
            Weight = weight;
            Height = height;
            Breed = breed;
            MaxSpeed = maxspeed;
            Sex = sex;
        }
        public void PrintInfo() {
        // Print Dog information
        Console.WriteLine("\nName: " + Name + "\nAge: " + Age + "\nWeight: " + Weight + "\nHeight: " + Height + "\nBreed: " + Breed + "\nMaxSpeed: " + MaxSpeed + "\nSex: " + Sex);
        }

    }


    class Kennel {
        public List<Dog> Dogs { get; set; }

        public Kennel() {
        // Kennel constructor
        Dogs = new List<Dog>();
        }
        public void PrintMainInfo() {
        // Print main menu options
        string[] options = { "Introduction", "Kennel Members", "Racing Platform", "Exit Tunnel" };

            for (int i = 0; i < options.Length; i++) {
                Console.WriteLine($"{i + 1}.{options[i]}");

            }
        }
        public void PrintDogsNames() {
        // Print dog names
        string[] options = { "Scout", "Max", "Milo", "Stirling", "Daisy" };

            for (int i = 0; i < options.Length; i++) {
                Console.WriteLine($"{i + 1}.{options[i]}");
            }
        }

        public void RacingDistance() {
        // Define racing distance options
        string[] options = { "Sprint races: 300-400 m", "Standard races: 500 m", "Long-distance races: 700-900 m",};

        // Prompt the user to choose a race distance type
        Console.WriteLine("Choose Race Distance Type:");
            for (int i = 0; i < options.Length; i++) {
                Console.WriteLine($"{i + 1}.{options[i]}");
            }

        }
        private Random random = new Random();

        public void RacingDogs(string dogName) {

            // Simulate the dog race
            Console.WriteLine("The dog race is starting!");

        int nrTickets = 0;
        for (int i = 0; i < Dogs.Count; i++) {
            nrTickets += i + 2;
        }
        int winningTicket = random.Next(nrTickets);
        List<Dog> placements = Dogs.OrderBy(o=>o.MaxSpeed).ToList();
        Dog winningDog = placements[0];
        for (int i = placements.Count-1; i >= 0; i--) {

            nrTickets -= i+ 2;
            if (winningTicket >= nrTickets) { 
                winningDog = placements[placements.Count-1-i];
            }
        }

        // Randomly select a winner from the available dogs
        int resultIndex = random.Next(0, Dogs.Count);


            string winner = Dogs[resultIndex].Name;

        // Prompt the user to enter the amount they want to bet
            Console.WriteLine("Enter the amount you want to bet:");

            if (int.TryParse(Console.ReadLine(), out int betAmount)) {
                // Display the winner after receiving the bet
                int adjustedSpeed = Dogs[resultIndex].MaxSpeed - random.Next(6);

            // Print the winner and their adjusted speed
            Console.WriteLine($"The winner of the dog race is: {winningDog.Name}, they finished with a max speed of {adjustedSpeed} km/h");

            // Check if the user's chosen dog matches the winner
            if (winner == dogName) {
                    Console.WriteLine($"Congratulations! You won {2 * betAmount} $!");
                }
                else {
                    Console.WriteLine($"Sorry, you lost your {betAmount} $.");
                }
            }
            else {
                Console.WriteLine("Invalid input for the bet amount.");
            }
        }
    }

