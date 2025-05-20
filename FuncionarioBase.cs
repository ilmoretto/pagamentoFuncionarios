public class FuncionarioBase
{
    private string _nome;
    private string _matricula;
    private string _cpf;
    protected double _salario;

    public FuncionarioBase() { }
    public FuncionarioBase(string nome, string matricula, string cpf) {
        setNome(nome);
        setMatricula(matricula);
        setCpf(cpf);
        _salario = 2500;
    }
    public void setNome(string nome) {
        _nome = nome;
    }
    public string getNome() {
        return _nome;
    }
    public void setMatricula(string matricula) {
        if (matricula != null)
            _matricula = matricula;
    }
    public string getMatricula() {
        return _matricula;
    }
    public double getSalario() {
        return _salario;
    }
    public void setCpf(string cpf) {
        cpf = cpf.Replace("-", "").Replace(".", "");
        if(cpf.Length == 11)
        {
            _cpf = cpf;
        }
        else
        {
            throw new Exception("CPF inválido!");
        }
           
    }

    public virtual void CalcularSalario() {
        Console.WriteLine($"\nSeu salário é: {_salario.ToString("C2")}");
    }
}