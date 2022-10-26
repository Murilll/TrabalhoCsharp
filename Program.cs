using System;

Console.WriteLine("\r\nSeja Bem Vido a FaçaFacul.\r\n");
List<Curso> listCurso = new List<Curso>();
List<Alunos> listAluno = new List<Alunos>();
List<Notas> listNota = new List<Notas>();
bool running = true;
int i = 0;
while (running)
{
    Console.WriteLine("1 - Cadastrar curso.\r\n2 - Listar cursos.\r\n3 - Cadastrar alunos.\r\n4 - Dar notas.\r\n5 - Estatística.\r\n6 - Sair.");
    int intMenu = Convert.ToInt32(Console.ReadLine());
    switch (intMenu)
    {
        case 1:
            Console.WriteLine("Digite o nome do curso: ");
            string nomeCurso = Console.ReadLine();            

            Console.WriteLine("Digite o código do curso: ");
            int codCurso = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a carga horária do curso (em horas.): ");
            int horasCurso = Convert.ToInt32(Console.ReadLine());

            listCurso.Add(new Curso() {Name = nomeCurso, 
                                    Cod = codCurso,
                                    cargaHoraria = horasCurso});

            break;

        case 2:
            Console.WriteLine("Lista De Todos Os Cursos\r\n");
            foreach (var elemento in listCurso)
            {
                Console.WriteLine($"Nome do curso: {elemento.Name}\r\nCódigo do curso: {elemento.Cod}\r\nCarga horaria do curso: {elemento.cargaHoraria}\r\n");
            }
            break;

        case 3:
            Console.WriteLine("Digite o nome do aluno para realizar o cadastro:");
            string nomeAluno = Console.ReadLine();

            Console.WriteLine("Digite o código do curso para realizar o cadastro do aluno no curso:");
            int codAluno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a matrícula do aluno:");
            int Matricula = Convert.ToInt32(Console.ReadLine());

            listAluno.Add(new Alunos() {Name = nomeAluno, 
                                    codCurso = codAluno,
                                    Matricula = Matricula});

            break;

        case 4:
        foreach (var elemento in listAluno)
        {
            Console.WriteLine($"Coloque a nota do Aluno: {elemento.Name}");
            int Nota = Convert.ToInt32(Console.ReadLine());
            listNota.Add(new Notas() {Nota = Nota});
            i++;
        }
        break;
        
        case 5:
        Console.WriteLine("Estatística:");
        foreach (var elemento in listNota)
        {
            int média = elemento.Nota + elemento.Nota / i;
            Console.WriteLine($"A média de notas: {média}");
        }
        
            break;
        
        case 6:
        Console.WriteLine("Console Fechado");
            running = false;
            break;
    }
}