using System;
using mars_rovers_project.Presentation.Contracts;

namespace mars_rovers_project.Presentation
{
    public class DefaultConsole : IDefaultConsole
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}