using Microsoft.AspNetCore.Mvc;
using System.Drawing;

using System.Collections.Generic;

namespace CardStorageSpike.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase
    {

        private static readonly string[] FirstNames = new[]
{
        "Bob", "Billy", "Ben", "Benjamin", "Bond", "Blob", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CardController> _logger;

        List<Card> cardManager= new List<Card>();

        public CardController(ILogger<CardController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCardInformation")]
        public IEnumerable<Card> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Card
            {
                CardNumber = Random.Shared.Next(0, 1000000),
                CardHolderFirstName = FirstNames[Random.Shared.Next(FirstNames.Length)]
            })
            .ToArray();
        }


        [HttpGet("{cardId}")]
        public ActionResult<IEnumerable<Card>> GetCard(int cardId)
        {
            Console.WriteLine(cardId);
            Console.WriteLine(cardManager);
            Console.WriteLine(cardManager[cardId]);
            return Ok(cardManager[cardId]);
        }

        [HttpPost(Name = "GetCardInformation")]
        public ActionResult<IEnumerable<Card>> Post()
        {
            var newCard = new Card();
            cardManager.Add(newCard);
            return Ok(newCard);
        }
    }
}
