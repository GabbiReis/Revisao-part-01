# Revisao-part-01

Criar uma API para registrar jogos da Mega sena. Com 2 métodos:
* a)	Método 1: Registrar jogo
Como entrada criar um model com os seguintes campos:
RegistroJogo: Nome, Cpf, primeiroNro, segundoNro, terceiroNro, quartoNro, quintoNro, sextoNro, data do jogo.
Para o método 1 (defina você o verbo mais adequado) e considere a seguinte entrada (exemplo de um jogo:
{
Nome: “H1”,
Cpf: “12345678901”,
primeiroNro: 10,
segundoNro: 2,
terceiroNro: 5,
quartoNro: 39,
quintoNro: 51,
sextoNro: 49
}
* As regras para o método 1 devem ser seguidas conforme abaixo:
•	Números devem ser entre 1 e 60
•	Os 6 números são obrigatórios para a realização do jogo e devem ser diferentes, então validar essa regra de negócio.
•	Nome é obrigatório mínimo 3 caracteres e máximo de 255.
•	Cpf é obrigatório e válido.
•	Gravar o jogo em uma arquivo .json chamado de jogosMega.json
•	O campo data jogo não é informado na API e sim obtido fazendo datetime.now (pegando o registro de agora).
Retorno da API se OK deve ser “Jogo Registrado com sucesso!”.

* b) Método 2: ObterTodosOsJogos
Esse método não tem parâmetro de entrada (Defina o verbo adequado para isso) e o retorno da API deve ser a listagem (array com os dados do jogo).
