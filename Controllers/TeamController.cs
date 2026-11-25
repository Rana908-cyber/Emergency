using Emergency_R_S.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Emergency_R_S.Controllers
{
    public class TeamController : Controller
    {

        private readonly EmgDBcontext context;
        public TeamController(EmgDBcontext context)
        {
            this.context = context;
        }
    }
}
