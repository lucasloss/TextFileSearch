using System.Collections.Generic;

namespace TextFileSearch
{
    /// <summary>
    /// Holds the application and user configurations.
    /// </summary>
    public class ApplicationConfiguration
    {
        /// <summary>
        /// Gets the list of <see cref="RecentProject"/> objects.
        /// </summary>
        public List<RecentProject> RecentProjects { get; } = new List<RecentProject>();
    }
}