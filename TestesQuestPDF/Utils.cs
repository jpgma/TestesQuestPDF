using System.Reflection;
using ZXing;

namespace TestesQuestPDF;

internal static class Utils
{
    internal static Stream ObterStreamArquivoInserido(string nome)
    {
        var info = Assembly.GetExecutingAssembly().GetName();
        var caminho = info.Name;
        var streamArquivo = Assembly
            .GetExecutingAssembly()
            .GetManifestResourceStream($"{caminho}.{nome}")!;
        return streamArquivo;
    }

    internal static byte[] ObterBytesArquivoInserido(string nome)
    {
        using var streamArquivo = ObterStreamArquivoInserido(nome);
        using var streamMemoria = new MemoryStream();
        streamArquivo.CopyTo(streamMemoria);
        return streamMemoria.ToArray();
    }

    internal static string ObterStringArquivoInserido(string caminho)
    {
        using var stream = ObterStreamArquivoInserido(caminho);
        using var reader = new StreamReader(stream, true);
        var conteudo = reader.ReadToEndAsync().GetAwaiter().GetResult();
        return conteudo;
    }

    internal static string GerarCodigoBarrasSVG(string conteudo, BarcodeFormat formato)
    {
        var writer = new BarcodeWriterSvg()
        {
            Format = formato,
            Options =
        {
            Width = 550,
            Height = 100,
            NoPadding = true,
            PureBarcode = true,
        }
        };
        var svg = writer.Write(conteudo);
        return svg.Content;
    }

    internal static string GerarQRCodeSVG(string conteudo)
    {
        var writer = new BarcodeWriterSvg()
        {
            Format = BarcodeFormat.QR_CODE,
            Options =
        {
            Width = 200,
            Height = 200,
            NoPadding = true,
        }
        };
        var svg = writer.Write(conteudo);
        return svg.Content;
    }
}
