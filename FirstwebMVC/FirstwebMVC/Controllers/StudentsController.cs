using FirstwebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstwebMVC.Controllers
{
    public class StudentsController : Controller
    {
        public StudentData obj = new StudentData();

        public IActionResult StudentModelData()
        {
            //ViewBag.stdlist = obj.GetStdModel();
            var data = obj.GetStdModel();
            return View(data);   //data = studentInfo
        }

        public IActionResult StudentModelDataScaffold()
        {
            //ViewBag.stdlist = obj.GetStdModel();
            var data = obj.GetStdModel();
            return View(data.Where(c => c.Gender == Gender.Male));   //data = studentInfo
        }
        public IActionResult StudentList()
        {
            ViewBag.msg = "Welcome to first App";
            ViewBag.age = 25;

            List<string> std = new List<string>();
            std.Add("Student-1");
            std.Add("Student-2");
            std.Add("Student-3");
            std.Add("Student-4");
            std.Add("Student-5");

            std.Remove("Student-5");
            std.AddRange(StudentData.GetStudent());

            ViewBag.stdData = std;
            ViewBag.stddata1 = StudentData.GetStudent();

            return View();
        }
    }
}
