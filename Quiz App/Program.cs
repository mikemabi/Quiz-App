// See https://aka.ms/new-console-template for more information
using System;
using Quiz_App;



Quiz quiz = new Quiz(); //Quiz object is created
int score = 0;
Console.WriteLine("Welcome to the Quiz App! You will be scored on 5 Quiz questions");
for ((int i, bool j) = (0, true); (i < 5) && j; i++)
{
    int num = Quiz.QuestnNum(); //call to method to get number of the quiz question the user wants
    quiz.QuestnHandler((num - 1), out char ans); //with that number he entered, selects the question and correct answer
    score = quiz.ProcessResponse((num - 1), ans, score); // call to method that compares his response to the real answer and scores    
    j = Quiz.StopDeciscion();//call to method to know if user would like to continue
}
Console.WriteLine("You are done! You scored {0} out of 5!", score);
Console.ReadKey();
