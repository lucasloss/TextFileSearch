﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace TextFileSearch
{
    /// <summary>
    /// Holds all the information associated with the search project.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Gets the search patterns used to filter the files when loading them from the specified paths.
        /// </summary>
        public List<string> SearchPatterns { get; private set; } = new List<string>();

        /// <summary>
        /// Gets the strings to be search in the text files.
        /// </summary>
        public List<SearchItem> SearchItems { get; private set; } = new List<SearchItem>();

        /// <summary>
        /// Gets the paths from where the files must be loaded.
        /// </summary>
        public List<PathInformation> Paths { get; private set; } = new List<PathInformation>();

        /// <summary>
        /// Gets a list of <see cref="TextFile"/> objects loaded from the specified paths.
        /// </summary>
        [JsonIgnore]
        public List<TextFile> TextFiles { get; } = new List<TextFile>();

        /// <summary>
        /// Gets or sets the project path, including the file name and extension.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets a value indicating whether <see cref="SearchPatterns"/> has unsaved changes.
        /// </summary>
        [JsonIgnore]
        public bool HasUnsavedSearchPatterns { get; private set; }

        /// <summary>
        /// Gets a value indicating whether <see cref="SearchItems"/> has unsaved changes.
        /// </summary>
        [JsonIgnore]
        public bool HasUnsavedSearchItems { get; private set; }

        /// <summary>
        /// Gets a value indicating whether <see cref="Paths"/> has unsaved changes.
        /// </summary>
        [JsonIgnore]
        public bool HasUnsavedPaths { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the <see cref="Project"/> has unsaved changes.
        /// </summary>
        /// <returns>A value indicating whether the <see cref="Project"/> has unsaved changes.</returns>
        public bool HasUnsavedChanges()
        {
            return !IsEmpty()
                && (HasUnsavedPaths
                || HasUnsavedSearchItems
                || HasUnsavedSearchPatterns);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is Project project)
            {
                return FileName == project.FileName
                    && UnsavedSearchPatterns(project)
                    && UnsavedSearchItems(project)
                    && UnsavedPaths(project);
            }

            return false;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            var hashCode = -1631017868;
            hashCode = (hashCode * -1521134295) + EqualityComparer<List<string>>.Default.GetHashCode(SearchPatterns);
            hashCode = (hashCode * -1521134295) + EqualityComparer<List<SearchItem>>.Default.GetHashCode(SearchItems);
            hashCode = (hashCode * -1521134295) + EqualityComparer<List<PathInformation>>.Default.GetHashCode(Paths);
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(FileName);
            return hashCode;
        }

        /// <summary>
        /// Call this method to indicate that this <see cref="Project"/> has been saved to disk.
        /// The call to this method will update the value of the following properties to False:
        /// <see cref="HasUnsavedSearchPatterns"/>, <see cref="HasUnsavedSearchItems"/> and <see cref="HasUnsavedPaths"/>.
        /// </summary>
        public void ChangesSavedToDisk()
        {
            HasUnsavedSearchPatterns = false;
            HasUnsavedSearchItems = false;
            HasUnsavedPaths = false;
        }

        /// <summary>
        /// Gets a value that indicates whether the project is empty.
        /// </summary>
        /// <returns>A value indicating whether the project is empty.</returns>
        public bool IsEmpty()
        {
            return FileName == null
                && SearchPatterns.Count == 0
                && SearchItems.Count == 0
                && Paths.Count == 0;
        }

        /// <summary>
        /// Updates the current <see cref="Project"/> with the information contained in the <see cref="Project"/> in the parameter.
        /// The call to this method also updates the value of the following properties:
        /// <see cref="HasUnsavedSearchPatterns"/>, <see cref="HasUnsavedSearchItems"/> and <see cref="HasUnsavedPaths"/>.
        /// </summary>
        /// <param name="project"><see cref="Project"/> from where the new information is going to be retrieved.</param>
        public void Update(Project project)
        {
            if (!HasUnsavedSearchPatterns)
            {
                HasUnsavedSearchPatterns = UnsavedSearchPatterns(project);
            }

            if (!HasUnsavedSearchItems)
            {
                HasUnsavedSearchItems = UnsavedSearchItems(project);
            }

            if (!HasUnsavedPaths)
            {
                HasUnsavedPaths = UnsavedPaths(project);
            }

            SearchPatterns.Clear();
            SearchItems.Clear();
            Paths.Clear();

            SearchPatterns.AddRange(project.SearchPatterns);
            SearchItems.AddRange(project.SearchItems);
            Paths.AddRange(project.Paths);
            FileName = project.FileName;
        }

        private bool UnsavedPaths(Project project)
        {
            return !(Paths.Count == project.Paths.Count
                && Paths.Except(project.Paths).Count() == 0
                && project.Paths.Except(Paths).Count() == 0);
        }

        private bool UnsavedSearchItems(Project project)
        {
            return !(SearchItems.Count == project.SearchItems.Count
                && SearchItems.Except(project.SearchItems).Count() == 0
                && project.SearchItems.Except(SearchItems).Count() == 0);
        }

        private bool UnsavedSearchPatterns(Project project)
        {
            return !(SearchPatterns.Count == project.SearchPatterns.Count
                && SearchPatterns.Except(project.SearchPatterns).Count() == 0
                && project.SearchPatterns.Except(SearchPatterns).Count() == 0);
        }
    }
}
