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
  public class SectionsService : ISectionsService
  {
    public IEnumerable<SectionPrimitive> GetSections()
    {
      try
      {
        using (AtSolutionEntities context = new AtSolutionEntities())
        {
          return context.Sections.ToList().Select(x => x.GetPrimitive());
        }
      }
      catch (Exception e)
      {
        throw new FaultException<ExceptionDetail>(new ExceptionDetail(e), e.Message);
      }
    }

    public SectionPrimitive CreateOrUpdateSection(SectionPrimitive sectionPrimitive)
    {
      try
      {
        using (AtSolutionEntities context = new AtSolutionEntities())
        {
          Section entity = sectionPrimitive.GetEntity();

          Section existingEntity = context.Sections.Where(x => x.Id == sectionPrimitive.Id).FirstOrDefault();

          //no record of this item in the DB, item being passed in has a PK
          if (existingEntity == null && entity.Id > 0)
          {
            throw new FaultException<ExceptionDetail>(new ExceptionDetail(new Exception("Błąd zapisu do bazy")),
                                                        "Obiekt nie istniał w bazie, a jego Id jest większe od 0.");
          }
          //Item has no PK value, must be new
          else if (entity.Id <= 0)
          {
            context.Sections.AddObject(entity);
          }
          //Item was retrieved, and the item passed has a valid ID, do an update
          else
          {
            context.Sections.ApplyCurrentValues(entity);
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

    public void DeleteSection(SectionPrimitive sectionPrimitive)
    {
      throw new NotImplementedException();
    }

    public SectionPrimitive GetSection(int id)
    {
      try
      {
        using (AtSolutionEntities context = new AtSolutionEntities())
        {
          var result = context.Sections.Where(x => x.Id == id).FirstOrDefault();
          if (result != null)
            return result.GetPrimitive();
          else
            return null;
        }
      }
      catch (Exception e)
      {
        throw new FaultException<ExceptionDetail>(new ExceptionDetail(e), e.Message);
      }
    }
  }
}
