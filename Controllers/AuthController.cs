using Emergency_R_S.Models;
using Microsoft.AspNetCore.Mvc;
using Emergency_R_S.Data;

namespace Emergency_R_S.Controllers
{
    public class AuthController : Controller
    {
            private readonly EmgDBcontext context;
            public AuthController(EmgDBcontext context)
            {
                this.context = context;
            }
          
        }
    }

