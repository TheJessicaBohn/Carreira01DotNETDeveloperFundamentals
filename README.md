# [Carreira 01. .NET Developer Fundamentals](https://balta.io/carreiras/dotnet-fundamentals)

## Linguagens e Compiladores:
- ## O que são linguagens de programação?
    - **Definições:**
        - É uma forma de comunicação humano-computador, onde o humano fala para o computador como executar um comando;
        - Já que os computadores entendem apenas binário, uma LP (linguagem de programação), faz esse intermédio;
        - O que escrevemos em determinada linguagem o compilador transforma em liguagem de maquina (binário);
        - Em resumo temos um arquivo de texto:
            - Que um humano consegue ler;
            - Que será traduzido para binário;

- ## Alto e Baixo Nível:
  - **Definições:**
  - O envio de instruções ao computador é o nível de maquina;
  - As instruções ao computador sempre serão no formato binário;
  - Quanto mais detalhada(como microproessadores que tem pouca memória) a necessidade, mais baixo é o nível;
  - Linguagens mais modernas e mais proximas do usuário, como C# e Java, são chamados de liguagem de alto nível, pois é mais favorecida para os usuários em detrimento do processador;
  - Assembly: Baixo nível;
  - C#: Alto nível;
  - Linguagens de alto nível são geralmente mais escolhidas pois trazem um acesso há tudo que precisamos em nível de hardware, já prontos;
 
- ## Linguagens compiladas e interpretadas:
  - **Definições:**
  - **Compiladas:**
      - É quando existe o processo de compilção da linguagem;
      - Consiste em receber um arquivo de texto e convertê-lo num binário;
      - Normamente são mais legíveis para o ser humano;
  - **Interpretadas:**
      - Arquivos de testo puro, não transformados em binários;
      - Eles são lidos em tempo de execução, por um intérprete;
      - JavaScript é um exemplo de linguagem interpretada;
      - No caso do JavaScript:
          - O navegador é escrito em uma linguagem de auto nível;
          - Possuindo um interpretador;
          - Lê e executa um arquivo de JavaScript;

- ## Compilada VS Interpretada:
  - **Definições:**
  - Geralmente usamos as duas, principalmente se você for um desenvolvedor Web;
  - Não se prenda há um tipo de linguagem pois no fim,não faz diferença pois a compilação ou interpretação ocorre "por baixo dos panos";
  - Aprenda bem uma(Seja especialista em uma), mas conheça outras também;
  - **Interpretadas:**
    - **Prós:**
      - Não precisa ser compilada (só colocar um novo arquivo) ;
      - Correções mais faceis de serem executadas, pois são arquivos estáticos e não tem a necessidade de ser traduzida para uma linguagem de maquina antes, um output antes;
      - Mais simples de serem distribuídas;
    - **Contras: (Tradeoffs)**
      - Detecção de erros: só ocorrem em tempo de execução (só aparecem quando o cliente estiver visualizando o seu site);
      - Tamanho maior no final da aplicação, pois são arquivos textos e não binários que seriam quase como um zip, porém existe ferramentes que fazem a minificação do arquivo;
      - Menor otimização da execução;
      - Multiplos arquivos;
  - **Compiladas:**
    - **Prós:**
      - Tempo de compilação: Detectamos os erros no tempo de compilação, por isso a detecção dos erros são mais rápidos, e conseguimos ver isso já do nosso lado sem precisar a nossa aplicação para o cliente e depois ter que mandar uma correção, caso algo de errado;
      - Tamanho menor das aplicações, um exemplo em .NET no Windowns temos um .exe, ou um .dll, ou no Mac ou Linux temos sempre uma .dll, ou seja já é um arquivo nativamente mais compactado num formato que o computador entende, binário, com espaços e caracteres expeciais já removidos;
      - E como resultado final ele tem apenas um arquivo final por projeto;
    - **Contras: (Tradeoffs)**
      - Precisa de um compilador, nas linguagem interpretadas, podemos simplesmente pegar o arquivo e "jogar" para o browser, enquanto as complidas precisamos instalar um compilador;
      - Pode ser mais burocrática, pelo fato de ter que instalar programas a parte, além de que se você criou uma aplicação com erro, é necessário recompilar de novo e redistribuir a aplicação;

