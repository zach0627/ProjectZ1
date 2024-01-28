using Microsoft.AspNetCore.Mvc;
using ProjectZ1.Models;

namespace ProjectZ1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController
    {
        private static List<Card> _cards = new List<Card>();

        [HttpGet]
        public List<Card> GetList()
        {
            return _cards;
        }


    }

}
