using System.Collections.Concurrent;

public class FuncionarioComissionado : FuncionarioBase
{
    private double _valorVendas;
    protected double _comissao;

    public FuncionarioComissionado() { }
    public FuncionarioComissionado(double valorVendas, string nome, string matricula, string cpf)
        : base(nome, matricula, cpf) {
        setValorVendas(valorVendas);

    }
    public void setValorVendas(double valorVendas) {
        if (valorVendas > 0) {
            _valorVendas = valorVendas;
        } else {
            throw new Exception("Deve ser maior que zero!");
        }
    }
    public double getValorVendas() {
        return _valorVendas; 
    }
    public double getComissao() {
        return _comissao;   
    }
    public void calcularComissao() {
        double percentual = 0.03;
        _comissao = (_valorVendas * percentual);
    }
    public override void CalcularSalario() {
        calcularComissao();
        _salario = _salario + _comissao;
        
    }
    
}