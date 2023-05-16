namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = "";

            response = ((answer < 9) ? "Is less than nine" : "greater than or equal to nine");

            Console.WriteLine($" your response {response} because {answer} is less than nine");
        }
    }
}
