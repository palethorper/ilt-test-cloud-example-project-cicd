using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Runtime;
using ApplicationTestingILT.ObjectRepository;
using System.Collections.Generic;
using System.Data;
using UiPath.Activities.System.Jobs.Coded;
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
using ApplicationTestingILT;

namespace ApplicationTestingILT
{
    [System.ComponentModel.Browsable(false)]
    public class Approval__50_000_at_5_year_boundaryActivity : System.Activities.Activity
    {
        public Approval__50_000_at_5_year_boundaryActivity()
        {
            this.Implementation = () =>
            {
                return new Approval__50_000_at_5_year_boundaryActivityChild()
                {
                };
            };
        }
    }

    internal class Approval__50_000_at_5_year_boundaryActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public Approval__50_000_at_5_year_boundaryActivityChild()
        {
            DisplayName = "Approval__50_000_at_5_year_boundary";
        }

        protected override async System.Threading.Tasks.Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var codedWorkflow = new global::ApplicationTestingILT.Approval__50_000_at_5_year_boundary();
            CodedWorkflowHelper.Initialize(codedWorkflow, new UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatureChecker(new System.Collections.Generic.List<string>() { UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatures.AsyncEntrypoints }), context);
            await System.Threading.Tasks.Task.Run(() => CodedWorkflowHelper.RunWithExceptionHandlingAsync(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext() { RelativeFilePath = "Approval $50,000 at 5-year boundary.cs" });
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }, () =>
            {
                CodedExecutionHelper.Run(() =>
                {
                    {
                        codedWorkflow.Execute();
                        newResult = new System.Collections.Generic.Dictionary<string, object>
                        {
                        };
                    }
                }, cancellationToken);
                return System.Threading.Tasks.Task.FromResult(newResult);
            }, (exception, outArgs) =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.After(new AfterRunContext() { RelativeFilePath = "Approval $50,000 at 5-year boundary.cs", Exception = exception });
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }), cancellationToken);
            return endContext =>
            {
            };
        }
    }
}