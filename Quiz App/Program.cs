// See https://aka.ms/new-console-template for more information
using System;
using Quiz_App;



Quiz quiz = new Quiz(); //Quiz object is created
int score = 0;
Console.WriteLine("Welcome to the Quiz App!");
for (int i = 0; i < 5; i++)
{
    int num = Quiz.QuestnNum(); //call to method to get number of the quiz question the user wants
    quiz.QuestnHandler((num - 1), out char ans); //with that number he entered, selects the question and correct answer
    score = quiz.ProcessResponse((num - 1), ans, score); // call to method that compares his response to the real answer and scores
}
Console.WriteLine("You are done! You scored {0} out of 5!", score);
Console.ReadKey();
