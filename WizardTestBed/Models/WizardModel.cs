using System.Collections.Generic;

namespace WizardTestBed.models
{
    public class WizardModel : WizardModelBase
    {
        /// <summary>
        /// Parameterless class constructor
        /// </summary>
        public WizardModel()
        {
            
        }

        /// <summary>
        /// Parameterized class constructor. Uses base class's constructor
        /// </summary>
        /// <param name="wizardSteps">List&lt;<WizardStep>&gt; objects</param>
        public WizardModel(List<WizardStep> wizardSteps ) : base(wizardSteps)
        {
            // initialise properties
            OrgData = new OrganisationData();
            AdminData = new AdministrationData();
            StructData = new StructureData();
        }

        public OrganisationData OrgData { get; set; }
        public AdministrationData AdminData { get; set; }
        public StructureData StructData { get; set; }
    }
}