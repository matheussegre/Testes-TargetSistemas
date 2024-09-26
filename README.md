# Desafio Target Sistemas

## A resposta do desafio 3 está no program.cs, também vou deixar ela abaixo:

```c#
﻿decimal MenorFaturamento = decimal.MaxValue;
decimal MaiorFaturamento = decimal.MinValue;
decimal Total = 0;
int DiasComFaturamento = 0;

List<decimal> FaturamentoAnual = new List<decimal>
{
     100, 200, 0, 150, 300, 0, 180, 250, 200, 0, 0, 220, 280, 0, 190
};


foreach (var valor in FaturamentoAnual)
{
    if (valor > MaiorFaturamento)
        MaiorFaturamento = valor;

    if (valor < MenorFaturamento)
        MenorFaturamento = valor;

    if (valor > 0)
    {
        Total += valor;
        DiasComFaturamento++;
    }
}

var mediaAnual = DiasComFaturamento > 0 ? Total / DiasComFaturamento : 0;

var diasAcimaDaMedia = 0;
foreach (var valor in FaturamentoAnual)
{
    if (valor > mediaAnual)
        diasAcimaDaMedia++;
}

Console.WriteLine($"Menor faturamento: {MenorFaturamento}");
Console.WriteLine($"Maior faturamento: {MaiorFaturamento}");
Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
```
### Caso seja necessário executar, copie o desafio com o código abaixo:
```
git clone https://github.com/matheussegre/Testes-TargetSistemas.git
```

# Desafio 4
### Tabelas
```sql
Cliente
cliente_id (PK)   | INT
razao_social      | VARCHAR
estado_id (FK)    | INT

Telefone
telefone_id (PK)  | INT
numero            | VARCHAR
cliente_id (FK)   | INT
tipo_id (FK)      | INT

TipoTelefone
tipo_id (PK)      | INT
descricao         | VARCHAR

Estado
estado_id (PK)    | INT
sigla             | CHAR(2)
nome              | VARCHAR
```

### Relacionamento das Tabelas

Cliente -**(1:N)**-> Telefone <-**(N:1)**-TipoTelefone 
<br/>
Cliente -**(N:1)**-> Estado

### Consulta SQL
```sql
     SELECT c.cliente_id, c.razao_social, t.numero telefone
       FROM Cliente c INNER JOIN Estado e ON c.estado_id = e.estado_id
                       LEFT JOIN Telefone t ON c.cliente_id = t.cliente_id
      WHERE e.sigla = 'SP'
```
