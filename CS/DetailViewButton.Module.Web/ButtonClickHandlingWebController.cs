using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Web.Editors.ASPx;

namespace DetailViewButton.Module.Web {
    public partial class ButtonClickHandlingWebController : ViewController {
        public ButtonClickHandlingWebController() {
            TargetViewId = "Person_DetailView";
            ViewControlsCreated += new EventHandler(ButtonClickHandlingWebController_ViewControlsCreated);
        }
        void ButtonClickHandlingWebController_ViewControlsCreated(object sender, EventArgs e) {
            DetailView view = (DetailView)View;
            foreach(ControlDetailItem item in view.GetItems<ControlDetailItem>()) {
                if(item.Id == "MyButton One") {
                    (item.Control as ASPxButtonEx).Text = "MyButton One";
                    (item.Control as ASPxButtonEx).Click += new EventHandler(ButtonClickHandlingWebController_Click);
                    break;
                }
            }
        }
        void ButtonClickHandlingWebController_Click(object sender, EventArgs e) {
            // Perform the required actions on the server side.
        }
    }
}
