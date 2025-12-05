class QuizVraagAntwoord
{
    internal QuizVraag vraag;
    internal bool goed;

    internal QuizVraagAntwoord(int aantalVragen)
    {
        vragen = new QuizVraag[aantalVragen];
    }
        
        internal QuizVraagAntwoord(QuizVraag vraag)
    {
        vraag = vraag;
        goed = false;
    }
}
 
