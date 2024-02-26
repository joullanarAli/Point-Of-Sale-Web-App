
using DatabaseContext.UnitOfWork.Interface;
using Microsoft.AspNetCore.Mvc;
namespace web.Controllers
{
    public class BaseController : Controller
    {
        
        protected IUnitOfWork _unitOfWork;
        
        public BaseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
