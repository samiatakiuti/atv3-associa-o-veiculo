public class Veiculo
{
    private string _modelo = "";
    private string _placa = "";
    
    public string Modelo
    {
        get
        {
            return _modelo;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "O modelo do veículo não pode ser vazio."
                );
            }

            _modelo = value;
        }
    }

    public string Placa
    {
        get
        {
            return _placa;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "A placa não pode ser vazia."
                );
            }

            _placa = value;
        }
    }

    public Veiculo(string modelo, string placa)
    {
        Modelo = modelo;
        Placa = placa;
    }
}
