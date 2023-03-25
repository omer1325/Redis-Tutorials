using StackExchange.Redis;

ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:1453");
ISubscriber subscriber = redis.GetSubscriber();

while (true)
{
    Console.WriteLine("Mesaj : ");
    string message = Console.ReadLine();
    await subscriber.PublishAsync("mychannel", message);
}

