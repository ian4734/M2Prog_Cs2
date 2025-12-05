class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldeAntwoorden;

    internal Quiz(int aantalVragen)
    {
        vragen = new QuizVraag[aantalVragen];
    }
    

    void voegVraagToe(QuizVraag vraag, int index)
    {
        vragen[index] = vraag;
    }
    void voegVraagToeOpIndex(int index, string vraag, string antwoord)
    {
        QuizVraag vraag = new QuizVraag(vraag, antwoord);
        voegVraagToe(vraag, index);
    }
    
      
    
    
}

