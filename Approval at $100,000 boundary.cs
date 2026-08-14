using ApplicationTestingILT.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using UiPath.Activities.System.Jobs.Coded;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
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
using UiPath.Web.Activities.API;
using UiPath.Web.Activities.API.Models;
using UiPath.Web.Activities.Http.Models;

namespace ApplicationTestingILT
{
    public class Approval_at__100_000_boundary : CodedWorkflow
    {
        [TestCase]
        public void Execute()
        {
            // Code Generation:
            // Navigate to 'https://uibank.uipath.com/loans/apply'. It is expected to: Loan application form is displayed
            // Enter 'boundary100k@email.com' in 'Email Address' field. It is expected to: Email address is accepted in the field
            // Enter '100000' in 'Loan Amount' field. It is expected to: Loan amount is accepted in the field
            // Select '3' from 'Loan Term' dropdown. It is expected to: 3 years term is selected
            // Enter '100000' in 'Yearly Income' field. It is expected to: Yearly income is accepted in the field
            // Enter '45' in 'Age' field. It is expected to: Age is accepted in the field
            // Click 'Submit Loan Application' button. It is expected to: Application is processed and redirected to result page
            // Verify approval message displayed. It is expected to: Message 'Congrats! You've been approved for a loan with UiBank!' is shown
            var app = uiAutomation.Open(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome__UiBank_Loan_Apply);
            app.GoToUrl("https://uibank.uipath.com/loans/apply");
            var isFormDisplayed = app.WaitState(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome__UiBank_Loan_Apply.Email_Address_of_Reques_, NCheckStateMode.WaitAppear, 10000);
            testing.VerifyExpression(isFormDisplayed, "Loan application form should be displayed");
            app.TypeInto(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome__UiBank_Loan_Apply.Email_Address_of_Reques_, "boundary100k@email.com");
            app.TypeInto(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome__UiBank_Loan_Apply.Loan_Amount_Requested, "100000");
            app.SelectItem(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome__UiBank_Loan_Apply.Loan_Term, "3");
            app.TypeInto(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome__UiBank_Loan_Apply.Current_Yearly_Income___, "100000");
            app.TypeInto(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome__UiBank_Loan_Apply.Age, "45");
            app.Click(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome__UiBank_Loan_Apply.Submit_Loan_Application);
            var resultPage = uiAutomation.Attach(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome_UiBank_Loan_result);
            var congratsMessage = resultPage.GetText(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome_UiBank_Loan_result.Congrats_);
            var approvedMessage = resultPage.GetText(Descriptors.Chrome__UiBank_Loan_Apply_app.Chrome_UiBank_Loan_result.You_ve_been_approved_fo_);
            var fullMessage = $"{congratsMessage} {approvedMessage}";
            testing.VerifyExpression(fullMessage.Contains("Congrats! You've been approved for a loan with UiBank!"), "Approval message should be displayed");

        }
    }
}