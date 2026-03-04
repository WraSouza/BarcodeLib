// See https://aka.ms/new-console-template for more information
using BarcodeLib;

var generator = new QrCodeGenerator();

if(generator.TryGenerate("1234567890", out var barcodeBytes))
{
    File.WriteAllBytes("barcode.png", barcodeBytes);
    Console.WriteLine("Código de barras gerado com sucesso!");
}
else
{
    Console.WriteLine("Falha ao gerar o código de barras.");
}
