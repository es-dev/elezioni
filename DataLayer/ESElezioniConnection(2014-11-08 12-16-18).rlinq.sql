-- DataLayer.Affluenza
CREATE TABLE [Affluenza] (
    [ConsultazioneId] int NOT NULL,         -- _consultazione
    [Id] int IDENTITY NOT NULL,             -- _id
    [Orario] datetime NOT NULL,             -- _orario
    CONSTRAINT [pk_Affluenza] PRIMARY KEY ([Id])
)

go

-- DataLayer.Candidato
CREATE TABLE [Candidato] (
    [Cognome] varchar(255) NULL,            -- _cognome
    [Id] int IDENTITY NOT NULL,             -- _id
    [ListaId] int NOT NULL,                 -- _lista
    [Nome] varchar(255) NULL,               -- _nome
    [Numero] int NOT NULL,                  -- _numero
    CONSTRAINT [pk_Candidato] PRIMARY KEY ([Id])
)

go

-- DataLayer.CapoCoalizione
CREATE TABLE [CapoCoalizione] (
    [ConsultazioneId] int NOT NULL,         -- _consultazione
    [Descrizione] varchar(255) NULL,        -- _descrizione
    [Id] int IDENTITY NOT NULL,             -- _id
    [Numero] int NOT NULL,                  -- _numero
    [Simbolo] varchar(255) NULL,            -- _simbolo
    CONSTRAINT [pk_CapoCoalizione] PRIMARY KEY ([Id])
)

go

-- DataLayer.Collegio
CREATE TABLE [Collegio] (
    [ConsultazioneId] int NOT NULL,         -- _consultazione
    [Descrizione] varchar(255) NULL,        -- _descrizione
    [Id] int IDENTITY NOT NULL,             -- _id
    [Numero] int NOT NULL,                  -- _numero
    CONSTRAINT [pk_Collegio] PRIMARY KEY ([Id])
)

go

-- DataLayer.Comune
CREATE TABLE [Comune] (
    [CodiceISTAT] varchar(255) NULL,        -- _codiceISTAT
    [Descrizione] varchar(255) NULL,        -- _descrizione
    [Id] int IDENTITY NOT NULL,             -- _id
    [Nome] varchar(255) NULL,               -- _nome
    [NumeroSezioni] int NOT NULL,           -- _numeroSezioni
    [Provincia] varchar(255) NULL,          -- _provincia
    CONSTRAINT [pk_Comune] PRIMARY KEY ([Id])
)

go

-- DataLayer.Consultazione
CREATE TABLE [Consultazione] (
    [ComuneId] int NOT NULL,                -- _comune
    [Descrizione] varchar(255) NULL,        -- _descrizione
    [Id] int NOT NULL,                      -- _id
    [Numero] int NOT NULL,                  -- _numero
    [Tipo] varchar(255) NULL,               -- _tipo
    CONSTRAINT [pk_Consultazione] PRIMARY KEY ([Id])
)

go

-- DataLayer.Lista
CREATE TABLE [Lista] (
    [CapoCoalizioneId] int NOT NULL,        -- _capoCoalizione
    [Descrizione] varchar(255) NULL,        -- _descrizione
    [Id] int IDENTITY NOT NULL,             -- _id
    [Numero] int NOT NULL,                  -- _numero
    [Simbolo] varchar(255) NULL,            -- _simbolo
    CONSTRAINT [pk_Lista] PRIMARY KEY ([Id])
)

go

-- DataLayer.Operatore
CREATE TABLE [Operatore] (
    [Amministratore] tinyint NOT NULL,      -- _amministratore
    [Cognome] varchar(255) NULL,            -- _cognome
    [ConfermaPassword] varchar(255) NULL,   -- _confermaPassword
    [ConsultazioneId] int NOT NULL,         -- _consultazione
    [Email] varchar(255) NULL,              -- _email
    [Id] int IDENTITY NOT NULL,             -- _id
    [Nome] varchar(255) NULL,               -- _nome
    [passwd] varchar(255) NULL,             -- _password
    [Supervisor] tinyint NOT NULL,          -- _supervisor
    [Telefono] varchar(255) NULL,           -- _telefono
    [Username] varchar(255) NULL,           -- _username
    [Utente] tinyint NOT NULL,              -- _utente
    CONSTRAINT [pk_Operatore] PRIMARY KEY ([Id])
)

go