- ## Tipagem de dados:
  - **Definições:**
  - São linguagens também chamadas de fortemente tipadas;
  - Obrigam a especificar o **tipo de dado** da informação;
  - Menor liberdade (diferente do JavaScript com var);
  - Maior otimização, pois ele já sabe onde na memória ele vai guardar aquela informação, pois pelo tipo ele sabe o tamanho e nde guardar aquela variável;
  ``` int idade = 18; // Ok
  int idade = 18.2; // Erro
  int idade = "18"; // Erro
  int idade = 'a'; // Erro
  ```
  - Nada fora de um número inteiro é aceito no caso acima em C#, que é uma linguagem fortemente tipada;
  - Esse mesmo exemplo em JavaScript que é uma linguagem fracamente ou não tipada, teriamos o seguinte resultado:
  ``` int idade = 18; // Ok
  int idade = 18.2; // Ok
  int idade = "18"; // Ok
  int idade = 'a'; // Ok
  ```
  - Por definição os tipos são para padronizar os dados, para nós e para o processador/memória;
  - O **let** utiliza sempre o mesmo tamanho de alocação;
  - Tipando temos uma otimização, o compilador avisa do erro, além de saber o espaço de memória a ser alocado previamente, trazendo assim mais performance para o programa;
  - Exemplo no **C#**:
  ``` int => 32 bit
  float => 32 bit
  double => 64 bit
  decimal => 128 bit
  ```
- ## Revisão:
  - **Definições:**
  - Linguagens Tipadas e não tipadas;
    - Sendo o C# uma linguagem tipada ou fortemente tipada;
  - Linguagens compiladas ou interpretadas;
    - Sendo o C# uma linguagem compilada;
  - Linguagens de alto e de baixo nível;
    - Sendo o C# de alto nível;
  - Compildores Vs Interpretadores;

## C#:
- ## Por que utilizar C#?
  - C# é ima linguagem de programação: tipada compilada e gerenciada;
  - Criada por Anders Hejlsberg (também criador do Delphi e do TypeScript)
em meados de 2001;
  - Principal linguagem da Microsoft (Substituindo VB) ;
   - **Vantagens:**
   - Linguagem completa - Uma das mais completas do mercado atualmente, e como ele faz parte de um ecossistema não serve para apenas para aplicações web ou desktop e mobile, ele serve também para machine learn em data science, diversas outras tecnologias e frameworks também usam C#, assim como games, por exemplo o Unity que é uma das plataformas mais famosas;
   - Maturidade, desde a sua criação em 2001 ele vem sido atualizado, e pelo tempo que ele está no mercado tem muito conteúdo, diferente de uma nova tecnologia que você tem que desbravar tudo sozinho além do fato que pode ser que não vingue. Além de achar mais facilmente profissionais na área;
   - Mercado enterprise, mais voltado para grande empresas, até pela dificulade das grandes empresas em fazer mudanças;
   - Comunidade, grande quantidade de comunidade pelo mundo trazendo assim um amparo;
   - Aplicabilidade, por ser muito completa, aprendendo bem o C#, você está hábil a criar qualquer tipo de aplicação com uma boa base;
   - MicroSoft por trás;
   - Orientação à Objetos;

