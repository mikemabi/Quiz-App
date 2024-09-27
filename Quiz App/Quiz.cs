using System;

namespace Quiz_App
{
    public class Quiz
    {
        // Private field of the questions as well as options of the quiz app, to restrict external access
        
        // using an array to hold the questions
        private string[] _Questions = { "qst 1", "qst 2", "qst 3", "qst 4", "qst 5" };

        // and a multidimensional array to hold both the options and the correct answer
        private string[,] _Options = { { "option 1", "opt 2", "opt 3" }, { "A", "B", "C" } };

        // Int array that will hold exactly what question is being asked
        private int[] AskedQuestions;

        // getter method for the questions
        public string[] Questions
        {
            get
            {
                return this._Questions;
            }
        }
        
        // and also getter method for the options
        public string[,] Options
        {
            get
            {
                return this._Options;
            }
        }
        
        //Below is a method to return a single question, complete with options and correct answers
        public void QuestnFragment(int i,out string question, out string option, out string ans) {
           question = this.Questions[i];
            option = this.Options[0,i];
            ans = this.Options[1,i];
        }

        // Method to be called when a question is being asked
        public void AskQuestn()
        {

        }

    

