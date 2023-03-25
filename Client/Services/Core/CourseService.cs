using BULB.Client.Services.Common;
using BULB.Shared.DTO;

namespace BULB.Client.Services.Core
{
    public class CourseService : BaseService<CourseDTO>
    {
        public CourseService(HttpClient client) 
            : base(client, "Course")
        {
        }
    }
}
