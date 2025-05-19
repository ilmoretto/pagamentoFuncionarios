public class FuncionarioRegular : FuncionarioBase
{
    public FuncionarioRegular() { }
    public FuncionarioRegular(string nome, string matricula, string cpf)
        : base(nome, matricula, cpf) {

    }
    public override void CalcularSalario() {
        base.CalcularSalario();
    }

}
