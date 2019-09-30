using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApp.Context.Repositories;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class KioskController : Controller
    {
        private readonly IMenuItemRepository _menuItemRepository;

        public KioskController(IMenuItemRepository menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }


        /// <summary>
        /// Get All Menu Items
        /// </summary>
        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            return _menuItemRepository.GetAllItems();
        }

        /// <summary>
        /// Get Selected Item
        /// </summary>
        /// <param name="id">Item ID</param>
        [HttpGet("{id}")]
        public ActionResult<MenuItem> Get(int id)
        {
            return _menuItemRepository.GetItem(id);
        }


        [HttpGet("menu/{id}")]
        public IEnumerable<MenuItem> GetMenu(int id)
        {
            return _menuItemRepository.GetAllMenuItems(id);
        }


        /// <summary>
        /// Add New Item
        /// </summary>
        /// <param name="item">New Item Data</param>
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

        /// <summary>
        /// 결제 정보를 받아서 DB에 저장한다.
        /// </summary>
        /// <param name="payment"></param>
        [HttpPost("payment")]
        public ActionResult PostPayment([FromBody] Payment payment)
        {
            if(ModelState.IsValid)
            {
                _menuItemRepository.AddPayment(payment);
                _menuItemRepository.Save();

                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        /// <summary>
        /// Edit Menu Item
        /// </summary>
        /// <param name="id">Item ID</param>
        /// <param name="item">Edited Menu Item Data</param>
        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]MenuItem item)
        {
            if(ModelState.IsValid)
            {
                _menuItemRepository.Update(id, item);
                _menuItemRepository.Save();
            }
        }

        /// <summary>
        /// Delete Menu Item
        /// </summary>
        /// <param name="id">Item ID</param>
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _menuItemRepository.Delete(id);
            _menuItemRepository.Save();

            return Ok();
        }
    }
}
