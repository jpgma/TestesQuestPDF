using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace TestesQuestPDF;

internal class CrachasCredenciamento
{
    internal sealed record Cracha(string Cpf, string Position, string Name, string Role, string Address, string Date);

    [Obsolete]
    internal static Document GerarCrachas(IEnumerable<Cracha> crachas)
    {
        const float largura = 100;
        const float altura = 70;

        return Document.Create(container =>
        {
            foreach (var cracha in crachas)
            {
                var qrCodeSvg = Utils.GerarQRCodeSVG(cracha.Cpf);

                _ = container.Page(page =>
                {
                    page.Size(largura, altura, Unit.Millimetre);
                    page.Margin(1, Unit.Millimetre);
                    page.DefaultTextStyle(_ =>
                        _.NormalWeight()
                            .FontFamily("Roboto")
                            .Medium()
                            .LetterSpacing(0.1F)
                    );

                    page.Header()
                        .Height(25)
                        .Background(Colors.Black)
                        .AlignCenter()
                        .AlignMiddle()
                        .Text(cracha.Position.ToUpper())
                        .FontColor("#fff");

                    page.Content()
                        .Border(0.1f, Unit.Millimetre)
                        .Grid(grid =>
                        {
                            grid.Columns(2);

                            grid.Item(2)
                                .AlignLeft()
                                .PaddingTop(5)
                                .PaddingLeft(15)
                                //.BorderBottom(0.1f, Unit.Millimetre)
                                .Padding(5)
                                .Text(cracha.Name.ToUpper())
                                .FontSize(9)
                                .DirectionAuto()
                                .Bold()
                                .FontColor(Colors.Black);

                            grid.Item()
                                .PaddingTop(15)
                                .PaddingLeft(20)
                                .Column(col =>
                                {
                                    col.Spacing(10);

                                    col.Item()
                                        .PaddingTop(2)
                                        .Text(cracha.Role.ToUpper())
                                    .FontSize(8);

                                    col.Item()
                                        .PaddingTop(2)
                                        .Text(cracha.Address.ToUpper())
                                    .FontSize(8);

                                    col.Item()
                                        .PaddingTop(2)
                                        .Text(cracha.Date)
                                        .FontSize(7);
                                });

                            grid.Item()
                                .AlignMiddle()
                                .AlignCenter()
                                .Background(Colors.White)
                                .Width(30, Unit.Millimetre)
                                .Height(30, Unit.Millimetre)
                                .Svg(qrCodeSvg);
                        });
                });
            }
        });
    }
}
