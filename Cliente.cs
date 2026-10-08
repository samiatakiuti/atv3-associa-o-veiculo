public class Cliente
{
    private string _nome = "";
    private string _cpf = "";

    public string Nome
    {
        get
        {
            return _nome;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "O nome do cliente não pode ser vazio."
                );
            }

            _nome = value.Trim();
        }
    }

    public string CPF
    {
        get
        {
            return _cpf;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "O CPF não pode ser vazio."
                );
            }

            _cpf = value.Trim();
        }
    }

    public Cliente(string nome, string cpf)
    {
        Nome = nome;
        CPF = cpf;
    }
}

