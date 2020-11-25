using Syncfusion.XForms.RichTextEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FBLASocialApp.Views.NewPost
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPostPage : ContentPage
    {
        public NewPostPage()
        {
            InitializeComponent();

            rte.ToolbarOptions = ToolbarOptions.Bold | ToolbarOptions.Hyperlink;
        }
    }
}