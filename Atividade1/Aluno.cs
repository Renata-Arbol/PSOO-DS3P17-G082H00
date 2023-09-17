using System;
using System.Collections.Generic;

public class Aluno : Pessoa
{
    private string ra;
    private List<(Disciplina, double)> notasDisciplinas = new List<(Disciplina, double)>();

    public Aluno(string nome, int idade, string ra) : base(nome, idade)
    {
        this.ra = ra;
    }

    public string RA
    {
        get { return ra; }
    }

    public void AdicionarNota(Disciplina disciplina, double nota)
    {
        notasDisciplinas.Add((disciplina, nota));
    }

    public string ObterStatus(Disciplina disciplina)
    {
        foreach (var (disc, nota) in notasDisciplinas)
        {
            if (disc == disciplina)
            {
                if (nota >= 6.0)
                    return "Aprovado";
                else if (nota < 4.0)
                    return "Reprovado";
                else
                    return "Cursando";
            }
        }
        return "Disciplina não encontrada";
    }

    public double CalcularMedia()
    {
        if (notasDisciplinas.Count == 0)
            return 0.0;

        double totalNotas = 0.0;
        foreach (var (_, nota) in notasDisciplinas)
        {
            totalNotas += nota;
        }
        return totalNotas / notasDisciplinas.Count;
    }
}