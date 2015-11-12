using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacConsole.Interface
{
    /// <summary>
    /// Interface IOutput
    /// </summary>
    public interface IOutput
    {
        /// <summary>
        /// Writes the specified content.
        /// </summary>
        /// <param name="content">The content.</param>
        void Write(string content);
    }
}
