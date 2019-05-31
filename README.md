# ASPNetCoreDocker

Projeto
O projeto é rico na aplicação prática de diversos conceitos e tecnologias. Dentre os tais, aplicação do contêiner Docker, que permite versionar o banco de dados e levá-lo a uma evolução contínua, Visual Studio, ASP.NET Core, Entity Framework Core, SQL, REST API, Tapioca Hateoas – responsável por simplificar a aplicação do Hateoas às API’s –, Query Params e versionamento de Endpoints e da API.


Fiz uso do JWTT, de forma a garantir mais segurança às aplicações; Swagger, um framework muito útil na documentação de API’s, e, com a finalidade de viabilizar a compreensão do código e torná-lo mais organizado, adotei a aplicação em camadas e, para tornar o programa mais limpo e reduzir escrita desnecessária, repositório genérico, responsável por reaproveitar partes em comum do código.


Trabalhei com os verbos essenciais do REST – Get, Put, Post, Delete – e o verbo Path, utilizado em Updates. Para promover ainda mais segurança à aplicação, incluo aqui o Padrão VO – Value Object: encapsulamento de banco de dados e abstração através de adapters e Value Objects. Há a possibilidade de manipular serialização dos objetos com Data Contract.


Ademais, implementação de paginação com funcionalidades do Tapioca Hateoas e arquivos: prover a funcionalidade de download de arquivos na API, e Content Negociation, que proporciona variabilidade de formatos: Json, XML, CSV, PDF, etc. 
