using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Playground.Data;
using Playground.Models;

namespace Playground.Controllers
{
    public class OrgDataController : Controller
    {
        // TODO : clean up extraneous columns in models
        // TODO : remove extraneous controllers and views
        // TODO : fix up layouts for views 
        // TODO : replace textboxes with text areas where neccessary
        // TODO : replace org locations and previous grant data capture controls with correct controls
        // TODO : replace checkboxes with radio controls
        // TODO : add other textboxes and columns where neccessary
        // TODO : fix up model state is invalid for AdminData
        // TODO : add bootstrap styling to all controls in views
        // TODO : complete back and next navigation to display old data for the org locations and previous grant data
        // TODO : clean up MVCWizard.js file
        // TODO : put Wizard.css file in correct location or add custom styles to site.css
        // TODO : migrate playground code to production code
        // TODO : Apply current methods to Grant Application module (investigate areas?)
        // TODO : move lookup table CRUD functionality to Admin portal

        private readonly GenericUnitOfWork _uow;
        private HashSet<OperationalLocation> _locations;
        private HashSet<PreviousGrantsInformation> _previousGrants;

        public OrgDataController()
        {
            _uow = new GenericUnitOfWork();
            GetCountryList();
            GetWomensRightsIssueList();
            GetOperationalAreaList();
            GetLearntAboutList();
        }

        public OrgDataController(GenericUnitOfWork uow)
        {
            _uow = uow;
            GetCountryList();
            GetWomensRightsIssueList();
            GetOperationalAreaList();
            GetLearntAboutList();
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
                    string opLocationsJson = Request.Form["opLocations"];
                    _locations = JsonConvert.DeserializeObject<HashSet<OperationalLocation>>(opLocationsJson);

                    obj.OrgData.Vision = data.Vision;
                    obj.OrgData.Mission = data.Mission;
                    obj.OrgData.WomensRightsIssuesId = data.WomensRightsIssuesId;
                    obj.OrgData.YearFormed = data.YearFormed;
                    obj.OrgData.Founder = data.Founder;
                    obj.OrgData.ReasonFormed = data.ReasonFormed;
                    obj.OrgData.OperationalAreaId = data.OperationalAreaId;
                    obj.OrgData.OperationalLocationId = data.OperationalLocationId;
                    obj.OrgData.OperationalLocations = _locations;
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
                ovm.OperationalLocations = obj.OrgData.OperationalLocations;
                ovm.Achievements = obj.OrgData.Achievements;

                return View("OrganisationData", ovm);
            }

            if (nextBtn != null)
            {
                //if (ModelState.IsValid)
                //{
                    string previousGrantsJson = Request.Form["previousGrants"];
                    _previousGrants = JsonConvert.DeserializeObject<HashSet<PreviousGrantsInformation>>(previousGrantsJson);

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
                    obj.AdminData.PreviousGrants = _previousGrants;

                    return View("StructureData");
                //}
            }

            return View();
        }

        [HttpPost]
        public ActionResult StructureData(Structure data, string prevBtn, string nextBtn, HttpPostedFileBase upload, HttpPostedFileBase refLetter)
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
                    avm.PreviousGrants = obj.AdminData.PreviousGrants;

                    return View("AdministrationData", avm);
                }
            }

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    // file saving code : https://www.mikesdotnetting.com/article/259/asp-net-mvc-5-with-ef-6-working-with-files
                    var uploadedFiles = new List<File>();

                    if (upload != null && upload.ContentLength > 0)
                    {
                        var registrationCertificate = new File()
                        {
                            FileName = System.IO.Path.GetFileName(upload.FileName),
                            FileType = FileType.RegistrationCertificate,
                            ContentType = upload.ContentType
                        };

                        using (var reader = new System.IO.BinaryReader(upload.InputStream))
                        {
                            registrationCertificate.Content = reader.ReadBytes(upload.ContentLength);
                        }
                        //data.Files = new List<File> {registrationCertiificate};
                        uploadedFiles.Add(registrationCertificate);
                        data.Files = uploadedFiles;
                    }

                    if (refLetter != null && refLetter.ContentLength > 0)
                    {
                        var referenceLetter = new File()
                        {
                            FileName = System.IO.Path.GetFileName(refLetter.FileName),
                            FileType = FileType.ReferenceLetter,
                            ContentType = refLetter.ContentType
                        };

                        using (var reader = new System.IO.BinaryReader(refLetter.InputStream))
                        {
                            referenceLetter.Content = reader.ReadBytes(refLetter.ContentLength);
                        }

                        uploadedFiles.Add(referenceLetter);
                        data.Files = uploadedFiles;
                    }

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
                    obj.StructData.Files = data.Files;
                    
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

        private void GetCountryList()
        {
            if (ViewData["countries"] == null)
            {
                var countryList = new SelectList(_uow.Repository<Country>().GetAll().ToList(), "ID", "Description");
                ViewData["countries"] = countryList;
            }
        }

        private void GetWomensRightsIssueList()
        {
            if (ViewData["womensRightsIssues"] == null)
            {
                var womensRightsIssueList = new SelectList(_uow.Repository<WomensRightsIssue>().GetAll().ToList(), "ID", "Description");
                ViewData["womensRightsIssues"] = womensRightsIssueList;
            }
        }

        private void GetOperationalAreaList()
        {
            if (ViewData["operationalAreas"] == null)
            {
                var operationalAreaList = new SelectList(_uow.Repository<OperationalArea>().GetAll().ToList(), "ID", "Description");
                ViewData["operationalAreas"] = operationalAreaList;
            }
        }

        private void GetLearntAboutList()
        {
            if (ViewData["learntAbout"] == null)
            {
                var learntAboutList = new SelectList(_uow.Repository<LearntAbout>().GetAll().ToList(), "ID", "Description");
                ViewData["learntAbout"] = learntAboutList;
            }
        }
    }
}