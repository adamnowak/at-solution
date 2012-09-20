using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using at_solution.portal.primitive;

namespace at_solution.portal.services.interfaces
{
  public interface IServicesFactory
  {
    IArticlesService GetArticlesSerivce();
    ISectionsService GetSectionService();
  }
}
