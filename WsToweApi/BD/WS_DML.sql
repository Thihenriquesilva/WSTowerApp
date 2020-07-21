use WSTower

INSERT INTO TipoUsuario(NomeTipoUsuario) VALUES
('Admnistrador'),('Comum');

INSERT INTO Usuario(NomeUsuario,Email,Senha,Telefone,idTipoUsuario) VALUES
('Douglas','Douglas@gmail.com','123123','40028922',1),
('Andre','Andre@gmail.com','123123','1243234234',2),
('Marcos','Marcos@gmail.com','123123','70070074534',2),
('Thiago','Thiago@gmail.com','123123','1312342422',2);

INSERT INTO Estadio(NomeEstadio,Endereco) VALUES 
('Est�dio C�cero Pompeu de Toledo','Pra�a Roberto Gomes Pedrosa, 1 - Morumbi, S�o Paulo - SP, 05653-070'),
('Allianz Parque','Av. Francisco Matarazzo, 1705 - �gua Branca, S�o Paulo - SP, 05001-200'),
('Est�dio Jornalista M�rio Filho','Av. Pres. Castelo Branco, Port�o 3 - Maracan�, Rio de Janeiro - RJ, 20271-130'),
('Man� Garrincha','SRPN - Asa Norte, Bras�lia - DF, 70070-701');

INSERT INTO Times(NomeTime) VALUES
('S�o Paulo'),('Palmeiras'),('Corinthans'),('Santos'),('Flamengo'),('Ituano'),('Gremio'),('Fluminence'),('Vasco'),('Chapecoense'),('Portuguesa');

INSERT INTO TipoParticipacao(TituloParticipacao) VALUES
('Transmiss�o Ao Vivo'),('Para Assitir no local'),('Para participar');

INSERT INTO TipoEvento(NomeTipoEvento) VALUES
('Futebol'),('E-Sports'),('Show');

INSERT INTO EventoE_Sports(NomeEventoE_Sports) VALUES
('Campeonato de CS GO ');

INSERT INTO  EventoShow(NomeEventoShow)VALUES
('120 anos de mamonas assassinas');

INSERT INTO EventoFutebol(idTimeCasa,idTimeVisitante) VALUES
(1,2);

INSERT INTO Evento(DataEvento,Descricao,HoraDoEvento,idEstadio,idTipoEvento,idTipoParticipacao,idEventoFutebol,AcessoLivre) VALUES
('27/07/2020 3:53:04 AM','Campeonato Paulista masculino','27/07/2020 3:53:04 AM',1,1,2,1,1);

INSERT INTO Evento(DataEvento,Descricao,HoraDoEvento,idEstadio,idTipoEvento,idTipoParticipacao,idEventoshow,AcessoLivre) VALUES
('27/08/2020 4:53:04 AM','Show de m�sica','27/08/2020 4:53:04 AM',2,3,2,1,1)

INSERT INTO Evento(DataEvento,Descricao,HoraDoEvento,idEstadio,idTipoEvento,idTipoParticipacao,idEventoE_Sports,AcessoLivre) VALUES
('20/10/2020 4:53:04 AM','Campeonato de CsGo','27/08/2020 4:53:04 AM',3,2,1,1,1)


INSERT INTO Favoritos(idUsuario,idEvento,StatusFavorito) VALUES 
(1,2,1)

select * from Estadio
select * from Usuario
select * from TipoUsuario
select * from TipoEvento
select * from TipoParticipacao
select * from Times
select * from EventoShow
select * from EventoFutebol
select * from EventoE_Sports
Select* from Evento
Select * from Favoritos