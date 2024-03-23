# [Carreira 01. .NET Developer Fundamentals](https://balta.io/carreiras/dotnet-fundamentals)
## O que são linguagens de programação?
- **Definições:**
    - É uma forma de comunicação humano-computador, onde o humano fala para o computador como executar um comando;
    - Já que os computadores entendem apenas binário, uma LP (linguagem de programação), faz esse intermédio;
    - O que escrevemos em determinada linguagem o compilador transforma em liguagem de maquina (binário);
    - Em resumo temos um arquivo de texto:
        - Que um humano consegue ler;
        - Que será traduzido para binário;

## Alto e Baixo Nível:
- **Definições:**
  - O envio de instruções ao computador é o nível de maquina;
  - As instruções ao computador sempre serão no formato binário;
  - Quanto mais detalhada(como microproessadores que tem pouca memória) a necessidade, mais baixo é o nível;
  - Linguagens mais modernas e mais proximas do usuário, como C# e Java, são chamados de liguagem de alto nível, pois é mais favorecida para os usuários em detrimento do processador;
  - Assembly: Baixo nível;
  - C#: Alto nível;
  - Linguagens de alto nível são geralmente mais escolhidas pois trazem um acesso há tudo que precisamos em nível de hardware, já prontos;
 
## Linguagens compiladas e interpretadas:
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
## Compilada VS Interpretada:
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
  
## Glossário:
- **Compilador:** Agente que executa a compilação, que é a transformação do texto que escrevemos para binário(0 e 1). Lembrando que cada linguagem tem o seu próprio compilador. Um exemplo que eu gosto muito de usar para quem é bem leigo é que o programa escrito é como se fosse uma musica na partitura, e nós ao tocarmos somos os "compiladores".
- **Tempo de Execução:** É o que acontece durante a execução  do código pelo computador ou interpretador.
