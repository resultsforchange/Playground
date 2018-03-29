using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WizardWebTester.Models;

namespace WizardWebTester.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("OrganisationData");
        }

        [HttpPost]
        public ActionResult OrganisationData(OrganisationData data, string prevBtn, string nextBtn)
        {
            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    WizardModel obj = GetWizard();
                    obj.OrgData.Vision = obj.OrgData.Vision;
                    obj.OrgData.Mission = obj.OrgData.Mission;
                    obj.OrgData.WomensRightsIssuesId = obj.OrgData.WomensRightsIssuesId;
                    obj.OrgData.YearFormed = obj.OrgData.YearFormed;
                    obj.OrgData.Founder = obj.OrgData.Founder;
                    obj.OrgData.ReasonFormed = obj.OrgData.ReasonFormed;
                    obj.OrgData.OperationalAreaId = obj.OrgData.OperationalAreaId;
                    obj.OrgData.OperationalLocationId = obj.OrgData.OperationalLocationId;
                    obj.OrgData.Achievements = obj.OrgData.Achievements;

                    return View("AdministrationData");
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult AdministrationData(AdministrationData data, string prevBtn, string nextBtn)
        {
            WizardModel obj = GetWizard();

            if (prevBtn != null)
            {
                OrganisationData od = new OrganisationData();

                od.Vision = obj.OrgData.Vision;
                od.Mission = obj.OrgData.Mission;
                od.WomensRightsIssuesId = obj.OrgData.WomensRightsIssuesId;
                od.YearFormed = obj.OrgData.YearFormed;
                od.Founder = obj.OrgData.Founder;
                od.ReasonFormed = obj.OrgData.ReasonFormed;
                od.OperationalAreaId = obj.OrgData.OperationalAreaId;
                od.OperationalLocationId = obj.OrgData.OperationalLocationId;
                od.Achievements = obj.OrgData.Achievements;

                return View("OrganisationData");
            }

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    obj.AdminData.Name = data.Name;

                    obj.AdminData.PhysicalAddressLine1 = data.PhysicalAddressLine1;
                    obj.AdminData.PhysicalAddressLine2 = data.PhysicalAddressLine2;
                    obj.AdminData.PhysicalCity = data.PhysicalCity;
                    obj.AdminData.PhysicalCountry = data.PhysicalCountry;
                    obj.AdminData.PhysicalCode = data.PhysicalCode;

                    obj.AdminData.PostalAddressLine1 = data.PostalAddressLine1;
                    obj.AdminData.PostalAddressLine2 = data.PostalAddressLine2;
                    obj.AdminData.PostalCity = data.PostalCity;
                    obj.AdminData.PostalCountry = data.PostalCountry;
                    obj.AdminData.PostalCode = data.PostalCode;

                    obj.AdminData.TelephoneNumber = data.TelephoneNumber;
                    obj.AdminData.MobileNumber = data.MobileNumber;
                    obj.AdminData.EmailAddress = data.EmailAddress;
                    obj.AdminData.WebsiteUrl = data.WebsiteUrl;
                    obj.AdminData.SkypeAddress = data.SkypeAddress;
                    obj.AdminData.TwitterAccount = data.TwitterAccount;
                    obj.AdminData.FacebookAccount = data.FacebookAccount;

                    obj.AdminData.ContactName = data.ContactName;
                    obj.AdminData.ContactPosition = data.ContactPosition;
                    obj.AdminData.ContactTelephoneNumber = data.ContactTelephoneNumber;
                    obj.AdminData.ContactEmailAddress = data.ContactEmailAddress;
                    obj.AdminData.ContactSkypeAddress = data.ContactSkypeAddress;

                    obj.AdminData.LearntAboutId = data.LearntAboutId;
                    obj.AdminData.ReceivedPreviousGrant = data.ReceivedPreviousGrant;
                    obj.AdminData.PreviousGrantInformationId = data.PreviousGrantInformationId;

                    return View("StructureData");
                }
            }

            return View();
        }

        [HttpPost]
        public ActionResult StructureData(StructureData data, string prevBtn, string nextBtn)
        {
            WizardModel obj = GetWizard();

            if (prevBtn != null)
            {
                if (ModelState.IsValid)
                {
                    AdministrationData ad = new AdministrationData();

                    ad.Name = obj.AdminData.Name;

                    ad.PhysicalAddressLine1 = obj.AdminData.PhysicalAddressLine1;
                    ad.PhysicalAddressLine2 = obj.AdminData.PhysicalAddressLine2;
                    ad.PhysicalCity = obj.AdminData.PhysicalCity;
                    ad.PhysicalCountry = obj.AdminData.PhysicalCountry;
                    ad.PhysicalCode = obj.AdminData.PhysicalCode;

                    ad.PostalAddressLine1 = obj.AdminData.PostalAddressLine1;
                    ad.PostalAddressLine2 = obj.AdminData.PostalAddressLine2;
                    ad.PostalCity = obj.AdminData.PostalCity;
                    ad.PostalCountry = obj.AdminData.PostalCountry;
                    ad.PostalCode = obj.AdminData.PostalCode;

                    ad.TelephoneNumber = obj.AdminData.TelephoneNumber;
                    ad.MobileNumber = obj.AdminData.MobileNumber;
                    ad.EmailAddress = obj.AdminData.EmailAddress;
                    ad.WebsiteUrl = obj.AdminData.WebsiteUrl;
                    ad.SkypeAddress = obj.AdminData.SkypeAddress;
                    ad.TwitterAccount = obj.AdminData.TwitterAccount;
                    ad.FacebookAccount = obj.AdminData.FacebookAccount;

                    ad.ContactName = obj.AdminData.ContactName;
                    ad.ContactPosition = obj.AdminData.ContactPosition;
                    ad.ContactTelephoneNumber = obj.AdminData.ContactTelephoneNumber;
                    ad.ContactEmailAddress = obj.AdminData.ContactEmailAddress;
                    ad.ContactSkypeAddress = obj.AdminData.ContactSkypeAddress;

                    ad.LearntAboutId = obj.AdminData.LearntAboutId;
                    ad.ReceivedPreviousGrant = obj.AdminData.ReceivedPreviousGrant;
                    ad.PreviousGrantInformationId = obj.AdminData.PreviousGrantInformationId;

                    return View("AdministrationData");
                }
            }

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    obj.StructData.IsWomensRightsOrganisation = data.IsWomensRightsOrganisation;
                    obj.StructData.WomensRightsPhiliosophy = data.WomensRightsPhiliosophy;
                    obj.StructData.WomensRoleInDecisionMaking = data.WomensRoleInDecisionMaking;
                    obj.StructData.HowAreKeyDecisionsMade = data.HowAreKeyDecisionsMade;
                    obj.StructData.WomensRoleOnBoard = data.WomensRoleOnBoard;
                    obj.StructData.PaidStaffId = data.PaidStaffId;
                    obj.StructData.UnpaidStaffId = data.UnpaidStaffId;
                    obj.StructData.BoardId = data.BoardId;
                    obj.StructData.AdvisorId = data.AdvisorId;
                    obj.StructData.VolunteerId = data.VolunteerId;
                    obj.StructData.MemberId = data.MemberId;
                    obj.StructData.RegistrationCertificate = data.RegistrationCertificate;
                    obj.StructData.ReferenceLetter = data.ReferenceLetter;

                    // save data here

                    RemoveWizard();

                    return View("Success");
                }
            }
            return View();
        }

        private WizardModel GetWizard()
        {
            if (Session["wizard"] == null)
            {
                Session["wizard"] = new WizardModel() {OrgData = new OrganisationData(), AdminData = new AdministrationData(), StructData = new StructureData()};
            }
            return (WizardModel)Session["wizard"];
        }

        private void RemoveWizard()
        {
            Session.Remove("wizard");
        }

        /// <summary>
        /// Get a list of all the wizard steps.
        /// Pass in the CurrentStepIndex and the 
        /// function will set the CurrentStepIndex 
        /// property of the relevant object to true.
        /// </summary>
        /// <param name="currentStepIndex"></param>
        /// <returns></returns>
        private List<WizardStep> GetSteps(int currentStepIndex)
        {
            var steps = new List<WizardStep>();

            var wizardStart = new WizardStep()
            {
                Action = "WizardStart",
                Controller = "Wizard",
                IsCurrentStep = (0 == currentStepIndex),
                StepIndex = 0,
                Title = "Start"
            };

            var organisationData = new WizardStep()
            {
                Action = "OrganisationData",
                Controller = "Wizard",
                IsCurrentStep = (1 == currentStepIndex),
                StepIndex = 1,
                Title = "Capture Organisation Data"
            };

            var administrationData = new WizardStep()
            {
                Action = "AdministrationData",
                Controller = "Wizard",
                IsCurrentStep = (2 == currentStepIndex),
                StepIndex = 2,
                Title = "Capture Administration Data"
            };

            var structureData = new WizardStep()
            {
                Action = "StructureData",
                Controller = "Wizard",
                IsCurrentStep = (3 == currentStepIndex),
                StepIndex = 3,
                Title = "Capture StructureData Data"
            };

            var wizardCompleted = new WizardStep()
            {
                Action = "WizardCompleted",
                Controller = "Wizard",
                IsCurrentStep = (4 == currentStepIndex),
                StepIndex = 4,
                Title = "Done!",
                HideOnSideNavigation = true,
            };

            steps.Add(wizardStart);
            steps.Add(organisationData);
            steps.Add(administrationData);
            steps.Add(structureData);
            steps.Add(wizardCompleted);

            return steps;
        }
    }
}