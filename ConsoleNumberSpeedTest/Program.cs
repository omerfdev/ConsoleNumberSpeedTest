DateTime firstTime, lastTime;
firstTime = DateTime.Now;
int allCount = 0;
Random rnd = new Random();
for (int i = 0; i < 1000; i++)
{
    allCount += rnd.Next(1, 1001);
}
lastTime = DateTime.Now;
TimeSpan speed = lastTime - firstTime;
Console.WriteLine(speed.TotalMilliseconds);
Console.ReadLine();
