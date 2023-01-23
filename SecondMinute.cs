namespace Program{
    class SecondMinute{
        public SecondMinute(){
            int sec = 288970;
            int hour = sec/3600;

            int day = hour/24;

            int left_hour = hour%24;

            int left_sec = sec%3600;

            int min = left_sec/60;
            
            int final_sec = left_sec%50;

            System.Console.WriteLine($"{day} days, {left_hour} hours, {min} minutes, {final_sec} seconds");
        }
    }
}