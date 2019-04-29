﻿using aid_id.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aid_id.Controllers
{
    public class LoginController : Controller
    {
        //GET Login/Index or Login
        //http://localhost:51356/ or http://localhost:51356/Login
        [AllowAnonymous]
        public ActionResult Index()
        {
            string value = "";
            var cookieLogin = ControllerContext.HttpContext.Request.Cookies["cookieLogin"];
            if (cookieLogin != null)
            {
                value = cookieLogin.Value;
            }
            if (value == "1")
            {
                return View("Logged");
            }
            //else
            return View("Index");
        }

        //POST FORM FROM -> SignInForm
        //http://localhost:51356/Login/Verify
        [HttpPost]
        [Route("/Login/SingIn/Verify")]
        [ValidateAntiForgeryToken]
        public ActionResult Verify()
        {
            try
            {
                using (Aid_idContext db = new Aid_idContext())//Context -> Make connection to database ...
                {
                    try//Try login success...
                    {
                        ViewBag.Error = "";
                        //String not delete with reload page for the inputEmail
                        string EmailConfirmed = "";
                        try
                        {
                            EmailConfirmed = (TempData["EmailConfirmed"]).ToString();
                        }
                        catch (Exception) { }
                        ViewBag.Email = EmailConfirmed;
                        //QUERY SELECT
                        //SELECT CORREO FROM USUARIOS WHERE CORREO = DATAINPUT LIMIT 1; DATA INPUT EXAMPLE = raulcaro38@gmail.com;
                        var email = Request.Form["inputEmail"]; //raulcaro38@gmail.com
                        var pass = Request.Form["inputPass"]; //123abc
                        Sha1 encript = new Sha1();
                        var passEncripted = encript.GetSHA1(pass);
                        //https://sha1.gromweb.com/
                        /*String -> 123abc =  SHA1 -> 4be30d9814c6d4e9800e0d2ea9ec9fb00efa887b*/
                        var res = (from Usuarios u in db.Usuarios
                                   where u.Correo == EmailConfirmed //raulcaro38@gmail.com
                                   where u.Passcode == passEncripted //123abc
                                   select u).First();
                        //Cookies Save
                        HttpCookie cookieLogin = new HttpCookie("cookieLogin", "1");
                        cookieLogin.Expires = DateTime.Now.AddYears(1); //the cookie is deleted after one year
                        ControllerContext.HttpContext.Response.SetCookie(cookieLogin);
                        HttpCookie cookieEmail = new HttpCookie("cookieEmail", email);
                        cookieLogin.Expires = DateTime.Now.AddYears(1); //the cookie is deleted after one year
                        ControllerContext.HttpContext.Response.SetCookie(cookieEmail);
                        return View("Logged");
                    }
                    catch (InvalidOperationException) //If login fail...
                    {
                        var email = Request.Form["inputEmail"]; //raulcaro38@gmail.com
                        ViewBag.Error = "Error, password not correct";
                        return View("SingIn");
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                ViewBag.Error = "Error, No se puede conectar con la BBDD";
                return View("Index");
            }
        }

        public ActionResult Register()
        {
            using (Aid_idContext db = new Aid_idContext())
            {
                Usuarios user = new Usuarios();
                //Nombre
                user.Nombre = Request.Form["inputNameRegister"];
                //Apellido
                user.Apellido = Request.Form["inputSurnameRegister"];
                //Edad
                byte inputAgeRegisterByte = 0;
                Byte.TryParse(Request.Form["inputAgeRegister"], out inputAgeRegisterByte);
                user.Edad = inputAgeRegisterByte;
                //Peso
                byte inputWeightRegisterByte = 0;
                Byte.TryParse(Request.Form["inputWeightRegister"], out inputWeightRegisterByte);
                user.Peso = inputWeightRegisterByte;
                //Altura
                byte inputHeightRegisterByte = 0;
                Byte.TryParse(Request.Form["inputHeightRegister"], out inputHeightRegisterByte);
                user.Altura = inputHeightRegisterByte;
                //Email
                user.Correo = Request.Form["inputEmailRegister"];
                //PASSWORD inputPass1Register
                Sha1 encript = new Sha1();
                var passEncripted = encript.GetSHA1(Request.Form["inputPass1Register"]);
                user.Passcode = passEncripted;
                //Glucemia Min
                byte inputGluMinRegisterByte = 0;
                Byte.TryParse(Request.Form["inputGluMinRegister"], out inputGluMinRegisterByte);
                user.Glucemia_min = inputGluMinRegisterByte;
                //Glucemia Max
                byte inputGluMaxRegisterByte = 0;
                Byte.TryParse(Request.Form["inputGluMaxRegister"], out inputGluMaxRegisterByte);
                user.Glucemia_max = inputGluMaxRegisterByte;
                //Ratio Ins/Glu (mg/dl)/U
                byte inputInsGluRegisterByte = 0;
                Byte.TryParse(Request.Form["inputInsGluRegister"], out inputInsGluRegisterByte);
                user.R_insulina_gluc = inputInsGluRegisterByte;
                //Ratio Ins/Ch (g/U)
                byte inputInsChRegisterByte = 0;
                Byte.TryParse(Request.Form["inputInsGluRegister"], out inputInsChRegisterByte);
                user.R_insulina_carb = inputInsChRegisterByte;
                //inputInsTotRegister
                byte inputInsTotRegisterByte = 0;
                Byte.TryParse(Request.Form["inputInsTotRegister"], out inputInsTotRegisterByte);
                user.Total_insulina_diaria = inputInsTotRegisterByte;
                //INSERT IN DATABASE
                if (user != null)
                {
                    db.Usuarios.Add(user);
                    db.SaveChanges(); 
                }
                ViewBag.Nombre = user.Nombre;
                return View("Register");
            }
        }

        //POST FORM FROM -> IndexForm
        //http://localhost:51356/Login/SingIn/
        [HttpPost]
        [Route("/Login/SingIn/")]
        [ValidateAntiForgeryToken]
        public ActionResult SingIn()
        {
            try
            {
                using (Aid_idContext db = new Aid_idContext())
                {
                    try
                    {
                        //QUERY SELECT
                        var email = Request.Form["inputEmail"];
                        var res = (from Usuarios u in db.Usuarios
                                   where u.Correo == email
                                   select u).First();
                        //SELECT CORREO FROM USUARIOS WHERE CORREO = DATAINPUT LIMIT 1; DATA INPUT EXAMPLE = raulcaro38@gmail.com;
                        ViewBag.Email = Request.Form["inputEmail"];
                        return View("SingIn");
                    }
                    catch (InvalidOperationException)
                    {
                        ViewBag.EmailRegister = Request.Form["inputEmail"];
                        return View("SingUp");
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                ViewBag.Error = "Error, No se puede conectar con la BBDD";
                return View("Index");
            }
        }
        //Logout -> Delete cookies
        //http://localhost:51356/Login/Logout
        public ActionResult LogOut()
        {
            HttpCookie cookieEmail = new HttpCookie("cookieEmail", "");
            Response.SetCookie(cookieEmail);
            HttpCookie cookieLogin = new HttpCookie("cookieLogin", "");
            Response.SetCookie(cookieLogin);
            return View("Index");
        }
    }
}