- ## C# como primeira linguagem:
  - **Definições:**
  - Não é a mais fácil, existem outras como **Python** como **JavaScript**, onde se tem bem menos coisas pra se aprender, e por esse motivo são relativamente mais fáceis de serem aprendidas;
  - Focada em OOP (Base da programação), todo desenvolvedor precisa saber de Programação orientada a objetos, e o C# te obriga a trabalhar nesse formato;
    - Temos também a progrmação funcional;
  - Fácil no começo pode te prejudicar no fim, pois se você começa com uma linguagem não orientada a objetos uma hora você vai precisar saber sobre o assunto;
  - OOP te dá a base para aprender coisas novas, principalmente que surgem o tempo todo na nossa área atualmente;
  - A conta uma hora vem, se você não aprender agora, vai ter que voltar e aprender;
  - Quanto mais tempo na base, mais fácil de aprender coisas novas, se você passar muito rapidamente pela base e partir logo pra framework e coisas mais avançadas vai chegar uma hora que você vai ficar estaguinando na sua carreira, aí você vai ter que parar pra aprender o básico;
  - A quantidade de horas é a mesma, pois se não você vai ter que voltar para trás pra aprender;
    - Você escolhe quanto tempo vai investir no básico, não existe mágica, tem que praticar, por mais que seja chato e não prazeroso;
  - Se você não consolidou o básico ainda:
    - Você tem dificuldades de aprender coisas novas, se você demora muito pra aprender coisas novas é porque você não sabe bem o básico;
    - Dificuldade em codificar coisas diferentes do seu cotidiano;
    - Resistência a mudanças, medo de aprender ou fazer coisas novas;
    - Pare e aprenda agora;

- ## Código gerenciado:
  - **Lembrando que:**
  - C# é uma uma linguagem fortemente tipada;
  - Compilada e;
  - De código **gerenciado**;
  - **Definições:**
  - Significa que a sua execução depende de um gerenciador;
  - Também conhecida como **Runtime**;
    - No caso o do C# o **Runtime**  se chama **CLR** ou **CLR Runtime**;
  - Gerencia memória, segurança, entre outros recursos básicos;
  - Linguagens como C/C++ por exemplo, se faz necessário a alocação de memória manualmente (fora do .NET);
    - Famoso ``` p = malloc (sizeof (int));
                 *p = 123;
                 free (p);```, que alocava e desalocava memória, e as chances de dar bugs e erros eram muito grandes;
  - Sabe a famosa tela azul do Windows? Isso ocorre muitas vezes pois algum programa tentou acessar uma mémoria que era reservado para o SO;
  - Permite interagirmos menos ou quase não interagirmos com recursos de maquina, ou seja tira essa parte mais "mecanica" na mão do desenvolvedor;
    - O gerenciador vai saber a hora de alocar ou limpar a memoria, qual área é segura e assim por diante;
    - Dessa forma é possível focar muito mais nas regras de negócio;

- ## Compilação e gerenciamento:
  - **Definições:**
  - A MS possui outras linguagens como o VB.NET, F#, e até mesmo Cobol.NET;
  - Todas elas precisam ser mantidas;
    - Manutenção de código mesmo, correções de bugs e afins;
  - Quando o ecossistema de desenvolvimento MS foi criado ele foi pensado desta forma:
    -  Suporte a várias linguagens;
  - Se cada linguagem tiver um gerenciador, isto seria muito complicado;
  - Os compiladores são separados;
    - Um para cada linguagem (ou mais de uma linguagem);
  - A compilação inicial gera um código intermediário (não gera o código binário);
    - Intermediate Language (IL);
    - Serve para manter apenas um gerenciador final;
    - Quando compilamos o código C# ele é traduzido para essa liguagem intermédiaria e depois ele é compilado, assim como nas outras linguagens como o VB.Net, F# e outras linguagens;
    - Isso é muito legal pois permite que tenha apenas um gerenciador final para essas linguagens, e tenhamos diferentes tipos de arquivos dentro do nosso projeto, então nada impede de que tenhamos um arquivo VB.NET ou F# dentro do nosso projeto C#;
    - Mas geralmente escolhemos apenas um tipo de linguagem apenas;

