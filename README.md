# API de Pedidos Online

Esta API contém dados sobre pedidos online com dados no formato JSON.
```json
{
  "id": "string"  
  "name": "string",
  "product": "string",
  "quantity": 0,
  "total": 0
}
```

## Descrição

- API feita com .NET Core 9.0.2
- Linguagem C#
- API simples
- Código Limpo


## Como executar a API?

Primeiramente, para que tudo ocorra bem, você precisa ter no seu ambiente o .NET Core 9 configurado na versão:

- .NET SDK: Version 9.0.200  

Após verificar a versão do .NET no seu ambiente, será necessário fazer o clone do projeto da branch master. Com o projeto baixado, na raiz do seu projeto, para executar, basta digitar o comando no seu cmd ou powershell:

`dotnet run`

Obs: O projeto já está configurado para acessar os endpoints pelo swagger. Os endpoints são "/api" e "/pedidos".

No terminal será mostrado o localhost parecido com este: `http://localhost:5182`, que aponta para onde a API está rodando. Para acessar os endpoints, basta digitar depois da porta dessa forma: http://localhost:5182/api/pedidos.

A API armezena os dados temporariamente em memória, não possuindo ainda um banco de dados para persistir os dados. Caso queira testar no aplicativo que está neste link: https://github.com/JucimarJunior/meu-pedido-online/tree/master, basta colocar na URL BASE, o link `http://localhost:<porta gerada>`.
