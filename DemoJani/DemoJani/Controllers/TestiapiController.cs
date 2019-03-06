using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoJani.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestiApiController : ControllerBase
    {

        [Route("Lista")]
        public List<Auto> AutoLista()
        {
            List<Auto> autot = new List<Auto>()
            {
                new Auto()
                {
                    Merkki = "Ford",
                    Malli = "Focus",
                    Huippunopeus = 190
                },
                new Auto()
                {
                    Merkki = "Toyota",
                    Malli = "Avensis",
                    Huippunopeus = 220
                },
                new Auto()
                {
                    Merkki = "Porsche",
                    Malli = "911",
                    Huippunopeus = 300
                }
            };

            return autot;
        }

    }
}