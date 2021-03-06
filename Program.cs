﻿using System;
using MetodoConstrutor_Csharp.classes;

namespace MetodoConstrutor_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            Console.WriteLine($"Codigo: {produto1.Codigo} Nome: {produto1.Nome ?? "null"} Descricao: {produto1.Descricao ?? "null"} Estoque: {produto1.Estoque}");
            Produto produto2 = new Produto(1);
            Console.WriteLine($"Codigo: {produto2.Codigo} Nome: {produto2.Nome ?? "null"} Descricao: {produto2.Descricao ?? "null"} Estoque: {produto2.Estoque}");
            Produto produto3 = new Produto(1, "produto3", "Esse e o produto 3", 20);
            Console.WriteLine($"Codigo: {produto3.Codigo} Nome: {produto3.Nome ?? "null"} Descricao: {produto3.Descricao ?? "null"} Estoque: {produto3.Estoque}");
        }
    }
}
