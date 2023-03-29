List<Alunos> lstAlunos = new List<Alunos>();

for (int i = 0; i < 3; i++)
{
    Alunos alunos = new Alunos();
    Console.WriteLine("Nome do aluno:");
    alunos.nome = Console.ReadLine();
    Console.WriteLine("Ano do aluno:");
    alunos.ano = Console.ReadLine();
    Console.WriteLine("Matéria favorita do aluno:");
    alunos.matéria = Console.ReadLine();

    lstAlunos.Add(alunos);
    Console.WriteLine("====================");
}

Console.WriteLine("====================");
Console.WriteLine("Lista de alunos");
Console.WriteLine("====================");
foreach (var alunos in lstAlunos)
{
    Console.WriteLine("Nome: " + alunos.nome + " |Ano: " + alunos.ano + " |Matéria favorita: " + alunos.matéria);
}