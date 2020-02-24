using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QLTHEs.Datas.Models.qlTheModels;
using QLTHEs.Datas.Repositories;
using QLTHEs.Models;

namespace QLTHEs.Controllers
{
    public class CapThesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        [BindProperty]
        public CapTheViewModel capTheVM { get; set; }
        public CapThesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            capTheVM = new CapTheViewModel
            {
                CapThes = _unitOfWork.capTheRepository.GetAll()
                
            };
            foreach (var capthe in capTheVM.CapThes)
            {
                capthe.NguoiCap = _unitOfWork.nhanVienRepository.GetByStringId(capthe.NguoiCap).TenNv;
                capthe.NguoiNhan = _unitOfWork.nhanVienRepository.GetByStringId(capthe.NguoiNhan).TenNv;
                capthe.VanPhong = _unitOfWork.vanPhongRepository.GetByStringId(capthe.VanPhong).TenVp;
                
            }
        }
        public IActionResult Index()
        {
            
            return View(capTheVM);
        }
    }
}