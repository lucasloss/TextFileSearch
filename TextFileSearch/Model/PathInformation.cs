using System.Collections.Generic;

namespace TextFileSearch
{
    /// <summary>
    /// Represents the path where the application is going to search for files.
    /// </summary>
    public class PathInformation
    {
        /// <summary>
        /// Gets or sets the path where the aplication is going to search for files.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the path exists.
        /// </summary>
        public bool Exists { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the application should search recursively in the specified path.
        /// </summary>
        public bool RecursiveSearch { get; set; }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is PathInformation information &&
                   Path == information.Path &&
                   Exists == information.Exists &&
                   RecursiveSearch == information.RecursiveSearch;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            var hashCode = -64031662;
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(Path);
            hashCode = (hashCode * -1521134295) + Exists.GetHashCode();
            hashCode = (hashCode * -1521134295) + RecursiveSearch.GetHashCode();
            return hashCode;
        }
    }
}
