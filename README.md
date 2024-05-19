# [Carreira 01 - .NET Developer Fundamentals](https://balta.io/carreiras/dotnet-fundamentals)

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
  - Quanto mais detalhada(como microprossadores que tem pouca memória) a necessidade, mais baixo é o nível;
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
    - Arquivos de texto puro, não transformados em binários;
    - Eles são lidos em tempo de execução, por um intérprete;
    - JavaScript é um exemplo de linguagem interpretada;
    - No caso do JavaScript:
      - O navegador é escrito em uma linguagem de auto nível;
      - Possuindo um interpretador;
      - Lê e executa um arquivo de JavaScript;

- ## Compilada VS Interpretada:
  - **Definições:**
  - Geralmente usamos as duas, principalmente se você for um desenvolvedor Web;
  - Não se prenda há um tipo de linguagem, pois no fim, não faz diferença pois a compilação ou interpretação ocorre "por baixo dos panos";
  - Aprenda bem uma(Seja especialista em uma), mas conheça outras também;
  - **Interpretadas:**
    - **Prós:**
      - Não precisa ser compilada (só colocar um novo arquivo);
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
  - Maior otimização, pois ele já sabe onde na memória ele vai guardar aquela informação, pois pelo tipo ele sabe o tamanho e onde guardar aquela variável;
  -``` int idade = 18; // Ok
	int idade = 18.2; // Erro
	int idade = "18"; // Erro
	int idade = 'a'; // Erro
	```
  - Nada fora de um número inteiro é aceito no caso acima em C#, que é uma linguagem fortemente tipada;
  - Esse mesmo exemplo em JavaScript que é uma linguagem fracamente ou não tipada, teriamos o seguinte resultado:
  -``` int idade = 18; // Ok
	int idade = 18.2; // Ok
	int idade = "18"; // Ok
	int idade = 'a'; // Ok
	```
  - Por definição os tipos são para padronizar os dados, para nós e para o processador/memória;
  - O **let** utiliza sempre o mesmo tamanho de alocação;
  - Tipando temos uma otimização, o compilador avisa do erro, além de saber o espaço de memória a ser alocado previamente, trazendo assim mais performance para o programa;
  - Exemplo no **C#**:
  - ``` int => 32 bit
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
  - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/ccbee0a1-05e9-40d6-81d1-42a7e571a68c)
 
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
  - ![intersecção](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/320387ac-0d33-41eb-b7a2-efdd524376ce)
  - Como podemos ver na imagem acima o .NET Standard é a intersecção desses dois frameworks;
  - Ele não é um framework, ele é apenas um contrato;
    - Também chamado de surface API
  - Garante que tudo que escrevemos será compatível com ambos frameworks;
  - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/62278aec-9872-40a5-b0f0-2eda55892867)
  
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
   - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/76e9941b-373b-47f8-8617-bdea0d051de6)

   Fonte: Microsoft
   - Linux:
   - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/3c783291-6c8b-4ad4-b680-5c74ec83e15b)

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
  - Para instalar vá ao site da MS https://dotnet.microsoft.com/pt-br/
  - Clique em **Baixar**
  - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/a4aab0fa-e0d4-406d-8812-221c47b2e696)
  - Clique em **SDK do .NET x64**
  - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/74ae336d-da11-43b0-8e62-2da5ea24a8c7)
  - Vá em downloads e clique duas vezes para exeutar o aplicativo;
  - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/3ff2838f-2ab0-4b43-ac5a-ab56fd1c3fa8)
  - Clique em instalar:
  - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/f77ebd05-6afc-43dc-8bbd-e18507396484)
  - Não vou trabalhar com Linux e nem MAC OS, mas segue o link onde você pode escolher qual quer instalar: https://dotnet.microsoft.com/pt-br/download/dotnet/8.0
  - pelo **Powershell** po terminal é possível saber a versão do .NET instalado pelo comando ```dotnet --version```
  - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/06970190-c1e2-4559-987a-42a4a11f7bea)

- ## Dotnet CLI:
  - **Definições:** CLI
  - Sigla para Command Line Interface: Interface de linha de comando;
    - Comandos adicionados ao nosso terminal;
    - Geralmente os comando por linha de comando mudam pouco;
    - Ajuda pois se nos acostumamos a algo visual e um botão muda de lugar, acaba criando uma dificuldade em se atualizar
  - **Definições:** dotnet CLI
  - Foi instalado ao instalarmos o SDK
  - Definido pelo comando ```dotnet```:
    - ```dotnet -- version```: Verifica a versão do dotnet atualmente instalado;
    - ```dotnet --list-sdks```: Lista os SDKs instalados;
    - ```dotnet --list runtimes```: Lista os Runtimes instalados;
    - ```dotnet help```: Exibe ajuda e também lista os comandos disponíveis;
 -![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/c3eb2d6f-ea0e-4eec-bffc-d0dac658a984)

- ## VS Code:
  - **Definições:** Visual Studio Code 
  - É um editor de código;
    - Existe outras alterntivas como ATOM, Sublime, Vim, Brackets;
    - Porém na minha opinião e na opinião do instrutor do curso, balta.io, esse é o melhor editor para se trabalhar, pois:
      - Melhor suporte a C#;
      - Feito pela MS;
      - Tem atualizações frequentes;
      - Tem possibilidade de criarmos os nossos próprios pacotes;
      - Tem temas personalizados;
      - etc.
  - Instalação:
    - O passo a passo é como o da instalação de qualquer programa no windows: baixar, abrir pasta de download, e clicar duas vezes para instalar, como no passo a passo da instalação do SDK
    - Você pode baixa-lo aqui: https://code.visualstudio.com/
    -  É importante lembrar que o simbolo do VS Code é azul e falta uma aste do lado direito, lembra um peixinho, pois o do Visual Studio Community é roxo e seu simbolo de lemniscata é completo
      - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/39784f6b-116d-4629-a319-cbbd427d8e83), VS Code;
      - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/2f7e3bef-0441-4308-8245-88addcc9809c), Visual Studio;
      - Nas configurações de instalação pode deixar todas as opções seguintes marcadas:
  - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/9731b15c-d2dc-438e-82b8-e555630bf86d)
      - Se desejar criar um atalho na sua Área de trabalho Windows pode marcar a primeira opção;
      - A segunda opção adiciona um botão no Windows Explore para abrir o seu arquivo diretamente no VS Code no menu de contexto;
      - A terceira opção adiciona um botão no Windows Explore para abrir o seu arquivo diretamente no VS Code no menu de diretório;
      - A quarta, vai registrar o Code como arquivos conhecidos, então tudo que for .cs (C#) o Windows vai abrir diretamente com o VS Code;
      - E a quinta e última ele permite abrir o Code a partir do terminal e outra coisa bem importante para o funcionamento do aplicativo, pois adiciona o VS Code à variável PATH das Variáveis de Ambiente, se não depois você precisará fazer esse processo "no braço";
  - Extensões:
    - ```Ctrl + Shift + X``` ou ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/8d59a99b-0053-4d8c-b5ef-85b2cd97b9f2);
    - Aberto ele possui uma lupinha para você pesquisar o que deseja, além de já mostrar as suas extenções instaldas:
  - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/27f7f4b7-9629-43d3-99d0-f64b99a7b69d)
    - Para o curso será necessário apenas as extensão: **C#** e a **C# Dev Kit**, é importante ver que ela tem o logo oficial da MS;
  - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/c3fe57c8-f8e7-45ab-bdb3-6368c818574b)
    - É importante tomar cuidado com extensões [DEPRECATED], pois elas não possuem suporte mais;
    - Uma extensão muito legal é a **vscode-icons** ela é muito bonitinha e tem alguns icones bem legais;
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/09621686-38cb-46a4-9e4b-a2545e7cf9b5)
    - Ao dar ```Ctrs + , ```, é possível acessar ao **settings**, pode se pode mexer tanto nas configurações visuais, como fonte, tamanho da fonte, quento em **open settings** ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/f225f20b-e14b-4d12-9625-a335edd31906) onde é possível configurar o formato do JSON ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/d1c950c3-5edc-42be-addc-ae0e5e406a14), além disso ele possui um intellisense, o que pode te ajudar a conhecer outras opções;
    - O comando ```Ctrl + Shift + P``` você tem acesso aos comandos do visual studio
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/29067e13-5af5-4717-9281-d0d12d170cad)
  - **Definições:** Visual Studio Community
  - É uma IDE;
    - Uma IDE, é diferente de um editor de código, pois ela é algo muito maior e possui muito mais recursos;
    - Porém é mais pesado e necessita de uma maquina melhor para a sua utilização;

- ## Tipos de projeto:
  - **Definições:** Tipos de Projeto
  - Como vimos em capítulos anteriores o .NET suporta diversos tipos de projetos, como APIs, Machine Learn
  - Então para cada aplicação que vamos criar, precisamos especificar o tipo de projeto;
  - Ex.: Class Library(ele é apenas uma biblioteca):
    - O resultado final é uma DLL;
    - Não possui interface;
    - Não possui resultado visível
    - O resultado final é uma cadeia de caracteres, uma string;
  - Ex.: Console Application:
    - Famosa telinha preta do DOS;
    - É um .exe;
    - O resultado final é uma aplicação que roda no terminal;
    - Pode receber dados, esperar input do usuário;
    - Possui reultado visível;
  - Projeto Web;
    - ASP.NET Web;
    - ASP.NET MVC;
    - ASP.NET WebAPI;
  - Projetos Testes;
    - Microsoft Tests;
  - **Definições:** Criando um novo projeto
  - dotnetcli:
    - ```dotnet new console``` => Novo Console Application;
    - ```dotnet new classlib``` => Nova Class Library;
    - ```dotnet new web``` => Novo projeto ASP.NET Core;
    - ```dotnet new mvc``` => Novo projeto ASP.NET Core;
    - ```dotnet new webapi``` => Novo projeto ASP.NET Core;
    - ```dotnet new msteste``` => Novo projeto Microsoft Test;
    - Lembrando que como nesse repositório, utilizamos o .NET 8 os projetos ASP.NET Core
  - Criar um novo projeto é o mesmo que gerar os arquivos iniciais de uma aplicação, então não precisamos criar tudo do zero;
  - Vai sempre gerar os arquivos na pasta atual;
  - Para especificar uma pasta, podemos utilizar o ```-o```
  - ```dotnet new console -o MeuApp```;
  - Vai criar uma nova pasta chamada MeuApp com os arquivos dentro
  - Uma ferramenta que muito legal que que gosto de usar é o [GitHub Desktop](https://desktop.github.com/), clique no nome e baixe o aplicativo, caso você tenha criado um repositório no GitHub para estudar como eu, lá ele tem uma opção de clonar, para que ele possa ser copiado e para sua maquina e editado por lá também;
  - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/3bc8d425-cda6-444f-aea8-fe19ca8e0972)
  - Lembrando que o os programas no Windows são Plug and Play, ou seja, next, next, next...
  - Após clonado vamos abrir o aplicativo baixado da loja da MS, Windows Terminal e por lá abrir a sua pastinha clonada do GitHub, com o comando ```cd nomeOuCaminhoDaPasta```
  - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/26d75dce-47ef-4cae-97d6-8da504cfe9c6)
  - Como podem ver na primeira linha ele só vai até a primeira seta no "jessi", e depois do comando que termina na segunda seta, na segunda linha ele já está dentro da minha pasta clonada;
  - Dentro dessa pasta vamos criar uma novo projetinho pelo comando ```mkdir NomeDoProjeto```, no meu caso vou chamar de "ProjetoTeste";
  - Os nomes das apicações em .NET tendem a começar sempre com letras maiúsculas, no futuro isso vai influenciar os chamados NameSpaces, além do uso do **Kebab Case**(espetinho de crurrasco), que significa que ao invés de espaço ou caracter especial para separar, utilizamos uma nova letra maiúscula;
  - Para entrar então na nossa pastinha, vamos lembrar do comando ```cd nomeOuCaminhoDaPasta```;
  - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/399a2723-8d49-4470-afd4-cb4507778e56)
  - Lembre-se de usar uma ou duas letras e depois usar o TAB, para completar o comando;
  - Dentro da pasta **ProjetoTeste**, vamos dar o comando ```dotnet new console```, e criar a nossa aplicação:
  - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/455df7d3-f7c8-4de7-9fbb-f279669b903b)
  - Para ver o que tem dentro da pasta, podemos usar o comando ```ls```:
  - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/c0534e84-b36a-4c0c-a9c4-41a589e9d8be)

- ## Fluxo de execução:
  - **Definições:**
  - Quando criamos o nosso projeto, assim como foi motrado no capítulo acima, o .NET executa alguns comandos adicionais, como por exemplo o ```dotnet restore ```, que busca todos os pacotes necesssários que a aplicação precisa para funcionar e faz a instalação deles.
  - Para você saber se está em um projeto .NET sempre tem que ter uma extenção **nomeProjeto.csproj**
  - Caso você tente executar um ```dotnet restore ```, dentro de uma pasta que não tenha o **.csproj**, ele vai dar um erro;
  - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/4f3ebe0a-f2a8-4b3d-8876-fe2e01efd20d)
  - ```dotnet build ``` compila a nossa aplicação:
  - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/75b61471-aed3-45fe-8550-71634fa02d71)
  - ```dotnet clean``` limpa todos os arquivos de cache da nossa aplicação, os SO´s Windows, MAC e Linux, "cacheiam" muita coisa, o mesmo pacote que você use para uma aplicação A, talvez você use pra uma aplicação B, então o SOs já baixam deixando o cache, então você não necessita baixar novamente aquele pacote. Então esse comando, limpa esses itens. De vez em quando pode ficar sujeira nesses chaches até por compilações erradas e a compilação acaba ficando "suja". A recomandação do Balta é que sempre antes de executar um ```dotnet build``` seria interessante executar um ```dotnet clean```, para garantir que não vai ficar sujeira na memória;
  - ```dotnet run```, um dos mais usados, é quem executa a nossa aplicação de fato.
  - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/90cdb778-b1c2-4fd0-9c4e-6844c7b2d514)

- ## Variáveis de ambiente;
  - **Definições:**
  - É comum existir mais de ambiente para as nossas aplicações:
    - Desenvolvimento (nossa maquina, pois é onde estamos desenvolvendo de fato a nossa aplicação) ;
    - Homologação (ambiente de testes, fora da sua maquina, porém o usuário final não tem acesso);
    - Produção (onde o cliente tem acesso à aplicação);
  - Cada ambiente possui suas configurações:
    - Chaves de acesso externo (cada ambiente tem seu "login");
    - Conexões com banco de dados (cada ambiente tem seu próprio banco de dados);
  - Desta forma, podemos dizer ao .NET qual ambiente estamos utilizando:
    - ```dotnet run --environment=$SEU_AMBIENTE```
      - ```dotnet run --environment=development```
      - ```dotnet run --environment=production```
  - O comando **run** não executa depuração (Debug)
    - assim a aplicação não vai parar nos Break Points;
  - O curso não vai abordar esse assunto;

- ## Estrutura do App:
  - **Definições:** Estrutura do console
  - Arquivo.csproj:
    - Formato XML
    - Definições do projeto
    - Presente em todo projeto .NET
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/26324290-292b-417f-87cf-60543d4210b4)
    -     ```<Project Sdk="Microsoft.NET.Sdk">

          <PropertyGroup>
          <OutputType>Exe</OutputType>
          <TargetFramework>net8.0</TargetFramework>
          <ImplicitUsings>enable</ImplicitUsings>
          <Nullable>enable</Nullable>
          </PropertyGroup>

            </Project>```
    - 1º demonstra que ele está usando o .NET SDK, que vimos a instalação anteriormente;]
    - 2º encontramos o **PropertyGroup**, que apenas define um grupo;
    - 3º cada tipo de projeto tem um output. Nesse caso foi criado um console, e o output dele é do tipo **.exe**
    - 4º TargetFramework, se refere a qual framework essa aplicação está se baseando, no caso estamos utilizando o .NET8
  - Program.cs:
    - Arquivo principal (c#)
    - Porta de entrada
    - Será o peimeiro a ser executado
    - Toda aplicação .net que executa sem ser o class library, ele tem um .cs, e ele busca esse arquivo que sempre vai ser o primeiro a ser executado, então não é legal renomear esse "cara",
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/826af44e-410e-48b8-8b59-fc1cc376dd77)
    - Nessa imagem podemos ver que o program.cs da versão do .NET 8 está bem mais enxuta que as suas versões anteriores;
  - Ao abrir o projeto **ProjetoTeste** podemos ver que ele gerou a pasta **obj**, e os arquivos **Program.cs**, e **ProjetoTeste.csproj**, a pasta **bin** foi gerada ao executar um ```dotnet build```;
  - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/c3d1d997-da0f-41ed-af0c-05531dee08a3)
    - Então o resultade de uma compilação fica dentro de uma pasta bin(binary).
    - O .csproj, a sua nomenclatura sempre segue o nome que você deu ao criar o projeto;
    - **cs:** C#, e **proj:** de projeto;
    - A pasta **obj**, é usada para tempo de  da nossa aplicação
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/92367231-66ab-4215-b450-62a8bc6d01fc)

- ## Debug:
  - **Definições:** Depurando
  - É possível executar a aplicação de dois modos:
    - Modo Release: que a gente executa a aplicação solta sem break points diretamente com ```dotnet run```, como se fossemos um cliente de fato, rodando a aplicação
    - Modo Debug: executar o programa com os chamados breaking points
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/9dba005b-9589-4939-8d09-3e1899046b5a)
    - Em **Settings** ```Ctrl + , ``` digite na pesquisa ```format on save```:
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/99eda34a-6eaf-4b2d-98fc-3fd48d18c333)
    - Essa opção formata seu arquivo já na hora de salvar, ele já deixa identado;
    - **Debugando:** vá no ícone de debug ou ```Ctrl + Shift + D ```
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/71b453f7-de04-4d3c-91cd-ead9e71ad287)
    -  Nesse caso vamos ter alguns passos a mais já que que a minha pasta não gerou automaticamente então clique no link **create a launch.json file**
    -  Se assim como o meu seu projeto não criar a pastinha .vscode, siga o seguinte passo a passo;
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/9cff0bb5-62b6-47f5-8e20-92a6d625a932)
    - Selecione a opção **C#**
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/d53659b2-9366-40e4-8503-10cf22c230c9)
    - E ele vai criar esse arquivo pra você dentro da pasta **.vscode**
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/4130f30e-1ece-473c-97fb-ce88851ec7a6)
    - Porém será necessário adicionar as configurações como mostra a imagem acima
    - Ao dar o ```Ctrl + , ``` ele já vai estar assim:
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/cd0f88ae-6bb9-48d9-a192-c66e06f37cf1)
    - Coloque os break points onde você deseja depurar, desde que seja um .cs
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/8981f4b1-6315-4543-b0ad-e01bd33618b1)
    - Clique na setinha verde ou ```F5```
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/f48eadaf-486d-4639-b31c-4c123feec11f)
    - Ao funcionar o debug ele vai mostrar esses novos itens na tela, como o console de debug, a informação dentro das variáveis e o menu de break points, onde é possível ir para os proximos pontos selecionados do código;
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/57f785fb-c4fb-48e0-a663-6544042d3666); 
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/6fece475-c787-46d0-834b-6ede6cf956cf): Continue ```F5```
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/b29ff752-c43f-4a10-aaa5-f0e5ff278543): Step over ```F10```
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/13dbd9e3-54fb-40c9-b4c5-bd22bc32ac2c): Step into ```F11```
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/2e226516-d2ec-412b-b182-0012822e0e03): Step out ```Shift + F11```
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/823eca9b-8fb0-4068-aee0-1658ff03f593): Restart ```Ctrl + Shift+ F5```
    - ![image](https://github.com/TheJessicaBohn/Carreira-01.-.NET-Developer-Fundamentals/assets/47541659/e184edb8-5b47-47d5-a93d-2e86be2c5d9c): Stop ```Shift + F5```

- ## Revisão:
  - **Definições:** .NET
  - Instalação simples lado a lado;
  - Tipos de projeto;
  - Executar uma aplicação;
  - Estrutura de um Console App;
  - Debug;

## Linguegem de Programação - com C#:
- ## Notas importantes:
  - **Definições:**
  - Não utilze espaços nem caracteres especiais na criação  do programa:
    - **Bons:** MeuApp, Pedidos, MinhaApp;
    - **Ruins:** "MeuApp", $APP, App #Teste
  - Tente utilizar caminhos curtos e sem caracteres especiais:
    - **Bons:**C:\dev, C:\apps;
    - **Ruins:** C:\ Caminho Com Espaços e Caracteres Especiais\Meu App;
  - Evite caminhos de rede se possível, utilize o C:\
  - O C# é Case Sensitive:
    - Isto significa que ele diferencia maiúsculas de minúsculas;
    - Teste é diferente de teste;

- ## Escopo de um programa:
  - **Definições:** Tudo o que um programa precisa para de fato ser executado
  - Importações: do que vamos utilizar nesse programa. Elas ficam no começo do nosso arquivo;
    - Ex.: Importação do módulo para escrita de arquivos em disco;
    - Ex.: Importação do módulo para do acesso ao banco de dados;
  - Namespace: São **separações lógicas**, serve para distinguir arquivos diferentes em pastas diferentes, porém com nomes iguais
  - Classe: É o programa em si, tudo o que vai ser executado pelo programa está dentro da classe;
  - Método Principal: É o sempre o primeiro método a ser executado;
  - Na execução do projeto, a primeira coisa que é feita é a busca pelo **Program.cs**, lendo a classe **Program** e o que estiver no método **Main**;

- ## Namespaces:
  - **Definições:**
  - Enquanto as pastas são divisões físicas;    
    - São para ajudar o Windows a se localizar;
  - Os namespaces são divisões lógicas;
    - São para ajudar o C# a se localizar;
  - Assim como não podemos ter dois arquivos com o mesmo nome nas pastas;
  - Não podemos ter suas classes com o mesmo nome no mesmo namespace;
  - O ideal é ter apenas um namespace e uma classe por arquivo;
  - O escopo de um namespace é definido entre CHAVES:
    - Classes e métodos também;
  - Um namespace pode ser reutilizado;
    - Pode estar presente em diversos arquivos;
  - Mesmas regras de **Notas Importantes**
  - Precisamos utilizar o ```using``` para importar o namespace;
  - Durante a execução, todos os arquivos do C# serão unificados;
  - A divisão física se perderá, irá se tornar apenas uma unica dll;
  - Sobrará apenas a divisão lógica, os namespaces;

- ## Using:
  - **Definições:** Importações
  - Importações definem as bibliotecas que o nosso programa irá utilizar;
    - Sejam elas internas, como por exemplo o uso do namespace;
    - Quanto externas, como por exempo o ```using System```
  - Por padrão só o básico vem incluso;
  - Precisamos importar o que desejamos para poder trabalhar;
  - Isto é feito no começo do programa;
  - Utilizamos a palavra reservada **using** para isso;
    - Não é obrigatório, mas é uma boa prática;
  - **Definições:** Notas importantes
  - Organizar nosso código em namespaces é fundamental;
  - Em aplicações grandes, o volume de código é alto;
  - A quantidade de arquivos é alta;
  - E o número de pessoas trabalhando no mesmo projeto também;
  - Entender bem esta organização é fundamental;
  - Use e abuse da criação de arquivos e namespaces, importante para organização;

- ## Variáveis:
  - **Definições:**
  - Uma variável é algo  que utilizamos para armazenar uma informação;
  - Ser variável significa que o valor pode ser alterado qualquer momento;
  - Ou seja, ele pode variar;
  - Sempre que "criamos" uma variável, dizemos que estamos inicializando-a;
  - Podemos usar um TIPO  ou palavra reservada **var** para criar uma variável;
    - Lembrando que o C# é uma linguagem fortemente tipada;
  - Vamos aprender ainda sobre os tipos dados;
  - No C# o tipo vem sempre antes do nome da variável;
  - Podemos informar um valor já na criação da variavel;
  - Se não informado o valor padrão será aplicado;
  - ~~~C#
    int idade; // Coreto, inicia em ZERO
    int idade = 25 // Coreto, inicia em 25
    var idade 25 // Coreto, inicia em 25
    var idade // Errado
    ~~~
  - **var** salva muito espaço no nosso código, não a nível de compilação, mas a nível e visualização;
  - **Definições:** Padronização de Nomes
  - Utilize nomes coesos (Clean Code);
    - Vai colocar por exemplo duração de algo: Ex.: ```duracaoEmHoras```, ```duracaoEmMinutos```;
    - Seja mais especifico na criação das suas variáveis, isso dá mais expressividade ao seu código;
    - Lembre-se de que outras pessoas vão ler seu código, e é importante que elas consigam ler com facilidade;
  - Não utilize caracteres especiais ou espaços;
  - Não comece com números;
  - A primeira letra de cada palavra é SEMPRE minúscula;

- ## Constantes:
  - **Definições:**
  - Assim como as variáveis utilizamos uma constante para armazenar uma infomação;
  - As constantes NÃO PODEM ser alteradas;
  - Uma vez criadas somos obrigados a atribuir um valor;
  - Feito isso elas não poderão ser modificadas novamente;
  - Não funcionam com a utilização de VAR;
  - São mais otimizadas que as variáveis;
  - Recomendadas para usos frequentes, regras;
  - A definição de constante é dada pela palavra reservada **const** antes do tipo;
  - Caso não seja informado um valor, o valor padrão será atribuido;
  - ~~~C#
    const int IDADE; // Coreto, inicia em ZERO
    const int IDADE = 25 // Coreto, inicia em 25
    const var IDADE 25 // Errado
    const var IDADE // Errado
   
   - **Definições:**Padronização de nomes
   - Utilize nomes coesos;
   - Não utilize caracteres especiais ou espaços;
   - Não comece com números;
   - É comum vermos constantes todas em maiúsculas, separadas por "_"
   - A ideia é bater o olho  no código e saber que aquilo é uma constante;
  
- ## Palavras Reservadas:
  - **Definições:** Nomes Reservados
  - O C# possui alguns nomes que são reservados;
    - Isso significa que não podemos utilizar esses nomes nem na criação de constantes e nem de variáveis;
  - Também são chamados de keywords;
  - São palavras de uso exclusivo do C#;
  - O VS Code vai te avisar sobre eles;
  - Lista de palavras reservadas do C#:
  - ![image](https://github.com/TheJessicaBohn/Carreira01DotNETDeveloperFundamentals/assets/47541659/1af1cfe8-1be4-4484-8c41-fc26d6d13d92)
  - ![image](https://github.com/TheJessicaBohn/Carreira01DotNETDeveloperFundamentals/assets/47541659/678773a9-fead-4c99-9f4c-08a3801df1f7)
  - Fonte: [/learn.microsoft.com](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/);

- ## Comentários:
  - **Definições:**
  - Por mais que escrevemos o melhor código possível, muitas vezes não conseguimos expressar tudo o que era preciso com o código, então pra isso o comentário é muito importante;
  - Em diversos cenários você precisará deixar uma mensagem;
  - Essa mensagem não deve ser executada pelo programa;
  - É comum utilizamos comentários em linhas que não desejamos executar também;
  - Podemos ter comentários de:
    - Uma linha;
    - Múltiplas linhas;
    - XML(Metadata);
  - ```
        // Comentário em uma linha
        
        /* 
            Comentário em várias
            linhas
        */ 
        
        /// Notação XML(Metadata)
    ```
  - Podemos utilizar o comando ``` Ctrl + ; ``` para comentar e descomentar ```//``` ;
  - Lembrando que um código bem escrito já é um código bem documentado (Clean Code);
  
