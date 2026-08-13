using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Runtime;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using UiPath.Robot.Activities.Api;
using UiPath.Shared.Activities;
using UiPath.Shared.Activities.Performance;
using UiPath.Testing.Activities.Performance;
using ApplicationTestingILT;

namespace Application.Testing.ILT
{
    [System.ComponentModel.Browsable(false)]
    public class BootloaderActivity : System.Activities.Activity
    {
        public InArgument<System.String> pipeName { get; set; }
        public InArgument<System.String> workflowPath { get; set; }
        public InArgument<System.Collections.Generic.Dictionary<System.String, System.Object>> wfArgs { get; set; }

        public BootloaderActivity()
        {
            this.Implementation = () =>
            {
                return new BootloaderActivityChild()
                {
                    pipeName = (this.pipeName == null ? (InArgument<System.String>)Argument.CreateReference((Argument)new InArgument<System.String>(), "pipeName") : (InArgument<System.String>)Argument.CreateReference((Argument)this.pipeName, "pipeName")),
                    workflowPath = (this.workflowPath == null ? (InArgument<System.String>)Argument.CreateReference((Argument)new InArgument<System.String>(), "workflowPath") : (InArgument<System.String>)Argument.CreateReference((Argument)this.workflowPath, "workflowPath")),
                    wfArgs = (this.wfArgs == null ? (InArgument<System.Collections.Generic.Dictionary<System.String, System.Object>>)Argument.CreateReference((Argument)new InArgument<System.Collections.Generic.Dictionary<System.String, System.Object>>(), "wfArgs") : (InArgument<System.Collections.Generic.Dictionary<System.String, System.Object>>)Argument.CreateReference((Argument)this.wfArgs, "wfArgs")),
                };
            };
        }
    }

    internal class BootloaderActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public InArgument<System.String> pipeName { get; set; }
        public InArgument<System.String> workflowPath { get; set; }
        public InArgument<System.Collections.Generic.Dictionary<System.String, System.Object>> wfArgs { get; set; }
        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public BootloaderActivityChild()
        {
            DisplayName = "Bootloader";
        }

        protected override async System.Threading.Tasks.Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var var_pipeName = pipeName.Get(context);
            var var_workflowPath = workflowPath.Get(context);
            var var_wfArgs = wfArgs.Get(context);
            var codedWorkflow = new global::ApplicationTestingILT.Bootloader();
            CodedWorkflowHelper.Initialize(codedWorkflow, new UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatureChecker(new System.Collections.Generic.List<string>() { UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatures.AsyncEntrypoints }), context);
            await System.Threading.Tasks.Task.Run(() => CodedWorkflowHelper.RunWithExceptionHandlingAsync(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext() { RelativeFilePath = "PerformanceTestingBootloaderWorkflow.cs" });
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }, async () =>
            {
                await codedWorkflow.Execute(var_pipeName, var_workflowPath, var_wfArgs, cancellationToken);
                newResult = new System.Collections.Generic.Dictionary<string, object>
                {
                };
                return newResult;
            }, (exception, outArgs) =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.After(new AfterRunContext() { RelativeFilePath = "PerformanceTestingBootloaderWorkflow.cs", Exception = exception });
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }), cancellationToken);
            return endContext =>
            {
            };
        }
    }
}