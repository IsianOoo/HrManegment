using Hr.Management.MVC.Contracts;
using Hr.Management.MVC.Models;
using Hr.Management.MVC.Services;
using Hr.Management.MVC.Services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hr.Management.MVC.Controllers
{
    public class LeaveTypeController : Controller
    {

        private readonly ILeaveTypeService _leaveTypeService;

        public LeaveTypeController(ILeaveTypeService leaveTypeRepository)
        {
            this._leaveTypeService = leaveTypeRepository;
        }
        // GET: LeaveTypeController
        public async Task<ActionResult>  Index()
        {
            var model = await _leaveTypeService.GetLeaveTypes();
            return View(model);
        }

        // GET: LeaveTypeController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View();
        }

        // GET: LeaveTypeController/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: LeaveTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateLeaveTypeVM leaveType)
        {
            try
            {
                var response = await _leaveTypeService.CreateLeaveType(leaveType);
                if(response.Success)
                {
                    return RedirectToAction(nameof(Index));
                }

                ModelState.AddModelError("", response.ValidationErrors);
                
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View(leaveType);
        }

        // GET: LeaveTypeController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View();
        }

        // POST: LeaveTypeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LeaveTypeController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View();
        }

        // POST: LeaveTypeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
