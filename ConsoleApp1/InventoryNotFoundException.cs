using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class InventoryNotFoundException : NotFoundException
    {
        public InventoryNotFoundException(Guid inventoryId) : base($"The inventory with id: {inventoryId} doesn't exist in the database.") { }
    }
}
