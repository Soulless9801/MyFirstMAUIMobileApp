using MyFirstMAUIMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public class LayoutsViewModel : BaseViewModel
    {
        public string StackLayout { get; set; } = TitleLayouts.StackLayout;

        public string VerticalLayout { get; set; } = TitleLayouts.VerticalLayout;

        public string HorizontalLayout { get; set; } = TitleLayouts.HorizontalLayout;

        public string AbsoluteLayout { get; set; } = TitleLayouts.AbsoluteLayout;

        public LayoutsViewModel()
        {
            Title = TitleLayouts.Title;
        }
    }
}
