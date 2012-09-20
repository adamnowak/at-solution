//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.EntityClient;
using at_solution.portal.entities;

namespace at_solution.portal.services.local
{
    public partial class AtSolutionEntities : ObjectContext
    {
        public const string ConnectionString = "name=AtSolutionEntities";
        public const string ContainerName = "AtSolutionEntities";
    
        #region Constructors
    
        public AtSolutionEntities()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public AtSolutionEntities(string connectionString)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public AtSolutionEntities(EntityConnection connection)
            : base(connection, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<ForumItem> ForumItems
        {
            get { return _forumItems  ?? (_forumItems = CreateObjectSet<ForumItem>("ForumItems")); }
        }
        private ObjectSet<ForumItem> _forumItems;
    
        public ObjectSet<Role> Roles
        {
            get { return _roles  ?? (_roles = CreateObjectSet<Role>("Roles")); }
        }
        private ObjectSet<Role> _roles;
    
        public ObjectSet<User> Users
        {
            get { return _users  ?? (_users = CreateObjectSet<User>("Users")); }
        }
        private ObjectSet<User> _users;
    
        public ObjectSet<Article> Articles
        {
            get { return _articles  ?? (_articles = CreateObjectSet<Article>("Articles")); }
        }
        private ObjectSet<Article> _articles;
    
        public ObjectSet<Section> Sections
        {
            get { return _sections  ?? (_sections = CreateObjectSet<Section>("Sections")); }
        }
        private ObjectSet<Section> _sections;

        #endregion
    }
}
