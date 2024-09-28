// See https://aka.ms/new-console-template for more information
using Quiz_App;

Quiz quiz = new Quiz();
int score = 0;
for (int i = 0; i < 5; i++)
{
    int num = Quiz.QuestnNum();
    quiz.QuestnHandler((num - 1), out char ans);
    score = quiz.ProcessResponse((num - 1), ans, score);

}

