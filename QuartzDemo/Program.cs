using Quartz;
using Quartz.Impl;

var schedulerFactory  = new StdSchedulerFactory();
var scheduler  = await schedulerFactory.GetScheduler();
await scheduler.Start();
var job =JobBuilder.Create<HelloJob>()
    .WithIdentity("job1","group")
    .Build();
var trigger = TriggerBuilder.Create()
    .WithIdentity("trigger1", "group")
    .StartNow()
    .WithSimpleSchedule(x=>x
        .WithIntervalInSeconds(5)
        .RepeatForever())
    .Build();
await scheduler.ScheduleJob(job, trigger);
// 保持程序运行
await Task.Delay(TimeSpan.FromMinutes(1));
await scheduler.Shutdown();
Console.WriteLine("Hello, World!");