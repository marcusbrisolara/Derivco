using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Derivco.Entities
{
    public class MenuItem
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public int? ParentId { get; set; }
        public string Description { get; set; }
        
        public List<MenuItem> SubItem { get; set; }

        public MenuItem()
        {
            SubItem = new List<MenuItem>();
        }
    }
}
