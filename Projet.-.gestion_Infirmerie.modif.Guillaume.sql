-- --------------------------------------------------------
-- Base de données :  GEST_INFIRMERIE
-- --------------------------------------------------------

DROP DATABASE GEST_INFIRMERIE; -- On supprime la base
CREATE DATABASE GEST_INFIRMERIE; -- On recrée la base
USE GEST_INFIRMERIE; -- On définit quel base utiliser

--
-- Structure de la table CLASSE
--

CREATE TABLE CLASSE (
	id_classe int IDENTITY NOT NULL,
	libelle_classe varchar(20) NOT NULL,
	niveau_classe varchar(15) NOT NULL,
	emploi_du_temps varchar (50) NOT NULL, 
	
	PRIMARY KEY (id_classe)
);

--
-- Contenu de la table CLASSE
--

INSERT INTO CLASSE VALUES ('ES','Terminal','Emploi du temps terminal ES');
INSERT INTO CLASSE VALUES ('S','Terminal','Emploi du temps terminal S');
INSERT INTO CLASSE VALUES ('L','Terminal','Emploi du temps terminal L');

-- --------------------------------------------------------

--
-- Structure de la table MEDICAMENT
--

CREATE TABLE MEDICAMENT (
	id_medic int IDENTITY NOT NULL,
	libelle_medic varchar(40) NOT NULL,
	archive_medic int NOT NULL,
	archivage_medic bit NOT NULL,
	
	PRIMARY KEY (id_medic)
);

--
-- Contenu de la table MEDICAMENT
--

INSERT INTO MEDICAMENT VALUES ('Dafalgan', 14, 'false');
INSERT INTO MEDICAMENT VALUES ('Insuline', 5, 'false');
INSERT INTO MEDICAMENT VALUES ('Doliprane', 20, 'false');

-- --------------------------------------------------------

--
-- Structure de la table ELEVES
--

CREATE TABLE ELEVES (
	id_eleves int IDENTITY NOT NULL,
	nom varchar(35) NOT NULL,
	prenom varchar(35) NOT NULL,
	date_naissance date NOT NULL,
	tel_eleve int,
	tel_parent int NOT NULL,
	tier_temps bit NOT NULL,
	commentaire_sante varchar(400),
	id_classe int NOT NULL,
	archive_elv bit NOT NULL,
	
	PRIMARY KEY (id_eleves),
	FOREIGN KEY (id_classe) REFERENCES CLASSE (id_classe)
);

--
-- Contenu de la table ELEVES
--
		------ Terminal ES ------
INSERT INTO ELEVES VALUES ('ADAM', 'Elena', '15/02/1998', '0697972483', '0624564352', 'false', 'Aucun problème spécifique', '1', 'false');
INSERT INTO ELEVES VALUES ('BRACHE', 'Antoine', '14/04/1998', '0621914583', '0678523152', 'false', 'Allergie aux piqûre de guêpe', '1', 'false');
INSERT INTO ELEVES VALUES ('COLT', 'Samuel', '17/11/1998', '0611422147', '0666458764', 'false', 'Aucun problème spécifique', '1', 'false');
INSERT INTO ELEVES VALUES ('DEBREAUX', 'Maxime', '30/06/1998', '0678459138', '0636302497', 'false', 'Aucun problème spécifique', '1', 'false');
INSERT INTO ELEVES VALUES ('MOHAMED', 'Ibrahim', '04/09/1997', '0646579482', '0613789578', 'false', 'Aucun problème spécifique', '1', 'false');
INSERT INTO ELEVES VALUES ('PENNARD', 'CHARLES-HENRI', '25/12/1999', '0612895654', '0695124826', 'false', 'Allergie aux arachides', '1', 'false');
INSERT INTO ELEVES VALUES ('PREVOST', 'Mathilde', '28/07/1998', '0649851578', '0714955478', 'true', 'Aucun problème spécifique', '1', 'false');

		------ Terminal S ------
INSERT INTO ELEVES VALUES ('DUPONT', 'Robert', '13/10/1998', '0697532483', '0685474352', 'false', 'Aucun problème spécifique', '2', 'false');
INSERT INTO ELEVES VALUES ('LELIEVRE', 'Louis', '24/05/1998', '0678325583', '0675499152', 'false', 'Diabete', '2', 'false');
INSERT INTO ELEVES VALUES ('MARCHAND', 'Anais', '27/01/1998', '0611422554', '0664425764', 'false', 'Aucun problème spécifique', '2', 'false');
INSERT INTO ELEVES VALUES ('ROBINET', 'Maeva', '13/06/1998', '0644821381', '0698552197', 'false', 'Aucun problème spécifique', '2', 'false');
INSERT INTO ELEVES VALUES ('YANG', 'Paul', '06/02/1998', '0647845482', '0621589578', 'false', 'Aucun problème spécifique', '2', 'false');
INSERT INTO ELEVES VALUES ('PANA', 'Coline', '20/07/1997', '0624795654', '0695128526', 'true', 'Fragilitée des articulations', '2', 'false');


		------ Terminal L ------
