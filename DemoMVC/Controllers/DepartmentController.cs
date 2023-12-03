using Demo.BLL.Interfaces;
using DemoDAL.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Extensions.Logging;
using Demo.BLL.Repository;
using AutoMapper;
using System.Collections.Generic;
using DemoMVC.ViewModels;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace DemoMVC.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DepartmentController> _logger;
        private readonly IMapper _mapper;

        public DepartmentController
            (
                IUnitOfWork unitOfWork,
                ILogger<DepartmentController> logger ,
                IMapper mapper
            )
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var deptartment =await _unitOfWork.DepartmentRepository.GetAllAsync();
            var DepartmentVM = _mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(deptartment);
            return View(DepartmentVM);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DepartmentViewModel departmentVM)
        {
            if(ModelState.IsValid)
            {
                var department = _mapper.Map<DepartmentViewModel, Department>(departmentVM);
                _unitOfWork.DepartmentRepository.Add(department);
                await _unitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }
            return View(departmentVM);
        }

        public async Task<IActionResult> Details(int? id , string ViewName = "Details")
        {
            if (!id.HasValue)
                return BadRequest();
            var department =await _unitOfWork.DepartmentRepository.GetByIdAsync(id.Value);
            var departmentVM = _mapper.Map<Department,DepartmentViewModel>(department);
            if (department is null)
                return NotFound();
            return View(ViewName,departmentVM);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            return await Details(id , "Edit");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute]int id,DepartmentViewModel departmentVM)
        {
            if(id != departmentVM.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    var department = _mapper.Map<DepartmentViewModel,Department>(departmentVM);
                    _unitOfWork.DepartmentRepository.Update(department);
                    await _unitOfWork.Complete();
                    return RedirectToAction(nameof(Index));
                }
                catch(Exception ex) 
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }

            return View(departmentVM);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            return await Details(id, "Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute] int id, DepartmentViewModel departmentVM)
        {
            if (id != departmentVM.Id)
                return BadRequest();
            try
            {
                var department = _mapper.Map<DepartmentViewModel,Department>(departmentVM);
                _unitOfWork.DepartmentRepository.Delete(department);
                await _unitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                //ModelState.AddModelError(string.Empty, ex.Message);
                _logger.LogError(ex.Message);
            }
            return View(departmentVM);
        }
    }
}
