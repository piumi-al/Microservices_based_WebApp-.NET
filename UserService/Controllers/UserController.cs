/* IT19207964
 * Weerasooriya K.T.N.
 */
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Data;
using UserService.Entites;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IApplicationDbContext context;

        public UserController(IApplicationDbContext context)
        {
            this.context = context;

        }

        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await this.context.Users.ToListAsync();
            if (customers == null) return NotFound();
            return Ok(customers);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await this.context.Users.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (user == null) return NotFound();
            return Ok(user);
        }




        // POST api/<CustomerController>
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            this.context.Users.Add(user);
            await this.context.SaveUserChanges();
            return Ok(user.Id);
        }





        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, User userUpdate)
        {
            var user = this.context.Users.Where(a => a.Id == id).FirstOrDefault();
            if (user == null) return NotFound();
            else
            {
                user.FirstName = userUpdate.FirstName;
                user.LastName = userUpdate.LastName;
                user.Contact = userUpdate.Contact;
                user.Address = userUpdate.Address;
                user.Email = userUpdate.Email;
                await this.context.SaveUserChanges();
                return Ok(user.Id);
            }
        }



        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var customer = await this.context.Users.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (customer == null) return NotFound();
            this.context.Users.Remove(customer);
            await this.context.SaveUserChanges();
            return Ok(customer.Id);
        }
    }
}
