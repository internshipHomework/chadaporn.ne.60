using System;

namespace work2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[] { "1","2","3","4","5","6","7","8","9","A" };
            string[] array3 = new string[] { "[ ]","[ ]","[ ]","[ ]","[ ]","[ ]","[ ]","[ ]","[ ]","[ ]" };
            Console.WriteLine(string.Join(" ", array3));
            Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");
            int count = 1;
            while ( count <= 100 ) {
                Console.Write("Please choose LED to turn On/Off: ");
                string ledch = Console.ReadLine();
                for (int i = 0; i < 10; i++) {
                    if ( array1[i] == ledch & array3[i] == "[!]" ){
                        array3[i] = "[ ]";
                    }
                    else if ( array1[i] == ledch & array3[i] == "[ ]" ){
                        array3[i] = "[!]";
                    }
                }
                Console.WriteLine(string.Join(" ", array3));
                Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");
                
                count++;
            }

        }
    }
}
