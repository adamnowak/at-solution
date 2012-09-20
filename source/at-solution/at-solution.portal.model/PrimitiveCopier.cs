
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

namespace at_solution.portal.primitive
{
    public static class GetPrimitiveCopier 
    {
        public static ArticlePrimitive GetPrimitiveCopy(this ArticlePrimitive primitiveToCopy)
        {
        		if (primitiveToCopy == null) return null;
        
        		ArticlePrimitive primitive = new ArticlePrimitive(); 
        
        		primitive.Id = primitiveToCopy.Id;
        		
        		primitive.User_Id = primitiveToCopy.User_Id;
        		
        		primitive.Title = primitiveToCopy.Title;
        		
        		primitive.Info = primitiveToCopy.Info;
        		
        		primitive.FullText = primitiveToCopy.FullText;
        		
        		primitive.CreateTime = primitiveToCopy.CreateTime;
        		
        		primitive.DeleteTime = primitiveToCopy.DeleteTime;
        		
        		primitive.Position = primitiveToCopy.Position;
        		
        		return primitive;
        }
        
        public static ForumItemPrimitive GetPrimitiveCopy(this ForumItemPrimitive primitiveToCopy)
        {
        		if (primitiveToCopy == null) return null;
        
        		ForumItemPrimitive primitive = new ForumItemPrimitive(); 
        
        		primitive.Id = primitiveToCopy.Id;
        		
        		primitive.Article_Id = primitiveToCopy.Article_Id;
        		
        		primitive.Text = primitiveToCopy.Text;
        		
        		primitive.User_Id = primitiveToCopy.User_Id;
        		
        		primitive.CreateTime = primitiveToCopy.CreateTime;
        		
        		primitive.DeleteTime = primitiveToCopy.DeleteTime;
        		
        		return primitive;
        }
        
        public static RolePrimitive GetPrimitiveCopy(this RolePrimitive primitiveToCopy)
        {
        		if (primitiveToCopy == null) return null;
        
        		RolePrimitive primitive = new RolePrimitive(); 
        
        		primitive.Id = primitiveToCopy.Id;
        		
        		primitive.Name = primitiveToCopy.Name;
        		
        		primitive.CreateTime = primitiveToCopy.CreateTime;
        		
        		primitive.DeleteTime = primitiveToCopy.DeleteTime;
        		
        		return primitive;
        }
        
        public static SectionPrimitive GetPrimitiveCopy(this SectionPrimitive primitiveToCopy)
        {
        		if (primitiveToCopy == null) return null;
        
        		SectionPrimitive primitive = new SectionPrimitive(); 
        
        		primitive.Id = primitiveToCopy.Id;
        		
        		primitive.Parent_Id = primitiveToCopy.Parent_Id;
        		
        		primitive.Name = primitiveToCopy.Name;
        		
        		primitive.Position = primitiveToCopy.Position;
        		
        		primitive.CreateTime = primitiveToCopy.CreateTime;
        		
        		primitive.DeleteTime = primitiveToCopy.DeleteTime;
        		
        		return primitive;
        }
        
        public static UserPrimitive GetPrimitiveCopy(this UserPrimitive primitiveToCopy)
        {
        		if (primitiveToCopy == null) return null;
        
        		UserPrimitive primitive = new UserPrimitive(); 
        
        		primitive.Id = primitiveToCopy.Id;
        		
        		primitive.Nick = primitiveToCopy.Nick;
        		
        		primitive.Name = primitiveToCopy.Name;
        		
        		primitive.Surname = primitiveToCopy.Surname;
        		
        		primitive.Email = primitiveToCopy.Email;
        		
        		primitive.Password = primitiveToCopy.Password;
        		
        		primitive.PasswordSalz = primitiveToCopy.PasswordSalz;
        		
        		primitive.Phone = primitiveToCopy.Phone;
        		
        		primitive.CreateTime = primitiveToCopy.CreateTime;
        		
        		primitive.DeleteTime = primitiveToCopy.DeleteTime;
        		
        		return primitive;
        }
        
    }
}