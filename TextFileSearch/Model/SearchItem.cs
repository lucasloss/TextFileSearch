using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextFileSearch
{
    /// <summary>
    /// Represents a string to be searched in text files and the results of a search.
    /// </summary>
    public class SearchItem
    {
        /// <summary>
        /// Gets or sets the string being searched.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets a list of <see cref="TextFileResult"/>, which represents the result of a search.
        /// </summary>
        [JsonIgnore]
        public List<TextFileResult> TextFileResults { get; } = new List<TextFileResult>();

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is SearchItem item &&
                   Value == item.Value;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            var hashCode = 664963824;
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(Value);
            return hashCode;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{TextFileResults.Sum(t => t.Count)} hits for \"{Value}\" in {TextFileResults.Count} files");

            foreach (var textFileResult in TextFileResults)
            {
                sb.Append(" - ").Append(textFileResult.Count).Append(" hits in file ").AppendLine(textFileResult.TextFile.Path);
            }

            if (TextFileResults.Count == 0)
            {
                sb.Append($"  No hits for \"{Value}\" in any of the files.");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
