using AutofacConsole.Interface;
using System;

namespace AutofacConsole
{
    /// <summary>
    /// Class ConsoleOutput.
    /// </summary>
    public class ConsoleOutput : IOutput
    {
        /// <summary>
        /// Writes the specified content.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Write(string content)
        {
            Console.WriteLine(content);
        }

        /// <summary>
        /// Waits this instance.
        /// </summary>
        public void Wait()
        {
            Console.ReadLine();
        }
    }
}
