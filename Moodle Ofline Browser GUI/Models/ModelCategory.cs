using Moodle_Ofline_Browser_GUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.Models
{
    public class ModelCategory : INotifyPropertyChanged, ICoreCategory
    {
        public ModelCategory()
        {
            SubCategories = new ObservableCollection<ModelCategory>();
            FieldInfo = null;
            CategoryName = "";
            IsSelected = false;
            IsExpanded = false;
            ParentCategory = null;
        }
        public ModelCategory(ModelCategory modelCategory)
        {
            this.SubCategories = modelCategory.SubCategories;
            this.FieldInfo = modelCategory.FieldInfo;
            this.IsExpanded = modelCategory.IsExpanded;
            this.IsSelected = modelCategory.IsSelected;
            this.ParentCategory = modelCategory.ParentCategory;
            this.CategoryName = modelCategory.CategoryName;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        protected string categoryName;
        public string CategoryName
        {
            get
            {
                return this.categoryName;
            }
            set
            {
                if (value != this.categoryName)
                {
                    this.categoryName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        protected ModelCategory parentCategory;
        public ModelCategory ParentCategory
        {
            get
            {
                return this.parentCategory;
            }
            set
            {
                if (value != this.parentCategory)
                {
                    this.parentCategory = value;
                    NotifyPropertyChanged();
                }
            }
        }


        protected bool isSelected;
        public bool IsSelected
        {
            get
            {
                return this.isSelected;
            }
            set
            {
                if (value != this.isSelected)
                {
                    this.isSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }
        protected bool isExpanded;
        public bool IsExpanded
        {
            get
            {
                return this.isExpanded;
            }
            set
            {
                if (value != this.isExpanded)
                {
                    this.isExpanded = value;
                    NotifyPropertyChanged();
                }
            }
        }

        protected FieldInfo fieldInfo;
        public FieldInfo FieldInfo
        {
            get
            {
                return this.fieldInfo;
            }
            set
            {
                if (value != this.fieldInfo)
                {
                    this.fieldInfo = value;
                    NotifyPropertyChanged();
                }
            }
        }

        protected ObservableCollection<ModelCategory> subCategories;
        public ObservableCollection<ModelCategory> SubCategories
        {
            get
            {
                return this.subCategories;
            }
            set
            {
                if (value != this.subCategories)
                {
                    this.subCategories = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
