decimal MenorFaturamento = decimal.MaxValue;
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

