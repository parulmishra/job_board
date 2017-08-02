using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

namespace JobBoard.Controllers
{
	public class HomeController : Controller
	{
		[Route("/")]
		public ActionResult Index()
		{
			return View();
		}
		
		[HttpGet("/job/list")]
        public ActionResult JobList()
        {
          List<JobOpening> allJobs = JobOpening.GetAll();
		  return View(allJobs);
		 // List<JobOpening> salesJobs = JobOpening.GetSales();
		 // List<JobOpening> softwareJobs = JobOpening.GetSoftware();
		 // List<JobOpening> marketingJobs = JobOpening.GetMarketing();
        }
		
		[HttpPost("/job/create")]
        public ActionResult CreateJob()
        {
			Contact jobContact = new Contact(Request.Form["contact-name"], Request.Form["contact-email"], Request.Form["contact-phone"]);
          JobOpening newJob = new JobOpening(Request.Form["job-title"], Request.Form["job-description"], int.Parse(Request.Form["experience"]), Request.Form["job-location"], jobContact);
		  
          newJob.Save();
          return View(newJob);
        }
	}
}