- ## IL:
  - **Definições:**
  - Embora as compilações sejam diferentes:
    - O gerenciamento é igual;
    - Alocação de memoria;
    - Execução de instruções no processador;
  - O CLR recebe um código e compila ele para IL:
    - C#, VB.NET, F#, Cobol.NET;
  - Podemos ter arquivos C# e VB.NET no mesmo projeto:
    - Porém nunca no mesmo arquivo, pela sintaxe de cada linguagem;
  - O resultado da compilação IL é sempre o mesmo;
  - O processo de conversão do IL para binário é conhecido como JIT
    
    ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/ccbee0a1-05e9-40d6-81d1-42a7e571a68c)
 
- ## Revisão:
  - **Definições:**
  - C# é maduro, completo, popular e tem muito material;
  - Linguagem, gerenciada, compilada e de alto nível;
  - É uma linguagem desafiadora,mas vai te dar uma ótima bagagem;
  - O C# é compilado inicialmente para IL;
  - Depois o CLR compila para código de maquina, executa e gerencia, mão na roda para o progrmador não ter que fazer o processo na mão;
  - IL é a linguagem intermediaria na qual todas as linguagens da Microsoft são compiladas;

## Frameworks:

- ## Frameworks:
  - **Definições:**
  - Framework é uma estrutura, um alicerce
    - Um conjunto de bibliotecas;
  - Usamos como base para construir nossas aplicações
    - Pra não precisar fazer tudo, começando do zero, como por exemplo escrever um arquivo texto no disco;
    - Quando utilizamos um framework, estamos utilizando um código base que já foi testado, estressando e temos assim, n outras garantias;
  - Conceito existente em diversas tecnologias, como por exemplo Java, JavaScript, etc;
  - Nesse curso veremos o **.NET**, um Framework Microsoft;
  - Ideia é trazer recursos comuns jé prontos:
    - Itens do dia-a-dia;
    - Escrita de arquivo em disco, por exemplo:
      - Acesso a banco de dados;
      - Criar um site;
      - Criar uma aplicação Desktop;
      - Um desenho de uma janela do Windows;
      - O desenho de um botão;
  - .NET nasceu junto com o C# em 2001
  - Framework poderoso; 
  - Validados e testados;
  - Nos poupam muito tempo;
  - Não vale a pena começar sem um pois o risco é menor;

- ## .NET Framework:
  - **Definições:**
  - C# é a linguagem, tem vagas que colocam "AspNet", mas o correto é que a linguagem é o C#;
  - O nome do framework é .NET, pelo boom da internet nos anos 2000;
  - Teve a sua primeira versão em meados de 2001;
    - chamado de .NET Framework, Framework explicitamente no nome;
  - Recebeu as versões 1.0, 1.1, 2.0, 3.0, 3.5, 4.X (atualmente);
  - Pode ser instalado Side-by-Side, ou seja, mais de uma versão desse .NET;
  - Compatível somente com Windows, só da pra hospedar em maquinas Windows, não suportando Mac, Linux, etc;
  - Considerado **legado**;

