namespace Program
{
    class Height
    {
        public Height()
        {
            int n = 180;
            /*
            Height is less than 150 cm = "Dwarf"

Height is between 150 cm and 165 cm = "Average height"

Height is between 165 cm and 195 cm = "Tall"

Height is above 195 cm = "Abnormal height"
            */
            if (n < 150)
            {
                System.Console.WriteLine("Dwarf");
            }
            else if(n>=150 && n<165){
                System.Console.WriteLine("Average height");
            }
            else if (n>=165 && n<195){
                System.Console.WriteLine("Tall");
            }
            else{
                System.Console.WriteLine("Abnormal height");
            }
        }
    }
}