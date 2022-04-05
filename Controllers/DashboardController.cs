using Microsoft.AspNetCore.Mvc;

namespace BankingManagementSystem.Controllers
{
    public class DashboardController : Controller
    {
    private readonly VSFBankContext _db;
        public DashboardController(VSFBankContext context)
        {
            _db = context;
        }
        
        public IActionResult Index()
        {
        //TempData["Accountnumber"] = 500102300208;
            return View();
        }
        public IActionResult AccountSummary()
        {
            //List<CustomerAcc> customerAccs = _db.CustomerAccs.ToList();
            var result = (from details in _db.CustomerAccs
                          where details.CustomerId == "1001"
                          select details).ToList();
            return View(result);
        }
        public IActionResult AccountDetails()
        {
            //List<TransactionDetail> transactionDetails = _db.TransactionDetails.ToList();
            var result = (from details in _db.TransactionDetails
                          where details.AccountNumber == 200106300808
                          select details).ToList();
            return View(result);
        }
    }
}
