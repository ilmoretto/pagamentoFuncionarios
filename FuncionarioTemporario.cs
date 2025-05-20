using System.Runtime.CompilerServices;

public class FuncionarioTemporario : FuncionarioBase
{
    private double _valeAlimentacao;

    public FuncionarioTemporario() { }
    public FuncionarioTemporario(string nome, string matricula, string cpf) : base(nome, matricula, cpf)
    {
        _valeAlimentacao = 500;
    }

    public double getValeAlimentacao()
    {
        return _valeAlimentacao;
    }

    public override void CalcularSalario()
    {
        _salario += _valeAlimentacao;

    }
}