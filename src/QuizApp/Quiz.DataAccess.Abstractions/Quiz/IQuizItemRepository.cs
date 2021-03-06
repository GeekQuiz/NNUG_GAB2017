using System.Collections.Generic;
using Quiz.Core.Quiz;

namespace Quiz.DataAccess.Abstractions.Quiz
{
    public interface IQuizItemRepository
    {
        IEnumerable<QuizItem> GetAll();
        QuizItem Get(int id);
        int Add(QuizItem model);
        void Update(QuizItem model);
        void Delete(int id);
    }
}