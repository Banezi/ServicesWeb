using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class CharacterController : ApiController
    {
        public List<CharacterDTO> GetAll()
        {
            List<CharacterDTO> liste = new List<CharacterDTO>();
            //Recuperation dans Business metier
            return liste;
        }
    }
}
