namespace _03_constructors;

class Program;


private void run()
{
    QuizVraag quizVraag = new QuizVraag("hier is de vraag", "hier is het antwoord");
    Quiz quiz = new Quiz(10);
    quiz.voegVraagToe(0, quizVraag);

    quizVraag quizvraag = new quizVraag("wat is 2 + 2?", "4");
    quizVraag quizvraag = new quizVraag("wat is kyano's favoriete kleur?", "blauw");
    quizVraag quizvraag = new quizVraag("is Codie kaal?", "ja");
    quizVraag quizvraag = new quizVraag("What 1997 N64 video game, features James Bond and is named after the 1995 film?", "Goldeneye 007");
    quizVraag quizvraag = new quizVraag("What arcade game was called Puckman in Japan?", "Pac-Man");
    quizVraag quizvraag = new quizVraag("Which spooky 2001 GameCube game starring Mario’s brother got a reboot for Nintendo Switch in 2019?", "Luigi's Mansion");
    quizVraag quizvraag = new quizVraag("What is thought to be the first video game, created in 1958 and becoming popular in the 1970s?", "Pong");
    quizVraag quizvraag = new quizVraag("Which video game franchise has installments called Black Ops, Modern Warfare and Ghosts?", "Call of Duty");
    quizVraag quizvraag = new quizVraag("The word Tetris is a combination of the Greek word Tetra (meaning four) and what 6-letter sport that was a favorite of game creator Alexy Pajitnov?", "Tennis");
}

