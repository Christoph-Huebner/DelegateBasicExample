namespace DelegateBasicExample
{
    class Program
    {
        delegate void LogDel(string text);
        static void Main()
        {
            LogDel LogTextToScreenDel, LogTextToFileDel;
            
            LogTextToScreenDel = new(Log.LogTextToScreen);
            LogTextToFileDel = new(Log.LogTextToFile);
            LogDel multiLogDel = LogTextToScreenDel + LogTextToFileDel;

            Console.WriteLine("Please enter you name");
            var name = Console.ReadLine();
            if (name != null && name != "")
            {
                multiLogDel(name);
            }
            else
            {
                Console.WriteLine("The name was empty!");
            }
        }
    }

    public class Log
    {
        static public void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }

        static public void LogTextToFile(string text)
        {
            using (StreamWriter sw = new(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
            {
                sw.WriteLine($"{DateTime.Now}: {text}");
            }
        }
    }
}