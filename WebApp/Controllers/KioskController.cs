using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Context.Repositories;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KioskController : ControllerBase
    {
        private readonly IMenuItemRepository _menuItemRepository;

        public KioskController(IMenuItemRepository menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }


        // GET: api/<controller>
        /// <summary>
        /// Get All Menu Items
        /// </summary>
        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            return _menuItemRepository.GetAllItems();
        }

        // GET api/<controller>/5
        /// <summary>
        /// Get Selected Item
        /// </summary>
        /// <param name="id">Item ID</param>
        [HttpGet("{id}")]
        public ActionResult<MenuItem> Get(int id)
        {
            return _menuItemRepository.GetItem(id);
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult Post([FromBody] MenuItem item)
        {
            if(ModelState.IsValid)
            {
                _menuItemRepository.AddItem(item);
                _menuItemRepository.Save();

                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]MenuItem item)
        {
            if(ModelState.IsValid)
            {
                _menuItemRepository.Update(id, item);
                _menuItemRepository.Save();
            }
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _menuItemRepository.Delete(id);
            _menuItemRepository.Save();

            return Ok();
        }
    }
}