- ## Tipos primitivos:
  - **Definições:**
  - Também conhecidos como **built-in types**;
  - São tipos base cujo outros tipos (Complexos) irão derivar;
  - Definir o tipo base correto otimiza a execução do programa (alocar memoria otimizada, caso esteja corretamente tipada);
  - São chamados de **Tipos de Valor** (Value Types);
  - Armazenam o valor e não a referência para um  item na memoria;
  - São Classificados em:
    - Tipos Simples (Simple Types);
	- Enumeradores (Enums);
	- Estruturas (Structs);
	- Tipos Nulos (Nullable Types);
  - Cada tipo possui uma capacidade;
  - Caso essa capacidade exceda, o programa gera um erro;
  - Essa capacidade pré-definida ajuda na otimização do seu programa;
  - Por exemplo o **int** que usamos previamente:
	- ```-2,147,483,648 até 2,147,483,647```;
- ## System:
  - **Definições:**
  - Tipo base do .NET, é da onde todos os outros tipos derivam;
  - Tudo no .NET começa pelo **System**;
  - Todo e qualquer tipo, seja built-in ou complexo, derivam dele;
  - Ele é a base de todos os objetos .NET;
  - Não precisamos nos preocupar em usá-la  ou qualquer coisa similar;
  - Seu uso já é implícito;

