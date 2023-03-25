using StackExchange.Redis;

ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:1453");
ISubscriber subscriber = redis.GetSubscriber();

await subscriber.SubscribeAsync("mychannel", (channel, message) =>
{
    Console.WriteLine(message);
});

Console.ReadLine();