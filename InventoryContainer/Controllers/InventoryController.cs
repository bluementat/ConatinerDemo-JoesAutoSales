using InventoryContainer.DataAccess;
using InventoryContainer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryContainer.Controllers
{    
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryRepository _inventoryDB;
        
        public InventoryController(IInventoryRepository InventoryDB)
        {
            _inventoryDB = InventoryDB;
        }
        
        [HttpGet]
        [Route("inventoryendpoint")]
        public ActionResult GetAll()
        {
            return Ok(_inventoryDB.GetAll());
        }
    }
}
