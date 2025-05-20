List<FuncionarioBase> funcionarios = new List<FuncionarioBase>();
bool encerrarP = false;
while (!encerrarP)
{
    Console.WriteLine("=======|Folha de Pagamento|=======");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Exibir");
    Console.WriteLine("0 - Sair");
    Console.Write("Selecione uma opção: ");
    int opcMenu = int.Parse(Console.ReadLine()!);

    switch (opcMenu)
    {
        case 0:
            encerrarP = true;
            break;
        case 1:

            break;

        case 2:

            break;



        default:
            Console.WriteLine("Opção inválida");
            break;
    }



}

