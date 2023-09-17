using System;
using System.Collections.Generic;

class Program
{
    static List<Aluno> alunos = new List<Aluno>();
    static List<Disciplina> disciplinas = new List<Disciplina>();
    static List<Professor> professores = new List<Professor>();

    static void Main(string[] args)
    {
        SeedDadosIniciais();
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Cadastrar Aluno");
            Console.WriteLine("2. Cadastrar Disciplina");
            Console.WriteLine("3. Cadastrar Professor");
            Console.WriteLine("4. Listar Alunos");
            Console.WriteLine("5. Listar Disciplinas");
            Console.WriteLine("6. Listar Professores");
            Console.WriteLine("7. Sair");
            Console.Write("Escolha uma opção: ");
            
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    CadastrarAluno();
                    break;
                case "2":
                    CadastrarDisciplina();
                    break;
                case "3":
                    CadastrarProfessor();
                    break;
                case "4":
                    ListarAlunos();
                    break;
                case "5":
                    ListarDisciplinas();
                    break;
                case "6":
                    ListarProfessores();
                    break;
                case "7":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CadastrarAluno()
    {
        Console.Write("Nome do Aluno: ");
        string nomeAluno = Console.ReadLine();

        Console.Write("Idade do Aluno: ");
        int idadeAluno = int.Parse(Console.ReadLine());

        Console.Write("RA do Aluno: ");
        string raAluno = Console.ReadLine();

        Aluno aluno = new Aluno(nomeAluno, idadeAluno, raAluno);
        alunos.Add(aluno);

        Console.WriteLine("Aluno cadastrado com sucesso!");
    }

    static void CadastrarDisciplina()
    {
        Console.Write("Nome da Disciplina: ");
        string nomeDisciplina = Console.ReadLine();

        Console.Write("Nome do Professor da Disciplina: ");
        string nomeProfessor = Console.ReadLine();

        Console.Write("Idade do Professor: ");
        int idadeProfessor = int.Parse(Console.ReadLine());

        Professor professor = new Professor(nomeProfessor, idadeProfessor, nomeDisciplina);
        professores.Add(professor);

        Disciplina disciplina = new Disciplina(nomeDisciplina, professor);
        disciplinas.Add(disciplina);

        Console.WriteLine("Disciplina cadastrada com sucesso!");
    }

    static void CadastrarProfessor()
    {
        Console.Write("Nome do Professor: ");
        string nomeProfessor = Console.ReadLine();

        Console.Write("Idade do Professor: ");
        int idadeProfessor = int.Parse(Console.ReadLine());

        Console.Write("Disciplina do Professor: ");
        string disciplinaProfessor = Console.ReadLine();

        Professor professor = new Professor(nomeProfessor, idadeProfessor, disciplinaProfessor);
        professores.Add(professor);

        Console.WriteLine("Professor cadastrado com sucesso!");
    }

    static void ListarAlunos()
    {
        Console.WriteLine("Alunos:");
        foreach (var aluno in alunos)
        {
            Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}, RA: {aluno.RA}");
        }
    }

    static void ListarDisciplinas()
    {
        Console.WriteLine("Disciplinas:");
        foreach (var disciplina in disciplinas)
        {
            Console.WriteLine($"Nome: {disciplina.Nome}, Professor: {disciplina.ProfessorAssociado.Nome}");
        }
    }

    static void ListarProfessores()
    {
        Console.WriteLine("Professores:");
        foreach (var professor in professores)
        {
            Console.WriteLine($"Nome: {professor.Nome}, Idade: {professor.Idade}, Disciplina: {professor.Disciplina}");
        }
    }
    static void SeedDadosIniciais()
    {
        Professor fernando = new Professor("Fernando", 40, "APSOO");
        Disciplina apsoo = new Disciplina("APSOO", fernando);

        Professor maria = new Professor("Maria", 35, "Matemática");
        Disciplina matematica = new Disciplina("Matemática", maria);

        professores.Add(fernando);
        professores.Add(maria);

        disciplinas.Add(apsoo);
        disciplinas.Add(matematica);

        Aluno renata = new Aluno("Renata Fernanda Arbol", 22, "G082hh0");
        alunos.Add(renata);

        Console.WriteLine("Dados iniciais foram inseridos.");
    }

    

}