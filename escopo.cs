public class Curso
{
    public string Name { get; set; }
    public int Cod { get; set; }
    public int cargaHoraria { get; set; }

    public Curso()
    {}

    public void addCurso(string name, int cod, int cargahoraria)
    {
        Name = name;
        Cod = cod;
        cargaHoraria = cargahoraria;
    }
}

public class Alunos
{
    public string Name { get; set; }
    public int codCurso { get; set; }
    public int Matricula { get; set; }

    public Alunos()
    {}

    public void addAluno(string name, int codcurso, int matricula)
    {
        Name = name;
        codCurso = codcurso;
        Matricula = matricula;
    }
}


public class Notas
{
    public int Nota { get; set; }

    public Notas()
    {}

    public void addNota(int nota)
    {
        Nota = nota;
    }
}
public class Estatisticas
{
    //Quantos foram aprovados
    //Quantos reprovaram
    //Média
}
