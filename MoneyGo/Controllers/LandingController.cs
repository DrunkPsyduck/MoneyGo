﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoneyGo.Models;
using MoneyGo.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyGo.Controllers
{
    public class LandingController : Controller
    {
        RepositoryTransacciones repo;

        public LandingController(RepositoryTransacciones repo)
        {
            this.repo = repo;
        }

        public object HttpSesion { get; private set; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(String email, String password)
        {
            Usuario user = this.repo.ValidarUsuario(email, password);
            if (user == null)
            {
                ViewData["MENSAJE"] = "usuario/password no válidos";
                return View();
            }
            else
            {
                HttpContext.Session.SetInt32("user", user.IdUsuario);
                HttpContext.Session.SetString("user", user.Nombre);
                return RedirectToAction("Index", "Transacciones");
            }

        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(String nombre, String nombreUsuario, String password, String email)
        {
            this.repo.InsertarUsuario(nombreUsuario, password, nombre, email);
            ViewData["MENSAJE"] = "Revise la bandeja de entrada de su email";
            return View();
        }
    }
}