namespace DelegateBasicExample
{
    class Program
    {
        delegate void LogDel(string text);
        static void Main(string[] args)
        {
            LogDel logDel = new LogDel(LogTextToScreen);
            Console.WriteLine("Please enter you name");
            var name = Console.ReadLine();
            if (name != null && name != "")
            {
                logDel(name);
            }
            else
            {
                Console.WriteLine("The name was empty!");
            }
        }

        static void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }
    }
}