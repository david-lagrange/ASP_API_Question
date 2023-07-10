using Entities.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chief_river_nursery_backend.Presentation.Controllers
{
    [Route("api/inventory")]
    [ApiController]
    public class InventoryController : ControllerBase
    {

        private readonly IServiceManager _service;

        public InventoryController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetInventory()
        {

            var inventory = _service.InventoryService.GetAllInventory(trackChanges: false);

            return Ok(inventory);

        }

        [HttpGet("{id:guid}")]
        public IActionResult GetInventory(Guid id)
        {
            var inventory = _service.InventoryService.GetInventory(id, trackChanges: false);

            if (inventory is null)
                throw new InventoryNotFoundException(id);

            return Ok(inventory);
        }
    }
}
