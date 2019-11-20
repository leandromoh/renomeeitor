
**RENOMEEITOR 3.7.4 - MANUAL DO USUÁRIO**

# Importante

Este software não é mantido e foi criado quando eu estava iniciando no mundo da programação (2012) e portanto não faz uso de padrões de projeto ou boas praticas de programação, coisas que desconhecia na época.

# Motivação do projeto 

A motivação que tive para criar esse software foi a de ajudar as pessoas que, por baixarem muitas séries, músicas ou videos, de diferentes sites, sempre encontram dificuldade em padronizar o nome dos arquivos e acabavam gastando muito tempo para realizar essa tarefa. O objetivo desse software é exclusivamente o de ajudar as pessoas na tarefa de renomear arquivos, e por conta disso, sua distribuição é livre e gratuita.

Além de ajudar a resolver um problema real, vi no projeto uma oportunidade de praticar o que estava aprendendo de programação. 

# Sobre o Renomeeitor e o manual

O software Renomeeitor foi desenvolvido a fim de facilitar a tarefa de renomear uma  grande quantidade de arquivos ao mesmo tempo. Além disso, o software possibilita aos usuários criar seus próprios padrões de renomeação e aplicá-los aos vários arquivos que desejar, de uma maneira fácil e rápida.

O objetivo desse manual é descrever como utilizar as principais funcionalidades do software e mostrar exemplos para cada uma delas, a fim de esclarecer possíveis duvidas que possam vir a aparecer durante o uso do mesmo.

# Sumário

**Básico**

1. Pasta selecionada
2. Tipos de arquivos permitidos
  1. 1.Selecionando um tipo especifico por vez
  2. 2.Selecionando todos os tipos de arquivo ao mesmo tempo
3. Substituição de trechos &quot;De/Para&quot;
4. Deixar nomes dos arquivos
  1. 1.Todo maiúsculo
  2. 2.Todo minúsculo
  3. 3.Primeira letra de cada palavra em maiúsculo
  4. 4.Primeira letra do nome do arquivo em maiúsculo

**Avançado**

1. Manipulação avançada de trechos no nome do arquivo
  1. 1.Apagar do nº ao mº caracter
  2. 2.Acrescentar trecho após o nº caracter
  3. 3.Acrescentar trecho no inicio do nome do arquivo
  4. 4.Acrescentar trecho no fim do nome do arquivo
  5. 5.Remover ocorrências de um trecho no nome do arquivo
2. Extrair Nomes a partir de um bloco de notas

**Pré-Visualização**

1. Como funciona a pré-visualização
2. Salvando uma lista


**BÁSICO**

**1 - Pasta selecionada**

Nesse campo o usuário deve selecionar a pasta onde estão os arquivos que ele deseja manipular, sendo que todas as funcionalidades do programa (incluindo as funcionalidades de outras abas) serão direcionadas sempre para os arquivos da pasta selecionada nesse campo. Há também a opção &quot;Incluir SubPastas&quot; que permite que o Renomeeitor &quot;enxergue&quot; todas as pastas que estão dentro da pasta selecionada. Caso a opção &quot;Incluir SubPastas&quot; não esteja selecionada, todas as subpastas da pasta selecionada (e seus arquivos) serão ignorados pelo programa.

**2 - Tipo de arquivos permitidos**

**2.1 - Selecionando um tipo especifico por vez**

É nesse campo que definimos qual tipo de arquivo o Renomeeitor procurará dentro da pasta selecionada. Por exemplo, se colocarmos no campo o valor &quot;mp3&quot; o Renomeeitor procurará apenas arquivos mp3 dentro da pasta selecionada, e é assim com qualquer outro tipo de arquivo (jpg, rar, pdf, exe, txt, etc...).

        **2.2 -**  **Selecionando todos os tipos de arquivo ao mesmo tempo**

Para selecionar todos os tipos de arquivo ao mesmo tempo é necessário colocar um asterisco ( \* ) como valor do campo. Fazendo isto, o Renomeeitor passará a ignorar o tipo de cada arquivo e passará a &quot;enxergar&quot; todos os arquivos encontrados dentro da pasta selecionada pelo usuário.

**3 - Substituição de trechos &quot;De/Para&quot;**

