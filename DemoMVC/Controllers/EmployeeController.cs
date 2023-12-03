using AutoMapper;
using Demo.BLL.Interfaces;
using DemoDAL.Model;
using DemoMVC.Helper;
using DemoMVC.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Controllers
{
	[Authorize]
	public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeController(IUnitOfWork unitOfWork , IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index(string SearchName = "")
        {
            IEnumerable<Employee> employee;
            if (string.IsNullOrEmpty(SearchName))
                employee =await _unitOfWork.EmployeeRepository.GetAllAsync();
            else
                employee = _unitOfWork.EmployeeRepository.Search(SearchName);
            ///Try joining
            ///var dep = _unitOfWork.DepartmentRepository.GetAll();
            ///ViewBag.EmpDep = employee.Join(dep,
            ///e => e.DepartmentId,
            ///d => d.Id,
            ///(emp, dep) => new
            ///                       {
            ///emp,
            ///departmentName = dep.Name
            ///                       });
            ///ViewBag.EmpDepJoin = employee;
            
            var employeeVM = _mapper.Map<IEnumerable<Employee>,IEnumerable<EmployeeViewModel>>(employee);
            return View(employeeVM);
        }

        public async Task<IActionResult> Search(string SearchName = "")
        {
            IEnumerable<Employee> employee;
            if (string.IsNullOrEmpty(SearchName))
                employee = await _unitOfWork.EmployeeRepository.GetAllAsync();
            else
                employee = _unitOfWork.EmployeeRepository.Search(SearchName);
            ///Try joining
            ///var dep = _unitOfWork.DepartmentRepository.GetAll();
            ///ViewBag.EmpDep = employee.Join(dep,
            ///e => e.DepartmentId,
            ///d => d.Id,
            ///(emp, dep) => new
            ///                       {
            ///emp,
            ///departmentName = dep.Name
            ///                       });
            ///ViewBag.EmpDepJoin = employee;

            var employeeVM = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(employee);
            return PartialView("EmployeeTablePartialView",employeeVM);
        }

        public IActionResult Create()
        {
        //    ViewBag.Departments = _unitOfWork.DepartmentRepository.GetAll();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeViewModel employeeVM)
        {
            if (ModelState.IsValid)
            {
                employeeVM.ImageName =await DocumentSetting.UploadFile(employeeVM.Image, "Images");
                var employee = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
                _unitOfWork.EmployeeRepository.Add(employee);
                await _unitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeVM);
        }


        public async Task<IActionResult> Details(int? id , string ViewName = "Details")
        {
            if (!id.HasValue)
                return BadRequest();
            var employee = await _unitOfWork.EmployeeRepository.GetByIdAsync(id.Value);
            var mappedEmployee = _mapper.Map<Employee, EmployeeViewModel>(employee);
            if(employee is null)
                return NotFound();
            ViewBag.Dep = _unitOfWork.DepartmentRepository.GetByIdAsync((int)employee.DepartmentId).Result.Name;
            return View(ViewName, mappedEmployee);
        }

        public async Task<IActionResult> Edit(int? id) 
               => await Details(id, "Edit");


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute]int id,EmployeeViewModel employeeVM)
        {
            if (id != employeeVM.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    if(employeeVM.Image!= null)
                    {
                        string imgName = employeeVM.ImageName;
                        employeeVM.ImageName =await DocumentSetting.UploadFile(employeeVM.Image, "Images");
                        DocumentSetting.DeleteFile(imgName, "Images");
                    }
                    var employee = _mapper.Map<EmployeeViewModel,Employee>(employeeVM);
                    _unitOfWork.EmployeeRepository.Update(employee);
                    await _unitOfWork.Complete();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError(string.Empty , ex.Message);
                }
            }

            return View(employeeVM);
        }


        public async Task<IActionResult> Delete(int? id) 
            =>await Details(id, "Delete");

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute]int? id , EmployeeViewModel employeeVM)
        {
            if (id != employeeVM.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    var employee = _mapper.Map<EmployeeViewModel,Employee>(employeeVM);
                    _unitOfWork.EmployeeRepository.Delete(employee);
                    var count =await _unitOfWork.Complete();
                    if (count > 0)
                        DocumentSetting.DeleteFile(employeeVM.ImageName, "Images");
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }
            return View(employeeVM);
        }
    }
}