-- DataLayer.Rilevamento
CREATE TABLE [Rilevamento] (
    [AffluenzaId] int NOT NULL,             -- _affluenza
    [Donne] int NOT NULL,                   -- _donne
    [Id] int IDENTITY NOT NULL,             -- _id
    [SezioneId] int NOT NULL,               -- _sezione
    [Totale] int NOT NULL,                  -- _totale
    [Uomini] int NOT NULL,                  -- _uomini
    CONSTRAINT [pk_Rilevamento] PRIMARY KEY ([Id])
)

go

-- DataLayer.Scrutinio
CREATE TABLE [Scrutinio] (
    [Bianche] int NOT NULL,                 -- _bianche
    [ConsultazioneId] int NOT NULL,         -- _consultazione
    [Contestate] int NOT NULL,              -- _contestate
    [Id] int IDENTITY NOT NULL,             -- _id
    [Nulle] int NOT NULL,                   -- _nulle
    [SezioneId] int NOT NULL,               -- _sezione
    [Validi] int NOT NULL,                  -- _validi
    CONSTRAINT [pk_Scrutinio] PRIMARY KEY ([Id])
)

go

-- DataLayer.ScrutinioCandidato
CREATE TABLE [ScrutinioCandidato] (
    [CandidatoId] int NOT NULL,             -- _candidato
    [Id] int IDENTITY NOT NULL,             -- _id
    [SezioneId] int NOT NULL,               -- _sezione
    [Voti] int NOT NULL,                    -- _voti
    [VotiAnnullati] int NOT NULL,           -- _votiAnnullati
    CONSTRAINT [pk_ScrutinioCandidato] PRIMARY KEY ([Id])
)

go

-- DataLayer.ScrutinioCapoCoalizione
CREATE TABLE [ScrutinioCapoCoalizione] (
    [CapoCoalizioneId] int NOT NULL,        -- _capoCoalizione
    [Id] int IDENTITY NOT NULL,             -- _id
    [SezioneId] int NOT NULL,               -- _sezione
    [Voti] int NOT NULL,                    -- _voti
    [VotiAnnullati] int NOT NULL,           -- _votiAnnullati
    CONSTRAINT [pk_ScrutinioCapoCoalizione] PRIMARY KEY ([Id])
)

go

-- DataLayer.ScrutinioLista
CREATE TABLE [ScrutinioLista] (
    [Id] int IDENTITY NOT NULL,             -- _id
    [ListaId] int NOT NULL,                 -- _lista
    [SezioneId] int NOT NULL,               -- _sezione
    [Voti] int NOT NULL,                    -- _voti
    [VotiAnnullati] int NOT NULL,           -- _votiAnnullati
    CONSTRAINT [pk_ScrutinioLista] PRIMARY KEY ([Id])
)

go

-- DataLayer.SedeElettorale
CREATE TABLE [SedeElettorale] (
    [ConsultazioneId] int NOT NULL,         -- _consultazione
    [Fax] varchar(255) NULL,                -- _fax
    [Id] int IDENTITY NOT NULL,             -- _id
    [Indirizzo] varchar(255) NULL,          -- _indirizzo
    [Mappa] varchar(255) NULL,              -- _mappa
    [Responsabile] varchar(255) NULL,       -- _responsabile
    [Telefono] varchar(255) NULL,           -- _telefono
    CONSTRAINT [pk_SedeElettorale] PRIMARY KEY ([Id])
)

go

-- DataLayer.Sezione
CREATE TABLE [Sezione] (
    [Id] int IDENTITY NOT NULL,             -- _id
    [Numero] varchar(255) NULL,             -- _numero
    [OperatoreId] int NOT NULL,             -- _operatore
    [SedeElettoraleId] int NOT NULL,        -- _sedeElettorale
    [TotaleVotanti] int NOT NULL,           -- _totaleVotanti
    [VotantiFemmine] int NOT NULL,          -- _votantiFemmine
    [VotantiMaschi] int NOT NULL,           -- _votantiMaschi
    CONSTRAINT [pk_Sezione] PRIMARY KEY ([Id])
)

go

-- DataLayer.SezioneCollegio
CREATE TABLE [SezioneCollegio] (
    [CollegioId] int NOT NULL,              -- _collegio
    [Id] int IDENTITY NOT NULL,             -- _id
    [SezioneId] int NOT NULL,               -- _sezione
    CONSTRAINT [pk_SezioneCollegio] PRIMARY KEY ([Id])
)

go

ALTER TABLE [Affluenza] ADD CONSTRAINT [ref_Affluenza_Consultazione] FOREIGN KEY ([ConsultazioneId]) REFERENCES [Consultazione]([Id])

go

ALTER TABLE [Candidato] ADD CONSTRAINT [ref_Candidato_Lista] FOREIGN KEY ([ListaId]) REFERENCES [Lista]([Id])

