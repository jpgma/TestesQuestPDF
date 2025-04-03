using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

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

        //var codigoProduto = produto.Codigo.Replace("#", string.Empty);
        //var ean13 = GerarEan13(codigoProduto, pesoLiquido);
        //var codigoBarrasSvg = GerarCodigoBarrasEan13SVG(ean13);

        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(180, 100, Unit.Millimetre);
                page.Margin(2, Unit.Millimetre);
                page.Content()
                    .Column(column =>
                    {
                        column.Spacing(5);

                        // Product Name
                        column
                            .Item()
                            .ExtendHorizontal()
                            .BorderColor(Colors.Black)
                            .Border(0.5f, Unit.Millimetre)
                            .Padding(1, Unit.Millimetre)
                            .Text(NomeProduto)
                            .AlignCenter()
                            .Bold()
                            .FontSize(20);

                        column.Item()
                            .ExtendHorizontal()
                            //.BorderColor(Colors.Black)
                            //.Border(0.3f, Unit.Millimetre)
                            .Row(_ =>
                            {
                                // Logo
                                _.AutoItem()
                                    .AlignCenter()
                                    .PaddingHorizontal(0.5f, Unit.Millimetre)
                                    .Width(45, Unit.Millimetre)
                                    .Image(logoBytes);

                                // Company Details
                                _.AutoItem()
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
                            });

                        column.Item()
                        .ExtendHorizontal()
                        .ExtendVertical()
                        .BorderColor(Colors.Black)
                        .Border(0.3f, Unit.Millimetre)
                        .Row(_ =>
                        {
                            // Carimbo
                            _.AutoItem()
                                .Padding(1, QuestPDF.Infrastructure.Unit.Millimetre)
                                .AlignCenter()
                                .AlignMiddle()
                                .Height(50, QuestPDF.Infrastructure.Unit.Millimetre)
                                .Image(carimboBytes);

                            _.AutoItem()
                            .ExtendVertical()
                            .ExtendHorizontal()
                            .BorderColor(Colors.Black)
                            .Border(0.3f, Unit.Millimetre)
                            .Padding(1, Unit.Millimetre)
                            .Column(_ =>
                            {
                                _.Item()
                                .ExtendVertical()
                                .ExtendHorizontal()
                                .Row(_ =>
                                {
                                    _.AutoItem()
                                    .ExtendVertical()
                                    .Column(_ =>
                                    {
                                        _.Item()
                                            .PaddingBottom(2, Unit.Millimetre)
                                            .AlignCenter()
                                            .Text("INDÚSTRIA BRASILEIRA").FontSize(10).ExtraBold();

                                        _.Item().AlignCenter().Text("MANTENHA CONGELADO").FontSize(10).ExtraBold();
                                        _.Item().AlignCenter().PaddingBottom(1, Unit.Millimetre).Text("A -12º OU MAIS FRIO").FontSize(10).ExtraBold();

                                        _.Item()
                                        .AlignBottom()
                                        .Border(0.5f, Unit.Millimetre)
                                        .PaddingHorizontal(2, Unit.Millimetre)
                                        .PaddingVertical(6, Unit.Millimetre)
                                        .Row(_ =>
                                        {
                                            _.AutoItem()
                                            .Column(_ =>
                                            {
                                                _.Item().AlignLeft().Text($"FABRICAÇÃO/LOTE: {DataFabricacao:dd/MM/yyyy}").FontSize(12).ExtraBold();
                                                _.Item().AlignLeft().Text($"VALIDADE: {DataFabricacao + PrazoValidade:dd/MM/yyyy}").FontSize(12).ExtraBold();
                                            });
                                        });
                                    });
                                });

                            });

                            _.AutoItem()
                            .ExtendVertical()
                            .ExtendHorizontal()
                            .Row(_ =>
                            {
                                _.AutoItem().AlignCenter().Text($"Registro na Agência de Defesa Agropecuária Estado do Pará sob n° XXXX/090").ExtraBold();
                            });
                        });

                        //// Freezing Instructions
                        //column.Item().AlignCenter().Text("INDÚSTRIA BRASILEIRA\nMANTENHA CONGELADO\nA -12°C OU MAIS FRIO").FontSize(12);

                        //// Manufacturing & Expiration Dates
                        //column.Item().Border(1).Padding(5).Row(row =>
                        //{
                        //    row.RelativeItem().Text($"FABRICAÇÃO/LOTE: {DataFabricacao:dd/MM/yyyy}");
                        //    row.RelativeItem().Text($"VALIDADE: {DataFabricacao + PrazoValidade:dd/MM/yyyy}");
                        //});

                        //// Weight & Barcode
                        //column.Item().Row(row =>
                        //{
                        //    row.RelativeItem().Text("PESO LÍQUIDO\nXX kg").FontSize(16).Bold();
                        //    //row.RelativeItem().Image(Placeholders.Barcode());
                        //});

                        // Registration Footer
                        
                    });
            });
        });
    }
}
