using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.ExpressApp.Editors;
using System.Web.UI.WebControls;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Web.Editors.ASPx;
using DevExpress.Web.ASPxEditors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Layout;

namespace WebSolution.Module.Web {
    public interface IModelButtonDetailViewItemWeb : IModelDetailViewItem { }
    [DetailViewItemAttribute(typeof(IModelButtonDetailViewItemWeb))]
    public class ButtonDetailViewItemWeb : ViewItem {
        public ButtonDetailViewItemWeb(IModelDetailViewItem model, Type objectType)
			: base(objectType, model.Id) {
			CreateControl();
		}
        protected override object CreateControlCore()
        {
            ASPxButton button = new ASPxButton();
            button.Text = "MyButton Two";
            button.EnableClientSideAPI = true;
            button.Click += new EventHandler(button_Click);                        
            return button;
        }
        void button_Click(object sender, EventArgs e) {
            // Perform the required actions on the server side.
        }
    }
}
