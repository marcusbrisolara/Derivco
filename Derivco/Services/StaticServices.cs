using Derivco.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Derivco.Services
{
    public static class StaticServices
    {
        public static string ToJson(this List<MenuItem> menuItems)
        {            
            return JsonConvert.SerializeObject(menuItems);
        }
    }
}
