# DevelopersBR - Corujinhas

# Loops

## O que é um laço ou loop?

Um loop é uma maneira de executar um trecho código repetidas vezes. É composto te uma condição e código que será executado.

## Quando usar
Usamos loops quando precisamos fazer a mesma coisa várias vezes. 

Imagine que temos uma cafeteria, 3 programadores pediram café. Com isso temo uma lista de pedidos.
Para cada café sendo preparado, seu código precisa escrever na tela que o pedido está sendo executado, e ao final precisamos saber o total de cafés servidos. 

Como seria esse código?

```
int cafesPreparados = 0;

// Preparando o café
cafesPreparados++;
Console.WriteLine($"Preparando o 1° café");

cafesPreparados++;
Console.WriteLine($"Preparando o 2° café");

cafesPreparados++;
Console.WriteLine($"Preparando o 3° café");

Console.WriteLine($"Total de devs felizes: {cafesPreparados}");
```

Se tivermos apenas 3 emails não é uma tarefa difícil, certo?

Mas imagine que agora nossa cafeteria aceita pedidos online, e recebeu 100 pedidos. Como fazer isso?

### Código
Qualquer tipo de código pode ser executado em um loop, não há restrições!
Entretanto, existem certos tipos de variáveis que são usadas para ajudar a controlar o que está acontecendo  durante as repetições. Essa variável normalmente é chamada de **contador**.

### Condições
As condições são usadas para verificar quantas vezes o trecho de código será repetido. Antes de cada execução (ou depois, dependendo do tipo da estrutura de repetição usada), a condição é verificada e se continuar verdadeira o código é executado. Os tipoe de condições podem ser:
- Verdadeiro ou Falso
- Um número especíco de vezes
- O número de elementos em uma coleção

### Diagrama
O loop é representado por um circuito fechado, que enquanto a condição não for satisfeita se repete.

![image](_resources/while.png)

# Tipos de loops

## While
É o tipo mais básico de loop, todos os demais derivam dele. Para while, for e foreach, a condição é verificada antes da execução, e se for verdadeira o código é executado. Normalmente é usado para comparações de verdadeiro e falso.

![image](_resources/while.png)

As principais características do while são:
- Enquanto uma condição for verdadeira(ou falsa), continue repetindo.
- Executa o trecho de código uma vez, volta ao inicio e verifica se a condição continua verdadeira e executa novamente.
- **Atenção!** Isso pode acontecer para sempre, desde que a condição continue verdadeira! Isso é chamado de **loop infinito** e na maioria dos casos não é desejado.


## Do While
Para do while, acontece o oposto, o código é executado e apenas após a condição é verificada.
Isso pode ser útil em casos onde pelo menos uma execução é sempre necessária.

![image](_resources/dowhile.png)

## For
O for funciona da mesma maneira que o while. É recomendado seu uso para casos em que a quantidade de vezes que a repetição deve acontecer é conhecida.
Para declarar um for é necessária uma variável, chamada index ou i e são necessárias 3 declarações separadas por ponto e vírgula(;):

![image](_resources/for.png)

- Inicializar: Declaramos o valor inicial do índice
- Condição: Adicionamos a comparação que será usada para parar o loop 
- Iterar: Incrementamos o índice, normalmente com ++

## Foreach
O foreach é recomendado quando trabalhamos com coleções ou listas. Sua tradução é "para cada", o que significa o trecho de código será repetido uma vez para cada elemento da lista.
