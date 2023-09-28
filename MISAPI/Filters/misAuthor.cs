using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MISAPI.Filters
{
    /// <summary>
    /// Check User has permission Report
    /// </summary>
    public class misAuthor : ActionFilterAttribute

    {
        private readonly string _reportID;
        public misAuthor(string reportID)
        {
            _reportID = reportID;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            {

                Boolean permiss = false;
                if (permiss == false)
                {
                    context.Result = new UnauthorizedObjectResult(new { ispermision = permiss });
                }
            }

        }

    }
}
