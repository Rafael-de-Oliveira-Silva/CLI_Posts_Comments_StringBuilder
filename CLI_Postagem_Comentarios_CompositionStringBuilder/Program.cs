using System;
using CLI_Postagem_Comentarios_CompositionStringBuilder.Entities;

namespace CLI_Postagem_Comentarios_CompositionStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = -1;
            int IdPostagem = 0;
            MyPost myPost = new MyPost();

            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("=============================================");
                Console.WriteLine("                    My Posts                 ");
                Console.WriteLine("=============================================");
                Console.WriteLine("");
                Console.WriteLine("(1) - Listar minhas postagem...");
                Console.WriteLine("(2) - Criar nova postagem...");
                Console.WriteLine("(3) - Curtir postagem...");
                Console.WriteLine("(4) - Comentar postagem...");
                Console.WriteLine("(0) - Encerrar...");
                Console.Write("> Resp: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine(myPost.ToString());
                            Console.ReadLine();
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Entre com os dados da nova postagem: ");
                            Console.Write("Moment (DD/MM/YYYY): ");
                            DateTime dt = DateTime.Parse(Console.ReadLine());
                            Console.Write("Title: ");
                            string title = Console.ReadLine();
                            Console.Write("Content: ");
                            string content = Console.ReadLine();
                            IdPostagem++;
                            Post p = new Post(dt, title, content, IdPostagem);
                            myPost.AddPostInMyPost(p);
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Informe o ID da postagem para curtir-lo: ");
                            Console.Write("#ID: ");
                            int idLike = int.Parse(Console.ReadLine());
                            myPost.AddLikePost(idLike);
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Informe o ID da postagem para comenta-lo: ");
                            Console.Write("#ID: ");
                            int idComment = int.Parse(Console.ReadLine());
                            Console.WriteLine("Entre com o texto desejado para comentar a postagem. ");
                            Console.Write("Texto: ");
                            string textComment = Console.ReadLine();
                            Comment c = new Comment(textComment);
                            myPost.AddCommentPost(idComment, c);
                            break;
                        }
                    case 0:
                        {
                            Console.Clear();
                            Console.WriteLine("Finalizando aplicação...");
                            Console.WriteLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Operação inválida!");
                            Console.ReadLine();
                            break;
                        }

                }
            }



        }
    }
}
