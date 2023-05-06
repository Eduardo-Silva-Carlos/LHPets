namespace LHPet.Models;

public class Cliente
{

    /*Nesse trecho de código a seguir são criados atributos de Cliente
     e seus gettes e settes correspondentes.*/

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Paciente { get; set; }

    /* Nesse trecho do código, é criado o Construtor do 
    model Cliente e determinado quais parâmetros são 
    necessários na criação das instâncias. */

    public Cliente(int id, string nome, string cpf, string email, string paciente)
    {
        this.Id = id;
        this.Nome = nome;
        this.Cpf = cpf;
        this.Email = email;
        this.Paciente = paciente;
    }

}




