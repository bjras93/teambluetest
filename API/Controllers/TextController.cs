using API.DTOs;
using Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/text/")]
    public class TextController : Controller
    {
        private readonly ITextService _textService;

        public TextController(ITextService textService)
        {
            _textService = textService;
        }
        [HttpPost]
        [Route("insert-distinct")]
        public IActionResult InsertDistinctWords([FromBody]UserInputRequest userInputRequest)
        {
            var result = _textService.FilterUserInput(userInputRequest.UserInput);
            return Ok(result);
        }
    }
}