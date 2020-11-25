using Syncfusion.TreeView.Engine;
using Syncfusion.XForms.TreeView;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TreeViewXamarin.Helper
{
    public class Behavior : Behavior<ContentPage>
    {
        #region Fields

        SfTreeView TreeView;
        Button AddButton;
        Button DeleteButton;
        #endregion

        #region Overrides

        protected override void OnAttachedTo(ContentPage bindable)
        {
            TreeView = bindable.FindByName<SfTreeView>("treeView");
            AddButton = bindable.FindByName<Button>("addButton");
            DeleteButton = bindable.FindByName<Button>("deleteButton");

            AddButton.Clicked += AddButton_Clicked;
            DeleteButton.Clicked += DeleteButton_Clicked;

            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            AddButton.Clicked -= AddButton_Clicked;
            DeleteButton.Clicked -= DeleteButton_Clicked;
            AddButton = null;
            DeleteButton = null;
            TreeView = null;
            base.OnDetachingFrom(bindable);
        }
        #endregion

        #region Call back

        private void AddButton_Clicked(object sender, EventArgs e)
        {
            var india = new TreeViewNode() { Content = "India" };
            var delhi = new TreeViewNode() { Content = "Delhi" };
            var newDelhi = new TreeViewNode() { Content = "New Delhi" };
            delhi.ChildNodes.Add(newDelhi);
            var tamilNadu = new TreeViewNode() { Content = "Tamil Nadu" };
            var chennai = new TreeViewNode() { Content = "Chennai" };
            india.ChildNodes.Add(delhi);
            india.ChildNodes.Add(tamilNadu);
            tamilNadu.ChildNodes.Add(chennai);

            TreeView.Nodes.Add(india);
        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            TreeView.Nodes.RemoveAt(1);
        }

        #endregion
    }
}
