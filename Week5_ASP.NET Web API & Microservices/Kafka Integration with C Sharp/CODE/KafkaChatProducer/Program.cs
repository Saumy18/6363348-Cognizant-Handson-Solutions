using System;
using System.Threading.Tasks;
using Confluent.Kafka;

namespace KafkaChatProducer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };

            using var producer = new ProducerBuilder<Null, string>(config).Build();

            Console.WriteLine("📤 Kafka Chat Producer");
            Console.WriteLine("Type messages to send. Type 'exit' to quit.\n");

            while (true)
            {
                Console.Write("> ");
                var message = Console.ReadLine();

                if (message?.ToLower() == "exit")
                    break;

                try
                {
                    var result = await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = message });
                    Console.WriteLine($" Sent: '{message}' to {result.TopicPartitionOffset}");
                }
                catch (ProduceException<Null, string> ex)
                {
                    Console.WriteLine($"❌ Error sending message: {ex.Message}");
                }
            }
        }
    }
}
