namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = askName();
            string favoriteColor = askFavoriteColor();
            string favoriteAnimal = askFavoriteAnimal();
            string favoriteBand = askFavoriteBand();
            TellStory(name, favoriteColor, favoriteAnimal, favoriteBand);

            Console.WriteLine("6 + 2 = " + Add(4,2));
            Console.WriteLine("6 - 2 = " + Subtract(4, 2));
            Console.WriteLine("6 * 2 = " + Multiply(4, 2));
            Console.WriteLine("6 / 2 = " + Divide(4, 2));
            Console.WriteLine("6 % 2 = " + Modulus(4, 2));

            //Bonus Addition
            Console.WriteLine("1 + 2 + 3 + 4 + 5 " +
                "+ 6 + 7 + 8 + 9 + 10 = " +Add(1,2,3,4,5,6,7,8,9,10));

        }
        //SECTION: MATHEMATICS
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Add(params int[] nums) //Bonus Addition
        {
            int total = 0;
            for (int i = 0; i < nums.Length;  i++) {
                total += nums[i];
            }
            return total;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int dividend, int divisor)
        { 
            return dividend / divisor; //Quotient
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2; //Remainder
        }

        //SECTION: STORY
        public static void TellStory(string name, string favoriteColor, string favoriteAnimal, string favoriteBand)
        {
            Console.WriteLine($"One day, {name} was walking through the woods. He was wearing {favoriteColor} pants." +
                $" All of the sudden, a {favoriteAnimal} ran in front of him and shouted \"Those pants are my favorite color! Give me give me give me!\" " +
                $"The {favoriteAnimal} stole his pants and ran off, blasting in his airpods {favoriteBand}");
        }
        public static string askName()
        {
            Console.WriteLine("What is your name?");
            string? returnable = Console.ReadLine();
            if (returnable != null)
            {
                return returnable;
            }
            else
            {
                return "No Name";
            }
        }

        public static string askFavoriteColor()
        {
            Console.WriteLine("What is your favorite color?");
            string? returnable = Console.ReadLine();
            if (returnable != null)
            {
                return returnable;
            }
            else
            {
                return "no color";
            }
        }

        public static string askFavoriteAnimal()
        {
            Console.WriteLine("What is your favorite animal?");
            string? returnable = Console.ReadLine();
            if(returnable != null)
            {
                return returnable;
            } else
            {
                return "no animal";
            }
        }

        public static string askFavoriteBand()
        {
            Console.WriteLine("What is your favorite band?");
            string? returnable = Console.ReadLine();
            if (returnable != null)
            {
                return returnable;
            }
            else
            {
                return "no band";
            }
        }

    }
}