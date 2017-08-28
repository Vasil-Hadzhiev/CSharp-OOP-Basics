namespace NeedForSpeed
{
    using NeedForSpeed.Controllers;

    public class StartUp
    {
        public static void Main()
        {
            var engine = new Engine();
            engine.Run();
        }
    }
}