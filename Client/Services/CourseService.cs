using BULB.Client.Services.Common;
using BULB.Shared.DTO;
using BULB.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
 

namespace BULB.Client.Services
{
    public class CourseService : BaseService<CourseDTO>
    {
        public CourseService(HttpClient client)
    : base(client, "Course")
        {
        }
    }
}
