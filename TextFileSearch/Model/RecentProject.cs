using System;

namespace TextFileSearch
{
    /// <summary>
    /// Represents a project that was loaded in the application.
    /// </summary>
    public class RecentProject
    {
        /// <summary>
        /// Gets or sets the path of the project, including its file name and extension.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="DateTime"/> value of the last time the project was loaded in the application.
        /// </summary>
        public DateTime Timestamp { get; set; }
    }
}