INSERT INTO ELEVES VALUES ('ADAM', 'Louise', '15/02/1998', '0697971978', '0624564352', 'false', 'Aucun problème spécifique', '3', 'false');
INSERT INTO ELEVES VALUES ('BRAWN', 'Astride', '12/09/1998', '0628874583', '0678754152', 'false', 'Allergie aux piqûre de guêpe', '3', 'false');
INSERT INTO ELEVES VALUES ('PINOT', 'Constance', '17/08/1998', '0611778147', '0668758764', 'false', 'Aucun problème spécifique', '3', 'false');
INSERT INTO ELEVES VALUES ('DERBECOURT', 'Margot', '28/02/1998', '0678774138', '0636335497', 'false', 'Aucun problème spécifique', '3', 'false');
INSERT INTO ELEVES VALUES ('MOHAMED', 'Esmeralda', '01/08/1998', '0646784482', '0613445578', 'false', 'Aucun problème spécifique', '3', 'false');
INSERT INTO ELEVES VALUES ('CAMPANA', 'Laura', '21/10/1998', '0612836654', '0692344826', 'false', 'Allergie aux arachides', '3', 'false');
INSERT INTO ELEVES VALUES ('PROUST', 'Mathieux', '13/02/1997', '0649854438', '0714334895', 'false', 'Aucun problème spécifique', '3', 'false');
-- --------------------------------------------------------

--
-- Structure de la table VISITE
--

CREATE TABLE VISITE (
	id_visite int IDENTITY NOT NULL,
	date_visite date NOT NULL,
	motif_visite varchar(255) NOT NULL,
	commentaire_visite varchar(255) NOT NULL,
	pouls_eleve int NOT NULL,
	heure_deb time NOT NULL,
	heure_fin time NOT NULL,
	id_eleves int NOT NULL,
	
	PRIMARY KEY (id_visite),
	FOREIGN KEY (id_eleves) REFERENCES ELEVES (id_eleves)
);

--
-- Contenu de la table VISITE
--

INSERT INTO VISITE VALUES ('01/10/2015', 'Mal de tête', 'Besoin de repos', '80', '10:01', '10:55', '5');
INSERT INTO VISITE VALUES ('01/10/2015', 'Mal de ventre', 'Besoin de repos', '77', '14:25', '15:30', '8');
INSERT INTO VISITE VALUES ('02/10/2015', 'Mal de ventre', 'Besoin de repos', '84', '9:37', '10:30', '12');
INSERT INTO VISITE VALUES ('02/10/2015', 'Mal de tête', 'Besoin de repos',  '69', '10:10', '10:30', '2');
INSERT INTO VISITE VALUES ('02/10/2015', 'Mal de ventre', 'Besoin de repos',  '90', '15:15', '16:30', '7');
INSERT INTO VISITE VALUES ('03/10/2015', 'Mal de tête', 'Besoin de repos',  '84', '11:11', '12:30', '17');
INSERT INTO VISITE VALUES ('03/10/2015', 'Mal de tête', 'Besoin de repos',  '87', '14:10', '14:30', '1');

-- --------------------------------------------------------

--
-- Structure de la table PRESCRIPTION
--

CREATE TABLE PRESCRIPTION (
	id_visite int NOT NULL,
	id_medic int NOT NULL,
	nb_prescri int NOT NULL,
	
	PRIMARY KEY (id_visite, id_medic),
	FOREIGN KEY (id_visite) REFERENCES VISITE (id_visite),
	FOREIGN KEY (id_medic) REFERENCES MEDICAMENT (id_medic)
);

--
-- Contenu de la table PRESCRIPTION
--

INSERT INTO PRESCRIPTION VALUES ('1', '2', '1');
INSERT INTO PRESCRIPTION VALUES ('3', '3', '1');
INSERT INTO PRESCRIPTION VALUES ('4', '3', '1');
INSERT INTO PRESCRIPTION VALUES ('7', '1', '1');

-- --------------------------------------------------------

--
-- Structure de la table CONNEXION
--

CREATE TABLE CONNEXION (
	id_connexion int IDENTITY NOT NULL,
	login VARCHAR (20),
	mdp VARCHAR (20),
	email VARCHAR (50),
	
	PRIMARY KEY (id_connexion)
);


INSERT INTO CONNEXION VALUES ('Infirmière', 'mdp', 'infirmière@stvincent.fr');

-- ---------------------------------------------------------- --------------------------------------------------------