using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DAL;
using TokenTrackerQuickApp.ViewModels;
using AutoMapper;
using Microsoft.Extensions.Logging;
using TokenTrackerQuickApp.Helpers;
using DAL.DefinitionsImported;
using Microsoft.EntityFrameworkCore;
using DAL.Models;

namespace TokenTrackerQuickApp.Controllers
{

    [Route("api/[controller]")]
    public class PointTransactionController : Controller
    {
        // test coment
        private IUnitOfWork _unitOfWork;
        readonly ILogger _logger;
        readonly IEmailSender _emailSender;
        ApplicationDbContext _context;
        AccountController _acctController;

        public PointTransactionController(IUnitOfWork unitOfWork, ILogger<PointTransactionController> logger, IEmailSender emailSender, ApplicationDbContext context, AccountController acctController)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _emailSender = emailSender;
            _context = context;
            _acctController = acctController;
        }



        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            List<PointTransaction> pointTransactions = _context.Set<PointTransaction>().ToList();
            return Ok(pointTransactions);
            //var allCustomers = _unitOfWork.Customers.GetAllCustomersData();
            //return Ok(Mapper.Map<IEnumerable<CustomerViewModel>>(allCustomers));
        }



        [HttpGet("throw")]
        public IEnumerable<CustomerViewModel> Throw()
        {
            throw new InvalidOperationException("This is a test exception: " + DateTime.Now);
        }



        [HttpGet("email")]
        public async Task<string> Email()
        {
            string recepientName = "QickApp Tester"; //         <===== Put the recepient's name here
            string recepientEmail = "test@ebenmonney.com"; //   <===== Put the recepient's email here

            string message = EmailTemplates.GetTestEmail(recepientName, DateTime.UtcNow);

            (bool success, string errorMsg) = await _emailSender.SendEmailAsync(recepientName, recepientEmail, "Test Email from TokenTrackerQuickApp", message);

            if (success)
                return "Success";

            return "Error: " + errorMsg;
        }



        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value: " + id;
        }



        // POST api/values
        [HttpPost]
        public void Post([FromBody] PointTransaction transaction)
        {
            transaction.TransactionDate = DateTime.Now;

            int pointsToAward = transaction.Points;

            List<ApplicationUser> users = _acctController.GetUsers();

            ApplicationUser receivingUser = users.Where(u => u.UserId == transaction.AwardToId).SingleOrDefault();

            ApplicationUser givingUser = users.Where(u => u.UserId == transaction.AwardFromId).SingleOrDefault();

            receivingUser.TotalTokensAwarded += pointsToAward;
            receivingUser.AwardsBankBalance += pointsToAward;

            givingUser.GiveBankBalance -= pointsToAward;

            _context.PointTransaction.Add(transaction);

            _context.SaveChanges();
        }



        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }



        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
