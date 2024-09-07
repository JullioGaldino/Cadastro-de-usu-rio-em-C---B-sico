namespace Cadastro_de_usuario
{
    internal class Program
    {
        static string CadastroLogin, CadastroSenha, Login, Senha, LiberacaoSenha, SenhaAdmin;
        static int i;

        static void Main(string[] args)
        {
            LiberacaoSenha = "Sim";

            cadastrar();
            Console.ReadKey();
            login();
            liberacaoSenha();
            Console.ReadKey();

            static void cadastrar ()
            {
                Console.WriteLine("Insira um nome para o Usuário: ");
                CadastroLogin = Console.ReadLine();
                Console.WriteLine("Insira uma senha: ");
                CadastroSenha = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Usuário Cadastrado com sucesso!");
            }

           static void login()
            {
                Console.Clear();
                Console.WriteLine("Insira seu usuário: ");
                Login = Console.ReadLine();
                Console.WriteLine("Insira sua senha: ");
                Senha = Console.ReadLine();


                if (Login == CadastroLogin && Senha == CadastroSenha)
                {
                    Console.Clear();
                    Console.WriteLine("Informações do Usuário: ");
                    Console.WriteLine("Nome: " + Login);
                    Console.WriteLine("Senha: *****");
                }
                else
                {
                    while (Login != CadastroLogin || Senha != CadastroSenha)
                    {
                        Console.Clear();
                        Console.WriteLine("Usuário ou senha incorreto.");
                        Console.WriteLine(" ");
                        Console.WriteLine("Insira seu usuário: ");
                        Login = Console.ReadLine();
                        Console.WriteLine("Insira sua senha: ");
                        Senha = Console.ReadLine();

                    }
                }
                
            }

           static void liberacaoSenha()
            {
                Console.Clear();
                int i = 5;

                Console.WriteLine("Libeirar senha?");
                LiberacaoSenha = Console.ReadLine();

                if (LiberacaoSenha == "Sim")
                {
                    Console.WriteLine("Informe a senha do Administrador: ");
                    SenhaAdmin = Console.ReadLine();
                    if (SenhaAdmin == "Admin")
                    {
                        Console.Clear();
                        Console.WriteLine("Acesso Liberado!");
                        Console.WriteLine(" ");
                        Console.WriteLine("Informações do Usuário: ");
                        Console.WriteLine("Nome: " + Login);
                        Console.WriteLine("Senha: " + Senha);
                    }
                    else
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Senha incorreta você tem {0}", i);
                            i = i - 1;
                            Console.WriteLine("Informe a senha do Administrador: ");
                            SenhaAdmin = Console.ReadLine();
                            
                        } while (i > 0 && SenhaAdmin != "Admin");
                        {
                            if (SenhaAdmin == "Admin")
                            {
                                Console.Clear();
                                Console.WriteLine("Acesso Liberado!");
                                Console.WriteLine(" ");
                                Console.WriteLine("Informações do Usuário: ");
                                Console.WriteLine("Nome: " + Login);
                                Console.WriteLine("Senha: " + Senha);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Número limite de tentativas.");
                            }
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sessão finalizada!");
                }
            }
        }
    }
}
