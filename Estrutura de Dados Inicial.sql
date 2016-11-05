DROP DATABASE DBPIM;
CREATE DATABASE DBPIM;
GO
USE DBPIM;

CREATE TABLE TBTIPOCONTATO(
	NCDIDTIPOCONTATO	INTEGER IDENTITY(1,1)	,
	CDSDESCRICAO		VARCHAR(20)				,
	
	CONSTRAINT PK_NCDIDTIPOCONTATO PRIMARY KEY(NCDIDTIPOCONTATO)
);

CREATE TABLE TBPAIS(
	NCDIDPAIS	INTEGER IDENTITY(1,1)	,
	CDSPAIS		VARCHAR(60)				,
	
	CONSTRAINT PK_NCDIDPAIS PRIMARY KEY(NCDIDPAIS)
);

CREATE TABLE TBESTADO(
	NCDIDESTADO 	INTEGER IDENTITY(1,1)			,
	CDSUF			VARCHAR(30)						,
	CDSSIGLA		VARCHAR(5)						,	
	NCDIDPAIS		INTEGER							,
	
	CONSTRAINT PK_NCDIDESTADO PRIMARY KEY(NCDIDESTADO)	
);

CREATE TABLE TBCIDADE(
	NCDIDCIDADE		INTEGER IDENTITY(1,1)				,
	CDSCIDADE		VARCHAR(60) 						,
	NCDIDESTADO 	INTEGER								,
	BIDATIVO		BIT									,
	CONSTRAINT PK_NCDIDCIDADE PRIMARY KEY(NCDIDCIDADE)	
);

CREATE TABLE TBSETOR(
	NCDIDSETOR		INTEGER identity(1,1)	,
	CNMNOME			VARCHAR(150)			,
	CDSDESCRICAO	VARCHAR(1000)			,
	BIDATIVO		BIT						,	
	CONSTRAINT PK_NCDIDSETOR PRIMARY KEY(NCDIDSETOR)
);

CREATE TABLE TBCARGO(
	NCDIDCARGO		INTEGER IDENTITY(1,1)	,
	CNMNOME			VARCHAR(20)				,
	CDSDESCRICAO	VARCHAR(120)			,
	NCDIDSETOR		INTEGER					,
	BIDATIVO		BIT						,
	CONSTRAINT PK_NCDIDCARGO PRIMARY KEY(NCDIDCARGO)
);

CREATE TABLE TBFUNCIONARIO(
	NCDIDFUNCIONARIO	INTEGER IDENTITY(1,1)	,
	CNMNOME  			VARCHAR(30)				,	
	CNMSOBRENOME		VARCHAR(30)				,
	CDSRG				VARCHAR(9)				,
	CDSCPF				VARCHAR(11)				,
	DDTNASCIMENTO		DATETIME				,
	BIDATIVO			BIT						,  
	NCDIDCARGO			INTEGER					,

	CONSTRAINT PK_NCDIDFUNCIONARIO PRIMARY KEY( NCDIDFUNCIONARIO )	
);

CREATE TABLE TBUSUARIO(
	NCDIDUSUARIO		INTEGER IDENTITY(1,1)	,
	CNMLOGIN			VARCHAR(100) NOT NULL	,
	CDSSENHA			VARCHAR(30) NOT NULL	,
	NNRNIVELACESSO		INTEGER					,
	NCDIDFUNCIONARIO	INTEGER					,
	BIDATIVO			BIT						,
	CONSTRAINT PK_NCDIDUSUARIO PRIMARY KEY( NCDIDUSUARIO )	
);

CREATE TABLE TBCLIENTE(
	NCDIDCLIENTE	INTEGER IDENTITY(1,1)					,
	CNMNOME  		VARCHAR(100)				,	
	CNMSOBRENOME	VARCHAR(100)				,
	CDSRG			VARCHAR(30)				,
	CDSCPF			VARCHAR(30)				,
	DDTNASCIMENTO	DATETIME				,
	BIDATIVO		BIT						,  
	CCDCNH			BIGINT									,
	DDTEMISSAO		DATETIME								,
	DDTVENCIMENTO	DATETIME								,

	CONSTRAINT PK_NCDIDCLIENTE PRIMARY KEY( NCDIDCLIENTE )	
);

CREATE TABLE TBENDERECO(
	NCDIDENDEDERECO			INTEGER IDENTITY(1,1)	,
	NCDIDPESSOA				INTEGER					,
	CDSLOGRADOURO			VARCHAR(160)			,
	NNRNUMERO				VARCHAR(10)				,
	CDSCOMPLEMENTO			VARCHAR(200)			,
	NCDIDCIDADE				INTEGER					,

	CONSTRAINT PK_NCDIDENDEDERECO PRIMARY KEY(NCDIDENDEDERECO)	
);

