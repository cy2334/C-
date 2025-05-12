namespace Quartz;

public class HelloJob:IJob
{
    public Task Execute(IJobExecutionContext context)
    {
        Console.WriteLine("Hello Quartz.NET! - " + DateTime.Now);
        return Task.CompletedTask;
    }
}