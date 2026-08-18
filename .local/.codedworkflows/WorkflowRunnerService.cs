using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using ApplicationTestingILT;

[assembly: WorkflowRunnerServiceAttribute(typeof(ApplicationTestingILT.WorkflowRunnerService))]
namespace ApplicationTestingILT
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the 4.APIs/ApplyForLoan-ServiceConnection.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ApplyForLoan_ServiceConnection(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"4.APIs\ApplyForLoan-ServiceConnection.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 4.APIs/ApplyForLoan-ServiceConnection.xaml
        /// </summary>
        public void ApplyForLoan_ServiceConnection()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"4.APIs\ApplyForLoan-ServiceConnection.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 4.APIs/ApplyForLoanAPI.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ApplyForLoanAPI(int Amount, int Term, int Income, int Age, string Email, string Accepted, Application_Testing_ILT.UiBankLoanDataRob uiBankLoanDataRob, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"4.APIs\ApplyForLoanAPI.xaml", new Dictionary<string, object> { { "Amount", Amount }, { "Term", Term }, { "Income", Income }, { "Age", Age }, { "Email", Email }, { "Accepted", Accepted }, { "uiBankLoanDataRob", uiBankLoanDataRob } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 4.APIs/ApplyForLoanAPI.xaml
        /// </summary>
        public void ApplyForLoanAPI(int Amount, int Term, int Income, int Age, string Email, string Accepted, Application_Testing_ILT.UiBankLoanDataRob uiBankLoanDataRob)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"4.APIs\ApplyForLoanAPI.xaml", new Dictionary<string, object> { { "Amount", Amount }, { "Term", Term }, { "Income", Income }, { "Age", Age }, { "Email", Email }, { "Accepted", Accepted }, { "uiBankLoanDataRob", uiBankLoanDataRob } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 4.APIs/ApplyForLoanAPI-2.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ApplyForLoanAPI_2(int Amount, int Term, int Income, int Age, string Email, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"4.APIs\ApplyForLoanAPI-2.xaml", new Dictionary<string, object> { { "Amount", Amount }, { "Term", Term }, { "Income", Income }, { "Age", Age }, { "Email", Email } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 4.APIs/ApplyForLoanAPI-2.xaml
        /// </summary>
        public void ApplyForLoanAPI_2(int Amount, int Term, int Income, int Age, string Email)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"4.APIs\ApplyForLoanAPI-2.xaml", new Dictionary<string, object> { { "Amount", Amount }, { "Term", Term }, { "Income", Income }, { "Age", Age }, { "Email", Email } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Approval at age boundary 65.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Approval_at_age_boundary_65(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Approval at age boundary 65.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Approval at age boundary 65.xaml
        /// </summary>
        public void Approval_at_age_boundary_65()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Approval at age boundary 65.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Approval for $10,000 minimal income.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Approval_for__10_000_minimal_income(string EmailAddress, string LoanAmount, string LoanTerm, string Age, string YearlyIncome, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Approval for $10,000 minimal income.xaml", new Dictionary<string, object> { { "EmailAddress", EmailAddress }, { "LoanAmount", LoanAmount }, { "LoanTerm", LoanTerm }, { "Age", Age }, { "YearlyIncome", YearlyIncome } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Approval for $10,000 minimal income.xaml
        /// </summary>
        public void Approval_for__10_000_minimal_income(string EmailAddress, string LoanAmount, string LoanTerm, string Age, string YearlyIncome)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Approval for $10,000 minimal income.xaml", new Dictionary<string, object> { { "EmailAddress", EmailAddress }, { "LoanAmount", LoanAmount }, { "LoanTerm", LoanTerm }, { "Age", Age }, { "YearlyIncome", YearlyIncome } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 3.Test Data Management/AI Generated/CreateDataFabricData.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CreateDataFabricData(int Amount, int Term, int Income, int Age, string Email, bool Accepted, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"3.Test Data Management\AI Generated\CreateDataFabricData.xaml", new Dictionary<string, object> { { "Amount", Amount }, { "Term", Term }, { "Income", Income }, { "Age", Age }, { "Email", Email }, { "Accepted", Accepted } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 3.Test Data Management/AI Generated/CreateDataFabricData.xaml
        /// </summary>
        public void CreateDataFabricData(int Amount, int Term, int Income, int Age, string Email, bool Accepted)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"3.Test Data Management\AI Generated\CreateDataFabricData.xaml", new Dictionary<string, object> { { "Amount", Amount }, { "Term", Term }, { "Income", Income }, { "Age", Age }, { "Email", Email }, { "Accepted", Accepted } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 3.Test Data Management/AI Generated/CreateLoanTestData.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CreateLoanTestData(int Amount, int Term, int Income, int Age, string Email, bool Accepted, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"3.Test Data Management\AI Generated\CreateLoanTestData.xaml", new Dictionary<string, object> { { "Amount", Amount }, { "Term", Term }, { "Income", Income }, { "Age", Age }, { "Email", Email }, { "Accepted", Accepted } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 3.Test Data Management/AI Generated/CreateLoanTestData.xaml
        /// </summary>
        public void CreateLoanTestData(int Amount, int Term, int Income, int Age, string Email, bool Accepted)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"3.Test Data Management\AI Generated\CreateLoanTestData.xaml", new Dictionary<string, object> { { "Amount", Amount }, { "Term", Term }, { "Income", Income }, { "Age", Age }, { "Email", Email }, { "Accepted", Accepted } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the DEmo-ExecutionTemplate.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void DEmo_ExecutionTemplate(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"DEmo-ExecutionTemplate.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the DEmo-ExecutionTemplate.xaml
        /// </summary>
        public void DEmo_ExecutionTemplate()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"DEmo-ExecutionTemplate.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 3.Test Data Management/Test Data Queues/Dispatcher.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Dispatcher(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"3.Test Data Management\Test Data Queues\Dispatcher.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 3.Test Data Management/Test Data Queues/Dispatcher.xaml
        /// </summary>
        public void Dispatcher()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"3.Test Data Management\Test Data Queues\Dispatcher.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 3.Test Data Management/AI Generated/Generate Loan Quotes.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Generate_Loan_Quotes(string EmailAddress, int LoanAmount, int LoanTerm, int YearlyIncome, int Age, Application_Testing_ILT.UiBankLoanDataRob uiBankLoanDataRob, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"3.Test Data Management\AI Generated\Generate Loan Quotes.xaml", new Dictionary<string, object> { { "EmailAddress", EmailAddress }, { "LoanAmount", LoanAmount }, { "LoanTerm", LoanTerm }, { "YearlyIncome", YearlyIncome }, { "Age", Age }, { "uiBankLoanDataRob", uiBankLoanDataRob } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 3.Test Data Management/AI Generated/Generate Loan Quotes.xaml
        /// </summary>
        public void Generate_Loan_Quotes(string EmailAddress, int LoanAmount, int LoanTerm, int YearlyIncome, int Age, Application_Testing_ILT.UiBankLoanDataRob uiBankLoanDataRob)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"3.Test Data Management\AI Generated\Generate Loan Quotes.xaml", new Dictionary<string, object> { { "EmailAddress", EmailAddress }, { "LoanAmount", LoanAmount }, { "LoanTerm", LoanTerm }, { "YearlyIncome", YearlyIncome }, { "Age", Age }, { "uiBankLoanDataRob", uiBankLoanDataRob } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 2.Autopilot for developers/Generate low code workflow.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Generate_low_code_workflow(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"2.Autopilot for developers\Generate low code workflow.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 2.Autopilot for developers/Generate low code workflow.xaml
        /// </summary>
        public void Generate_low_code_workflow()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"2.Autopilot for developers\Generate low code workflow.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 4.APIs/GetPublicIpAddress.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void GetPublicIpAddress(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"4.APIs\GetPublicIpAddress.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 4.APIs/GetPublicIpAddress.xaml
        /// </summary>
        public void GetPublicIpAddress()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"4.APIs\GetPublicIpAddress.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Handling.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Handling(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Handling.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Handling.xaml
        /// </summary>
        public void Handling()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Handling.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 4.APIs/NewQuoteFromServiceDefinitionInStudio.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void NewQuoteFromServiceDefinitionInStudio(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"4.APIs\NewQuoteFromServiceDefinitionInStudio.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 4.APIs/NewQuoteFromServiceDefinitionInStudio.xaml
        /// </summary>
        public void NewQuoteFromServiceDefinitionInStudio()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"4.APIs\NewQuoteFromServiceDefinitionInStudio.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 3.Test Data Management/Data driven/Sequence.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Sequence(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"3.Test Data Management\Data driven\Sequence.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 3.Test Data Management/Data driven/Sequence.xaml
        /// </summary>
        public void Sequence()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"3.Test Data Management\Data driven\Sequence.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 2.Autopilot for developers/Stopwatch.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Stopwatch(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"2.Autopilot for developers\Stopwatch.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 2.Autopilot for developers/Stopwatch.xaml
        /// </summary>
        public void Stopwatch()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"2.Autopilot for developers\Stopwatch.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 4.APIs/TC_CreateLoan_WithIntegrationService.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void TC_CreateLoan_WithIntegrationService(double Amount, double Term, double Income, double Age, string Email, bool Accepted, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"4.APIs\TC_CreateLoan_WithIntegrationService.xaml", new Dictionary<string, object> { { "Amount", Amount }, { "Term", Term }, { "Income", Income }, { "Age", Age }, { "Email", Email }, { "Accepted", Accepted } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 4.APIs/TC_CreateLoan_WithIntegrationService.xaml
        /// </summary>
        public void TC_CreateLoan_WithIntegrationService(double Amount, double Term, double Income, double Age, string Email, bool Accepted)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"4.APIs\TC_CreateLoan_WithIntegrationService.xaml", new Dictionary<string, object> { { "Amount", Amount }, { "Term", Term }, { "Income", Income }, { "Age", Age }, { "Email", Email }, { "Accepted", Accepted } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Test Data Loan Example.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Test_Data_Loan_Example(string EmailAddress, string LoanAmount, string LoanTerm, string Age, string YearlyIncome, Application_Testing_ILT.UiBankLoanDataRob uiBankLoanDataRob, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Test Data Loan Example.xaml", new Dictionary<string, object> { { "EmailAddress", EmailAddress }, { "LoanAmount", LoanAmount }, { "LoanTerm", LoanTerm }, { "Age", Age }, { "YearlyIncome", YearlyIncome }, { "uiBankLoanDataRob", uiBankLoanDataRob } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Test Data Loan Example.xaml
        /// </summary>
        public void Test_Data_Loan_Example(string EmailAddress, string LoanAmount, string LoanTerm, string Age, string YearlyIncome, Application_Testing_ILT.UiBankLoanDataRob uiBankLoanDataRob)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Test Data Loan Example.xaml", new Dictionary<string, object> { { "EmailAddress", EmailAddress }, { "LoanAmount", LoanAmount }, { "LoanTerm", LoanTerm }, { "Age", Age }, { "YearlyIncome", YearlyIncome }, { "uiBankLoanDataRob", uiBankLoanDataRob } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 4.APIs/TestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void TestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"4.APIs\TestCase.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 4.APIs/TestCase.xaml
        /// </summary>
        public void TestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"4.APIs\TestCase.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 1.Test Case/Verifications.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Verifications(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"1.Test Case\Verifications.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the 1.Test Case/Verifications.xaml
        /// </summary>
        public void Verifications()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"1.Test Case\Verifications.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}