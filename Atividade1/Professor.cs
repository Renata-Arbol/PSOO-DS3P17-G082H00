public class Professor : Pessoa
{
    private string disciplina;

    public Professor(string nome, int idade, string disciplina) : base(nome, idade)
    {
        this.disciplina = disciplina;
    }

    public string Disciplina
    {
        get { return disciplina; }
    }
}