using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using System.Windows.Forms;

namespace DetailViewButton.Module.Win {    
    public class ButtonDetailViewItemWin : DetailViewItem {         
        public ButtonDetailViewItemWin(string id, string caption) : base(id) { }      
        public ButtonDetailViewItemWin(string id) : this(id, null) { }
        public ButtonDetailViewItemWin(Type objectType, DictionaryNode info) : base(objectType, info) { }      
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
