FuncionarioRegular funcionario = new FuncionarioRegular("João", "12345", "123.456.789-00");
funcionario.CalcularSalario();

FuncionarioHorista funcionarioHorista = new FuncionarioHorista(44, 10, "Maria", "54321", "987.654.321-00");
funcionarioHorista.CalcularSalario();
Console.WriteLine($"Salário Horista: {funcionarioHorista.getSalario()}");

FuncionarioComissionado funcionarioComissionado = new FuncionarioComissionado(10000, "Carlos", "67890", "456.789.123-00");
funcionarioComissionado.CalcularSalario();
Console.WriteLine($"Salário Comissionado: {funcionarioComissionado.getSalario()}");