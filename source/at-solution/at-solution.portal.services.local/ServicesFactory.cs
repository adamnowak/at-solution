using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using at_solution.portal.entities;
using at_solution.portal.services.interfaces;
using at_solution.portal.primitive;

namespace at_solution.portal.services.local
{
  public class ServicesFactory : IServicesFactory
  {
    public IArticlesService GetArticlesSerivce()
    {
      return new ArticlesService();
    }

    public ISectionsService GetSectionService()
    {
      return new SectionsService();
    }
  }
}
