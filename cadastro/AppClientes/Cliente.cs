namespace cadastro;

public class Cliente
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public DateOnly DataNascimento { get; set; }

    public DateTime  Cadastrado { get; set;  }

    public decimal Desconto { get; set;}

}
