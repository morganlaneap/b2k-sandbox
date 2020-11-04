using Microsoft.AspNetCore.Mvc;
using StonksApi.Models;
using System;

namespace StonksApi.Controllers.GetStonkById
{
    [ApiController]
    public class GetStonkByIdController : Controller
    {
        [HttpGet]
        [Route("/stonks/{id}")]
        public IActionResult Get(string id)
        {
            return Ok(new Stonk
            {
                Id = id,
                Price = new Random().Next(100, 1000000)
            });
        }
    }
}