- ## .NET Core:
  - **Definições:**
  - Versão moderna no .NET Framework (isso na ópoca em que o curso foi lançado, hoje atualmente em abril de 2024 temos o **.NET 8** é o mais recente) ;
  - Lançado em meados de 2015;
  - Veio especialmente para suportar outros SOs como Linux e Mac;
  - Suas primeiras versões continham apenas o básico:
    - Core significa núcleo, ou seja o essencial;
    - Mudar um framework usado por milhões de não é fácil;
    - Foi totalmente reescrito;
    - Isso trouxe um monte de benefícios pois melhorou o framework e a linguagem, arrumou bugs alémde deixar ambos mais rápidos;
    - Ainda assim com uma ótima retro compatibilidade;
    - Na época do curso a versão era 3.1, era bem atual e eu trabalhava com essa versão no meu atual trabalho, já era muito boa, mas atualmente já migramos para 5, 6 e 8, e cada vez menos temos que escrever códigos nessas novas versões, inclusive estou usando o .NET 8, pois esse é o me computador pessoal, porém eu trabalho nele, o .NET roda as duas versões concomitantemente, porém as vezes é necessário clonar novamente repositórios e quando rodamos pela primeira vez, na hora de criar um arquivo de debug ele sempre pegas as versões mais antigas, então por esse motivo e também porque sempre temos que atualizar, estarei utilizando o .NET 8, nesse repositório;
    - Recomendação atual da MS (atualmente continua sendo);
    - Muitas melhorias de porformance;
    - [**Versões**](https://learn.microsoft.com/pt-br/dotnet/core/releases-and-support);
    - Instalação Side-by-Side;

- ## Standard:
  - **Definições:**
  - .NET Framework e .NET Core coexistem, isso é bom para migrar projetos, já que o primeiro já é legado;
    - Podem ser instalados juntos;
    - Podem ser utilizados no mesmo projeto;
  - Como garantir que algo que escrevemos roda em ambos?

  ![intersecção](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/320387ac-0d33-41eb-b7a2-efdd524376ce)
  - Como podemos ver na imagem acima o .NET Standard é a intersecção desses dois frameworks;
  - Ele não é um framework, ele é apenas um contrato;
    - Também chamado de surface API
  - Garante que tudo que escrevemos será compatível com ambos frameworks;

  ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/62278aec-9872-40a5-b0f0-2eda55892867)
  
  Fonte: Microsoft
  - Atualmente o Xamarim, vai ter suporte até 1° de Maio de 2024, e está sendo substituído pelo Maui
  - A imagem ilustra como funciona o Standard

- ## .NET 5:
  - **Definições:**
  - Apesar de estar utilizand o .NET 8, achei importantande manter esse tópico do .NET 5 pois ele foi o precursor da unificação dos Frameworks;
  - O .NET Core chegou ao .NET Framework em nível de conteúdo;
  - Não faz mais sentido ter os dois frameworks;
  - Lançado em Novembro de 2020;
  - Perde os prefixos Framework e Core, ficando apenas .NET;
  - Retrocompatível;

- ## LTS:
  - **Definições:** Releases;
  - .NET Framework: Não possuia data de lançamento programada;
  - .NET Core: Lançamentos (Releases) semestrais;
  - .NET 5 e futuros: Lançamentos Anuais;
  - Releases com tempo menor, tem menos quebra de código;
  - Sigla para Long Term Support: Suporte de longa data;
  - .NET Framework: Todos eram;
  - .NET Core: Versões com final 1: 1.1, 2.1, 3.1...
  - .NET 5 e futuros: Versões maiores (Major Version) ou .0;
  - Opte sempre por LTS para projetos em produção:

- ## Versionamento:
  - **Definições:**
  - Vesão Semântica:
    - Dividida em fases:
      - Alpha, Beta, Release Candidate, Final;
    - Dividida em três partes:
      - Major, Minor, Patch;
  - **Alpha:**
    - Ainda não se sabe como vão ser as coisas;
    - Muito ainda pode mudar;
  - **Beta:**
    - Já tem ideia da estrutura;
    - As coisas ainda podem mudar;
  - **Release Candidate:**
    - Candidato a versão final;
  - **Final:**
    - Versão Final, então precisamos tomar cuidado com as versões anteriores; 
  - **15.8.2**;
  - **Major:(15)**
    - Pode conter incompatibilidades com versões anteriores;
    - Chamadas de breaking changes;
  - **Minor:(8)**
    - Possui mudanças, mas é totalmente compatível com versões anteriores;
    - Backward Compatibility;
 - **PATCH:(2)** Correcões de bugs e outros itens simples;
 - Podemos utilizar anotações com:
   - Alpha => 0.0.1-a1;
   - Beta => 0.0.2-b1;
   - Release Candidate => 1.0.0-rc1;
   - Final => 1.0.0;
 - Normalmente alpha e beta tem versões menores que 1.0.0;

