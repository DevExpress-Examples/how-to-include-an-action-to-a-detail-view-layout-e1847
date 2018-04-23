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
using DevExpress.Web.ASPxEditors;

namespace DetailViewButton.Module.Web {
    public partial class ButtonClickHandlingWebController : ViewController {
        public ButtonClickHandlingWebController() {
            TargetViewId = "Person_DetailView";
            ViewControlsCreated += new EventHandler(ButtonClickHandlingWebController_ViewControlsCreated);
        }
        void ButtonClickHandlingWebController_ViewControlsCreated(object sender, EventArgs e) {
            DetailView view = (DetailView)View;
            foreach(ControlDetailItem item in view.GetItems<ControlDetailItem>()) {
                if ((item.Id == "MyButton One") ) {
                    item.ControlCreated += new EventHandler<EventArgs>(item_ControlCreated);
                    if (item.Control != null) {
                        ((ASPxButton)item.Control).Text = "MyButton One";
                    }
                }
            }
        }

        void item_ControlCreated(object sender, EventArgs e) {
            ((ASPxButton)((ControlDetailItem)sender).Control).Text = "MyButton One";
            ((ASPxButton)((ControlDetailItem)sender).Control).Click += new EventHandler(ButtonClickHandlingWebController_Click);
            ((ControlDetailItem)sender).ControlCreated -= new EventHandler<EventArgs>(item_ControlCreated);
        }
        void ButtonClickHandlingWebController_Click(object sender, EventArgs e) {
            // Perform the required actions on the server side.
            ((ASPxButton)sender).Click -= new EventHandler(ButtonClickHandlingWebController_Click);
        }
        protected override void OnDeactivated() {
            ViewControlsCreated -= new EventHandler(ButtonClickHandlingWebController_ViewControlsCreated);
            base.OnDeactivated();
        }
    }
}
