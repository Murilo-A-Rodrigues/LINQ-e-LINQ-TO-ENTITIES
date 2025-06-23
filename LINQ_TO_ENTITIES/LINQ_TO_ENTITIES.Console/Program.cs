using System;
using System.Linq;
using LINQ_TO_ENTITIES.Model;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1 - Cadastrar aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Atualizar nota do aluno");
            Console.WriteLine("4 - Remover aluno");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            var opcao = Console.ReadLine();

            using (var db = new EscolaContext())
            {
                switch (opcao)
                {
                    case "1":
                        Console.Write("Nome do aluno: ");
                        var nome = Console.ReadLine();
                        Console.Write("Nota: ");
                        if (double.TryParse(Console.ReadLine(), out double nota))
                        {
                            db.Alunos.Add(new Aluno { Nome = nome, Nota = nota });
                            db.SaveChanges();
                            Console.WriteLine("Aluno cadastrado!");
                        }
                        else
                        {
                            Console.WriteLine("Nota inválida.");
                        }
                        break;

                    case "2":
                        var alunos = db.Alunos.ToList();
                        Console.WriteLine("\nAlunos cadastrados:");
                        foreach (var aluno in alunos)
                            Console.WriteLine($"{aluno.Id}: {aluno.Nome} - Nota: {aluno.Nota}");
                        break;

                    case "3":
                        Console.Write("Nome do aluno para atualizar: ");
                        var nomeAtualizar = Console.ReadLine();
                        var alunoAtualizar = db.Alunos.FirstOrDefault(a => a.Nome == nomeAtualizar);
                        if (alunoAtualizar != null)
                        {
                            Console.Write("Nova nota: ");
                            if (double.TryParse(Console.ReadLine(), out double novaNota))
                            {
                                alunoAtualizar.Nota = novaNota;
                                db.SaveChanges();
                                Console.WriteLine("Nota atualizada!");
                            }
                            else
                            {
                                Console.WriteLine("Nota inválida.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Aluno não encontrado.");
                        }
                        break;

                    case "4":
                        Console.Write("Nome do aluno para remover: ");
                        var nomeRemover = Console.ReadLine();
                        var alunoRemover = db.Alunos.FirstOrDefault(a => a.Nome == nomeRemover);
                        if (alunoRemover != null)
                        {
                            db.Alunos.Remove(alunoRemover);
                            db.SaveChanges();
                            Console.WriteLine("Aluno removido!");
                        }
                        else
                        {
                            Console.WriteLine("Aluno não encontrado.");
                        }
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}