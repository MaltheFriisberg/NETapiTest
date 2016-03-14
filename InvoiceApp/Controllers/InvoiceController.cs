using InvoiceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InvoiceApp.Controllers
{
    public class InvoiceController : ApiController
    {
        Invoice[] invoices = new Invoice[]
        {
            new Invoice {id = 0, name = "hans" },
            new Invoice {id = 1, name = "kurt" }
        };

        public IEnumerable<Invoice> GetAllInvoices()
        {
            return invoices;
        }
        public IHttpActionResult GetInvoice(int id)
        {
            var invoice = invoices.FirstOrDefault((p) => p.id == id);
            if (invoice == null)
            {
                return NotFound();
            }
            return Ok(invoice);
        }
    }
}
