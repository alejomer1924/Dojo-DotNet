using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dojonetcore.Modelo;
namespace dojonetcore.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        FirebaseAccount Instancia = FirebaseAccount.Instancia;
        [HttpGet]
        public async Task<List<Usuario>> Get(){
             
            return await Instancia.GetUser(); 
        }
        
        [HttpPost]

        public async Task<String> Post(Usuario user){
            return await Instancia.AddUser(user); 
        }

        [HttpDelete]
         public async Task<String> Delete([FromQuery]String id){
            return await Instancia.deleteUser(id); 
        }
    }
    
}