- ## Runtime e SDK:
  - **Definições:** Runtime
  - Necessário para executar aplicações;
  - É dividido em 3 partes:
    - ASP.NET para aplicações web;
    - Desktop para aplicações desktop;
    - .NET Core para qualquer outra aplicação;
      - Console, Batch, Serviço
      - Não possui uma interface por exemplo
  - Também possui versões;
    - A versão tem que ser compatível com a versão utilizada durante a codificação;
  - Usado somente para distribuir as aplicações;
    - Apenas executa.
  - Tamanho menor, otimizado para execução;
  - **Definições:** SDK
  - Sigla para Software Development Kit: Kit para desenvolvimento de software;
  - Possui tudo o que precisamos para criar aplicações;
  - Já vem com o Runtime integrado;
  - Não devemos utilizar em produção, pois em produção só é necessário o Runtime;
  - É maior que o Runtime, pois vem com tudo o que precisamos
 - **Definições:** Requisitos
   - Windows:

   ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/76e9941b-373b-47f8-8617-bdea0d051de6)

   Fonte: Microsoft
   - Linux:

   ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/3c783291-6c8b-4ad4-b680-5c74ec83e15b)

   Fonte: Microsoft

- ## Revisão:
  - **Definições:**
  - Frameworks são estruturas prontas pra economizar o nosso tempo e diminuir os riscos;
  - .NET Framework é legado;
  - .NET Core é legado;
  - .NET 8 é o atual;
  - .NET 9 é o futuro;
  - .NET Standard é a padronização, surface API;
  - Garante que tudo que escrevemos é compatível com ambos
  - Opte sempre por versões LTS;
  - Runtime executa, SDK cria;

## .NET
- ## Instalação:
- ## dotnet cli:
- ## VS Code:
- ## Tipos de projeto:
- ## Fluxo de execução:
- ## Variáveis de ambiente;
- ## Estrutura do App:
- ## Debug:
- ## Revisão:

## Linguegem de Programação - com C#:
- ## Notas importantes:
- ## Escopo de um programa:
- ## Namespaces:
- ## Using:
- ## Variáveis:
- ## Constantes:
- ## Palavras Reservadas:
- ## Comentários:
- ## Tipos primitivos:
- ## System;
- ## Byte:
- ## Números inteiros:
- ## Números reais:
- ## Boolean:
- ## Char:
- ## String:
- ## Var:
- ## Object:
- ## Nullable Types:
- ## Alias:
- ## Valores padrões:
- ## Conversão implícita:
- ## Conversão explicita:
- ## Parse:
- ## Convert:
- ## Convertendo Tipos:
- ## Operadores aritméticos:
- ## Operadores de atribúição:
- ## Operadores de comparação:
- ## Utilizando operadores:
- ## Operadores lógicos:
- ## Operador condicional - IF:
- ## Utilizando IF:
- ## Estrutura Condicional - Switch:
- ## Laços de repetição - For:
- ## Laços de repetição - While:
- ## Laços de repetição - Do/While:
- ## Métodos e funções:
- ## Métodos e funções - Prática:
- ## Value Types e Reference Types:
- ## Value Types e Reference Types - Prática:
- ## Structs
- ## Structs - Prática:
- ## Enums:
- ## Revisão:

## Mão na massa - Criando uma calculadora:
- ## Iniciando o projeto:
- ## Soma:
- ## Utilizando Funções:
- ## Subtração:
- ## Divisão:
- ## Multiplicação:
- ## Menu da aplicação:
- ## Chamando as funções:
- ## Saindo da aplicação:
- ## Revisão:

