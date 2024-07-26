using Microsoft.AspNetCore.Mvc;

namespace Expenses.web.Controllers
{
    public class ExpensesController : Controller
    {
       /* private readonly IExpensesRepository _expense;

        public ExpensesController(IExpensesRepository expense)
        {
            _expense = expense;
        }

        public IActionResult Index(string searching)
        {
            List<ExpenseModel> Lists  = new List<ExpenseModel> ();
            if (string.IsNullOrEmpty(searching)) {
                Lists = _expense.GetAllExpenses().ToList();
                    }
            else {
                Lists = _expense.Search(searching).ToList();
            }
            return View(Lists); */
        }
    }
//}