go

ALTER TABLE [CapoCoalizione] ADD CONSTRAINT [ref_CpCoalizione_Consultazione] FOREIGN KEY ([ConsultazioneId]) REFERENCES [Consultazione]([Id])

go

ALTER TABLE [Collegio] ADD CONSTRAINT [ref_Collegio_Consultazione] FOREIGN KEY ([ConsultazioneId]) REFERENCES [Consultazione]([Id])

go

ALTER TABLE [Consultazione] ADD CONSTRAINT [ref_Consultazione_Comune] FOREIGN KEY ([ComuneId]) REFERENCES [Comune]([Id])

go

ALTER TABLE [Lista] ADD CONSTRAINT [ref_Lista_CapoCoalizione] FOREIGN KEY ([CapoCoalizioneId]) REFERENCES [CapoCoalizione]([Id])

go

ALTER TABLE [Operatore] ADD CONSTRAINT [ref_Operatore_Consultazione] FOREIGN KEY ([ConsultazioneId]) REFERENCES [Consultazione]([Id])

go

ALTER TABLE [Rilevamento] ADD CONSTRAINT [ref_Rilevamento_Affluenza] FOREIGN KEY ([AffluenzaId]) REFERENCES [Affluenza]([Id])

go

ALTER TABLE [Rilevamento] ADD CONSTRAINT [ref_Rilevamento_Sezione] FOREIGN KEY ([SezioneId]) REFERENCES [Sezione]([Id])

go

ALTER TABLE [Scrutinio] ADD CONSTRAINT [ref_Scrutinio_Consultazione] FOREIGN KEY ([ConsultazioneId]) REFERENCES [Consultazione]([Id])

go

ALTER TABLE [Scrutinio] ADD CONSTRAINT [ref_Scrutinio_Sezione] FOREIGN KEY ([SezioneId]) REFERENCES [Sezione]([Id])

go

ALTER TABLE [ScrutinioCandidato] ADD CONSTRAINT [ref_ScrtnioCandidato_Candidato] FOREIGN KEY ([CandidatoId]) REFERENCES [Candidato]([Id])

go

ALTER TABLE [ScrutinioCandidato] ADD CONSTRAINT [ref_ScrutinioCandidato_Sezione] FOREIGN KEY ([SezioneId]) REFERENCES [Sezione]([Id])

go

ALTER TABLE [ScrutinioCapoCoalizione] ADD CONSTRAINT [ref_ScrtnCpClzn_CapoCoalizione] FOREIGN KEY ([CapoCoalizioneId]) REFERENCES [CapoCoalizione]([Id])

go

ALTER TABLE [ScrutinioCapoCoalizione] ADD CONSTRAINT [ref_ScrtnCpoCoalizione_Sezione] FOREIGN KEY ([SezioneId]) REFERENCES [Sezione]([Id])

go

ALTER TABLE [ScrutinioLista] ADD CONSTRAINT [ref_ScrutinioLista_Lista] FOREIGN KEY ([ListaId]) REFERENCES [Lista]([Id])

go

ALTER TABLE [ScrutinioLista] ADD CONSTRAINT [ref_ScrutinioLista_Sezione] FOREIGN KEY ([SezioneId]) REFERENCES [Sezione]([Id])

go

ALTER TABLE [SedeElettorale] ADD CONSTRAINT [ref_SdElettorale_Consultazione] FOREIGN KEY ([ConsultazioneId]) REFERENCES [Consultazione]([Id])

go

ALTER TABLE [Sezione] ADD CONSTRAINT [ref_Sezione_Operatore] FOREIGN KEY ([OperatoreId]) REFERENCES [Operatore]([Id])

go

ALTER TABLE [Sezione] ADD CONSTRAINT [ref_Sezione_SedeElettorale] FOREIGN KEY ([SedeElettoraleId]) REFERENCES [SedeElettorale]([Id])

go

ALTER TABLE [SezioneCollegio] ADD CONSTRAINT [ref_SezioneCollegio_Collegio] FOREIGN KEY ([CollegioId]) REFERENCES [Collegio]([Id])

go

ALTER TABLE [SezioneCollegio] ADD CONSTRAINT [ref_SezioneCollegio_Sezione] FOREIGN KEY ([SezioneId]) REFERENCES [Sezione]([Id])

go

-- Index 'idx_Affluenza_ConsultazioneId' was not detected in the database. It will be created
CREATE INDEX [idx_Affluenza_ConsultazioneId] ON [Affluenza]([ConsultazioneId])

