using Emergency_R_S.Data;
using Emergency_R_S.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Emergency_R_S.Controllers
{
    public class AdminController : Controller
    {
        private readonly EmgDBcontext context;
        public AdminController(EmgDBcontext context)
        {
            this.context = context;
        }
     
    }
}
