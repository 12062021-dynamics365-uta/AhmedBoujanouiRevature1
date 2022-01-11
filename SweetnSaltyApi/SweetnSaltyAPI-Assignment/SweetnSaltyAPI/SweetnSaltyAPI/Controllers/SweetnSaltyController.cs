using Microsoft.AspNetCore.Mvc;
using SweetnSaltyBusiness;
using SweetnSaltyModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SweetnSaltyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SweetnSaltyController : Controller
    {
        private readonly ISweetnSaltyBusinessClass _businessClass;
        //constructor
        public SweetnSaltyController(ISweetnSaltyBusinessClass ISweetnSaltyBusinessClass)
        {
            this._businessClass = ISweetnSaltyBusinessClass;

        }


        [HttpPost]
        [Route("postaflavor/{flavor}")]
        public async Task<ActionResult<Flavor>> PostFlavor(string flavor)
        {
            //call the business layer and send the string 
            Flavor f = await this._businessClass.PostFlavor(flavor);
            if (f != null)
            {
                return Created($"http://5001/sweetnsalty/postaflavor/{f.FlavorId}", f);
            }
            else return BadRequest();

        }

        [HttpPost]
        [Route("postaperson/{fname}/{lname}")]
        public async Task<ActionResult<Person>> PostPerson(string fname, string lname, string flavorname)
        {
            Person p = await this._businessClass.PostPerson(fname, lname, flavorname);
            if (p != null)
            {
                return Created($"http://5001/sweetnsalty/postflavor/{p.PersonId}", p);
            }
            else return BadRequest();
        }

        [HttpGet]
        [Route("getaperson/{fname}/{lname}")]
        public async Task<ActionResult<Person>> GetPerson(int PersonId, string fname, string lname)
        {
            Person p3 = await this._businessClass.GetPerson(PersonId, fname, lname);
            if (p3 != null)
            {
                return Created($"http://5001/sweetnsalty/getperson/{p3.PersonId}/{p3.Fname}/{p3.Lname}", p3);
            }
            else return BadRequest();

        }

        [HttpGet]
        [Route("getapersonandflavors/{id}")]
        public async Task<ActionResult<Person>> GetPersonAndFlavors(int id)
        {
            throw new NotImplementedException();

        }

        [HttpGet]
        [Route("getlistofflavors")]
        public async Task<ActionResult<List<Flavor>>> GetAllFlavors()
        {
            throw new NotImplementedException();

        }


    }
}
