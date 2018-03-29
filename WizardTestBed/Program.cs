using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WizardTestBed.Data;
using WizardTestBed.models;
using WizardTestBed.Models;

namespace WizardTestBed
{
    class Program
    {
        static void Main(string[] args)
        {
            var userChoice = string.Empty;

            while (userChoice != "5")
            {
                Console.WriteLine("\nChoose one of the following options by entering option's number:\n ");
                Console.WriteLine("1- Initialize DB\n");
                //Console.WriteLine("2- Run and commit a transaction\n");
                //Console.WriteLine("3- Run and rollback a transaction\n");
                //Console.WriteLine("4- Select users in a team\n");
                Console.WriteLine("5- Exit");

                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        InitializeDB();
                        break;
                    //case "2":
                    //    RunAndCommitTransaction();
                    //    break;
                    //case "3":
                    //    RunAndRollbackTransaction();
                    //    break;
                    //case "4":
                    //    SelectUsersInTeam();
                    //    break;
                }
            }

            //var steps = GetSteps(0);
            //for (var i = 0; i <= (steps.Count -1); i++)
            //{
            //    var tmp = Wizard(i);
            //    Console.WriteLine("Action: {0}\nController: {1}\nIsCurrentStep: {2}\nStepIndex:{3}\nTitle:{4}\n\n", steps[i].Action, steps[i].Controller, steps[i].IsCurrentStep, steps[i].StepIndex, steps[i].Title);
            //    Console.Write("AllowFinish:{0}\nCurrentStepIndex:{1}\nFinishAction:{2}\nNextWizardStep:{3}\nPreviousWizardStep:{4}\nShowBackButton:{5}\nShowNextButton:{6}\n\n", tmp.AllowFinish, tmp.CurrentStepIndex, tmp.FinishAction.Title, tmp.NextWizardStep.Title, tmp.PreviousWizardStep.Title, tmp.ShowBackButton, tmp.ShowNextButton);
            //}
            //Console.ReadLine();
        }

        private static void InitializeDB()
        {
            Console.WriteLine("\nInitializing the db....");
            using (var ctx = new EfContext())
            {
                var dummyOrganisation = ctx.Set<Organisation>().FirstOrDefault();
            }
            Console.WriteLine("\nInitializing db has been completed....");
        }

        //public static WizardModel Wizard(int Index)
        //{
        //    WizardModel model = new WizardModel(GetSteps(Index));
        //    model.CurrentStepIndex = Index;
        //    return model;
        //}

        /// <summary>
        /// Get a list of all the wizard steps.
        /// Pass in the CurrentStepIndex and the 
        /// function will set the CurrentStepIndex 
        /// property of the relevant object to true.
        /// </summary>
        /// <param name="CurrentStepIndex"></param>
        /// <returns></returns>
        //private static List<WizardStep> GetSteps(int CurrentStepIndex)
        //{
        //    var steps = new List<WizardStep>();

        //    var wizardStart = new WizardStep()
        //    {
        //        Action = "WizardStart",
        //        Controller = "Wizard",
        //        IsCurrentStep = (0 == CurrentStepIndex),
        //        StepIndex = 0,
        //        Title = "Start"
        //    };

        //    var organisationData = new WizardStep()
        //    {
        //        Action = "OrganisationData",
        //        Controller = "Wizard",
        //        IsCurrentStep = (1 == CurrentStepIndex),
        //        StepIndex = 1,
        //        Title = "Capture Organisation Data"
        //    };

        //    var administrationData = new WizardStep()
        //    {
        //        Action = "AdministrationData",
        //        Controller = "Wizard",
        //        IsCurrentStep = (2 == CurrentStepIndex),
        //        StepIndex = 2,
        //        Title = "Capture Administration Data"
        //    };

        //    var structureData = new WizardStep()
        //    {
        //        Action = "StructureData",
        //        Controller = "Wizard",
        //        IsCurrentStep = (3 == CurrentStepIndex),
        //        StepIndex = 3,
        //        Title = "Capture StructureData Data"
        //    };

        //    var wizardCompleted = new WizardStep()
        //    {
        //        Action = "WizardCompleted",
        //        Controller = "Wizard",
        //        IsCurrentStep = (4 == CurrentStepIndex),
        //        StepIndex = 4,
        //        Title = "Done!",
        //        HideOnSideNavigation = true,
        //    };

        //    steps.Add(wizardStart);
        //    steps.Add(organisationData);
        //    steps.Add(administrationData);
        //    steps.Add(structureData);
        //    steps.Add(wizardCompleted);

        //    return steps;
        //}
    }
}
