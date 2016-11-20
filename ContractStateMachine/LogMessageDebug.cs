using System.Activities;
using log4net;

namespace ContractStateMachine
{
    public sealed class LogMessageDebug : CodeActivity
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LogMessageDebug));

        public InArgument<string> Message { get; set; }

        // Si votre activité retourne une valeur, dérivez de CodeActivity<TResult>
        // et retournez la valeur à partir de la méthode Execute.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtenir la valeur runtime de l'argument d'entrée Text
            string text = context.GetValue(Message);

            var workflowId = context.WorkflowInstanceId;
            log.Debug($"[{workflowId}] {text}");
        }
    }
}
