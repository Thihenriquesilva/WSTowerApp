USE WSTower
GO

INSERT INTO TipoUsuario(Titulo) VALUES
('Admnistrador'),('Comum');
GO

INSERT INTO Usuario(NomeUsuario,Email,Senha,Telefone,idTipoUsuario) VALUES
('Douglas','Douglas@gmail.com','123123','40028922',1),
('Andre','Andre@gmail.com','123123','1243234234',2),
('Marcos','Marcos@gmail.com','123123','70070074534',2),
('Thiago','Thiago@gmail.com','123123','1312342422',2);
GO

INSERT INTO Estadio(NomeEstadio,Endereco) VALUES 
('Est�dio C�cero Pompeu de Toledo','Pra�a Roberto Gomes Pedrosa, 1 - Morumbi, S�o Paulo - SP, 05653-070'),
('Allianz Parque','Av. Francisco Matarazzo, 1705 - �gua Branca, S�o Paulo - SP, 05001-200'),
('Est�dio Jornalista M�rio Filho','Av. Pres. Castelo Branco, Port�o 3 - Maracan�, Rio de Janeiro - RJ, 20271-130'),
('Man� Garrincha','SRPN - Asa Norte, Bras�lia - DF, 70070-701');
GO

INSERT INTO Times(Nome) VALUES
('S�o Paulo'),('Palmeiras'),('Corinthans'),('Santos'),('Flamengo'),('Ituano'),('Gremio'),('Fluminence'),('Vasco'),('Chapecoense'),('Portuguesa');
GO

INSERT INTO TipoParticipacao(TituloParticipacao) VALUES
('Transmiss�o Ao Vivo'),('Para Assitir no local'),('Para participar');
GO

INSERT INTO TipoEvento(NomeTipoEvento) VALUES
('Futebol'),('E-Sports'),('Show');
GO

select * from Estadio
select * from Usuario
select * from TipoUsuario
select * from TipoEvento
select * from TipoParticipacao
select * from Times