Nos campos &quot;De/Para&quot; há a possibilidade de trocar palavras no nome dos arquivos por outras  palavras que o usuário achar mais conveniente. Por exemplo, temos um arquivo chamado &quot; Série Policial – Epi 1.mkv &quot;. Se colocarmos em um campo &quot;De&quot; a palavra &quot;Epi&quot; e no campo &quot;Para&quot; correspondente a palavra &quot;Episódio&quot;, mandando renomear o arquivo o nome deixaria de ser &quot; Série Policial – Epi 1.mkv &quot; e passaria a ser &quot; Série Policial – Episódio 1.mkv &quot;. Na   aba básico   há três pares de campo &quot;De/Para&quot;, o que permite ao usuário fazer três substituições de uma só vez. Caso seja necessário fazer mais de três substituições, logo abaixo do botão &quot;Pré-Visualizar&quot; há um botão &quot;Limpar&quot; que apaga todo o conteúdo dos três pares do campo &quot;De/Para&quot;, poupando o usuário de ter que apagar manualmente o conteúdo de cada um dos campos.

**Observação 1:** Os campos &quot;De/Para&quot; são _case sensitive_, isso significa que eles diferenciam letras maiúsculas de minúsculas. Ou seja, se você mandar substituir a palavra &quot;Músicas&quot; por &quot;Textos&quot; enquanto no nome do arquivo está &quot;músicas&quot; ele não trocará, pois para o programa &quot;Músicas&quot; e &quot;músicas&quot; não são a mesma coisa.

**Observação 2:** Caso você deseje apagar uma palavra do nome do arquivo, o que seria equivalente a substituir esta palavra por vazio, consulte o tópico 5.5 - &quot;Remover ocorrências de um trecho no nome do arquivo&quot;.

**4 - Deixar nome dos arquivos**

Neste item há a opção de padronizar a forma como os nomes dos arquivos são escritos de forma simples e rápida.

**4.1 –**  **Todo maiúsculo**

Selecionando a opção &quot;Todo maiúsculo&quot;, todo o nome do arquivo ficará em maiúsculo.

**Exemplo** : &quot;SÉRIE POLICIAL – EPI 1.MKV &quot;

**4.2 -**  **Todo minúsculo**

Selecionando a opção &quot;Todo minúsculo&quot;, todo o nome do arquivo ficará em minúsculo.

**Exemplo** : &quot;série policial – epi 1.mkv &quot;

**4.3 – Primeira letra de cada palavra em maiúsculo**

Selecionando a opção &quot;Primeira letra de cada palavra em maiúsculo&quot;, ficará em maiúsculo apenas a primeira letra de cada palavra no nome do arquivo.

**Exemplo** : &quot;Série Policial – Epi 1.Mkv &quot;

**4.4 - Primeira letra do nome do arquivo em maiúsculo**

Selecionando a opção &quot;Primeira letra do nome do arquivo em maiúsculo&quot;, ficará em maiúsculo apenas a primeira letra do nome do arquivo.

**Exemplo** : &quot;Série policial – epi 1.mkv &quot;



**AVANÇADO**

**5 - Manipulação avançada de trechos no nome do arquivo**

**5.1 - Apagar do nº ao mº caracter**

Aqui podemos excluir trechos do nome do arquivo de acordo com a posição em que ocupam no nome. Por exemplo, temos os seguintes arquivos:

        músicas do john.txt

        lembretes do john.txt

Se colocarmos para apagar do 2º ao 3º caracter o programa nos devolverá:

        micas do john.txt

        lbretes do john.txt

Como o esperado, foram apagados os caracteres entre essas posições indicadas.

**5.2 - Acrescentar trecho após o nº caracter**

Neste item podemos acrescentar um trecho após uma determinada posição. Por exemplo, temos os seguintes arquivos:

        músicas do john.txt

        lembretes do john.txt

Se colocarmos para acrescentar o trecho &quot;123&quot; após o 2º caracter o programa nos devolverá:

        mú123sicas do john.txt

        le123mbretes do john.txt

Como o esperado, foi acrescentado o trecho &quot;123&quot; após a posição especificada.

**5.3 - Acrescentar trecho no inicio do nome do arquivo**

Aqui podemos acrescentar um trecho logo no inicio do nome do arquivo. Por exemplo, temos os seguintes arquivos:

        músicas do john.txt

        lembretes do john.txt

se colocarmos para acrescentar o trecho &quot;INICIO\_&quot; no inicio do nome o programa nos devolverá:

        INICIO\_músicas do john.txt

        INICIO\_lembretes do john.txt

Como o esperado, foi acrescentado o trecho &quot;INICIO\_&quot; logo no inicio do nome do arquivo.

**5.4 -  Acrescentar trecho no fim do nome do arquivo**

Aqui podemos acrescentar um trecho no fim do nome do arquivo. Por exemplo, temos os seguintes arquivos:

        músicas do john.txt

        lembretes do john.txt

se colocarmos para acrescentar o trecho &quot;\_FIM&quot; no fim do nome o programa nos devolverá:

        músicas do john\_FIM.txt

        lembretes do john\_FIM.txt

Como o esperado, foi acrescentado o trecho &quot;\_FIM&quot; no fim do nome do arquivo.

