using Models;

namespace Application.Interface
{
    public interface ITextService
    {
        FilterFeedback FilterUserInput(string userInput);
    }
}
