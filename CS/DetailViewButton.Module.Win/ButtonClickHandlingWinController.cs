using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Layout;
using System.Windows.Forms;

namespace DetailViewButton.Module.Win {
    public partial class ButtonClickHandlingWinController : ViewController {
        public ButtonClickHandlingWinController() {            
            TargetViewId = "Person_DetailView";
            ViewControlsCreated += new EventHandler(ButtonClickHandlingWinController_ViewControlsCreated);
        }
        void ButtonClickHandlingWinController_ViewControlsCreated(object sender, EventArgs e) {
            DetailView view = (DetailView)View;
            foreach(ControlDetailItem item in view.GetItems<ControlDetailItem>()) {
                if(item.Id == "MyButton One") {
                    (item.Control as Button).Text = "MyButton One";
                    (item.Control as Button).Click += new EventHandler(ButtonClickHandlingWinController_Click);
                    break;
                }
            }
        }
        void ButtonClickHandlingWinController_Click(object sender, EventArgs e) {
            //Perform the required actions here
        }
    }
}