## Mão na massa - Cronômetro:
- ## Iniciando o projeto:
- ## Estrutura do cronômetro:
- ## Thread e Sleep:
- ## Criando o menu:
- ## Opções do menu:
- ## Substring:
- ## Obtendo a opção:
- ## Calculando o tempo:
- ## Finalizando a aplicação
- ## Revisão:

## Mão na massa - Editor de textos:
- ## Iniciando o projeto:
- ## Iteração e caractere de escape:
- ## Do/While na prática:
- ## StreamWriter
- ## Salvando arquivo:
- ## Abrindo Arquivos:
- ## Revisão:

## Strings:
- ## Guids:
- ## Interpolação de Strings:
- ## Comparação de Strings:
- ## StartsWith/EndsWith:
- ## Equals:
- ## Índices:
- ## Métodos adicionais:
- ## Manipulando strings:
- ## StringBuilder:
- ## Revisão:

## Mão na massa - Editor HTML:
- ## Iniciando o projeto:
- ## Desenhando a tela:
- ## Exibindo o menu:
- ## Menu da aplicação:
- ## Editor:
- ## Visualizador:
- ## Substituindo caracteres:
- ## Revisão:

## Datas:
- ## Iniciando com datas:
- ## Obtendo valores da data:
- ## Formatando datas:
- ## Padrões de formatação:
- ## Adicionando valores:
- ## Comparando datas:
- ## CultureInfo:
- ## Timezone:
- ## Timespan:
- ## Revisão:

## Moedas:
- ## Tipo para moedas:
- ## Formatando moedas:
- ## Math:
- ## Revisão:

## Arrays:
- ## Arrays:
- ## Percorrendo um array:
- ## ForEach:
- ## Alterndo valores:
- ## Revisão:

## Exceptions:
- ## Exceptions:
- ## Try/Catch:
- ## Tratando erros:
- ## Disparando exceções:
- ## Finally:
- ## Revisão:

## Conclusão:

## Glossário:
- **Alpha:** Esboço de algo feito, e está longe de ter uma versão final;
- **Beta:** Versão de testes,mas não chega a ser uma versão finalde algo que já está funcionando, e já temos uma ideia de como vai ser no final;
- **CLR:** É a sigla para Common Language Runtime ou gerenciador de linguagem comum;
- **Compilador:** Agente que executa a compilação, que é a transformação do texto que escrevemos para binário(0 e 1). Lembrando que cada linguagem tem o seu próprio compilador. Um exemplo que eu gosto muito de usar para quem é bem leigo é que o programa escrito é como se fosse uma musica na partitura, e nós ao tocarmos somos os "compiladores".
- **Final:** Versão final da aplicação;
- **IL:** Sigla para Intermediate Language;
- **JIT:** Sigla para Just In Time;
- **Legado:** Sofwares mais de idade
- **Major:** Sempre o primeiro número de uma release, a release maior. Ex.: versão 2 para versão 3, podendo ser até um produto novo, e não tem garantia nenhuma da versão anterior para nova;
- **Minor:** Sempre o segundo número, ex.: versão 2.1 para versão 2.2, significa que as mudanças foram pequenas e mais leves, elas podem quebrar, mas não é uma mudança completa, não trocou um pacote ou um produto;
- **MS:** MicroSoft;
- **OOP - Object-oriented programming: ** Programação orientada a objetos;
- **Patch:** Terceiro número 2.1.0 para 2.1.1. Correção de bugs;
- **Release:** Nova versão de um aplicativo;
- **Release Candidate:** É a release canditada a ser a versão final da nossa aplicação. Está com os bugs corrigidos, nomes corretos;
- **SO:** Sistema Operacional;
- **Tempo de Execução:** É o que acontece durante a execução  do código pelo computador ou interpretador.
- **Tipo de dado:** um tipo de dado define  o formato dele, onde definimos por exemplo que aquela informação é um número, uma letra, uma cadeia de caracteres e assim por diante;

## Fonte:
- ## https://balta.io/carreiras/dotnet-fundamentals
