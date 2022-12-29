public string FuzzBizz(int num)
        {
            var answer = "";

            if (num % 3 == 0)
            { 
               return "Fizz! Divisable by 3!";
            }
            if (num % 5 == 0)
            {
                return "Buzz! Divisable by 5!";
            }
            if (num % 15 == 0)
            {
                return "FizzBuzz! Divisable by both!";
            }
            else
            return "FuzzBizz! Not divisable by 3, 5, or both";
               
        }
         static void Main(string[] args)
        {
            Console.WriteLine($"Is your number divisable by 3, 5, or both?");
            Console.WriteLine($"Enter your number: ");
            //Console.ReadLine();
            //var num = int.Parse(Console.ReadLine());
            Console.WriteLine(Methods.FizzBuzz(int.Parse(Console.ReadLine())));
        } 