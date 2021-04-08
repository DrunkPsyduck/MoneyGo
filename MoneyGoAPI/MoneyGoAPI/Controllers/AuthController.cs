﻿using MoneyGoAPI.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MoneyGoAPI.Models;
using MoneyGoAPI.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MoneyGoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        RepositoryTransacciones repo;
        HelperToken helperToken;

        public AuthController(RepositoryTransacciones repo, HelperToken helper)
        {
            this.repo = repo;
            this.helperToken = helper;
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Login(LoginModel model)
        {
            
            Usuarios usuario = this.repo.ValidarUsuario(model.UserEmail, model.Password);
            if (usuario == null)
            {
                return Unauthorized();
            }
            else
            {
                //El usuario o que queramos se almacena dentro del tokem mediante Claim. Claim permite almacenar datos por Key, Value
                String empleadojson = JsonConvert.SerializeObject(usuario);
                Claim[] claims = new[]
                {
                    new Claim("UserData", empleadojson)
                };

                JwtSecurityToken token = new JwtSecurityToken(
                    issuer: this.helperToken.Issuer,
                    audience: this.helperToken.Audience,
                    claims: claims,
                    expires: DateTime.UtcNow.AddMinutes(10),
                    notBefore: DateTime.UtcNow,
                    signingCredentials: new Microsoft.IdentityModel.Tokens.SigningCredentials(this.helperToken.GetKeyToken(), SecurityAlgorithms.HmacSha256));

                return Ok(new
                {
                    response = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
        }

    }
}
