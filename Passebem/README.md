Bem vindo ao Projeto PasseBem
 
Esse projeto será usado como processo de seleção da Auvo


![PASSEBEM](https://user-images.githubusercontent.com/53240060/197411704-c77d9551-845b-43b3-ac01-b301d70cf3a2.jpeg)


Ele foi feito com .NetFramework 4.6.1

Microsoft.AspNet.Mvc 5.2.7

Bootstrap 5

Jquery

Banco SQLServer


Instruções de execução 

Apostar clonar o projeto na sua maquina você precisara configurar o banco de dados
Pra isso deverar configurar a conectionString

Ela se encontra no arquivo Web.config

	<connectionStrings>
		<add name="ClimaTempoSimples" connectionString="Server=SeuServidorDeConexãoDoBanco;Database=ClimaTempoSimples;User ID=SeuUsuarioDoBancoLocal;Password=SeuSenhaDoBancoLocal;Trusted_Connection=False;" providerName="System.Data.SqlClient"/>
	</connectionStrings>

Obs: connectionStrings para Banco SQLServer

Apos configurar a connectionStrings

1° - PARTE 
Voce precisarar rodar o Migrations para criar o banco e as tabelas automaticamente

    Verifique se ja existe os aquivos de migration, se não existir, você terá que criar 
	Se já existir, vá para a 2° - PARTE
	Caso contrariom continue a 1° - PARTE 

	Para isso vá no terminal do Package Manager Console
		lá rode o comando
			Enable-Migrations 
		e depois o comando 
			Add-Migration Inicial
		

2° - PARTE
Agora para atualizar o banco

Vá no terminal do Package Manager Console
    Lá rode o comando
	Updade-Databese

Abra o banco de dados e verifique se as tabelas foram criadas,

Se estiver sido, voce deverar popular o banco

Para popular o banco, abra o arquivo CopiaDoBarna no banco de dados

Depois dele abrir no SQLServer

Selecione todos os comandos e clique em execultar

Depois verifique se o banco foi populado

Se tudo tiver dado certo, seu ambriente vai estar pronta,e assim basta rodar o projeto no VISUAL STUDIO!

Caso tenha algum problema, pode entrar em contato cmigo pelo whatsapp

69 98112-0993

ou pelo E-mail

lucas11souza97@gmail.com

Abraços, Valeu!!!