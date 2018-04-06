using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Playground.Models
{
    public class OrganisationData
    {
        public OrganisationData()
        {
            OrgData = new Organisation();
            AdminData = new Administration();
            StructData = new Structure();
        }

        public Organisation OrgData { get; set; }
        public Administration AdminData { get; set; }
        public Structure StructData { get; set; }
        public HttpPostedFileBase File { get; set; }
    }
}