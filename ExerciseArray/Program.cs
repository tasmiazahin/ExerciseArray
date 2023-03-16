namespace ExerciseArray;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many integers do you want?");

        int.TryParse(Console.ReadLine(), out int arrayLength);

        int[] numbers = new int[arrayLength];


        Console.WriteLine("Enter lowest number");

        int.TryParse(Console.ReadLine(), out int lowestNumber);


        Console.WriteLine("Enter Highest number");

        int.TryParse(Console.ReadLine(), out int highestNumber);


        Console.WriteLine("Generate random numbers in between " +  lowestNumber  + " and "  + highestNumber);

        Random rnd = new Random();

        for (int i = 0; i < arrayLength; i++)

        {
            //numbers[i] = Convert.ToInt32(Console.ReadLine());
            //int.TryParse(Console.ReadLine(), out numbers[i]);

            // Generate the random number and push into array
            numbers[i] = rnd.Next(lowestNumber, highestNumber);

        }

        Console.WriteLine("Straight array:");
        for (int i = 0; i <arrayLength; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("Backward array:");
        for (int i = arrayLength-1; i >= 0; i--)
        {
            Console.WriteLine(numbers[i]);
        }
    }



   
}

