class Calculator{

    public static void Main(){

        Operator opt = Operator.Addition;
        while(true){
            Console.Write("Operator:\t");
            string? input = Console.ReadLine();
            switch(input){
                case "+":
                    opt = Operator.Addition;
                    break;
                case "-":
                    opt = Operator.Subtraction;
                    break;
                case "*":
                    opt = Operator.Multiplication;
                    break;
                case "/":
                    opt = Operator.Division;
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    continue;
            }
            break;
        }

        float x = 0;
        while(true){
            Console.Write("X:\t\t");
            if(float.TryParse(Console.ReadLine(), out x)) break;
            else{
                Console.WriteLine("Invalid input!");
                continue;
            }
        }

        float y = 0;
        while(true){
            Console.Write("Y:\t\t");
            if(float.TryParse(Console.ReadLine(), out y)) break;
            else{
                Console.WriteLine("Invalid input!");
                continue;
            }
        }

        switch(opt){
            case Operator.Addition:
                Console.WriteLine(x + y);
                break;
            case Operator.Subtraction:
                Console.WriteLine(x - y);
                break;
            case Operator.Multiplication:
                Console.WriteLine(x * y);
                break;
            case Operator.Division:
                Console.WriteLine(x / y);
                break;
        }

    }

}