using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.Persistent.BaseImpl;

namespace DetailViewButton.Module {
    public class Updater : ModuleUpdater {
        public Updater(ObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();

            Person testPerson = ObjectSpace.FindObject<Person>(CriteriaOperator.Parse("FirstName == 'Sam'"));
            if(testPerson == null) {
                testPerson = ObjectSpace.CreateObject<Person>();
                testPerson.FirstName = "Sam";
                testPerson.Save();
            }
        }
    }
}
