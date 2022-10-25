using System;

List<string> listCurso = new List<string>();
List<string> listAluno = new List<string>();
List<int> listNota = new List<int>();


Console.WriteLine("\r\nSeja Bem Vido a FaçaFacul.\r\n\r\n1 - Cadastrar curso.\r\n2 - Listar cursos.\r\n3 - Cadastrar alunos.\r\n4 - Dar notas.\r\n5 - Estatística.\r\n6 - Sair.");
int intMenu = Convert.ToInt32(Console.ReadLine());
switch (intMenu)
{
    case 1:
        Console.WriteLine("Digite o nome do curso: ");
        string nomeCurso = Console.ReadLine();
        listCurso.Add(nomeCurso);

        Console.WriteLine("Digite o código do curso: ");
        int codCurso = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a carga horária do curso (em horas.): ");
        int horasCurso = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(listCurso);
        break;

    case 2:
        Console.WriteLine("Lista De Todos Os Cursos");
        Console.WriteLine(intMenu);
        break;

    case 3:
        Console.WriteLine("Digite o nome do aluno para realizar o cadastro:");
        string nomeAluno = Console.ReadLine();

        Console.WriteLine("Digite o código do curso para realizar o cadastro do aluno no curso:");
        int codAluno = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a matrícula do aluno:");
        int Matricula = Convert.ToInt32(Console.ReadLine());
        break;

    case 4:
    Console.WriteLine("Pesquisar por notas dos alunos:");
        break;
    
    case 5:
    Console.WriteLine("Estaística:");
        break;
    
    case 6:
    Console.WriteLine("Console Fechado:");
        break;
}

    

public class Curso
{
    public int Cod { get; protected set; }
    public string Name { get; protected set; }
    public int cargaHoraria { get; protected set; }

    

}

public abstract class Alunos
{
    public string Name { get; set; }
    public int codCurso { get; set; }
    public int Matricula { get; set; }
}

public class listaCursos : Curso
{

}

public class cadastroAlunos : Alunos
{

}

public class Notas
{

}
public class Estatisticas
{
    //Quantos foram aprovados
    //Quantos reprovaram
    //Média
}

public class Sair
{

}