using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using at_solution.portal.primitive;

namespace at_solution.portal.services.interfaces
{
  public interface IArticlesService
  {
    /// <summary>
    /// Adds the article to defined section.
    /// </summary>
    /// <param name="articlePrimitive">The article primitive.</param>
    /// <param name="sectionPrimitive">The section primitive.</param>
    ArticlePrimitive CreateOrUpdateArticle(ArticlePrimitive articlePrimitive, SectionPrimitive sectionPrimitive);

    /// <summary>
    /// Adds the forum item to defined article.
    /// </summary>
    /// <param name="forumItemPrimitive">The forum item primitive.</param>
    /// <param name="articlePrimitive">The article primitive.</param>
    ForumItemPrimitive CreateOrUpdateForumItem(ForumItemPrimitive forumItemPrimitive, ArticlePrimitive articlePrimitive);

    /// <summary>
    /// Deletes the forum item.
    /// </summary>
    /// <param name="forumItemPrimitive">The forum item primitive.</param>
    void DeleteForumItem(ForumItemPrimitive forumItemPrimitive);

  }
}
