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
  public class ArticlesService : IArticlesService
  {
    public ArticlePrimitive CreateOrUpdateArticle(ArticlePrimitive articlePrimitive, SectionPrimitive sectionPrimitive)
    {
      try
      {
        using (AtSolutionEntities context = new AtSolutionEntities())
        {
          Article entity = articlePrimitive.GetEntity();

          Article existingEntity = context.Articles.Where(x => x.Id == articlePrimitive.Id).FirstOrDefault();

          //no record of this item in the DB, item being passed in has a PK
          if (existingEntity == null && entity.Id > 0)
          {
            throw new FaultException<ExceptionDetail>(new ExceptionDetail(new Exception("Błąd zapisu do bazy")),
                                                        "Obiekt nie istniał w bazie, a jego Id jest większe od 0.");
          }
          //Item has no PK value, must be new
          else if (entity.Id <= 0)
          {
            context.Articles.AddObject(entity);
          }
          //Item was retrieved, and the item passed has a valid ID, do an update
          else
          {
            context.Articles.ApplyCurrentValues(entity);
          }

          context.SaveChanges();
          return entity;
        }
      }
      catch (Exception e)
      {
        throw new FaultException<ExceptionDetail>(new ExceptionDetail(e), e.Message);
      }
    }

    public ForumItemPrimitive CreateOrUpdateForumItem(ForumItemPrimitive forumItemPrimitive, ArticlePrimitive articlePrimitive)
    {
      throw new NotImplementedException();
    }

    public void DeleteForumItem(ForumItemPrimitive forumItemPrimitive)
    {
      throw new NotImplementedException();
    }
  }
}
