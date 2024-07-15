**Template base para desenvolvimento baseado em DDD e clean architeture**

*Atenção DDD não é uma arquitetura muito menos uma extenção. DDD é uma cultura de desenvolvimento
como o proprio nome diz é um design baseado em dominio.*

Sinta-se livre para mudar a arquitetura da forma que preferir, aqui esta só uma base para inicializar projetos
utilizando DDD e clean architeture.

Lembrando que quem faz o DDD é o desenvolvedor e não o framework. 


## Informativo

Esse modelo é ideal para trabalhar com Backend for Frontend (BFF) e microserviços.



## Tecnologias utilizadas (.NET 8, EFCore, AutoMapper, Swagger e FluentValidator)
	*WebAPI**
		- Microsoft.Extensions.Caching.StackExchangeRedis
	*Service*
		- AutoMapper
		- FluentValidation
	*Repository*
		- EntityFrameworkCore

	*Tests* - O projeto de testes foi movido para uma pasta fora da solução
		- Xunit
		- Moq	
		

## Notas de versão 

 - 1.0.0 - Versão inicial
	-  Foram adicionados os projetos WebApi, Ioc, Service, Repository, Shared, Domain e Tests.
	   Utilização do EfCore para persistência de dados, AutoMapper para mapeamento de objetos e o FluentValidator para validação das entidades.
		
 - 1.0.1 - Implementação de Patterns
	- Movimentação do projeto de testes para fora da solução.
	- Implementação do padrão de Repository Pattern genérico.
	- Implementação do padrão de Result Pattern/Notification Pattern.
	- Melhorias na configuração do swagger.


***


## Estrutura de pastas

```
Domain
├── Entity
│   ├── Base
│   │   └── EntityBase.cs
├── Interface
│   └── IEntityBase.cs
├── Service
└── ValueObjects

Repository
├── ContextConfig
├── Interceptors
│   └── AuditInterceptor.cs
├── Repository
│   └── Base
│       └── RepositoryBase.cs

Service
├── Dto
├── Interfaces
├── Mapper
│   └── MapperProfile.cs
├── Service
├── Validator
│   └── ValidatorBase
│       └── ValidtorBase.cs

Shared
├── Enums
│   ├── Utils
│   │   └── EnumOrdenacao.cs
├── Tools
├── Notification
│   ├── NotificationRequest.cs
│   ├── NotificationResult.cs
│   └── PagerSettings.cs

Ioc
├── DependencyInjector
│   └── DependencyInjector.cs

WebApi
├── Configuration
│   ├── AutomapperInjectionConfig.cs
│   ├── DependencyInjectorConfig.cs
│   ├── SwaggerConfig.cs
├── Controllers
├── DockerFile
├── Program.cs
└── AppSettings.json


```

## Configurações Iniciais
```
### WebApi
1. **Configurar Swagger:**
   - Navegue até a pasta `Configuration` e abra o arquivo `SwaggerConfig.cs`.
   - Coloque as informações sobre a sua aplicação.
   - Vá até `AppSettings.json` e configure o campo `"DiretorioSwagger"` com o endpoint do Swagger de acordo com a porta em que a aplicação está funcionando.

2. **Configurar DockerFile:**
   - Abra o arquivo `DockerFile`.
   - Renomeie todos os campos que estiverem com o nome `TemplateAPI` para o nome da sua aplicação.

### Repository
1. **Criar Configurações do Repositório:**
   - No projeto `Repository`, crie a configuração necessária para a conexão com o banco de dados na pasta `ContextConfig`.

2. **Configurar Interceptores:**
   - Na pasta `Interceptors`, você pode adicionar interceptores, como o `AuditInterceptor.cs`, para realizar auditorias ou outras funcionalidades.

3. **Base do Repositório:**
   - Na pasta `Repository/Base`, você pode criar uma classe base, como `RepositoryBase.cs`, que será utilizada por todos os repositórios.

### Service
1. **Configurar Dtos e Interfaces:**
   - Na pasta `Dto`, defina os Data Transfer Objects (DTOs) que serão utilizados na aplicação.
   - Na pasta `Interfaces`, defina as interfaces dos serviços que serão implementados.

2. **Configurar Mapper:**
   - Na pasta `Mapper`, abra o arquivo `MapperProfile.cs` e configure os mapeamentos necessários utilizando AutoMapper.

3. **Configurar Validators:**
   - Na pasta `Validator/ValidatorBase`, crie classes base para validação, como `ValidatorBase.cs`.

### Shared
1. **Configurar Enums e Utils:**
   - Na pasta `Enums/Utils`, adicione as enums e utilitários, como `EnumOrdenacao.cs`, que serão utilizados na aplicação.

2. **Configurar Notificações:**
   - Na pasta `Notification`, defina as classes de notificação, como `NotificationRequest.cs`, `NotificationResult.cs` e `PagerSettings.cs`.

### Ioc
1. **Configurar Injeção de Dependência:**
   - Na pasta `DependencyInjector`, configure a injeção de dependências no arquivo `DependencyInjector.cs`.

### Domain
1. **Configurar Entidades e Serviços:**
   - Na pasta `Entity/Base`, defina a classe base das entidades, como `EntityBase.cs`.
   - Na pasta `Interface`, defina a interface base das entidades, como `IEntityBase.cs`.
   - Adicione outras entidades e value objects conforme necessário.

```
***
**Desenvolvido por Luccas Silva e Serafim Froes**
