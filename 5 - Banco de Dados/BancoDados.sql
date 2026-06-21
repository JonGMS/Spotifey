
# Após a primeira vez do script rodado, pode remover o # do DROP abaixo, para que exclua e refaça tudo novamente.
#DROP DATABASE SPOTIFEI;

CREATE DATABASE IF NOT EXISTS SPOTIFEI;

USE SPOTIFEI;

CREATE TABLE ARTISTA(
	ID_ARTISTA INT PRIMARY KEY AUTO_INCREMENT,
	NOME VARCHAR(45) NOT NULL,
    BIO VARCHAR(300)
);

CREATE TABLE MUSICA(
	ID_MUSICA INT PRIMARY KEY AUTO_INCREMENT,
    TITULO VARCHAR(45) NOT NULL,
    ALBUM VARCHAR(45),
    DURACAO DECIMAL(5,2) NOT NULL,
    TOTAL_OUVINTES INT,
    ARTISTA_ID INT,
    FOREIGN KEY (ARTISTA_ID) REFERENCES ARTISTA(ID_ARTISTA)
);

CREATE TABLE ASSINATURA(
    ID_ASSINATURA INT PRIMARY KEY AUTO_INCREMENT,
    TIPO_ASSINATURA ENUM("BÁSICO", "PREMIUM"),
    VALOR DECIMAL(5,2) NOT NULL,
    TEMPO_MESES INT NOT NULL
);
CREATE TABLE ASSINATURA_MUSICA(
	ASSINATURA_ID INT,
    MUSICA_ID INT,
    FOREIGN KEY (ASSINATURA_ID) REFERENCES ASSINATURA(ID_ASSINATURA),
    FOREIGN KEY (MUSICA_ID) REFERENCES MUSICA(ID_MUSICA)
);

CREATE TABLE USUARIO(
	ID_USUARIO INT PRIMARY KEY AUTO_INCREMENT,
	NOME_USUARIO VARCHAR(45) NOT NULL,
    BIO VARCHAR(100),
    ASSINATURA_USUARIO_ID INT,
    FOREIGN KEY (ASSINATURA_USUARIO_ID) REFERENCES ASSINATURA(ID_ASSINATURA)
);


#Inserindo dados dos artistas, para depois verificar qual o ID e colocar no ARTISTA_ID na tabela MUSICA
INSERT INTO ARTISTA(NOME, BIO)
VALUES("AYAKASHI", "AYA");
INSERT INTO ARTISTA(NOME, BIO)
VALUES('Stomach Book', 'Vivi is just spilling her guts over and over again.');
INSERT INTO ARTISTA(NOME, BIO)
VALUES('Schiavoto', 'She started making music in the year of 2020. And to this day, Schiavoto continues spreading her art to the world.');
INSERT INTO ARTISTA(NOME, BIO)
VALUES('Brody', 'If you are a Brody fan you are not a fan of me, you are a fan of yourself. Believe in yourself');
INSERT INTO ARTISTA(NOME, BIO)
VALUES('Jean Menestrel', 'Este(a) artista não possui uma bio.');
INSERT INTO ARTISTA(NOME, BIO)
VALUES('Beamom', 'Ouça crucificada ao contrário. Disponível agora.');
INSERT INTO ARTISTA(NOME, BIO)
VALUES('Redd', 'Você pode me chamar de Redd. Eu sou só um menino que faz músicas dentro de um guarda-roupas. Estou dando o meu melhor');
INSERT INTO ARTISTA(NOME, BIO)
VALUES('BLK', 'Movido por um amor intenso pela música, BLK é um Cantor, Compositor e Produtor independente nascido em Mato Grosso do Sul.');
INSERT INTO ARTISTA(NOME, BIO)
VALUES('TsunaOficial', 'Este(a) artista não possui uma bio.');

# Caso não tenha algum valor (assim como o Álbum), pode ser colocado apenas null
# Se precisar ver o ID do artista, só usar a consulta abaixo
# SELECT * FROM ARTISTA
INSERT INTO MUSICA(TITULO, ALBUM, DURACAO, ARTISTA_ID) 
VALUES("Os Mesmos Olhos", null, 3.01, 1);
INSERT INTO MUSICA(TITULO, ALBUM, DURACAO, ARTISTA_ID) 
VALUES('Fukouna Girl', 'single', 3.53, 2);
INSERT INTO MUSICA(TITULO, ALBUM, DURACAO, ARTISTA_ID) 
VALUES('Banho de Sangue', 'HEXATOMBE (trilha sonora)', 3.40, 3);
INSERT INTO MUSICA(TITULO, ALBUM, DURACAO, ARTISTA_ID) 
VALUES('Die Another Day', 'single',1.20, 4);
INSERT INTO MUSICA(TITULO, ALBUM, DURACAO, ARTISTA_ID) 
VALUES('Benção da Coroa', 'single', 4.49, 5);
INSERT INTO MUSICA(TITULO, ALBUM, DURACAO, ARTISTA_ID) 
VALUES('Breu', 'single', 3.16, 6);
INSERT INTO MUSICA(TITULO, ALBUM, DURACAO, ARTISTA_ID) 
VALUES('Onde Eu me Perco', 'Drop Hexatombe', 5.20, 7);
INSERT INTO MUSICA(TITULO, ALBUM, DURACAO, ARTISTA_ID) 
VALUES('Novo Começo', 'Drop Hexatombe', 4.33, 8);
INSERT INTO MUSICA(TITULO, ALBUM, DURACAO, ARTISTA_ID) 
VALUES('Última Vez', 'Drop Hexatombe', 3.42, 9);