- ## Byte:
  - **Definições:**
  - O tipo **Byte** é utilizado para representar um byte de fato;
  - Em diversos casos precisa  da cadeia de bytes de um arquivo por exemplo;
    - Também chamando de byte array;
  - Temos também o **sbyte**, que permite valores negativos;
  - ```
	Signed e Unsigned
	Valores como "-" por exemplo, são chamadas de signed.
    ```
   - Ele é um tipo primitivo, 8 bits = 1 byte;
	- 0 até 255;
  - sbyte = 8 bits;
	- -128 até 127;
  - Nota: que o **sbyte** permite valores negativos, por isso o nome **sbyte**, que significa **Signed Byte**.
  - ```
    byte meuByte = 127;
    ```
  - Não é muito comum criar bytes assim na mão, a não ser que se esteja trabalhando com coisas muito especificas.

- ## Números inteiros:
  - **Definições:**
  - Um dos tipos mais usados são os números, tanto inteiros, quanto os reais;
  - Os números inteiros, ou seja, sem pontuação, podem ser definidos pelos tipos:
	- **short/ushort** -> números menores;
	- **int/uint** -> números razoáveis;
	- **long/ulong** -> números longos;
  - **U** como prefixo significa **unsigned**,, ou seja, sem sinal;
  - Assim como temos o **signed** nos bytes, nos números  por padrão são permitidos valores negativos;
  - Então usamos o **unsigned** para definir que o mesmo não pode definir valores negativos;
  - O tipo **int** é o mais comum de ser encontrado;
  - **short (16-bit):** -32.768 até 32.767;
  - **ushort (16-bit):** 0 até 65.535;
  - **int (32-bit):** -2.147.483.648 até 2.147.483.647;
  - **uint (32-bit):** 0 até 4.294.967.295;
  - **long(64-bit):** -9.223.372.036.854.775.808 até 9.223.372.036.854.775.807;
  - **ulong (64-bit):** 0 até 18.446.774.073.709.551.615;

