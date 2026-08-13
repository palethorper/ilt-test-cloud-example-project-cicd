using ApplicationTestingILT.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.Activities.System.Jobs.Coded;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.Api.Models;
using UiPath.Testing.Activities.Models;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace ApplicationTestingILT
{
    public class Approval__50_000_at_5_year_boundary : CodedWorkflow
    {
        [TestCase]
        public void Execute()
        {
            // Code Generation:
            // Navigate to 'https://uibank.uipath.com/loans/apply'. It is expected to: Loan application form is displayed
            // Enter 'boundary50k5y@email.com' in 'Email Address' field. It is expected to: Email address is accepted in the field
            // Enter '50000' in 'Loan Amount' field. It is expected to: Loan amount is accepted in the field
            // Select '5' from 'Loan Term' dropdown. It is expected to: 5 years term is selected
            // Enter '50000' in 'Yearly Income' field. It is expected to: Yearly income is accepted in the field
            // Enter '32' in 'Age' field. It is expected to: Age is accepted in the field
            // Click 'Submit Loan Application' button. It is expected to: Application is processed and redirected to result page
            // Verify approval message displayed. It is expected to: Message 'Congrats! You've been approved for a loan with UiBank!' is shown
            var loanApplyScreen = uiAutomation.Open(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome__UiBank_Loan_Apply);
            loanApplyScreen.GoToUrl("https://uibank.uipath.com/loans/apply");
            loanApplyScreen.TypeInto(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome__UiBank_Loan_Apply.Email_Address_of_Reques_, "boundary50k5y@email.com");
            loanApplyScreen.TypeInto(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome__UiBank_Loan_Apply.Loan_Amount_Requested, "50000");
            loanApplyScreen.SelectItem(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome__UiBank_Loan_Apply.Loan_Term, "5");
            loanApplyScreen.TypeInto(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome__UiBank_Loan_Apply.Current_Yearly_Income___, "50000");
            loanApplyScreen.TypeInto(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome__UiBank_Loan_Apply.Age, "32");
            loanApplyScreen.Click(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome__UiBank_Loan_Apply.Submit_Loan_Application);
            var resultScreen = uiAutomation.Attach(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome_UiBank_Loan_result);
            var approvalMessage = resultScreen.GetText(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome_UiBank_Loan_result.You_ve_been_approved_fo_);
            testing.VerifyExpression(approvalMessage == "You've been approved for a loan with UiBank!", "Verify that the approval message is correct.");
            
            resultScreen.GoToUrl("https://uibank.uipath.com/loans/apply");
        }
    }
}