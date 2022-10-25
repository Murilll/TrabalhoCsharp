using System;


Console.WriteLine("Seja Bem Vido a FaçaFacul.\r\n\r\n1 - Cadastrar curso.\r\n2 - Listar cursos.\r\n3 - Cadastrar alunos.\r\n4 - Dar notas.\r\n5 - Estatística.\r\n6 - Sair.");
int intMenu = Convert.ToInt32(Console.ReadLine());
if (intMenu == 1);
    

public abstract class Curso
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

}

public class Sair
{

}