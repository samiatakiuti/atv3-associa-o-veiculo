public class Locacao
{
    private Cliente _cliente;
    private Veiculo _veiculo;
    private DateOnly _dataRetirada;
    private int _quantidadeDias;
    private decimal _valorDiaria;

    public Cliente Cliente
    {
        get
        {
            return _cliente;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentException(
                    "A locação precisa possuir um cliente."
                );
            }

            _cliente = value;
        }
    }

    public Veiculo Veiculo
    {
        get
        {
            return _veiculo;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentException(
                    "A locação precisa possuir um veículo."
                );
            }

            _veiculo = value;
        }
    }

    public DateOnly DataRetirada
    {
        get
        {
            return _dataRetirada;
        }
        private set
        {
            _dataRetirada = value;
        }
    }

    public int QuantidadeDias
    {
        get
        {
            return _quantidadeDias;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    "A quantidade de dias deve ser maior que zero."
                );
            }

            _quantidadeDias = value;
        }
    }

    public decimal ValorDiaria
    {
        get
        {
            return _valorDiaria;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    "O valor da diária deve ser maior que zero."
                );
            }

            _valorDiaria = value;
        }
    }

    public Locacao(
        Cliente cliente,
        Veiculo veiculo,
        DateOnly dataRetirada,
        int quantidadeDias,
        decimal valorDiaria)
    {
        Cliente = cliente;
        Veiculo = veiculo;
        DataRetirada = dataRetirada;
        QuantidadeDias = quantidadeDias;
        ValorDiaria = valorDiaria;
    }

    public decimal CalcularValorBruto()
    {
        return QuantidadeDias * ValorDiaria;
    }

    public decimal CalcularDesconto()
    {
        if (QuantidadeDias >= 7)
        {
            return CalcularValorBruto() * 0.10m;
        }

        return 0;
    }

    public decimal CalcularValorFinal()
    {
        return CalcularValorBruto() - CalcularDesconto();
    }

    public void ExibirResumo()
    {
        Console.WriteLine("--LOCAÇÃO--");
        Console.WriteLine($"Cliente: {Cliente.Nome}");
        Console.WriteLine($"CPF: {Cliente.CPF}");
        Console.WriteLine($"Veículo: {Veiculo.Modelo}");
        Console.WriteLine($"Placa: {Veiculo.Placa}");
        Console.WriteLine($"Data de retirada: {DataRetirada:dd/MM/yyyy}");
        Console.WriteLine($"Quantidade de dias: {QuantidadeDias}");
        Console.WriteLine($"Valor da diária: R$ {ValorDiaria:F2}");
        Console.WriteLine($"Valor bruto: R$ {CalcularValorBruto():F2}");
        Console.WriteLine($"Desconto: R$ {CalcularDesconto():F2}");
        Console.WriteLine($"Valor final: R$ {CalcularValorFinal():F2}");
        Console.WriteLine();
    }
}

