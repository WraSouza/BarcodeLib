# 📦 BarcodeLib
[![NuGet Version](https://img.shields.io/nuget/v/CodeBarsGenerator.svg)](https://www.nuget.org/packages/CodeBarsGenerator/)
[![.NET](https://img.shields.io/badge/.NET-10.0-blueviolet?logo=dotnet)](https://dotnet.microsoft.com/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/CodeBarsGenerator.svg)](https://www.nuget.org/packages/CodeBarsGenerator/)
[![Build Status](https://img.shields.io/badge/build-passing-brightgreen.svg)]()
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)

Biblioteca .NET para geração de **códigos de barras (Code 128)** e **QR Codes** utilizando **ZXing.Net** e **SkiaSharp**. O retorno das imagens é no formato **BMP**. Disponível como **NuGet Package**, **API REST** e **Docker Image**.

---

## 🚀 Instalação

Via NuGet:
```bash
dotnet add package CodeBarsGenerator
```

## 🛠️ Exemplos de Uso

Gerar Código de Barras

```text
using BarcodeLib.Generators;

var generator = new BarcodeGenerator();

if (generator.TryGenerate("123456789", out var barcodeBytes))
{
    var path = @"C:\Users\seu_usuario\Pictures\arquivo.bmp";
    File.WriteAllBytes(path, barcodeBytes);
    //Escrever no console é opcional
    Console.WriteLine("✅ Código de barras gerado!");
}
```

Gerar QR Code

```text
using BarcodeLib.Generators;

var qr = new QrCodeGenerator();

if (qr.TryGenerate("1234567890", out var qrBytes))
{
    var path = @"C:\Users\seu_usuario\Pictures\arquivo.bmp";
    File.WriteAllBytes(path, barcodeBytes);
    //Escrever no console é opcional
    Console.WriteLine("✅ QR Code gerado!");
}
```

## 🧩 Formas de Consumo
📦 NuGet Package → para uso direto em projetos .NET

🌐 API REST → para integração entre sistemas via HTTP -> Disponível em https://github.com/WraSouza/CodeBarsGenerator

🐳 Docker Image → para rodar em containers facilmente -> Disponível em https://hub.docker.com/r/wladimirsouza/codebarsgenerator

## 📄 Licença
Este projeto está licenciado sob a [MIT License](LICENSE). Você pode usar, modificar e distribuir livremente, desde que mantenha a atribuição ao autor original.

## 🤝 Contribuições
Pull requests são bem-vindos!
Sinta-se à vontade para abrir issues e sugerir melhorias.
