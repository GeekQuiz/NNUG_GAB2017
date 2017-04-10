﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Quiz.Web.Areas.Quiz.Models
{
    public class QuizItemViewModel
    {
        public QuizItemViewModel()
        {
            Questions = new List<QuizItemQuestionViewModel>();
        }

        public static QuizItemViewModel MapFrom(DataAccess.Quiz.QuizItem model)
        {
            return new QuizItemViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Created = model.Created.ToShortDateString() + " " + model.Created.ToShortTimeString(),
                Modified = model.Modified?.ToShortDateString() + " " + model.Modified?.ToShortTimeString(),
                Questions = model.Questions.Select(QuizItemQuestionViewModel.MapFrom)
            };
        }
        
        [DisplayName("Id")]
        public int Id { get; set; }
        
        [DisplayName("Name")]
        public string Name { get; set; }
        
        [DisplayName("Modified at")]
        public string Modified { get; set; }

        [DisplayName("Created at")]
        public string Created { get; set; }

        [DisplayName("No. of questions")]
        public int QuestionCount => Questions.Count();

        public IEnumerable<QuizItemQuestionViewModel> Questions { get; set; }
    }
}