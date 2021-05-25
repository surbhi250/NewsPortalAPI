using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewsPortal.Data;
using NewsPortal.Model;

namespace NewsPortal.Pages
{
    public class EditNewsModel : PageModel
    {


        private readonly NewsPortalContext _context;

        public EditNewsModel(NewsPortalContext context)
        {
            _context = context;
        }


        [BindProperty]
        public News news { get; set; }


        public void OnGet(int? id)
        {
            if (id != null)
            {
                var data = (from customer in _context.News
                            where customer.NewsID == id
                            select customer).SingleOrDefault();

                news = data;
            }
        }

        public ActionResult OnPost()
        {
            var customer=news;
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Entry(customer).Property(x => x.HLine).IsModified = true;
            _context.Entry(customer).Property(x => x.NDetails).IsModified = true;
            _context.Entry(customer).Property(x => x.NCity).IsModified = true;
            _context.Entry(customer).Property(x => x.NDate).IsModified = true;
            
            _context.SaveChanges();
            return RedirectToPage("allNews");
        }


    }
}
