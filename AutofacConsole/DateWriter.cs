using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutofacConsole.Interface;

namespace AutofacConsole
{
    /// <summary>
    /// Class TodayWriter.
    /// </summary>
    public class DateWriter : IDateWriter
    {
        /// <summary>
        /// The output
        /// </summary>
        private readonly IOutput output;

        /// <summary>
        /// Initializes a new instance of the <see cref="DateWriter"/> class.
        /// </summary>
        /// <param name="output">The output.</param>
        public DateWriter(IOutput output)
        {
            this.output = output;
        }

        /// <summary>
        /// Writes the date.
        /// </summary>
        public void Write()
        {
            output.Write(DateTime.Now.ToString("O"));
            output.Wait();
        }
    }
}
