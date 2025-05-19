public class FuncionarioHorista : FuncionarioBase
{
    private double _horasTrabalhadas;
    protected double _valorHora;

    public FuncionarioHorista() { }
    public FuncionarioHorista(double horasTrabalhadas, double valorHora, string nome, string matricula, string cpf)
        : base(nome, matricula, cpf) {
        setHorasTrabalhadas(horasTrabalhadas);
        _valorHora = 50;
    }
    public void setHorasTrabalhadas(double horasTrabalhadas) {
        if (horasTrabalhadas > 0) {
            _horasTrabalhadas = horasTrabalhadas;
        } else {
            throw new Exception("Deve ser maior que zero!");
        }
    }
    public double getHorasTrabalhadas() {
        return _horasTrabalhadas;
    }
    public double getValorHora() {
        return _valorHora;
    }

    public override void CalcularSalario() {
        _salario = _horasTrabalhadas * _valorHora;
    }
}