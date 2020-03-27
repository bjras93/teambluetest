using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Application.Interface;
using Models;
using Repository.Interfaces;

namespace Application.Service
{
    public class TextService : ITextService
    {
        private readonly ITeamBlueTestContext _context;

        public TextService(ITeamBlueTestContext context)
        {
            _context = context;
        }
        public FilterFeedback FilterUserInput(string userInput)
        {
            var uniqueWords = UniqueWords(userInput);
            var filtered = FilterFromWatchList(uniqueWords);
            
            var result = new FilterFeedback
            {
                UniqueWordCount = CountUniqueWords(),
                WatchListHits = filtered
            };
            return result;
        }
        private List<string> FilterFromWatchList(ICollection<string> wordList)
        {
            List<string> result;
            if (wordList.Count < 50)
            {
                result = wordList
                    .Where(w => _context.WatchListWords.Any(c => c.Word == w))
                    .ToList();
                return result;

            }
            result = _context.WatchListWords
                .Where(w => wordList.Contains(w.Word))
                .Select(w => w.Word)
                .ToList();

            return result;
        }
        private List<string> UniqueWords(string userInput)
        {
            userInput = new Regex("[^a-zA-Z]").Replace(userInput.ToLower(), " ");

            var words = userInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var wordQuery = words.Distinct()
                .ToList();

            AddUserInput(wordQuery);

            return wordQuery;
        }
        private int CountUniqueWords()
        {
            return _context.UserInputs.Count();
        }
        private void AddUserInput(IEnumerable<string> wordQuery)
        {
            var userInputs = wordQuery.Select(w => new UserInput
            {
                DistinctText = w
            }).ToList();

            foreach (var input in userInputs.Where(us => !_context.UserInputs.Any(u => u.DistinctText == us.DistinctText)))
            {
                _context.UserInputs.Add(input);
            }

            _context.SaveChanges();
        }
    }
}
