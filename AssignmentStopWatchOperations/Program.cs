using System;

namespace AssignmentStopWatchOperations
{
    class Program
    {
        public class StopWatch
        {
            private DateTime startTime;
            private DateTime stopTime;
            private TimeSpan duration;
            public DateTime StartTime() 
            {
                startTime = DateTime.Now;
                return startTime;
            }
            public DateTime StopTime()
            {
                stopTime = DateTime.Now;
                return stopTime;
            }

        }
        static void Main(string[] args)
        { 
            var stopwatch = new StopWatch();
            int userInput;
            DateTime start_time;
            DateTime stop_time;
            double Duration;
            int counter = 0;
            while(true)
            {
                
                Console.Write("1-start the timer\n");

                Console.Write("2-start the timer\n");

                userInput = Convert.ToInt32(Console.ReadLine());

                if(userInput==1)
                {
                    start_time = stopwatch.StartTime();
                    counter = 1;
                }
                else
                {
                    throw (new InvalidOperationException("Pls enter 1 for start the timer"));

                }

                Console.Write("pls enter your second choice");

                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 2) 
                {
                    stop_time = stopwatch.StopTime();
                    counter = 0;
                }
                else
                {
                    throw (new InvalidOperationException("pls enter the 2 for stop the timer"));
                }
                if(counter==1)
                {
                    throw (new InvalidOperationException("Error in Code"));
                }
                Duration = (stop_time - start_time).TotalSeconds;
                if(Duration>60.0)
                {
                    Duration = (stop_time - start_time).TotalMinutes;
                    Console.WriteLine("total duration in minutes:"+Duration);
                }
                else
                {
                    Console.Write("The Duration:"+Duration);
                }
            }


        }
    }
}
