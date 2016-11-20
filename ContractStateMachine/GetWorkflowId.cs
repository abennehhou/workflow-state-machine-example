using System;
using System.Activities;
using log4net;

namespace ContractStateMachine
{
    public sealed class GetWorkflowId : CodeActivity
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(GetWorkflowId));

        public OutArgument<Guid> WorkflowId { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var workflowId = context.WorkflowInstanceId;
            log.Debug($"Workflow Instance Id: {workflowId}.");
            context.SetValue(WorkflowId, workflowId);
        }
    }
}
