using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.API.Data;
using ShoppingApp.API.Models;

namespace ShoppingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        public IShoppingService _shoppingService { get; }
        public ShoppingController(IShoppingService shoppingService)
        {
            _shoppingService = shoppingService;

        }
        // GET api/shoppingcart
    [HttpGet]
    public ActionResult<IEnumerable<ShoppingItem>> Get()
    {
        var items = _shoppingService.GetAllItems();
        return Ok(items);
    }
 
    // GET api/shoppingcart/5
    [HttpGet("{id}")]
    public ActionResult<ShoppingItem> Get(Guid id)
    {
        var item = _shoppingService.GetById(id);
 
        if (item == null)
        {
            return NotFound();
        }
 
        return Ok(item);
    }
 
    // POST api/shoppingcart
    [HttpPost]
    public ActionResult Post([FromBody] ShoppingItem value)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
 
        var item = _shoppingService.Add(value);
        return CreatedAtAction("Get", new { id = item.Id }, item);
    }
 
    // DELETE api/shoppingcart/5
    [HttpDelete("{id}")]
    public ActionResult Remove(Guid id)
    {
        var existingItem = _shoppingService.GetById(id);
 
        if (existingItem == null)
        {
            return NotFound();
        }
 
        _shoppingService.Remove(id);
        return Ok();
    }
    }
}
