using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
          
            for (int count = 0; count <= 5; count++)
            {
                RonVSKanyeAPI.Kanye();
                RonVSKanyeAPI.Ron();
                Console.WriteLine();
            }
        }
    }
}