**5.5 - Remover ocorrências de um trecho nome do arquivo**

Neste campo podemos excluir palavras ou até mesmo trechos dos nomes dos arquivos. Por exemplo, temos os seguintes arquivos:

        músicas do john.txt

        lembretes do john.txt

se colocarmos para remover o trecho &quot; do john&quot; do nome o programa nos devolverá:

        músicas.txt

        lembretes.txt

Como o esperado, o trecho &quot; do john&quot; foi apagado dos nomes.

**Observação** : Este campo é _case sensitive_, isso significa que ele diferencia letras maiúsculas de minúsculas. Ou seja, se você mandar excluir a palavra &quot;Músicas&quot; enquanto no nome do arquivo está &quot;músicas&quot; ele não fará, pois para o programa &quot;Músicas&quot; e &quot;músicas&quot; não são a mesma coisa.

**6 - Extrair Nomes a partir de um bloco de notas**

Nesta opção podemos pegar nomes de um bloco de notas e colocarmos esses nomes nos arquivos encontrados pelo programa. Isso é muito útil para quem baixa séries e animes, por exemplo, pois em vários casos pode-se achar o nome de todos os episódios arrumados e organizados em um site da maneira que gostaríamos que os nossos arquivos ficassem, e com essa funcionalidade do Renomeeitor, podemos conseguir isso de forma simples. Primeiramente os nomes no bloco de notas devem estar separados por linhas e de cima para baixo. Exemplificando: teríamos o nome do episódio 1 na primeira linha, o nome do episódio 2 na segunda linha e assim por diante. Não há problema caso haja linhas em branco entre os nomes, pois o Renomeeitor não considera linhas vazias, linhas que tem apenas o caracter de espaço e também não considera o caracter de tabulação (TAB). Dessa forma, não há problema se o nome do episódio 1 está primeira linha e o nome do episódio 2 está na linha 4 por exemplo, desde que as linhas 2 e 3 sejam linhas vazias ou só tenham caracteres que não serão considerados (espaço ou TAB). A partir do momento em que os nomes já estiverem no bloco de notas, o Renomeeitor vai pareá-los com os arquivos encontrados por ele, fazendo com que o primeiro arquivo encontrado fique com o primeiro nome do bloco de notas, o segundo arquivo encontrado com o segundo nome do bloco de notas e assim por diante. Antes de clicar no botão &quot;Aplicar&quot; é altamente recomendado clicar no botão &quot;Pré-Visualizar&quot; para ter certeza de que os nomes estão como se deseja.



**PRÉ-VISUALIZAÇÃO**

**7 - Como funciona a pré-visualização**

Nesta aba podemos ter uma prévia de como ficarão os nomes dos arquivos depois que aplicarmos alguma das funcionalidades oferecidas, como os campos &quot;De/Para&quot;, deixar tudo em minúsculo, apagar um trecho do nome do arquivo, etc. Esta aba é extremamente útil, pois nos permite visualizar se estamos conseguindo o queremos antes de alterarmos os nomes dos arquivos de fato, nos dando a chance de corrigir alguma coisa que não tenha ficado como gostaríamos antes de mexer no arquivo de verdade.

Para ter a prévia de uma funcionalidade, é só clicar no botão &quot;Pré-Visualizar&quot; da mesma, ou seja, se você está querendo deixar o nome dos arquivos em maiúsculo, por exemplo, e já selecionou esta opção, é só clicar no botão &quot;Pré-Visualizar&quot; dela para ver como ficarão os nomes..

**Observação** : Cada funcionalidade tem seu próprio botão de pré-visualização, que está na mesma seção da funcionalidade à que pertence. Para ver a prévia da funcionalidade X deve-se clicar no botão &quot;Pré-Visualizar&quot; da funcionalidade X, de tal forma que se você deseja a funcionalidade X e clica no botão de pré-visualização da funcionalidade Y, será mostrada a prévia da funcionalidade Y.

**8 - Salvando uma lista**

Nesta funcionalidade temos a opção de salvar os nomes da lista &quot;Antes&quot; ou da lista &quot;Depois&quot;, incluindo ou não o caminho dos arquivos no computador. Se o usuário clicar no botão &quot;Salvar Lista&quot;, primeiramente o Renomeeitor irá perguntar em qual pasta o usuário deseja salvar o bloco de notas onde os nomes serão armazenados. Após selecionar a pasta, será perguntado qual lista o usuário deseja salvar (lista &quot;Antes&quot; ou &quot;Depois&quot;). Após a lista ser escolhida, é perguntado se o usuário deseja também salvar o caminho do arquivo. Em sequência, a lista será salva e poderá ser conferida indo na pasta indicada pelo usuário.
