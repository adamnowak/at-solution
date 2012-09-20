using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using at_solution.portal.primitive;

namespace at_solution.portal.services.interfaces
{
  public interface ISectionsService
  {
    /// <summary>
    /// Gets all sections.
    /// </summary>
    /// <returns>All sections</returns>
    IEnumerable<SectionPrimitive> GetSections();

    /// <summary>
    /// Creates or update section.
    /// </summary>
    /// <param name="sectionPrimitive">The section created.</param>
    /// <returns>Created or updated section.</returns>
    SectionPrimitive CreateOrUpdateSection(SectionPrimitive sectionPrimitive);

    /// <summary>
    /// Deletes section.
    /// </summary>
    /// <param name="sectionPrimitive">The section which will be deleted.</param>
    /// <remarks>All articles from this section will be moved to parent section.</remarks>
    void DeleteSection(SectionPrimitive sectionPrimitive);

    /// <summary>
    /// Gets the section defined by id.
    /// </summary>
    /// <param name="id">The id.</param>
    /// <returns>
    /// Section defined by id or null.
    /// </returns>
    SectionPrimitive GetSection(int id);
  }
}
