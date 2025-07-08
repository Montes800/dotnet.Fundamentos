Conceitos Abordados
1. Classes e Objetos
Classe (Pessoa): É como um molde ou um projeto para criar objetos. No seu código, Pessoa define como um objeto "pessoa" deve ser e quais ações ele pode realizar.

Objeto (p1): É uma instância real de uma classe. p1 é uma "pessoa" de verdade, criada a partir do seu projeto Pessoa.

2. Propriedades (Getters e Setters)
Nome e Idade são propriedades. Elas oferecem uma forma controlada de acessar e modificar os dados internos (_nome e _idade) de um objeto.

Acessor get: Usado para obter o valor de uma propriedade. Note que a propriedade Nome automaticamente converte o nome para letras maiúsculas (_nome.ToUpper()) quando é lida.

Acessor set: Usado para definir (atribuir) um valor a uma propriedade.

Validação de Dados: Os acessores set incluem lógica de validação.

Nome não pode ser uma string vazia.

Idade não pode ser um número negativo.

Se dados inválidos forem fornecidos, uma ArgumentException é lançada, impedindo que o objeto fique em um estado inconsistente.

3. Encapsulamento
Os campos internos _nome e _idade são declarados como private. Isso significa que eles só podem ser acessados diretamente de dentro da própria classe Pessoa.

O encapsulamento protege o estado interno de um objeto e garante que os dados sejam sempre válidos, forçando o código externo a interagir com os dados apenas através das propriedades (que incluem a validação).

4. Métodos
Apresentar(): Este é um método da classe Pessoa. Ele define uma ação que um objeto Pessoa pode realizar. Neste caso, ele imprime uma saudação no console, usando o Nome e a Idade do objeto.
