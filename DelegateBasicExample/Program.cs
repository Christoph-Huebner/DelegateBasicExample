namespace DelegateBasicExample
{
    class Program
    {
        delegate void LogDel(string text, DateTime dateTime);
        static void Main(string[] args)
        {
            LogDel logDel = new LogDel(LogTextToScreen);
            Console.WriteLine("Please enter you name");
            var name = Console.ReadLine();
            if (name != null && name != "")
            {
                logDel(name, DateTime.Now);
            }
            else
            {
                Console.WriteLine("The name was empty!");
            }
        }

        static void LogTextToScreen(string text, DateTime dateTime)
        {
            Console.WriteLine($"{dateTime}: {text}");
        }
    }
}