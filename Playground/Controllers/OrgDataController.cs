using System;
using System.Web;
using System.Web.Mvc;
using Playground.Data;
using Playground.Models;

namespace Playground.Controllers
{
    public class OrgDataController : Controller
    {
        private readonly GenericUnitOfWork _uow;

        public OrgDataController()
        {
            _uow = new GenericUnitOfWork();
        }

        public OrgDataController(GenericUnitOfWork uow)
        {
            _uow = uow;
        }

        // GET: OrgData
        public ActionResult Index()
        {
            return View("OrganisationData");
        }

        [HttpPost]
        public ActionResult OrganisationData(Organisation data, string prevBtn, string nextBtn)
        {
            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    OrganisationData obj = GetOrgData();

                    obj.OrgData.Vision = data.Vision;
                    obj.OrgData.Mission = data.Mission;
                    obj.OrgData.WomensRightsIssuesId = data.WomensRightsIssuesId;
                    obj.OrgData.YearFormed = data.YearFormed;
                    obj.OrgData.Founder = data.Founder;
                    obj.OrgData.ReasonFormed = data.ReasonFormed;
                    obj.OrgData.OperationalAreaId = data.OperationalAreaId;
                    obj.OrgData.OperationalLocationId = data.OperationalLocationId;
                    obj.OrgData.Achievements = data.Achievements;
                    obj.OrgData.InsertedDateTime = DateTime.Now;
                    obj.OrgData.ModifiedDateTime = DateTime.Now;

                    return View("AdministrationData");
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult AdministrationData(Administration data, string prevBtn, string nextBtn)
        {
            OrganisationData obj = GetOrgData();

            if (prevBtn != null)
            {
                Organisation ovm = new Organisation();

                ovm.Vision = obj.OrgData.Vision;
                ovm.Mission = obj.OrgData.Mission;
                ovm.WomensRightsIssuesId = obj.OrgData.WomensRightsIssuesId;
                ovm.YearFormed = obj.OrgData.YearFormed;
                ovm.Founder = obj.OrgData.Founder;
                ovm.ReasonFormed = obj.OrgData.ReasonFormed;
                ovm.OperationalAreaId = obj.OrgData.OperationalAreaId;
                ovm.OperationalLocationId = obj.OrgData.OperationalLocationId;
                ovm.Achievements = obj.OrgData.Achievements;

                return View("OrganisationData", ovm);
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
        public ActionResult StructureData(Structure data, string prevBtn, string nextBtn)
        {
            OrganisationData obj = GetOrgData();

            if (prevBtn != null)
            {
                if (ModelState.IsValid)
                {
                    Administration avm = new Administration();

                    avm.Name = obj.AdminData.Name;

                    avm.PhysicalAddressLine1 = obj.AdminData.PhysicalAddressLine1;
                    avm.PhysicalAddressLine2 = obj.AdminData.PhysicalAddressLine2;
                    avm.PhysicalCity = obj.AdminData.PhysicalCity;
                    avm.PhysicalCountry = obj.AdminData.PhysicalCountry;
                    avm.PhysicalCode = obj.AdminData.PhysicalCode;

                    avm.PostalAddressLine1 = obj.AdminData.PostalAddressLine1;
                    avm.PostalAddressLine2 = obj.AdminData.PostalAddressLine2;
                    avm.PostalCity = obj.AdminData.PostalCity;
                    avm.PostalCountry = obj.AdminData.PostalCountry;
                    avm.PostalCode = obj.AdminData.PostalCode;

                    avm.TelephoneNumber = obj.AdminData.TelephoneNumber;
                    avm.MobileNumber = obj.AdminData.MobileNumber;
                    avm.EmailAddress = obj.AdminData.EmailAddress;
                    avm.WebsiteUrl = obj.AdminData.WebsiteUrl;
                    avm.SkypeAddress = obj.AdminData.SkypeAddress;
                    avm.TwitterAccount = obj.AdminData.TwitterAccount;
                    avm.FacebookAccount = obj.AdminData.FacebookAccount;

                    avm.ContactName = obj.AdminData.ContactName;
                    avm.ContactPosition = obj.AdminData.ContactPosition;
                    avm.ContactTelephoneNumber = obj.AdminData.ContactTelephoneNumber;
                    avm.ContactEmailAddress = obj.AdminData.ContactEmailAddress;
                    avm.ContactSkypeAddress = obj.AdminData.ContactSkypeAddress;

                    avm.LearntAboutId = obj.AdminData.LearntAboutId;
                    avm.ReceivedPreviousGrant = obj.AdminData.ReceivedPreviousGrant;
                    avm.PreviousGrantInformationId = obj.AdminData.PreviousGrantInformationId;

                    return View("AdministrationData", avm);
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
                    obj.StructData.PaidStaffTotal = data.PaidStaffTotal;
                    obj.StructData.PaidStaffFemales= data.PaidStaffFemales;
                    obj.StructData.PaidStaffMales = data.PaidStaffMales;
                    obj.StructData.PaidStaffTransNonConforming = data.PaidStaffTransNonConforming;
                    obj.StructData.UnpaidStaffTotal = data.UnpaidStaffTotal;
                    obj.StructData.UnpaidStaffFemales = data.UnpaidStaffFemales;
                    obj.StructData.UnpaidStaffMales = data.UnpaidStaffMales;
                    obj.StructData.UnpaidStaffTransNonConforming = data.UnpaidStaffTransNonConforming;
                    obj.StructData.BoardMembersTotal = data.BoardMembersTotal;
                    obj.StructData.BoardMembersFemales = data.BoardMembersFemales;
                    obj.StructData.BoardMembersMales = data.BoardMembersMales;
                    obj.StructData.BoardMembersTransNonConforming = data.BoardMembersTransNonConforming;
                    obj.StructData.AdvisorsTotal = data.AdvisorsTotal;
                    obj.StructData.AdvisorsFemales = data.AdvisorsFemales;
                    obj.StructData.AdvisorsMales = data.AdvisorsMales;
                    obj.StructData.AdvisorsTransNonConforming = data.AdvisorsTransNonConforming;
                    obj.StructData.VolunteersTotal = data.VolunteersTotal;
                    obj.StructData.VolunteersFemales = data.VolunteersFemales;
                    obj.StructData.VolunteersMales = data.VolunteersMales;
                    obj.StructData.VolunteersTransNonConforming = data.VolunteersTransNonConforming;
                    obj.StructData.MembersTotal = data.MembersTotal;
                    obj.StructData.MembersFemales = data.MembersFemales;
                    obj.StructData.MembersMales = data.MembersMales;
                    obj.StructData.MembersTransNonConforming = data.MembersTransNonConforming;

                    //obj.StructData.RegistrationCertificate = Convert.FromBase64String(data.RegistrationCertificate.ToString());
                    //obj.StructData.ReferenceLetter = Convert.FromBase64String(data.ReferenceLetter.ToString());

                    // save data here
                    _uow.Repository<Organisation>().Add(obj.OrgData);
                    _uow.Repository<Administration>().Add(obj.AdminData);
                    _uow.Repository<Structure>().Add(obj.StructData);

                    _uow.SaveChanges();
                    RemoveOrgData();

                    return View("Success");
                }
            }
            return View();
        }
        
        private OrganisationData GetOrgData()
        {
            if (Session["orgData"] == null)
            {
                Session["orgData"] = new OrganisationData() { OrgData = new Organisation(), AdminData = new Administration(), StructData = new Structure() };
            }
            return (OrganisationData)Session["orgData"];
        }

        private void RemoveOrgData()
        {
            Session.Remove("orgData");
        }
    }
}