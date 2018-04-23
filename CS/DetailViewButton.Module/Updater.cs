using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

namespace DetailViewButton.Module {
    public class Updater : ModuleUpdater {
        public Updater(Session session, Version currentDBVersion) : base(session, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();

            Person testPerson = Session.FindObject<Person>(CriteriaOperator.Parse("FirstName == 'Sam'"));
            if(testPerson == null) {
                testPerson = new Person(Session);
                testPerson.FirstName = "Sam";
                testPerson.Save();
            }
        }
    }
}
