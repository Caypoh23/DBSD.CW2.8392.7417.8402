﻿using DBSD.CW2._8392._7417._8402.DAL;
using DBSD.CW2._8392._7417._8402.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace DBSD.CW2._8392._7417._8402.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientRepository _repository;
        private readonly IConfiguration _configuration;

        public PatientController(IPatientRepository repository, IConfiguration configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }
        // GET: PatientController
        public ActionResult Filter(
                int pageNum,
                PatientFilterViewModel filter
            )
        {
            if (pageNum <= 0)
                pageNum = 1;
            int pageSize = _configuration.GetValue<int>("ViewSettings:PageSize");
            var patients = _repository.Filter(filter.Name,
                                              filter.Address,
                                              filter.RegisteredDate,
                                              filter.DiagnoseName,
                                              filter.DoctorName,
                                              pageSize, 
                                              filter.SortColumn.ToString(),
                                              pageNum,
                                              out int totalCount,
                                             filter.SortDesc);

            filter.Patients = new StaticPagedList<Patient>(patients, pageNum, pageSize, totalCount);
            filter.CurrentPage = pageNum;

            return View(filter);
        }

        // GET: PatientController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PatientController/Create
        public ActionResult Create()
        {
            var model = new PatientCreateEditViewModel
            {
                Diagnoses = new SelectList(_repository.GetDiagnoses(), "Id", "Name"),
                Doctors = new SelectList(_repository.GetDoctors(), "Id", "Name"),
                Wards = new SelectList(_repository.GetWards(), "Id", "Number")
            };
            return View(model);
        }

        // POST: PatientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PatientCreateEditViewModel model)
        {
          
            try
            {
                var patient = new Patient
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    DoB = model.DoB,
                    Occupation = model.Occupation,
                    Gender = model.Gender,
                    Phone = model.Phone,
                    Address = model.Address,
                    DoctorId = model.DoctorId,
                    DiagnoseId = model.DiagnoseId,
                    WardId = model.WardId,
                    EmergencyHospitalization = model.EmergencyHospitalization
                };
                _repository.Insert(patient);

                return RedirectToAction(nameof(Filter));
            }
          
           catch
            {
                return View(model);

            }
          
        }

        // GET: PatientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PatientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: PatientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PatientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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