using System.Data.Entity;

namespace WizardTestBed.Data
{
    /// <summary>
    /// This class inherits from CreateDatabaseIfNotExists class which 
    /// creates the database only if it doesn't exists. It also overrides 
    /// the Seed method. 
    /// </summary>
    public class DbInitializer : CreateDatabaseIfNotExists<EfContext>
    {
        protected override void Seed(EfContext context)
        {
            //using (var ctx = new EfContext())
            //{
                // var repository = new Repository(ctx);

                #region Organisation data

                //var orgA = new Organisation()
                //{
                //    Vision = "Org A vision",
                //    Mission = "Org A mission",
                //    WomensRightsIssuesId = 1,
                //    YearFormed = "1996",
                //    Founder = "Org A founder",
                //    ReasonFormed = "Org A formation reason",
                //    OperationalLocationId = 1,
                //    OperationalAreaId = 1,
                //    Achievements = "Org A achievements",
                //    InsertedDateTime = DateTime.Now,
                //    ModifiedDateTime = DateTime.Now
                //};

                //var orgB = new Organisation()
                //{
                //    Vision = "Org B vision",
                //    Mission = "Org B mission",
                //    WomensRightsIssuesId = 2,
                //    YearFormed = "1995",
                //    Founder = "Org B founder",
                //    ReasonFormed = "Org B formation reason",
                //    OperationalLocationId = 2,
                //    OperationalAreaId = 2,
                //    Achievements = "Org B achievements",
                //    InsertedDateTime = DateTime.Now,
                //    ModifiedDateTime = DateTime.Now
                //};

                //repository.Insert(orgA);
                //repository.Insert(orgB);

                #endregion

                #region Administration

                // create administration seed data here

                #endregion

                #region Structure

                // create structure seed data here

                #endregion

                // save the changes above ^
                // ctx.SaveChanges();
            //}
        }
    }
}