CREATE TABLE TBCONTATO(
	NCDIDCONTATO		INTEGER IDENTITY(1,1)					,
	NCDIDPESSOA			INTEGER									,
	NCDIDTIPOCONTATO	INTEGER									,
	CDSTELEFONE			VARCHAR(11)								,
	BIDATIVO			BIT										,
	
	CONSTRAINT PK_NCDIDCONTATO PRIMARY KEY(NCDIDCONTATO)		
);

CREATE TABLE TBOPERADORACARTAO(
	NCDIDOPERADORACARTAO		INTEGER IDENTITY(1,1)	,
	CDSBANDEIRA				VARCHAR(50)				,
	BIDATIVO				BIT						,
	
	CONSTRAINT PK_NCDIDOPERADORACARTAO PRIMARY KEY(NCDIDOPERADORACARTAO)
);

CREATE TABLE TBCARTAODECREDITO(
	NCDIDCARTAO						INTEGER IDENTITY(1,1)	,
	NCDIDOPERADORACARTAO		 	INTEGER 				,
	CCDRCARTAO						VARCHAR(25)				,
	NNRCODIGO						VARCHAR(3)				,
	DDTVALIDADE						DATETIME				,
	CNMNOMECARTAO					VARCHAR(120)			,
	BIDATIVO						BIT						,
	NCDIDCLIENTE					INTEGER					,
	CONSTRAINT PK_NCDIDCARTAO PRIMARY KEY(NCDIDCARTAO)		);

CREATE TABLE TBCATEGORIACARRO(
	NCDIDCATEGORIACARRO	INTEGER IDENTITY(1,1)	,
	CNMCATEGORIACARRO	VARCHAR(30)				,
	CDSDESCRICAO		VARCHAR(120)			,
	CONSTRAINT PK_NCDIDCATEGORIACARRO PRIMARY KEY(NCDIDCATEGORIACARRO)
);

CREATE TABLE TBMARCACARRO(
	NCDIDMARCACARRO 	INTEGER IDENTITY(1,1)	,
	CNMMARCACARRO		VARCHAR(50)				,
	CDSDESCRICAO		VARCHAR(120)			,
	CONSTRAINT PK_NCDIDMARCACARRO PRIMARY KEY(NCDIDMARCACARRO)
);

CREATE TABLE TBMODELOCARRO(
	NCDIDMODELOCARRO		INTEGER	IDENTITY(1,1)	,
	CDSMODELOCARRO			VARCHAR(50)				,
	NCDIDMARCACARRO			INTEGER					,
	NCDIDCATEGORIACARRO		INTEGER					,
	
	CONSTRAINT PK_NCDIDMODELOCARRO PRIMARY KEY(NCDIDMODELOCARRO)
);

CREATE TABLE TBCOR(
	NCDIDCOR		INTEGER IDENTITY(1,1)	,
	CDSCOR			VARCHAR(20) 			,
	
	CONSTRAINT PK_NCDIDCORCARRO PRIMARY KEY(NCDIDCOR)
);

CREATE TABLE TBCARRO(
	NCDIDCARRO			INTEGER IDENTITY(1,1)			,
	CCDCHASSI			VARCHAR(17)						,		
	CCDPLACA			VARCHAR(7)						,
	DDTDATAFABRICACAO	DATETIME						,
	DDTDATAAQUISICAO	DATETIME						,
	NNRQTDEDELOCACOES	INTEGER							,
	NCDIDCORCARRO		INTEGER							,
	NCDIDMODELOCARRO	INTEGER							,
	BIDLOCADO			BIT								,
	NVLDIARIA			DECIMAL(10,4)					,
		
	CONSTRAINT PK_NCDIDCARRO PRIMARY KEY(NCDIDCARRO)	);

CREATE TABLE TBLOCACAO(
	NCDIDLOCACAO	INTEGER IDENTITY(1,1)				,
	NCDIDUSUARIO	INTEGER								,
	DDTLOCACAO		DATETIME							,
	NVLLOCACAO		DECIMAL(30,2)						,
	DDTDEVOLUCAO	DATETIME							,
	NCDIDCARTAO		INTEGER								,
	NCDIDCARRO		INTEGER								,

	CONSTRAINT PK_NCDIDLOCACAO PRIMARY KEY(NCDIDLOCACAO) 
	
);



/*
	Descri��o: 	A primeira letra fala sobre o tipo de dado
				A segunda e terceira, s�o breves descri��es referente ao dado armazenado

	NCD 
		N 	= N�mero
		CD 	= C�digo
	NNR
		N 	= N�mero
		NR	= Numeral(um n�mero qualquer)
	NVL
		N 	= N�mero
		VL	= Valor(Dinheiro) / quantidade
		
	DDT
		D 	= DATE	
		DT	= DATETIME

	BID = BOOLEAN
		1 	= TRUE
		0 	= FALSE

	CDS
		C	= CHARACTER
		DS	= Descri��o
*/
