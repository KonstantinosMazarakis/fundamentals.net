using System;

namespace fundamentals.net
{
    class Program
    {
        static void Main(string[] args)
        {
            // for(int i = 0;i < 256;i++){
            //     Console.WriteLine(i);
            // }

            for(int x = 1;x < 101;x++){
                if(x % 3 == 0 || x % 5 == 0){
                    if(x % 3 == 0 && x % 5 == 0){
                        Console.WriteLine("FizzBuzz for " + x);
                    }else if(x % 3 == 0){
                        Console.WriteLine("Fizz for " + x);
                    }else if(x % 5 == 0){
                        Console.WriteLine("Buzz for " + x);
                    }
                }
            }
        }
    }
}
