using clase02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clase02.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Empleado()
        {
            using (Tbl_empleadoEntities1 Empl = new Tbl_empleadoEntities1())
            {
                var listadoempleado = Empl.UserList.ToList();
                return View(listadoempleado);
            }


        }
        public ActionResult Delete(int id)
        {
            using (Tbl_empleadoEntities1 Empl = new Tbl_empleadoEntities1())
            {

                UserList EliminarEmpleado = Empl.UserList.Where
                    (x => x.Id_empleado == id).FirstOrDefault();
                Empl.UserList.Remove(EliminarEmpleado);
                Empl.SaveChanges();
            }


            return Redirect("/Empleado/Empleado");


        }

        public ActionResult Registro(String nombre, int id=0)
        {
            ViewBag.id = id;
            ViewBag.nombre = nombre;
            
            return View();
        }

        [HttpPost]
        public ActionResult Save(String nombre, int dui, int id)
        {

            using (Tbl_empleadoEntities1 emp = new Tbl_empleadoEntities1())
            {
                UserList empleado = new UserList();

                if (id == 0)
                {

                    empleado.Empl_nombre = nombre;
                    empleado.Empl_DUI = dui;
                    emp.UserList.Add(empleado);
                    emp.SaveChanges();
                }
                else
                {
                    int idupdate = id;
                    UserList editar = emp.UserList.Where(x => x.Id_empleado == idupdate).FirstOrDefault();
                    editar.Empl_nombre = nombre;
                    emp.SaveChanges();
                }

            }




            return Redirect("/Empleado/Empleado");
        }

        public ActionResult Edit(int id)
        {
            ViewBag.id = id;

            return View();
        }

    }


}