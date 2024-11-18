using Microsoft.AspNetCore.Mvc;
using cumulative_assingment_1.Models;
using cumulative_assingment_1.Controllers;

namespace cumulative_assingment_1.Controllers
{
    public class TeacherPageController : Controller
    {

        // currently relying on the API to retrieve author information
        // this is a simplified example. In practice, both the TeacherAPI and TeacherPage controllers
        // should rely on a unified "Service", with an explicit interface
        private readonly TeacherAPIController _api;

        public TeacherPageController(TeacherAPIController api)
        {
            _api = api;
        }

        //GET : TeacherPage/List
        public IActionResult List()
        {
            List<Teacher> Teachers = _api.ListTeachers();
            return View(Teachers);
        }

        //GET : TeacherPage/Show/{id}
        public IActionResult Show(int id)
        {
            Teacher SelectedTeacher = _api.FindTeacher(id);
            return View(SelectedTeacher);
        }


    }
}
