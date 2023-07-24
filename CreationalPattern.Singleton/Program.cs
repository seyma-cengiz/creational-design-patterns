using CreationalPattern.Singleton;

Task task1 = Task.Factory.StartNew(() =>
{
    var logger = Logger.GetInstance();
    Console.WriteLine($"Logger instance: {logger.Count}");
});


Task task2 = Task.Factory.StartNew(() =>
{
    var logger = Logger.GetInstance();
    Console.WriteLine($"Logger instance: {logger.Count}");
});

await Task.WhenAll(task1, task2);

Console.WriteLine("All tasks are completed.");
