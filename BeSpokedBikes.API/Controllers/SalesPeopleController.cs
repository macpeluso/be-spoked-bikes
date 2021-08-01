using BeSpokedBikes.Application.Models;
using BeSpokedBikes.Application.Queries.SalesPeople;
using BeSpokedBikes.Domain.Exceptions;
using BeSpokedBikes.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeSpokedBikes.API.Controllers
{
    public class SalesPeopleController : BaseController
    {
        private readonly ISalesPeopleQueries salesPeopleQueries;
        private readonly BSBContext context;

        public SalesPeopleController(BSBContext context, ISalesPeopleQueries queries)
        {
            this.salesPeopleQueries = queries;
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/getSalesPeople")]
        public async Task<List<SalesPersonModel>> GetCustomers() => await this.salesPeopleQueries.GetSalesPeople();
        [HttpPost("editAssociate")]
        public async Task<JsonResult> Edit(SalesPersonModel model)
        {
            try
            {


                var person = await this.context.SalesPeople.FirstOrDefaultAsync(x => x.SalesPersonId == model.SalesPersonId);

                if (person == null) throw new RestException("That product doesn't exist");
                person.Manager = model.Manager;
                person.TerminationDate = model.TerminationDate;
                person.Contact.FirstName = model.FirstName;
                person.Contact.LastName = model.LastName;
                person.Contact.Phone = model.Phone;
                person.Contact.Address.StreetAddress = model.StreetAddress;
                person.Contact.Address.SubAddress = model.SubAddress;
                person.Contact.Address.City = model.City;
                person.Contact.Address.State = model.State;
                person.Contact.Address.PostalCode = model.PostalCode;

                await context.SaveChangesAsync();

                return new JsonResult(new { success = true });
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
