/* IT19152110
 * Rajapaksha K.D.
 */
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentService.Data;
using PaymentService.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PaymentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {

        private readonly IApplicationDbContext context;

        public PaymentController(IApplicationDbContext context)
        {
            this.context = context;

        }



        // GET: api/<PaymentController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var pay = await this.context.Payments.ToListAsync();
            if (pay == null) return NotFound();
            return Ok(pay);
        }




        // GET api/<PaymentController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var pay = await this.context.Payments.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (pay == null) return NotFound();
            return Ok(pay);
        }




        // POST api/<PaymentController>
        [HttpPost]
        public async Task<IActionResult> Create(Payment pay)
        {
            this.context.Payments.Add(pay);
            await this.context.SavePaymentChanges();
            return Ok(pay.Id);
        }





    }
}