- ## Números reais:
  - **Definições:**
  - Números que exigem uma maior precisão, ou seja, com pontuação:
	- **float (Notação F)**;
	- **double**;
	- **decimal (notação M)**;
  - Possuem assimilação negativa e positiva por padrão, dispensando o uso do signed/unsigned em seus tipos;
  - **float (32-bit)** -> 3.402823e38 até 3.402823e38
  - **double (64-bit)** -> -1.79769313486232e308 até 1.79769313486232e308
  - **decimal (128-bit)** (+ou-)1.0e-28 até 7.9x10e28
  - Lembrando que por padrão os números sem qualquer ponto o C# os reconhece como **int** em caso de uso do **var**, e a partir de uso de pontos pode ser reconhecido como **double**;
  - Para saber que se trata de um **float** é necessário colocar a notação f ao final do número. Ex.: ``` float saldo = 2.500f```, se não o compilador devolve que não pode implicitamente converter um esse valor para um tipo float;
  - A mesma coisa se dá para o tipo **decimal** é necessária a utilização da notação. Ex: ``` decimal saldoTotal = 2.500m```;
  
- ## Boolean:
  - **Definições:**
  - Tipo booleano, armazena apenas **true** ou **false** (verdadeiro ou falso);
  - Definido pela palavra reservada **bool**;
  - **bool (8-bit):** true or false;
  - ~~~
	bool usuarioJaCadastrado = false;
	bool pagamentoRecebido = true;
	var usuarioExpirado = false;
	~~~
