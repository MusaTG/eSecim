using Business.Abstract;
using Business.Conrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MayoralController : ControllerBase
    {
        IMayoralCandidateService _mayoralCandidateService;

        public MayoralController(IMayoralCandidateService mayoralCandidateService)
        {
            _mayoralCandidateService = mayoralCandidateService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _mayoralCandidateService.GetAll();
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {
            var result = _mayoralCandidateService.GetById(id);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Post(MayoralCandidate mayoralCandidate)
        {
            var result = _mayoralCandidateService.Add(mayoralCandidate);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
