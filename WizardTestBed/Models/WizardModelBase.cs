using System.Collections.Generic;

namespace WizardTestBed.models
{
    /// <summary>
    /// The main idea for this base class is to abstract a lot of the rules for the wizard, 
    /// such as which buttons to display, what action takes place when the Next button is 
    /// clicked, and whether the Finish button should display.
    /// </summary>
    public class WizardModelBase
    {
        public bool ShowWizardSteps { get; set; }           // should we show the wizard steps 
        public int CurrentStepIndex { get; set; }           // the current step in the wizard
        public bool AllowFinish { get; set; }               // should we have a finish button in this wizard step
        public List<WizardStep> WizardSteps { get; set; }   // the list of all wizard steps

        /// <summary>
        /// Should we show the Back button ?
        /// </summary>
        public bool ShowBackButton
        {
            get
            {
                // hide on first step and on finished page
                if (CurrentStepIndex > 0 &&                                     // step index 0 would be the first page (so we don't need a back button)
                    (CurrentStepIndex != WizardSteps.Count - 1)) return true;   // (WizardSteps.Count - 1) would indicate the last step of the wizard (i.e. the Wizard success page => we don't need a back button here)
                return 
                    false;
            }
        }

        /// <summary>
        /// Should we show the Next Button ?
        /// </summary>
        public bool ShowNextButton
        {
            get
            {
                if (WizardSteps != null &&                      // we actually have wizard steps to process
                    WizardSteps.Count != 0 &&                   // we have more than one wizard step
                    CurrentStepIndex != WizardSteps.Count - 1)  // (WizardSteps.Count - 1) would indicate the last step of the wizard (i.e. the Wizard success page => we don't need a next button here)                 
                    return true;   
                return
                    false;
            }
        }

        /// <summary>
        /// Provide information for the finish step of the 
        /// wizard (i.e. the page before the Wizard Success page)
        /// </summary>
        public WizardStep FinishAction
        {
            get
            {
                if (WizardSteps != null)                        // we actually have a wizard step lict to process
                {
                    return WizardSteps[WizardSteps.Count - 1];  // return the last wizard step
                }
                else
                {
                    return null;                                // don't return anything
                }
            }
        }

        /// <summary>
        /// Provide information for the previous step of the wizard
        /// </summary>
        public WizardStep PreviousWizardStep
        {
            get
            {
                if (WizardSteps != null)                        // we actully have wizard steps that we can process
                {
                    if (CurrentStepIndex == 0)                  // if we are at the first page
                    {
                        return WizardSteps[0];                  // just return the same page's information, as we don't have a previous page
                    }
                    else
                    {
                        return WizardSteps[CurrentStepIndex - 1]; // return the previous step's information
                    }
                }
                return null;                                      // no wizard steps to process so return nothing
            }
        }

        /// <summary>
        /// Provide information for the next step of the wizard
        /// </summary>
        public WizardStep NextWizardStep
        {
            get
            {
                if (WizardSteps != null)                                // we actually have wizard steps to process
                {
                    if (CurrentStepIndex == (WizardSteps.Count - 1))    // if the current step is the next to last step
                    {
                        return WizardSteps[CurrentStepIndex];           // 
                    }
                    else
                    {
                        if ((CurrentStepIndex == (WizardSteps.Count - 1)) && CurrentStepIndex == 0)
                        {
                            return WizardSteps[CurrentStepIndex];
                        }
                        else
                        {
                            return WizardSteps[CurrentStepIndex + 1];
                        }
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// Parameterless class consructor
        /// </summary>
        public WizardModelBase()
        {
            
        }

        /// <summary>
        /// Parameterized class constructor
        /// </summary>
        /// <param name="wizardSteps">List&lt;WizardStep&gt; objects</param>
        public WizardModelBase(List<WizardStep> wizardSteps )
        {
            // initialise the WizardSteps property with the value passed into the class
            WizardSteps = wizardSteps;
            // display the wizard steps by default
            ShowWizardSteps = true;
        }

        /// <summary>
        /// Is this the current step? We use this function to 
        /// indicate to the sidebar which css class needs to be 
        /// applied to the sidebar link.
        /// </summary>
        /// <param name="step">The current step in the wizard</param>
        /// <returns></returns>
        public string CurrentStep(int step)
        {
            // check if the current step index is the current step index
            // so we know which css class to apply to the sidebar link
            if (step == CurrentStepIndex)
            {
                // apply the 'selected' css class to the link
                return "selected";
            }
            else
            {
                // apply the ''step css class to the link
                return "step";
            }
        }



    }

    public class WizardStep
    {
        public int StepIndex { get; set; }                  // the current step in the wizard
        public string Action { get; set; }                  // the controller action that should be executed for the current step
        public string Controller { get; set; }              // the controller for the wizard
        public string Title { get; set; }                   // the tite to be displayed for the link in the wizard sidebar
        public bool IsCurrentStep { get; set; }             // is this the current step in the wizard       
        public bool HideOnSideNavigation { get; set; }      // should this step be hidden in the sidebar
    }
}
