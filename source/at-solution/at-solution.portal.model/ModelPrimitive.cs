
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;


namespace at_solution.portal.primitive
{
    public interface IPrimitive
    {
        int Id { get; set; }
        Nullable<System.DateTime> CreateTime { get; set; }
        Nullable<System.DateTime> DeleteTime { get; set; }
        bool IsNew { get; }
        bool IsDeleted { get; }    
    }
        
    public abstract class PrimitiveBase : IPrimitive
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> DeleteTime { get; set; }
        public bool IsNew
        {
            get { return Id <= 0; }            
        }
        public bool IsDeleted
        {
          get { return DeleteTime != null && DeleteTime.HasValue; }
        }    
    }
}