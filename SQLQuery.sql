CREATE TABLE Utilisateurs (
    IdUtilisateur INT PRIMARY KEY IDENTITY(1,1),
    Nom NVARCHAR(50) NOT NULL,
    Prenom NVARCHAR(50) NOT NULL,
    Login NVARCHAR(50) NOT NULL UNIQUE,
    MotDePasse NVARCHAR(100) NOT NULL,
    Role NVARCHAR(20) NOT NULL CHECK (Role IN ('Admin', 'Secretaire', 'Veterinaire')),
    Email NVARCHAR(100),
    Telephone NVARCHAR(20),
    DateCreation DATETIME DEFAULT GETDATE()
);

CREATE TABLE Proprietaires (
    IdProprietaire INT PRIMARY KEY IDENTITY(1,1),
    Nom NVARCHAR(50) NOT NULL,
    Prenom NVARCHAR(50) NOT NULL,
    Adresse NVARCHAR(200),
    Telephone NVARCHAR(20),
    Email NVARCHAR(100),
    DateEnregistrement DATETIME DEFAULT GETDATE()
);

CREATE TABLE Animaux (
    IdAnimal INT PRIMARY KEY IDENTITY(1,1),
    Nom NVARCHAR(50) NOT NULL,
    Espece NVARCHAR(50) NOT NULL,
    Race NVARCHAR(50),
    DateNaissance DATE,
    Sexe NVARCHAR(10) CHECK (Sexe IN ('Male', 'Femelle')),
    Poids DECIMAL(5,2),
    IdProprietaire INT NOT NULL,
    FOREIGN KEY (IdProprietaire) REFERENCES Proprietaires(IdProprietaire)
);

CREATE TABLE RendezVous (
    IdRendezVous INT PRIMARY KEY IDENTITY(1,1),
    DateRDV DATETIME NOT NULL,
    Motif NVARCHAR(200),
    Statut NVARCHAR(20) DEFAULT 'Planifie' CHECK (Statut IN ('Planifie', 'Termine', 'Annule')),
    IdAnimal INT NOT NULL,
    IdVeterinaire INT NOT NULL,
    FOREIGN KEY (IdAnimal) REFERENCES Animaux(IdAnimal),
    FOREIGN KEY (IdVeterinaire) REFERENCES Utilisateurs(IdUtilisateur)
);

CREATE TABLE Consultations (
    IdConsultation INT PRIMARY KEY IDENTITY(1,1),
    DateConsultation DATETIME DEFAULT GETDATE(),
    Diagnostic NVARCHAR(500),
    Traitement NVARCHAR(500),
    Remarques NVARCHAR(500),
    IdAnimal INT NOT NULL,
    IdVeterinaire INT NOT NULL,
    IdRendezVous INT,
    FOREIGN KEY (IdAnimal) REFERENCES Animaux(IdAnimal),
    FOREIGN KEY (IdVeterinaire) REFERENCES Utilisateurs(IdUtilisateur),
    FOREIGN KEY (IdRendezVous) REFERENCES RendezVous(IdRendezVous)
);

CREATE TABLE Medicaments (
    IdMedicament INT PRIMARY KEY IDENTITY(1,1),
    Nom NVARCHAR(100) NOT NULL,
    Description NVARCHAR(300),
    QuantiteStock INT NOT NULL DEFAULT 0,
    SeuilAlerte INT DEFAULT 10,
    DateExpiration DATE,
    Prix DECIMAL(8,2)
);

CREATE TABLE Vaccinations (
    IdVaccination INT PRIMARY KEY IDENTITY(1,1),
    NomVaccin NVARCHAR(100) NOT NULL,
    DateVaccination DATE NOT NULL,
    DateRappel DATE,
    IdAnimal INT NOT NULL,
    IdVeterinaire INT NOT NULL,
    FOREIGN KEY (IdAnimal) REFERENCES Animaux(IdAnimal),
    FOREIGN KEY (IdVeterinaire) REFERENCES Utilisateurs(IdUtilisateur)
);

CREATE TABLE Factures (
    IdFacture INT PRIMARY KEY IDENTITY(1,1),
    DateFacture DATETIME DEFAULT GETDATE(),
    MontantTotal DECIMAL(10,2) NOT NULL,
    Statut NVARCHAR(20) DEFAULT 'Impayee' CHECK (Statut IN ('Payee', 'Impayee')),
    ModePaiement NVARCHAR(30),
    IdConsultation INT NOT NULL,
    IdProprietaire INT NOT NULL,
    FOREIGN KEY (IdConsultation) REFERENCES Consultations(IdConsultation),
    FOREIGN KEY (IdProprietaire) REFERENCES Proprietaires(IdProprietaire)
);

CREATE TABLE ConsultationMedicaments (
    IdConsultation INT NOT NULL,
    IdMedicament INT NOT NULL,
    Quantite INT NOT NULL,
    PRIMARY KEY (IdConsultation, IdMedicament),
    FOREIGN KEY (IdConsultation) REFERENCES Consultations(IdConsultation),
    FOREIGN KEY (IdMedicament) REFERENCES Medicaments(IdMedicament)
);

-- Données de test
INSERT INTO Utilisateurs (Nom, Prenom, Login, MotDePasse, Role, Email)
VALUES ('Admin', 'Principal', 'admin', 'admin123', 'Admin', 'admin@clinique.com');

INSERT INTO Utilisateurs (Nom, Prenom, Login, MotDePasse, Role, Email)
VALUES ('Ben Ali', 'Sarra', 'secretaire', 'sec123', 'Secretaire', 'sarra@clinique.com');

INSERT INTO Utilisateurs (Nom, Prenom, Login, MotDePasse, Role, Email)
VALUES ('Trabelsi', 'Ahmed', 'veto', 'veto123', 'Veterinaire', 'ahmed@clinique.com');

INSERT INTO Medicaments (Nom, Description, QuantiteStock, DateExpiration, Prix)
VALUES 
('Amoxicilline', 'Antibiotique', 50, '2027-12-31', 15.00),
('Vermifuge', 'Contre les parasites', 30, '2027-06-30', 8.50),
('Anti-inflammatoire', 'Douleur et inflammation', 25, '2026-12-31', 12.00);