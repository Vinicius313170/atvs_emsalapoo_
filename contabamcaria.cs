public class Conta{
    //atributos
    public int CPF;
    public int senha;
    public int saldo;
    public string nome;
    public string endereco;
    // construtor da classe 
    public Conta(int CPFdoUsuario, int senhaDOusuario, int saldoDOusuario, string nomeDoUsuario, string ederecoDOusuario){
        CPF = CPFdoUsuario;
        senha = senhaDOusuario;
        saldo = saldoDOusuario;
        nome = nomeDoUsuario;
        endereco = ederecoDOusuario;
    }
}