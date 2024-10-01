using System;
using System.Diagnostics;
using System.Collections.Generic;


namespace Quiz_App
{
    public class Quiz
    {
        // Private field of the questions as well as options of the quiz app, used to restrict external access

        // using an array to hold the quiz questions
        private string[] _Questions = {
            "1) What is the name of Nigeria's immediate past president\n" +
                    "A) Ngozi Iweala B) Muhammadu Buhari C) Goodluck Jonathan",
            "2) What is the capital of Nigeria\n" +
                    "A) Abuja B) Oyo C) Lagos\n",
            "3) What Year did Nigeria gain Independence\n" +
                    "A) 1914 B) 1960 C) 1969",
            "4) Which of these is the approximate population of Nigeria\n" +
                    "A) 50 million B) 100 million C) 200 million",
            "5) What is 5^3?\n" + "A) 25 B) 100 C) 125",
            "6) What is √49\n" +
                "A)7 B)8 C)9",
            "7) What is the remainder from 25/9\n" +
                "A)7 B)8 C)9",
            "8) 5+2-10+18?\n" +
                "A)6 B)10 C)15",
            "9) What is the name of an animal, place or thing?\n" +
                "A) Verb B) Adjective C)Noun",
            "10) What formula is used to calculate area of a triangle with all three sides given?\n" +
                "A) Pythagoras Theorem B)SOHCAHTOA C) Heron's Formula",
            "11) What does an adjective do?\n" +
                "A) Replaces a noun B) Acts as a noun C) Qualifies a noun",
            "12) Fill in the gap: I _____ yesterday\n" +
                "A)Danced B)Dance C)Dancing",
            "13) Identify the adjective: The boy is happy\n" +
                "A)Happy B)Boy C)is",
            "14) The basic unit of life is:\n" +
                "A)Plant B)cell C)embryo",
            "15) What part of the brain regulates sleep?\n" +
                "A)Opthalamus B)phalanges C)Hypothalamus",
            "16) How many hours of sleep does the body need?\n" +
                "A)12 B)16 C)8",
            "17) Bat belongs to what family?\n" +
                "A)Bird B)Mammal C)Dog",
            "18) What is the unit of the Indian currency\n" +
                "A)Rupee B)Kuwait C)Indian dollar",
            "19) How many countries are in Africa?\n" +
                "A)54 B)60 C)90",
            "20) Who is the all-time leading world footballer awardee?\n" +
                "A)Leo Messi B)Kylian Mbappe C)C. Ronaldo"};



        // and another array holding the correct answers:
        private char[] _Answers = { 'B', 'A', 'B', 'C', 'C', 'A', 'A', 'C', 'C', 'C', 'C', 'A', 'A', 'B', 'C', 'C', 'B', 'A', 'A', 'A' };



        // List of integers that will hold exactly what question is being asked:
        public static List<int> AskedQuestions = new List<int>() { };

        // getter method for the questions:
        public string[] Questions
        {
            get
            {
                return this._Questions;
            }
        }

        // and also getter method for the answers:
        public char[] Answers
        {
            get
            {
                return this._Answers;
            }
        }

        //Below is a method to return a single question, complete with options and correct answers:
        public void QuestnHandler(int i, out char ans)
        {
            string question = this.Questions[i];
            ans = this.Answers[i];
            Console.WriteLine("You have chosen question {0}\n{1}", i+1, question);
        }

        //This method is to Capture the option of the question chosen by the user. It accepts no
        //instance parameters, so is static:
        public static char ResponseCapture()
        {

            char responseCap;

            while (true)
            { 
                bool j = char.TryParse(Console.ReadKey().KeyChar.ToString(), out char response);
                Console.WriteLine("\n");
                responseCap = Char.ToUpper(response);
                if (j && (responseCap.Equals('A') || responseCap.Equals('B') || responseCap.Equals('C')))
                    break;
                Console.WriteLine("You have entered wrong. Please try again");
            }
            return responseCap;
        }

        //Having received input from the user, this method compares it with the actual answer and keeps
        //track of his scores:
        public int ProcessResponse(int i, char ans, int score)
        {
            char response = ResponseCapture();
            if (response.Equals(ans))
            {
                score = score + 1;
                Console.Clear();
                Console.WriteLine("That was correct!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong! The correct answer is {0}", ans);
            }
            return score;

        }



        // Method to be called when a quiz question is to be asked; it determines that whatever number is
        //entered is legal to be accepted by the program:
        public static int QuestnNum()
        {

            int num = 0;
            Console.WriteLine("Please enter a number from 1 to 20:");

            while (true)
            {
                bool j = int.TryParse(Console.ReadLine(), out num);
                if (j)
                {
                    switch (num)
                    {
                        case (< 1):
                            Console.WriteLine("Please try again. A number between 1 and 20");
                            break;

                        case (> 20):
                            Console.WriteLine("Please try again. A number between 1 and 20");
                            break;

                        default:
                            if (AskedQuestions.Contains(num))
                            {
                                Console.WriteLine("You've picked that question before. Please choose another");
                                break;
                            }
                            else
                            {
                                AskedQuestions.Add(num);
                                return num;
                            }



                    }









                }
                else Console.WriteLine("That isn't a number. Please try again");
            }

        }

        //Method to decide whether to stop the quiz or to continue
        public static bool StopDeciscion()
        {
            while (true)
            {
                Console.WriteLine("Continue to the next question? Y/N");
                bool j = char.TryParse(Console.ReadKey().KeyChar.ToString(), out char response);
                Console.WriteLine("\n");
                char responseCap = Char.ToUpper(response);
                if (j && (responseCap.Equals('Y')))
                    return true;
                else if (j && (responseCap.Equals('N')))
                    return false;
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Response. Please try again");
                }
            }
        }

    }
}