- ## Char:
  - **Definições:**
  - Utilizado para armazenar apenas um e somente um carácter no formato Unicode;
  - Definido pela palavra reservada **char**;
  - A atribuíção de um valor char é dada por aspas simples;
  - **char (16-bit):** qualquer caractere;
  - ~~~
	char primeiraLetra = "P"; // Erro pois aspas duplas são para um conjunto ou cadeia de chars
	char primeiraLetra = 'P'; // Ok
	var segundaLetra = 's'; // Ok dessa forma o próprio compilador entende que essa declaração se trata de um char
	~~~

- ## String:
  - **Definições:**
  - Armazena uma cadeia de caracteres;
  - Podemos pensar nele como uma lista de **char**;
  - Definido pela palavra reservada **string**;
  - A atribuição de um valor string é dada por aspas duplas;
  - **string (?):** uma cadeia de caracteres;
  - ~~~
	 string primeiraLetra = "P"; // Ok, por mais que ele tenha apenas uma letra ele é uma cadeia de caracteres, e isso significa que isso é uma lista, então isso é uma lista de carácter com um carácter só;
	 string primeiraLetra = 'P' // Erro, string é sempre com aspas duplas;
	 string texto = " Meu Texto"; // Ok
	 var documento = " 12358496654"; // Ok, dessa forma ele é reconhecido como string, e se pode passar qualquer tipo de carácter, seja número, letra, ou carácter especial;
	~~~

