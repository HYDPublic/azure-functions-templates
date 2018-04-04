#if (portalTemplates)
#r "Microsoft.Azure.EventGrid"
using Microsoft.Azure.EventGrid.Models;

public static void Run(EventGridEvent eventGridEvent, TraceWriter log)
#endif
#if (vsTemplates)
// Default URL for triggering event grid function in the local environment.
// http://localhost:7071/runtime/webhooks/EventGridExtensionConfig?functionName={functionname}

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.EventGrid.Models;
using Microsoft.Azure.WebJobs.Extensions.EventGrid;

namespace Company.Function
{
    public static class EventGridTriggerCSharp
    {
        [FunctionName("EventGridTriggerCSharp")]
        public static void Run([EventGridTrigger]EventGridEvent eventGridEvent, TraceWriter log)
#endif
        {
            log.Info(eventGridEvent.Data.ToString());
        }
#if (vsTemplates)
    }
}
#endif