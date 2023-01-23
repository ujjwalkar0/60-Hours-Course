namespace Program{
    class Largest{
        public Largest(){
            int num1 = 60, num2 = 45, num3 = 123;

            if ((num1>num2) && (num1>num3)){
                System.Console.WriteLine(num1);
            }
            else if ((num2>num3) && (num2>num3)){
                System.Console.WriteLine(num2);
            }
            else if ((num3>num2) && (num3>num1)){
                System.Console.WriteLine(num3);
            }
        }
    }
}