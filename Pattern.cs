namespace Program{
    class Pattern{

        void Front(params int[] arr){
            for (int i=1; i<=10; i++){
                if (arr.Contains(i)) 
                {
                    continue;
                }
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
        }

        void Back(params int[] arr){
            for (int i=10; i>0; i--){
                if (arr.Contains(i)) 
                {
                    continue;
                }
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
        }

        public Pattern(){
            Front(5,6);
            Front(5,6);
            Front(5,6);
            Back();
            Back(2,1);
            Back(2,1);
            Front(8);

        }
    }
}