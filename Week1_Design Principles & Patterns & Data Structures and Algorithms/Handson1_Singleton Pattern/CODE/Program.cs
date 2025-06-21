using System;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton Pattern Test\n");
            
            // Test 
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();
            
            logger1.Log("Test message from logger1");
            logger2.Log("Test message from logger2");
            
            Console.WriteLine($"Are both references the same instance? {ReferenceEquals(logger1, logger2)}\n");
            
            // Test 2
            Console.WriteLine("Testing thread safety...");
            
            Parallel.For(0, 5, i => {
                Logger threadLogger = Logger.GetInstance();
                threadLogger.Log($"Message from thread {i}");
            });
            
            Console.WriteLine("\nAll tests completed successfully!");
        }
    }
}