go

-- Index 'idx_Candidato_ListaId' was not detected in the database. It will be created
CREATE INDEX [idx_Candidato_ListaId] ON [Candidato]([ListaId])

go

-- Index 'idx_CpClizione_ConsultazioneId' was not detected in the database. It will be created
CREATE INDEX [idx_CpClizione_ConsultazioneId] ON [CapoCoalizione]([ConsultazioneId])

go

-- Index 'idx_Collegio_ConsultazioneId' was not detected in the database. It will be created
CREATE INDEX [idx_Collegio_ConsultazioneId] ON [Collegio]([ConsultazioneId])

go

-- Index 'idx_Consultazione_ComuneId' was not detected in the database. It will be created
CREATE INDEX [idx_Consultazione_ComuneId] ON [Consultazione]([ComuneId])

go

-- Index 'idx_Lista_CapoCoalizioneId' was not detected in the database. It will be created
CREATE INDEX [idx_Lista_CapoCoalizioneId] ON [Lista]([CapoCoalizioneId])

go

-- Index 'idx_Operatore_ConsultazioneId' was not detected in the database. It will be created
CREATE INDEX [idx_Operatore_ConsultazioneId] ON [Operatore]([ConsultazioneId])

go

-- Index 'idx_Rilevamento_AffluenzaId' was not detected in the database. It will be created
CREATE INDEX [idx_Rilevamento_AffluenzaId] ON [Rilevamento]([AffluenzaId])

go

-- Index 'idx_Rilevamento_SezioneId' was not detected in the database. It will be created
CREATE INDEX [idx_Rilevamento_SezioneId] ON [Rilevamento]([SezioneId])

go

-- Index 'idx_Scrutinio_ConsultazioneId' was not detected in the database. It will be created
CREATE INDEX [idx_Scrutinio_ConsultazioneId] ON [Scrutinio]([ConsultazioneId])

go

-- Index 'idx_Scrutinio_SezioneId' was not detected in the database. It will be created
CREATE INDEX [idx_Scrutinio_SezioneId] ON [Scrutinio]([SezioneId])

go

-- Index 'idx_ScrtnCandidato_CandidatoId' was not detected in the database. It will be created
CREATE INDEX [idx_ScrtnCandidato_CandidatoId] ON [ScrutinioCandidato]([CandidatoId])

go

-- Index 'idx_ScrtnioCandidato_SezioneId' was not detected in the database. It will be created
CREATE INDEX [idx_ScrtnioCandidato_SezioneId] ON [ScrutinioCandidato]([SezioneId])

go

-- Index 'idx_ScrtnCpClzn_CpCoalizioneId' was not detected in the database. It will be created
CREATE INDEX [idx_ScrtnCpClzn_CpCoalizioneId] ON [ScrutinioCapoCoalizione]([CapoCoalizioneId])

go

-- Index 'idx_ScrtnCpCalizione_SezioneId' was not detected in the database. It will be created
CREATE INDEX [idx_ScrtnCpCalizione_SezioneId] ON [ScrutinioCapoCoalizione]([SezioneId])

go

-- Index 'idx_ScrutinioLista_ListaId' was not detected in the database. It will be created
CREATE INDEX [idx_ScrutinioLista_ListaId] ON [ScrutinioLista]([ListaId])

go

-- Index 'idx_ScrutinioLista_SezioneId' was not detected in the database. It will be created
CREATE INDEX [idx_ScrutinioLista_SezioneId] ON [ScrutinioLista]([SezioneId])

go

-- Index 'idx_SdElttrale_ConsultazioneId' was not detected in the database. It will be created
CREATE INDEX [idx_SdElttrale_ConsultazioneId] ON [SedeElettorale]([ConsultazioneId])

go

-- Index 'idx_Sezione_OperatoreId' was not detected in the database. It will be created
CREATE INDEX [idx_Sezione_OperatoreId] ON [Sezione]([OperatoreId])

go

-- Index 'idx_Sezione_SedeElettoraleId' was not detected in the database. It will be created
CREATE INDEX [idx_Sezione_SedeElettoraleId] ON [Sezione]([SedeElettoraleId])

go

-- Index 'idx_SezioneCollegio_CollegioId' was not detected in the database. It will be created
CREATE INDEX [idx_SezioneCollegio_CollegioId] ON [SezioneCollegio]([CollegioId])

go

-- Index 'idx_SezioneCollegio_SezioneId' was not detected in the database. It will be created
CREATE INDEX [idx_SezioneCollegio_SezioneId] ON [SezioneCollegio]([SezioneId])

go

