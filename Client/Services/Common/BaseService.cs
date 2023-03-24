using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using BULB.Shared.DTO;
using BULB.EF.Models;
using BULB.Shared;
using System.Collections.Generic;
using BULB.Shared.Utils;


namespace BULB.Client.Services.Common
{
    public class BaseService<E>
    {
        protected HttpClient Http { get; set; }
        public string RestAPI;
        protected string BaseObject;

        protected JsonSerializerOptions options = new JsonSerializerOptions()
        {
            ReferenceHandler = ReferenceHandler.Preserve,
            PropertyNameCaseInsensitive = true
        };

        public BaseService(HttpClient client, String ControllerName)
        {
            Http = client;
            this.RestAPI = $"api/{ControllerName}";
            this.BaseObject = ControllerName;
        }


        public async Task<List<E>> Get()
        {
            return await Http.GetFromJsonAsync<List<E>>($"{RestAPI}/Get{BaseObject}", options);

        }

        public async Task<E> Get(string ID)
        {
            return await Http.GetFromJsonAsync<E>($"{RestAPI}/Get{BaseObject}/{ID}", options);

        }

    }
}
