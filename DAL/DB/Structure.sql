drop table if exists album;
drop table if exists utilisateur;
drop table if exists listeSouhait;
drop table if exists listeAlbumPossede;

create table utilisateur (
    utilisateurId integer not null primary key auto_increment,
    utilisateurLogin varchar(100) not null,
    utilisateurMdp varchar(100) not null,
    utilisateurAdmin boolean
);

create table album (
    albumId integer not null primary key auto_increment,
    albumCover varchar(100) not null,
    albumNom varchar(100) not null,
    albumSerie varchar(100) not null,
    albumAuteur varchar(100) not null,
    albumCategorie varchar(100) not null,
    albumGenre varchar(100) not null,
    albumEditeur varchar(100) not null
);

create table listeSouhait (
    utilisateurId integer not null,
    albumId integer not null,
    FOREIGN KEY (utilisateurId) REFERENCES utilisateur(utilisateurId),
    FOREIGN KEY (albumId) REFERENCES album(albumId)
);

create table listeAlbumPossede (
    utilisateurId integer not null,
    albumId integer not null,
    FOREIGN KEY (utilisateurId) REFERENCES utilisateur(utilisateurId),
    FOREIGN KEY (albumId) REFERENCES album(albumId)
);
