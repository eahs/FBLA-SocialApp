using Xamarin.Forms.Internals;

namespace FBLASocialApp.Controls
{
    /// <summary>
    /// This class extends the behavior of the SearchableListView control to filter the ListViewItem based on text.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class SearchableArticleList : SearchableListView
    {
        #region Method 

        /// <summary>
        /// Filtering the list view items based on the search text.
        /// </summary>
        /// <param name="obj">The list view item</param>
        /// <returns>Returns the filtered item</returns>
        public override bool FilterContacts(object obj)
        {
            if (base.FilterContacts(obj))
            {
                var taskInfo = obj as SocialApi.Models.Post;
                if (taskInfo == null || string.IsNullOrEmpty(taskInfo.Title) || string.IsNullOrEmpty(taskInfo.Author.FullName))
                {
                    return false;
                }
                return taskInfo.Title.ToUpperInvariant().Contains(this.SearchText.ToUpperInvariant())
                       || taskInfo.Author.FullName.ToUpperInvariant().Contains(this.SearchText.ToUpperInvariant());
            }
            return false;
        }

        #endregion
    }
}
