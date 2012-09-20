using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using at_solution.portal.primitive;
using at_solution.portal.services.interfaces;
using at_solution.portal.services.local;

namespace at_solution.portal.webgui.Controllers
{
    public class SectionController : Controller
    {
      IServicesFactory _servicesFacotry = new ServicesFactory();
        

        public ActionResult Index()
        {
          var sections = _servicesFacotry.GetSectionService().GetSections();
          return View(sections);
        }

        /// <summary>
        /// Creates subsection for section defined by id.
        /// </summary>
        /// <param name="id">The id of section</param>
        /// <returns></returns>
        /// <remarks>If id is null then this is one of main sections.</remarks>
        public ActionResult Create(int? id)
        {
          ViewBag.SectionId = id;
          return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(int? id, SectionPrimitive section)
        {
          ViewBag.SectionId = id;          
          section.Parent_Id = id;
          _servicesFacotry.GetSectionService().CreateOrUpdateSection(section);
          return View(section);
        }

        public ActionResult Edit(int id)
        {
          var section = _servicesFacotry.GetSectionService().GetSection(id);
          ViewBag.SectionId = section.Parent_Id;
          return View(section);
        }

        [HttpPost]
        public ActionResult Edit(SectionPrimitive section)
        {
          if (ModelState.IsValid)
          {
            ViewBag.SectionId = section.Parent_Id;
            _servicesFacotry.GetSectionService().CreateOrUpdateSection(section);
          }
          return View(section);
        }

        
        

    }
}
