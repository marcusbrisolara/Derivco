using Derivco.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Derivco.Services
{
    public class Menu
    {
        public List<MenuItem> Items { get; set; }
        private List<MenuItem> _menuItems;
        public List<MenuItem> SeedMenuItems()
        {
            return new List<MenuItem>
            {
                new MenuItem{ Id = 1, ParentId = null, Description = "Administration" },
                new MenuItem{ Id = 2, ParentId = null, Description = "Reports" },
                new MenuItem{ Id = 3, ParentId = 1, Description = "User Admin" },
                new MenuItem{ Id = 4, ParentId = 1, Description = "Product Admin" },
                new MenuItem{ Id = 5, ParentId = 1, Description = "Order Admin" },
                new MenuItem{ Id = 6, ParentId = 2, Description = "Win Tech Report" },
                new MenuItem{ Id = 7, ParentId = 2, Description = "Microsoft Report" },
                new MenuItem{ Id = 8, ParentId = 3, Description = "Create User" },
                new MenuItem{ Id = 9, ParentId = 3, Description = "Edit User" },
                new MenuItem{ Id = 10, ParentId = 4, Description = "All Products" },
                new MenuItem{ Id = 11, ParentId = 4, Description = "Create Product" },
                new MenuItem{ Id = 12, ParentId = 5, Description = "Order Reports" },
                new MenuItem{ Id = 13, ParentId = 5, Description = "Create Order"  },
                new MenuItem{ Id = 14, ParentId = 10, Description = "My Products" },
                new MenuItem{ Id = 15, ParentId = 12, Description = "Audit Reports" },
                new MenuItem{ Id = 16, ParentId = 15, Description = "Update Orders" },
                new MenuItem{ Id = 17, ParentId = 15, Description = "Create Orders" }
            };
        }

        public void GenerateMenu(List<MenuItem> menuItems)
        {
            _menuItems = menuItems;
            if (_menuItems == null)
                _menuItems = SeedMenuItems();
            _menuItems.OrderByDescending(o => o.ParentId).ToList().ForEach(m =>
            {
                _menuItems.FirstOrDefault(f => f.Id.Equals(m.ParentId))?.SubItem.Add(m);
            });
            Items = _menuItems.Where(w => w.ParentId == null).ToList();
        }
    }
}
