using System.ComponentModel;

namespace TextFileSearch
{
    /// <summary>
    /// Represents a text file.
    /// </summary>
    public class TextFile
    {
        /// <summary>
        /// Gets or sets the full path of the text file, including its name and extension.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the content of the text file.
        /// </summary>
        [Browsable(false)]
        public string Content { get; set; }
    }
}
