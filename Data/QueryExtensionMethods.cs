using System.Linq;
using Microsoft.AspNetCore.Http;

namespace WeightRecorder.Data
{
    public static class QueryExtensionMethods
    {
        public static IQueryable<RecordedWeight> ForCurrentUser(this IQueryable<RecordedWeight> weights, HttpContext httpContext)
        {
            var userId = httpContext.User.GetUserId();
            
            return weights.Where(w => w.UserId == userId);
        }
    }
}
