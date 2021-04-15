insert into utilisateur values (1, 'admin', 'mdpadmin', 1);
insert into utilisateur values (2, 'charles', 'mdpcharles', 0);
insert into utilisateur values (3, 'loic', 'mdploic', 0);

insert into album values (1, 'Moriarty-the-patriot.jpg', 'Moriarty Tome 1', 'Moriarty', 'Ryosuke Takeuchi', 'Manga', 'Policier', 'Kana');
insert into album values (2, 'blackButler.jpg', 'Black Butler Tome 1', 'Black Butler', 'Yana Toboso', 'Manga', 'Fantasy', 'Kana');
insert into album values (3, 'asterixCleopatre.jpg', 'Astérix et Cléopâtre', 'Astérix', 'René Goscinny', 'BD', 'Humour', 'Hachette');
insert into album values (4, 'asterixCorse.jpg', 'Astérix en Corse', 'Astérix', 'René Goscinny', 'BD', 'Humour', 'Dargaud');
insert into album values (5, 'asterixSerpe.jpg', "Astérix et la serpe d'or", 'Astérix', 'René Goscinny', 'BD', 'Humour', 'Dargaud');
insert into album values (6, 'supermanRedson.jpg', 'Superman: Red Son', 'Superman: Red Son', 'Mark Millar', 'Comic', 'Aventure', 'DC Comics');
insert into album values (7, 'powerX.jpg', 'Power of X', 'Dawn of X', 'Jonathan Hickman', 'Comic', 'Aventure', 'Marvel Comics');
insert into album values (8, 'houseX.png', 'House of X', 'Dawn of X', 'Jonathan Hickman', 'Comic', 'Aventure', 'Marvel Comics');
insert into album values (9, 'tintinLotus.jpg', 'Le Lotus Bleu', 'Les aventures de Tintin', 'Hergé', 'BD', 'Aventure', 'Casterman');
insert into album values (10, 'tintinBijoux.jpg', 'Les bijoux de la Castafiore', 'Les aventures de Tintin', 'Hergé', 'BD', 'Aventure', 'Casterman');
insert into album values (11, 'XIII_SoleilNoir.jpg', 'Le jour du soleil noir', 'XIII', 'William Vance', 'BD', 'Thriller', 'Dargaud');
insert into album values (12, 'XIII_Jugement.jpg', 'Le jugement', 'XIII', 'William Vance', 'BD', 'Thriller', 'Dargaud');
insert into album values (13, 'secretJanissaire.jpg', 'Le secret du janissaire', 'De cape et de crocs', 'Alain Ayroles', 'BD', 'Fantasy', 'Delcourt');
insert into album values (14, 'archipelDanger.jpg', 'L\'archipel du danger', 'De cape et de crocs', 'Alain Ayroles', 'BD', 'Fantasy', 'Delcourt');
insert into album values (15, 'mila.jpg', 'Mila Racine', 'Femmes en résistance', 'Olivier Frasier', 'BD', 'Historique', 'Casterman');
insert into album values (16, 'berty.jpg', 'Berty Albrecht', 'Femmes en résistance', 'Ullcer', 'BD', 'Historique', 'Casterman');

insert into listesouhait values (1,3);
insert into listesouhait values (1,13);
insert into listesouhait values (1,8);
insert into listesouhait values (2,4);
insert into listesouhait values (2,6);
insert into listesouhait values (2,9);
insert into listesouhait values (3,11);
insert into listesouhait values (3,1);

insert into listealbumpossede values (1,5);
insert into listealbumpossede values (1,7);
insert into listealbumpossede values (2,12);
insert into listealbumpossede values (2,11);
insert into listealbumpossede values (2,15);
insert into listealbumpossede values (3,5);