using Playground.Models;

namespace Playground.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.EfContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.EfContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. 

            context.Country.AddOrUpdate(
                new Country() { Description = "Algeria", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now},
                new Country() { Description = "Angola", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Benin", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Botswana", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Burkina Faso", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Burundi", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Cabo Verde", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Cameroon", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Central African Republic", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Chad", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Comoros", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Congo", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Côte d’Ivoire", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "DR Congo", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Djibouti", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Egypt", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Equatorial Guinea", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Eritrea", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Ethiopia", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Gabon", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Gambia", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Ghana", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Guinea", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Guinea Bissau", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Kenya", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Lesotho", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Liberia", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Libya", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Madagascar", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Malawi", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Mali", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Mauritania", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Mauritius", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Morocco", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Mozambique", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Namibia", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Niger", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Nigeria", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Rwanda", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Sahrawi Republic", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "São Tomé and Príncipe", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Senegal", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Seychelles", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Sierra Leone", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Somalia", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "South Africa", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "South Sudan", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Sudan", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Swaziland", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Togo", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Tunisia", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Uganda", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "UR of Tanzania", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Zambia", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new Country() { Description = "Zimbabwe", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now }
            );

            context.WomensRightsIssue.AddOrUpdate(
                new WomensRightsIssue() { Description = "Violence against women", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new WomensRightsIssue() { Description = "Economic security and justice", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new WomensRightsIssue() { Description = "Climate change and environmental justice", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new WomensRightsIssue() { Description = "Women''s health - HIV and AIDS)", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new WomensRightsIssue() { Description = "Women''s health - Sexual and reproductive rights)", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new WomensRightsIssue() { Description = "Women''s health - Cancers and other non-communicable diseases)", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new WomensRightsIssue() { Description = "Governance, peace and security", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new WomensRightsIssue() { Description = "Yound women''s leadership", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new WomensRightsIssue() { Description = "Arts, culture and sports", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new WomensRightsIssue() { Description = "Women and technology", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new WomensRightsIssue() { Description = "Other", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now }
            );

            context.OperationalArea.AddOrUpdate(
                new OperationalArea() { Description = "Northern Africa", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new OperationalArea() { Description = "Eastern Africa", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new OperationalArea() { Description = "Central Africa", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new OperationalArea() { Description = "Western Africa", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new OperationalArea() { Description = "Southern Africa", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now }
            );

            context.LearntAbout.AddOrUpdate(
                new LearntAbout() { Description = "Internet", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new LearntAbout() { Description = "AWDF website", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new LearntAbout() { Description = "AWDF grantee", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new LearntAbout() { Description = "AWDF partner", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new LearntAbout() { Description = "AWDF staff member", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new LearntAbout() { Description = "AWDF board member or advisor", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new LearntAbout() { Description = "Another civil society organisation", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new LearntAbout() { Description = "Donor", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new LearntAbout() { Description = "Email announcement", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new LearntAbout() { Description = "Via call for applications", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now },
                new LearntAbout() { Description = "Other (please specify)", InsertedBy = "Administrator", InsertedDateTime = DateTime.Now, ModifiedBy = "Administrator", ModifiedDateTime = DateTime.Now }
            );
        }
    }
}