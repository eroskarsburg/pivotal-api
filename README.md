# Pivotal Api
### Technologies Used
- **Frameworks:** .NET
- **Programming Languages:** C#
- **Database:** SQL Server

![.NET Badge](https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=fff&style=flat)
![C# Badge](https://img.shields.io/badge/C%23-512BD4?logo=csharp&logoColor=fff&style=flat)

### Installation
1. Clone the repository: `git clone https://github.com/eroskarsburg/pivotal-api.git`
2. Navigate to the project directory.
3. Install dependencies: `dotnet restore`
4. Configure database connection in `appsettings.json`.
5. Run migrations: `dotnet ef database update`.
6. Start the application: `dotnet run`.
### Commit Pattern
`feat`: Commits do tipo feat indicam que seu trecho de código está incluindo um novo recurso (se relaciona com o MINOR do versionamento semântico).

`fix`: Commits do tipo fix indicam que seu trecho de código commitado está solucionando um problema (bug fix), (se relaciona com o PATCH do versionamento semântico).

`docs`: Commits do tipo docs indicam que houveram mudanças na documentação, como por exemplo no Readme do seu repositório. (Não inclui alterações em código).

`test`: Commits do tipo test são utilizados quando são realizadas alterações em testes, seja criando, alterando ou excluindo testes unitários. (Não inclui alterações em código)

`build`: Commits do tipo build são utilizados quando são realizadas modificações em arquivos de build e dependências.

`perf`: Commits do tipo perf servem para identificar quaisquer alterações de código que estejam relacionadas a performance.

`style`: Commits do tipo style indicam que houveram alterações referentes a formatações de código, semicolons, trailing spaces, lint... (Não inclui alterações em código).

`refactor`: Commits do tipo refactor referem-se a mudanças devido a refatorações que não alterem sua funcionalidade, como por exemplo, uma alteração no formato como é processada determinada parte da tela, mas que manteve a mesma funcionalidade, ou melhorias de performance devido a um code review.

`chore`: Commits do tipo chore indicam atualizações de tarefas de build, configurações de administrador, pacotes... como por exemplo adicionar um pacote no gitignore. (Não inclui alterações em código)

`ci`: Commits do tipo ci indicam mudanças relacionadas a integração contínua (continuous integration).

`raw`: Commits to tipo raw indicam mudanças relacionadas a arquivos de configurações, dados, features, parametros.

`cleanup`: Commits do tipo cleanup são utilizados para remover código comentado, trechos desnecessários ou qualquer outra forma de limpeza do código-fonte, visando aprimorar sua legibilidade e manutenibilidade.

`remove`: Commits do tipo remove indicam a exclusão de arquivos, diretórios ou funcionalidades obsoletas ou não utilizadas, reduzindo o tamanho e a complexidade do projeto e mantendo-o mais organizado.
### Contributing
Contributions are welcome! Please fork the repository and submit a pull request with your improvements.

### License
[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
