using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Text.RegularExpressions;
using ZXing;

namespace TestesQuestPDF;

internal sealed class EtiquetaPesagemSevisa
{
    public string NomeProduto { get; init; } = string.Empty;
    public string ProduzidoPor { get; init; } = string.Empty;
    public string CNPJ { get; init; } = string.Empty;
    public string InscricaoEstadual { get; init; } = string.Empty;
    public string Endereco { get; init; } = string.Empty;
    public string CidadeEstado { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string WhatsApp { get; init; } = string.Empty;
    public DateTime DataFabricacao { get; init; } = DateTime.Now;
    public TimeSpan PrazoValidade { get; init; } = TimeSpan.FromDays(30);
    public string PesoLiquido { get; init; } = string.Empty;
    public int NumeroAgenciaDefesa { get; init; } = 0;

    internal Document GerarEtiqueta()
    {
        var logoBytes = File.ReadAllBytes($"{AppDomain.CurrentDomain.BaseDirectory}/Logos/logo-sevisa-pb.png");
        var carimboBytes = File.ReadAllBytes($"{AppDomain.CurrentDomain.BaseDirectory}/Logos/carimbo.png");

        var dun14 = GerarDUN14("0128", PesoLiquido);
        var codigoBarrasSvg = GerarCodigoBarrasDun14SVG(dun14);

        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(180, 100, Unit.Millimetre);
                page.Margin(1, Unit.Millimetre);
                page.Content()
                .Column(_ =>
                {
                    _.Spacing(1, Unit.Millimetre);

                    // Nome do produto
                    _.Item()
                        .ExtendHorizontal()
                        .BorderColor(Colors.Black)
                        .Border(1, Unit.Millimetre)
                        .Padding(1.5f, Unit.Millimetre)
                        .Text(NomeProduto)
                        .ClampLines(1)
                        .AlignCenter()
                        .Bold()
                        .FontSize(25);

                    _.Item()
                        .ExtendHorizontal()
                        .PaddingTop(1, Unit.Millimetre)
                        .Row(DetalhesDaEmpresa(logoBytes));

                    _.Item()
                    .ExtendHorizontal()
                    .ExtendVertical()
                    .BorderColor(Colors.Black)
                    //.Border(0.3f, Unit.Millimetre)
                    //.Row(CarimboEDetalhesDoProduto(carimboBytes));
                    .Table(_ =>
                    {
                        _.ColumnsDefinition(_ =>
                        {
                            _.ConstantColumn(50, Unit.Millimetre);
                            _.RelativeColumn(1.5f);
                            _.RelativeColumn(1);
                        });

                        _.ExtendLastCellsToTableBottom();

                        _.Cell().Row(1).Column(1)
                        .RowSpan(2)
                        .AlignCenter()
                        .AlignMiddle()
                        .Height(50, Unit.Millimetre)
                        .Image(carimboBytes);

                        _.Cell().Row(1).Column(2)
                        .ExtendHorizontal()
                        .AlignBottom()
                        .AlignCenter()
                        .Text(text =>
                        {
                            text.AlignCenter();

                            text.Span("\nINDÚSTRIA BRASILEIRA\n\n").ExtraBold().FontSize(10);
                            text.Span("MANTENHA CONGELADO\n").ExtraBold().FontSize(10);
                            text.Span("A -12º OU MAIS FRIO").ExtraBold().FontSize(10);
                        });

                        _.Cell().Row(2).Column(2)
                        .AlignMiddle()
                        .AlignCenter()
                        .Padding(2, Unit.Millimetre)
                        .BorderColor(Colors.Black)
                        .Border(1, Unit.Millimetre)
                        .Row(_ =>
                        {
                            _.AutoItem()
                            .Padding(2, Unit.Millimetre)
                            .Text(text =>
                             {
                                 text.AlignLeft();

                                 text.Span($"\nFABRICAÇÃO/LOTE: {DataFabricacao:dd/MM/yyyy}    \n").FontSize(12).ExtraBlack();
                                 text.Span($"VALIDADE: {DataFabricacao + PrazoValidade:dd/MM/yyyy}    \n").FontSize(12).ExtraBlack();
                             });
                        });

                        // codigo de barras
                        _.Cell().Row(1).Column(3)
                        .AlignBottom()
                        .AlignCenter()
                        .Column(_ =>
                        {
                            _.Item()
                            .AlignCenter()
                            .Text("NÃO CONTÉM GLÚTEN")
                            .FontSize(12).Black();

                            _.Item()
                            .AlignCenter()
                            .AlignMiddle()
                            .Svg(codigoBarrasSvg);
                        });

                        //Peso
                        _.Cell().Row(2).Column(3)
                        .AlignCenter()
                        .AlignMiddle()
                        .Column(_ =>
                        {
                            _.Item()
                            .AlignCenter()
                            .Text("PESO LÍQUIDO")
                            .FontSize(20).Black();

                            _.Item()
                            .AlignCenter()
                            .Text($"{PesoLiquido} Kg")
                            .FontSize(25).Black();

                        });

                    });
                });

                // Texto fora do layout
                page.Footer()
                    .AlignRight()
                    .Text("Registro na Agência de Defesa Agropecuária do Estado do Pará sob n° XXXX/090")
                    .FontSize(12)
                    .ExtraBold();
            });
        });
    }

    private Action<RowDescriptor> DetalhesDaEmpresa(byte[] logoBytes)
    {
        return row =>
        {
            row.AutoItem()
            .AlignCenter()
            .PaddingHorizontal(0.5f, Unit.Millimetre)
            .Width(45, Unit.Millimetre)
            .Image(logoBytes);

            row.AutoItem()
            .PaddingLeft(3, Unit.Millimetre)
            .Text(text =>
            {
                text.Span($"PRODUZIDO POR: ").ExtraBold().FontSize(10);
                text.Span($"{ProduzidoPor}\n").FontSize(10);
                text.Span($"CNPJ: {CNPJ} Inscr. Est.: {InscricaoEstadual}\n").FontSize(10);
                text.Span("UNIDADE DE BENEFICIAMENTO DE CARNE E PRODUTOS CÁRNEOS\n").ExtraBold().FontSize(10);
                text.Span($"{Endereco}\n").FontSize(10);
                text.Span($"{CidadeEstado}\n").FontSize(10);
                text.Span($"Email: {Email} Telefone: {WhatsApp}").FontSize(10);
            });
        };
    }

    private static string GerarDUN14(string codigoProduto, string pesoLiquido)
    {
        const int primeiroDigitoDun14 = 9; // Indicando item de medida/peso variável
        var codigoProdutoAjustado = Regex.Replace(codigoProduto, @"\D", "")
                                        .PadRight(6, '0')
                                        .Substring(0, 6);
        var pesoLiquidoAjustado = Regex.Replace(pesoLiquido, @"\D", "")
                                       .PadLeft(5, '0')
                                       .Substring(0, 5);
        var semDv = $"{primeiroDigitoDun14}{codigoProdutoAjustado}{pesoLiquidoAjustado}";
        var res = $"{semDv}{CalcularDvEan13(semDv)}";
        return res;
    }

    public static int CalcularDvEan13(string eanSemDv)
    {
        if (eanSemDv.Length != 12)
        {
            throw new ArgumentException("Codigo Ean sem DV deve ter 12 caracteres");
        }

        int somaPares = 0;
        int somaImpares = 0;

        for (int i = 0; i < 12; i++)
        {
            int digit = int.Parse(eanSemDv[i].ToString());

            if ((i + 1) % 2 == 0)
            {
                somaPares += digit;
            }
            else
            {
                somaImpares += digit;
            }
        }

        somaPares *= 3;

        int somaTotal = somaPares + somaImpares;

        int resto = somaTotal % 10;

        int dv = (resto == 0) ? 0 : 10 - resto;

        return dv;
    }

    private static string GerarCodigoBarrasDun14SVG(string codigoDun14)
    {
        var writer = new BarcodeWriterSvg()
        {
            Format = BarcodeFormat.EAN_13,
            Options =
            {
                Width = 550,
                Height = 100,
                NoPadding = true,
                PureBarcode = true,
            }
        };
        var svg = writer.Write(codigoDun14);
        return svg.Content;
    }

    private static Action<RowDescriptor> CarimboEDetalhesDoProduto(byte[] carimboBytes)
    {
        return _ =>
        {
            // Carimbo
            _.AutoItem()
            .AlignCenter()
            .AlignMiddle()
            .Height(50, QuestPDF.Infrastructure.Unit.Millimetre)
            .Image(carimboBytes);

            //_.AutoItem()
            //.Width(10, Unit.Millimetre)
            //.ExtendVertical()
            //.BorderColor(Colors.Black)
            //.Border(0.3f, Unit.Millimetre)
            //.Column(_ => {
            //    _.Item()
            //    .AlignCenter()
            //    .Text($"123").FontSize(10).Bold();
            //});

            //_.AutoItem()
            //.Width(10, Unit.Millimetre)
            //.ExtendVertical()
            //.BorderColor(Colors.Black)
            //.Border(0.3f, Unit.Millimetre)
            //.Padding(1, Unit.Millimetre)
            //.Column(_ => { });
        };
    }
}
