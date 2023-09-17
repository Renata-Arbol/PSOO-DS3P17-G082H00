public class Disciplina
{
    public string Nome { get; }
    public Professor ProfessorAssociado { get; }

    public Disciplina(string nome, Professor professor)
    {
        Nome = nome;
        ProfessorAssociado = professor;
    }
}