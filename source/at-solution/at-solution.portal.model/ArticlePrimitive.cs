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
    //[MetadataType(typeof(ArticleMetaData))]
    public partial class ArticlePrimitive : PrimitiveBase
    {
        #region Primitive Properties
    		public virtual Nullable<int> User_Id
    		{
    			get;
    			set;
    		}
    		public string Title
    		{
            get;
            set;
    		}
    		public string Info
    		{
            get;
            set;
    		}
    		public string FullText
    		{
            get;
            set;
    		}
    		public Nullable<System.DateTime> CreateTime
    		{
            get;
            set;
    		}
    		public Nullable<System.DateTime> DeleteTime
    		{
            get;
            set;
    		}
    		public Nullable<int> Position
    		{
            get;
            set;
    		}

        #endregion
    }
    
}