- ## Var:
  - **Definições:**
  - Substitui o nome de qualquer tipo;
  - Será do tipo do primeiro valor atribuido, e depois não se pode mudar o tipo;
  - Recomendando o uso: deixe para usar **var** quando já dominar os tipos;
  - ~~~
	var idade = 27; // Será do tipo int;
	idade = "Bohn" // vai ocorrer um erro pois eu já declarei essa variável anteriormente como sendo do tipo int, mesmo implicitamente;
	var nome = "Jéssica" // Será do tipo string;
  - A vantagem de se utilizar var, é quando temos tipos criados pelo desenvolvedor, e ou são complexos. Ex.:
  - ~~~
	IEnumerable<MeuTipoComplexo> lista = new IEnumerable<MeuTipoComplexo>(); // Tipo, nome da variável, e qual valor ela recebe;
	var lista = new IEnumerable<MeuTipoComplexo>(); // var recebe o mesmo tipo da sintaxe acima;
	~~~

- ## Object:
  - **Definições:**
  - Tipo genérico que recebe qualquer valor ou objeto;
  - Caso não saiba  o tipo da informação ou ela seja de vários tipos diferentes;
  - Não possui intellisense (Ajuda de editores) por ser um tipo desconhecido, e é uma grande desvantagem;
  - Evite usar;
  - Enquanto **var** serve para omitir um tipo, o object serve para definir um tipo;
  - Serve principalmente para trabalhar com listas e tipos genéricos;
  - ~~~
	object idade = 27; // Será do tipo object;
	object nome = "Jéssica" // Será do tipo object;
	~~~
  - No var é obrigado sabermos o tipo;
  - No object é como se fosse o **any** em TypeScript;
  - Ele permite passar valores de float pra int tranquilamente e isso pode ser perigoso;
  - O object é um tipo desconhecido, enquanto o var é um atalho de tipo;

- ## Nullable Types:
  - **Definições:** Null
  - Significa vazio, nada usado para definição de tipo;
  - Diferente de zero ou uma string vazia;
  - Todo tipo, primitivo ou complexo pode receber o valor null;
  - O tipo deve ser marcado como Nullable Type;
  - **void** significa vazio, não tem retorno nenhum, é nada, é o mesmo que o null, porém para retorno de métodos;
  - Podemos atribuir **null**  a um objeto;
  - Desde que o mesmo seja marcado como como nullable;
	- Usando *interrogação* na frente do tipo;
  - Se uma chamada a um valor nulo for feita um erro será apresentado caso não tenha a interrogação;
  - ~~~
	int? idade = null;
	idade = 25;
	idade = 0;
	~~~

- ## Alias:
  - **Definições:**
  - Alias é um apelido que todo tipo no .NET tem;
  - Por exemplo:
	- System.String(nome real) tem o alias string(apelido);
	- Vimos anteriormente os alias;
  - Como o C# é Case Sensitive, tanto faz escrevermos um ou outro;
  - Porém, o recomendado é sempre usar o **alias**;
  - No caso abaixo o resultado é o mesmo, e com alias, escrevemos menos;
  - ~~~
	int idade = 25; //Alias
	Int32 idade = 25; // Tipo
	~~~

- ## Valores padrões:
  - **Definições:**
  - Todo tipo built-in, já possui um valor padrão;
  - Se nenhum valor  informado, seu valor for informado será utilizado:
	- **int:** 0;
	- **float:** 0;
	- **decimal:** 0;
	- **bool:** false;
	- **char:** '\0';
	- **string:** "";

- ## Conversão implícita:
  - **Definições:**
  - É comum precisamos transformar um dado de tipo X em tipo Y;
  - Existem dois tipos de conversão: as implícitas e as explícitas;
  - As implícitas são conversões que:
	- Podem ser executadas apenas com passagem de dados, ou seja sem explicitar nada;
	- Possuem tipos compatíveis;
  - ~~~
	float valor = 25.8F;
	int outro = 25;
	valor = outro; //conversão implícita;
	~~~
  - A conversão anterior ocorreu pois um número real pode receber um número inteiro;
  - Porém, ao contrário não aconteceria;
	- Um número inteiro não tem pontuação;
	- Logo ele não receberia um número real;
  - A conversão só ocorrerá se:
	- O tipo de dado for compatível;
	- O tamanho do dado for compatível;
  - Em caso de números a precisão pode ser alterada;
  - Qualquer situação adversa causará erro;
  - **Tabela de conversão**
	- **sbyte:** short, int, long, float, double, decimal;
	- **byte:** short, ushort, int, uint, long, ulong, float, double, decimal;
	- **short:** int, long, float, double, decimal;
	- **ushort:** int, uint, long, ulong, float, double, decimal;
	- **int:** long, float, double, decimal;
	- **uint:** long, ulong, float, double, decimal;
	- **long:** float, double, decimal;
	- **ulong:** float, double, decimal;
	- **char:** ushort, int, uint, long, ulong, float, double, decimal;
	- **float:** double;

