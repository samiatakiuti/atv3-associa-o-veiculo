Cliente cliente1 = new Cliente(
    "Ana Silva",
    "123.456.789-00"
);
Veiculo veiculo1 = new Veiculo(
    "Toyota",
    "ABC-1234"
);
Locacao locacao1 = new Locacao(
    cliente1,
    veiculo1,
    new DateOnly(2026, 10, 8),
    5,
    150.00m
);
locacao1.ExibirResumo();

Cliente cliente2 = new Cliente(
    "Carlos Souza",
    "987.654.321-00"
);
Veiculo veiculo2 = new Veiculo(
    "Honda",
    "DEF-5678"
);
Locacao locacao2 = new Locacao(
    cliente2,
    veiculo2,
    new DateOnly(2026, 10, 8),
    10,
    200.00m
);
locacao2.ExibirResumo();

