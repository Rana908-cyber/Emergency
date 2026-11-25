using Emergency_R_S.Data;
using Emergency_R_S.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Emergency_R_S.Controllers
{
    public class CitizenController : Controller
    {
        private readonly EmgDBcontext context;
        public CitizenController(EmgDBcontext context)
        {
            this.context = context;
        }
    }
}