- ## Conversão explícita:
  - **Definições:**
  - Se a conversão implícita é aquela que escondemos o tipo;
  - Na conversão explícita temos que obrigatoriamente informar o tipo que estamos convertendo;
  - Ocorre quando os tipos não são compatíveis;
  - É dada pelo uso do tipo entre parênteses antes da atribuíção;
  - Segue as mesmas regras anteriores;
  - ~~~
	int inteiro = 100;
	uint inteiroSemSinal = (uint)inteiro; //conversão explícita;
	~~~
  - Um inteiro por exemplo aceita números com sinal e sem sinal, então não podemos diretamente passar diretamente um valor **int** para um **uint**;
  - sempre que virmos essa notação da antes do nome da variável, isto é uma conversão explícita;
  - Caso o valor for negativo, na hora de executar o programa, ele vai dar um erro;
  - Quanto menos usarmos a conversão explícita melhor para garantir que vamos ter menos erros;

- ## Parse:
  - **Definições:**
  - Método presente em todo tipo primitivo;
  - Usado para converter um carácter ou string para um tipo qualquer;
  - Caso haja alguma incompatibilidade, gera um erro;
  - ~~~
	int inteiro = int.Parse("100"); // tentando converter uma cadeia de caracteres chamada "100", pois está entre aspas duplas;
	~~~
  - No exemplo acima até da certo a conversão pois apesar de ser uma cadeia de caracteres, de fato é um número, porém se tivesse algum espaço ou qualquer outro tipo de carácter, o parse, daria um erro, seguindo a lógica da conversão explícita, dando um erro em tempo de execução, e não daria tempo de tratar isso em tempo de depuração;
  - Essa função tenta converter um tipo para um inteiro um double ou decimal;
  - Porém no **Parse** ele sempre espera uma string, ou cadeia de caracteres;

- ## Convert:
  - **Definições:**
  - Similar ao parse visto anteriormente;
  - Porém permite converter vários tipos de valor;
	- Não apenas strings;
  - Devemos informar  o tipo na chamada de conversão;
  - ~~~
	 int inteiro = Convert.ToInt32("100");
	 ~~~
  - Ao contrário do **Parse** que é uma extensão dos tipos, o **Convert** é de fato uma classe;
	- Ele é um objeto que permite que a gente converta uma string para outro tipo, podendo ser para qualquer outro tipo primitivo;
  - E a grande vantagem do Convert sobre o Parse, é que o mesmo permite converter vários tipos para um inteiro, não somente uma string;
	- Podendo ser um float, um double ou boolean;
  - Assim como a conversão explícita e o Parse ele vai tentar converter, se ele não conseguir executar essa conversão, ele vai acusar um erro em tempo de execução para o usuário; 
  - Tirando a conversão implícita todos os outros tipos de conversão dão um erro em tempo de execução, o que leva a ter mais cuidado na hora do uso desse tipo de conversão e dos testes na hora de soltar para o usuário;

- ## Convertendo Tipos:
  - **Definições:** conversão explícita x conversão implícita
  - ~~~
	int inteiro; // apenas definido dessa forma, ele seta o valor padrão para inteiro que é zero;
	 int inteiro = 100; // é interessante sempre já inicializar a variável ou o tipo para que o mesmo não fique vazio;
	float real = 25.5f; // poderiamos usar o var, e também é importante lembrar que o float tem a notação .0f;
	 
	inteiro = real; // vamos ter um erro pois pois não podemos fazer um conversão implícita do tipo float para int;
	real = inteiro; // dessa forma funciona, pois é possível fazer a conversão implícita, e nesse caso o real passa a valer 100.0f;
	 ~~~
  - Se de fato fosse necessário fazer essa conversão do número real para o inteiro, lembrando que isso pode gerar um warning. 
  - Lembrando também que quando um inteiro recebe um real, ele faz o arredondamento desse numero;
  - ~~~
	inteiro = (int)real; 
	~~~
  - Existe alguns itens como **Math.ceil()** e **Math.floor** que fazem o arredondamento para cima ou para baixo de acordo com a necessidade do programa;
  - **Definições:** Parse
  - Na maioria dos tipos primitivos podemos usar o parse, porém ele sempre espera uma string;
  - ~~~
	inteiro = int.Parse(real); // aqui dá um erro pois ele não pdoe converter um float para um 'System.ReadOnlySpan<char>'
	~~~
  - Existe também um outro método de conversão muito utilizado. Eu uso bastante particularmente no meu trabalho. O **.ToString()**;
	- Todo objeto dentro do .NET tem tem esse método, ele é utilizado para convertê-lo em uma string;
	- Que pode ser usado da sequinte maneira:
  - ~~~
	inteiro = int.Parse(real.ToString()); // nesse caso estamos estamos fazendo primeiramente uma conversão para inteiro em um Parse de um número real, 
										  // mas antes foi necessário converter um número real para uma string, que é o que ocorre dentro do ();
	
	string valorReal = real.ToString; // que também poderia ser feito dessa forma;
	inteiro = valorReal;
									  // lembrando que se considerarmos todo esse código como um único programa, esse código daria um erro em tempo de execução
									  // Pois o valor de valorReal seria uma string "25.5", ou seja não é possível converter sem um (int) para um inteiro;
	~~~
  - **Definições:**Convert
  - Lembrando que ele tem 19 sobrecargas para um int por exemplo para fazer a conversão entre boolean, float etc;
  - ~~~
	inteiro = Convert.ToInt32(real) // então para que o programa acima desse o valor correto precisariamos utilizar o Convert
									// Lembrando que no caso do Convert ele faz o arredondamento automático para cima ou para baixo;
	
	Console.WriteLine(Convert.Boolean(1)) // nesse caso seria true para qualquer numero diferente de zero, e se fosse zero seria false;
										  / apenas um exemplo a mais do uso do Convert;
	~~~

