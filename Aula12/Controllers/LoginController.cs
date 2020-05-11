using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula12.Aplicacao;
using Aula12.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
//using Model;
//using BL;

namespace Aula8.Controllers
{
    [Route("fapen/login")]
    public class LoginController : Controller
    {
        private ApiContext _contexto;
        public LoginController(ApiContext contexto)
        {
            _contexto = contexto;
        }
        [HttpPost]
        [Route("InsertUser")]
        public IActionResult InsertUser([FromBody]Login usuarioEnviado)
        {
            try
            {
                if (!ModelState.IsValid || usuarioEnviado == null)
                {
                    return BadRequest("Dados inválidos! Tente novamente.");
                }
                else
                {
                    var resposta = new UsuarioAplicacao(_contexto).InsertUser(usuarioEnviado);
                    return Ok(resposta);
                }
            }
            catch (Exception)
            {
                return BadRequest("Erro ao comunicar com a base de dados!");
            }
        }

        [HttpPut]
        [Route("UpdateUser")]
        public IActionResult UpdateUser([FromBody]Login usuarioEnviado)
        {
            try
            {
                if (!ModelState.IsValid || usuarioEnviado == null)
                {
                    return BadRequest("Dados inválidos! Tente novamente.");
                }
                else
                {
                    var resposta = new UsuarioAplicacao(_contexto).UpdateUser(usuarioEnviado);
                    return Ok(resposta);
                }
            }
            catch (Exception)
            {
                return BadRequest("Erro ao comunicar com a base de dados!");
            }
        }

        [HttpPost]
        [Route("GetUserByEmail")]
        public IActionResult GetClienteByLogin([FromBody]string login)
        {
            try
            {
                if (login == string.Empty)
                {
                    return BadRequest("Login inválido! Tente novamente.");
                }
                else
                {
                    var resposta = new UsuarioAplicacao(_contexto).GetUserByLogin(login);

                    if (resposta != null)
                    {
                        var usuarioResposta = JsonConvert.SerializeObject(resposta);
                        return Ok(usuarioResposta);
                    }
                    else
                    {
                        return BadRequest("Usuário não cadastrado!");
                    }
                }
            }
            catch (Exception)
            {
                return BadRequest("Erro ao comunicar com a base de dados!");
            }
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public IActionResult GetAllClientes()
        {
            try
            {
                var listaDeUsuarios = new UsuarioAplicacao(_contexto).GetAllUsers();

                if (listaDeUsuarios != null)
                {
                    var resposta = JsonConvert.SerializeObject(listaDeUsuarios);
                    return Ok(resposta);
                }
                else
                {
                    return BadRequest("Nenhum usuário cadastrado!");
                }
            }
            catch (Exception)
            {
                return BadRequest("Erro ao comunicar com a base de dados!");
            }
        }

        [HttpDelete]
        [Route("DeleteUserByEmail")]
        public IActionResult DeleteUserByLogin([FromBody]string login)
        {
            try
            {
                if (login == string.Empty)
                {
                    return BadRequest("Login inválido! Tente novamente.");
                }
                else
                {
                    var resposta = new UsuarioAplicacao(_contexto).DeleteUserByEmail(login);
                    return Ok(resposta);
                }
            }
            catch (Exception)
            {
                return BadRequest("Erro ao comunicar com a base de dados!");
            }
        }
    }
}
