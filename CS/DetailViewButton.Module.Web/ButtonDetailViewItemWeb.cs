using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.ExpressApp.Editors;
using System.Web.UI.WebControls;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Web.Editors.ASPx;

namespace WebSolution.Module.Web {
    public class ButtonDetailViewItemWeb : DetailViewItem {
        public ButtonDetailViewItemWeb(string id, string caption) : base(id) { }
        public ButtonDetailViewItemWeb(string id) : this(id, null) { }
        public ButtonDetailViewItemWeb(Type objectType, DictionaryNode info) : base(objectType, info) { }
        protected override object CreateControlCore() {
            ASPxButtonEx button = new ASPxButtonEx();            
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
