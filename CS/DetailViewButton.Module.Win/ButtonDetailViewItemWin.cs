using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using System.Windows.Forms;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Layout;

namespace DetailViewButton.Module.Win {
    public interface IModelButtonDetailViewItemWin : IModelViewItem { }

    [ViewItemAttribute(typeof(IModelButtonDetailViewItemWin))]
    public class ButtonDetailViewItemWin : ViewItem
    {         
        public ButtonDetailViewItemWin(IModelViewItem model, Type objectType)
			: base(objectType, model.Id) {
			CreateControl();
		}

        protected override object CreateControlCore() {         
            Button button = new Button();
            button.Text = "MyButton Two";
            button.Click += new EventHandler(button_Click);         
            return button;      
        }      
        void button_Click(object sender, EventArgs e) {        
            //Perform the required actions here
        }    
    }
}
