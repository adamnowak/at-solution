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
using at_solution.portal.primitive;

namespace at_solution.portal.entities
{
    public partial class Section : SectionPrimitive
    {
        #region Primitive Properties
    		public override Nullable<int> Parent_Id
    		{
            get { return _parent_Id; }
            set
            {        
                try
                {
                    _settingFK = true;
                    if (_parent_Id != value)
                    {
                        if (Section_Parent != null && Section_Parent.Id != value)
                        {
                            Section_Parent = null;
                        }
                        _parent_Id = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
    		}
    		private Nullable<int> _parent_Id;    
    

        #endregion
        #region Navigation Properties
    
        public ICollection<Section> Sections_Children
        {
            get
            {
                if (_sections_Children == null)
                {
                    var newCollection = new FixupCollection<Section>();
                    newCollection.CollectionChanged += FixupSections_Children;
                    _sections_Children = newCollection;
                }
                return _sections_Children;
            }
            set
            {
                if (!ReferenceEquals(_sections_Children, value))
                {
                    var previousValue = _sections_Children as FixupCollection<Section>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupSections_Children;
                    }
                    _sections_Children = value;
                    var newValue = value as FixupCollection<Section>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupSections_Children;
                    }
                }
            }
        }
        private ICollection<Section> _sections_Children;
    
        public Section Section_Parent
        {
            get { return _section_Parent; }
            set
            {
                if (!ReferenceEquals(_section_Parent, value))
                {
                    var previousValue = _section_Parent;
                    _section_Parent = value;
                    FixupSection_Parent(previousValue);
                }
            }
        }
        private Section _section_Parent;
    
        public ICollection<Article> Articles
        {
            get
            {
                if (_articles == null)
                {
                    var newCollection = new FixupCollection<Article>();
                    newCollection.CollectionChanged += FixupArticles;
                    _articles = newCollection;
                }
                return _articles;
            }
            set
            {
                if (!ReferenceEquals(_articles, value))
                {
                    var previousValue = _articles as FixupCollection<Article>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupArticles;
                    }
                    _articles = value;
                    var newValue = value as FixupCollection<Article>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupArticles;
                    }
                }
            }
        }
        private ICollection<Article> _articles;

        #endregion
        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupSection_Parent(Section previousValue)
        {
            if (previousValue != null && previousValue.Sections_Children.Contains(this))
            {
                previousValue.Sections_Children.Remove(this);
            }
    
            if (Section_Parent != null)
            {
                if (!Section_Parent.Sections_Children.Contains(this))
                {
                    Section_Parent.Sections_Children.Add(this);
                }
                if (Parent_Id != Section_Parent.Id)
                {
                    Parent_Id = Section_Parent.Id;
                }
            }
            else if (!_settingFK)
            {
                Parent_Id = null;
            }
        }
    
        private void FixupSections_Children(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Section item in e.NewItems)
                {
                    item.Section_Parent = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Section item in e.OldItems)
                {
                    if (ReferenceEquals(item.Section_Parent, this))
                    {
                        item.Section_Parent = null;
                    }
                }
            }
        }
    
        private void FixupArticles(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Article item in e.NewItems)
                {
                    if (!item.Sections.Contains(this))
                    {
                        item.Sections.Add(this);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Article item in e.OldItems)
                {
                    if (item.Sections.Contains(this))
                    {
                        item.Sections.Remove(this);
                    }
                }
            }
        }

        #endregion
    }
}
