# Sistema de Estacionamento em ASP.NET MVC

Esse é um upgrade de um de meus repositórios (desafio_CriandoSistemaEstacionamento) criado na versão console, proposto como desafio pelo bootcamp da [DIO](dio.me).

Utilizei o padrão MVC (Model-View-Controller) pois tinha por objetivo justamente essa separação em camadas permitindo assim, uma maior manutenibilidade.
O projeto se trata de um CRUD simples para um sistema de estacionamento, onde é possível realizar cadastros, edição, visualização de forma detalhada e exclusão de veículos. 
O mesmo possui algumas validações para não permitir o cadastro de uma mesma placa, campos para preenchimentos são obrigatórios e usei como referência modelos de placas de São Paulo-SP (que possui sete caracteres alfanuméricos) e também realiza o cálculo do valor cobrado por tempo/hora em que o veículo esteve estacionado.

Apliquei os conceitos vistos em uma outra trilha de Formação.NET da [DIO](dio.me), usando o [EntityFramework](https://learn.microsoft.com/pt-br/ef/) e [migrations](https://learn.microsoft.com/pt-br/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)

* O [Mermaid](https://mermaid.live/edit#pako:eNpVkE1uwjAQha9izapIZFGWWVSCBFZUVCq7mMXInjSW_Fdji6Ikp2HRg3CxmmRDZzV633uj0etBOElQQqvdRXQYIjvW3LI862bttRJ4_73fHHs9saJ4GwJ9JzrHgW1enulqMWc2DxOr-u0PGa_dOKvVFD1YGljd7NFH50_P5HhxA9s26qNzlv6TLlBO7ZoWyxYLgYFVGCYLLMFQMKhk_r5_KBxiR4Y4lHmV1GLSkQO3Y7Ziiu7zagWUMSRaQvISI9UKvwIayLf1OaskVXThfW5kKmb8AyAeX3o) é uma opção bem legal para diagramas:

[![](https://mermaid.ink/img/pako:eNqNkMEKwjAMhl-l5KSgL7CDoG560ZPiZfMQ2ugK7SpdisjY03jwQXwxW0XxpoGE8OXnJ0kH0imCDA7GnWWNnsU2rxoRYzpYUxPEjrQMxrVDMR5PZl3RSmdqFMGiwPvtfnX9Sz5LczEv56iwZY9-n8CyXOmW0X9s9t_qvCyU5r-kRZkTo6npgxNdRGroh0MqKWEElrxFreK93ZMC12Spgiy2ig4YDFdQNX2UYmC3uTQSMvaBRhBOCplyjUeP9g0pru_8-vXC5yf7BxV_bYo?type=png)](https://mermaid.live/edit#pako:eNqNkMEKwjAMhl-l5KSgL7CDoG560ZPiZfMQ2ugK7SpdisjY03jwQXwxW0XxpoGE8OXnJ0kH0imCDA7GnWWNnsU2rxoRYzpYUxPEjrQMxrVDMR5PZl3RSmdqFMGiwPvtfnX9Sz5LczEv56iwZY9-n8CyXOmW0X9s9t_qvCyU5r-kRZkTo6npgxNdRGroh0MqKWEElrxFreK93ZMC12Spgiy2ig4YDFdQNX2UYmC3uTQSMvaBRhBOCplyjUeP9g0pru_8-vXC5yf7BxV_bYo)

- No site, vá no campo: Actions > Copy Markdown. Copie o link e cole no seu arquivo README.md e o diagrama estará lá.
  
### Tecnologias Utilizadas

Liste as tecnologias (linguagens, ferramentas, bibliotecas) que você utilizou para elaborar o projeto. Essa parte é importante para quando um recrutador (que não tem conhecimento de programação) acessar o seu projeto, ele vai saber só olhando a documentação quais tecnologias você já conhece!

Exemplo:
* C#
* CSS
* JavaScript
* SQL Server
* EntityFrameWork
* ASP.NET
* GIT

## Dependências e Versões utilizadas

* Microsoft.EntityFrameworkCore - Versão: 6.0.0
* Microsoft.EntityFrameworkCore.Design - Versão: 6.0.0
* Microsoft.EntityFrameworkCore.SqlServer - Versão: 6.0.0
* Microsoft.VisualStudio.Web.CodeGeneration.Design - Versão: 6.0.16
* .NET - Versão: 6.0.0

## Como rodar o projeto ✅

Após clonar o repositório em sua máquina local, será necessário utilizar no terminal, o comando **dotnet ef database update** ou **Update-Database** para conseguir executar as migrations.

## ⚠️ Problemas enfrentados

Pode ocorrer problemas com as migrations ao tentar executar as migrations, nesse caso, serão necessários alguns comandos para correção.

```
Comando 1 -- Talvez seja necessário remover as migations, dessa forma rode o seguinte comando:

Remove-Migration
```
Depois, rode o seguinte comando:

```
Comando 2 -- Adicionando uma nova migration

Add-Migration NomeDaMigracao

```
Por fim, rode o seguinte comando:

```
Comando 3 -- Atualizando o banco de dados e aplicando a nova migration

Update-Database

```

## Informações adicionais

Pensando em boas práticas de começar desde já a documentar meus projetos, achei um canal muito bacana no [youtube](https://youtu.be/ef-78uxqFig) que ensina a fazer uma boa documentação e onde também é disponibilizado esse modelo que utilizei. Dá uma olhadinha no perfil da [Stephanie](https://github.com/stephanie-cardoso/modelo-README.md)
