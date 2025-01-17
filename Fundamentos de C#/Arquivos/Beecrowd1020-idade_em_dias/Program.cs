﻿/* 
https://www.beecrowd.com.br/judge/pt/problems/view/1020
Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. Este é apenas um exercício com objetivo de testar raciocínio matemático simples.

Entrada
O arquivo de entrada contém um valor inteiro.

Saída
Imprima a saída conforme exemplo fornecido.

Exemplo de Entrada
400
Exemplo de Saída
1 ano(s)
1 mes(es)
5 dia(s)
 */
 int valor = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine($"{valor / 365} ano(s)");
 valor %= 365;
 Console.WriteLine($"{valor / 30} mes(es)");
 valor %= 30;
 Console.WriteLine($"{valor} dia(s)");