- ## Operadores aritméticos:
  - **Definições:** Operações Aritméticas
  - Soma => +
  - Subtração => -
  - Multiplicação => *
  - Divisão => /
  - Multiplicação e divisão são executadas primeiro;
  - Caso queira executar em outra ordem, usar parênteses;
  - Aceita short, int, float, double e decimal;
  - Em caso de uso de números inteiros:
	- Se o valor for real, será arredondado;
	- 4,5 => 5;
  - ~~~
	int soma = 25 + 22; // 47
	int subtracao = 25 - 22; // 3
	int multiplicacao =  25; * 22 // 550 
	int divisao = 22 / 5; // 4 pois foi arredondado
	~~~
  - Utilizamos parênteses para redefinir a ordem de execução
  - ~~~
	int x = 2 + 2 * 2; // 6
	int y = 2 + (2 * 2); // 6 mesmo do anterior
	int z = (2 + 2) * 2; // 8 pois executou soma primeiro
	~~~

- ## Operadores de atribuição:
  - **Definições:** Operações de Atribuição
  - Utilizamos igual para atribuir um valor;
  - Porém, podemos utilizar igual junto a um operador aritmético;
  - **x += 5** é o mesmo que **x = x + 5**;
  - ~~~
	int x = 0; // atribuição;
	x += 5; // x = x + 5;
	x -= 1; // x = x - 1;
	x *= 10; // x = x * 10;
	x /= 2; // x = x / 2;

- ## Operadores de comparação:
  - **Definições:**

- ## Utilizando operadores:
- ## Operadores lógicos:
  - **Definições:**

- ## Operador condicional - IF:
  - **Definições:**

- ## Utilizando IF:
- ## Estrutura Condicional - Switch:
  - **Definições:**

- ## Laços de repetição - For:
  - **Definições:**

- ## Laços de repetição - While:
  - **Definições:**

- ## Laços de repetição - Do/While:
  - **Definições:**

- ## Métodos e funções:
  - **Definições:**

- ## Métodos e funções - Prática:
- ## Value Types e Reference Types:
  - **Definições:**

- ## Value Types e Reference Types - Prática:
- ## Structs
  - **Definições:**

- ## Structs - Prática:
- ## Enums:
  - **Definições:**

- ## Revisão:
  - **Definições:**


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
- ## Iteração e carácter de escape:
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
- **Bug:** Termo que vem históricamente dos antigos computadores que funcionavam com válvulas que eram como lâmpadas e atraiam os insetos, e bug é inseto em inglês;
- ```cd ..```: Voltar uma pasta acima;
- ```clear``` ou ```cls``` : Limpar terminal;
- **CLR:** É a sigla para Common Language Runtime ou gerenciador de linguagem comum;
- **Compilador:** Agente que executa a compilação, que é a transformação do texto que escrevemos para binário(0 e 1). Lembrando que cada linguagem tem o seu próprio compilador. Um exemplo que eu gosto muito de usar para quem é bem leigo é que o programa escrito é como se fosse uma musica na partitura, e nós ao tocarmos somos os "compiladores".
- ```Ctrl + C ```: Para de executar a aplicação;
- ```Ctrl + S ```: Salvar as modificações no arquivo;
- **Debug:** "Caçar os bugs" da nossa aplicação;
- ```dotnet add```: Adicionar um pacote ou uma referência a um projeto do .NET.
- ```dotnet build```: Compila a aplicação um projeto do .NET.
- ```dotnet build-server```: Interagir com servidores iniciados por um build.
- ```dotnet clean```: Limpar as saídas do build(compilações) de um projeto do .NET.
- ```dotnet format```: Aplicar preferências de estilo a um projeto ou solução.
- ```dotnet help```: Mostrar a ajuda da linha de comando.
- ```dotnet list```: Listar as referências de um projeto do .NET.
- ```dotnet msbuild```: Executar comandos do MSBuild (Microsoft Build Engine).
- ```dotnet new```: Criar um novo projeto ou arquivo do .NET.
- ```dotnet nuget```: Fornece comandos adicionais do NuGet.
- ```dotnet pack```: Criar um pacote do NuGet.
- ```dotnet publish```: Publicar um projeto do .NET para implantação.
- ```dotnet remove```: Remover um pacote ou uma referência de um projeto do .NET.
- ```dotnet restore```: Restaurar as dependências especificadas em um projeto do .NET.
- ```dotnet run```: Ccompila e executar a aplicação .NET.
- ```dotnet sdk```: Gerencie a instalação do SDK do .NET.
- ```dotnet sln```: Modificar os arquivos da solução do Visual Studio.
- ```dotnet store```: Armazenar os assemblies especificados no repositório de pacotes do runtime.
- ```dotnet test```: Executar testes de unidade usando o executor de testes especificado em um projeto do .NET.
- ```dotnet tool```: Instalar ou gerenciar ferramentas que ampliam a experiência do .NET.
- ```dotnet vstest```: Executar comandos do VSTest (Microsoft Test Engine).
- ```dotnet workload```: Gerenciar as cargas de trabalho opcionais.
- ```exit```: Fecha o terminal
- **Error(s):** Erro que não deixa a aplicação buildar;
- **Final:** Versão final da aplicação;
- **IL:** Sigla para Intermediate Language;
- **JIT:** Sigla para Just In Time;
- **Legado:** Sofwares mais de idade;
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
- ```Ctrl + ' ```: Toggle o terminal do VS Code;
- **Warnings:** alertas para melhoria de código;
- **XML:** Extensible Markup Language, uma linguagem de marcação que já foi muito usuada durante um tempo para tráfego de informações entre um sistema e outro, mas atualmente não tão usado assim, porém o .NET ainda utiliza por conta da retrocompatibilidade com sistemas anteriores;

## Fontes: 
Lembrando que todas os links já estão no corpo de texto em caso de download, e todas as imagens são próprias minhas feitas em paint ou Canva, ou então são retiradas das documentações do sites da Microsoft, o conteúdo pertence ao link abaixo do curso do [balta.io](https://balta.io/), com algumas modificações e considerações minhas. A finalidade desse repositório é apenas para estudo pessoal e ajudar qualquer pessoa que esteja acompanhando o curso, mas com o resumo dos slides em .md, além de estar atualizado em .NET 8. Esse repositório não visa qualquer tipo de fim lucrativo. 
- ## https://balta.io/carreiras/dotnet-fundamentals
- ## Microsoft
