using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LagoonOrderApp.Services
{
    public class JsonConvertService
    {
        public JsonConvertService()
        {

        }

        public T ConvertToModel<T>(string json)
        {
            var result = JsonConvert.DeserializeObject<T>(json);

            return result;
        }

        public string ConvertToJson(object model)
        {
            var result = JsonConvert.SerializeObject(model);

            return result;
        }
    }
}
