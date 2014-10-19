-- DataLayer.Affluenza
CREATE TABLE [Affluenza] (
    [Orario] datetime NOT NULL,             -- _orario
    [Id] int NOT NULL,                      -- _id
    [ConsultazioneId] int NOT NULL,         -- _consultazione
    CONSTRAINT [pk_Affluenza] PRIMARY KEY ([Id])
)
go

-- DataLayer.Candidato
CREATE TABLE [Candidato] (
    [Numero] int NOT NULL,                  -- _numero
    [Nome] varchar(255) NULL,               -- _nome
    [ListaId] int NOT NULL,                 -- _lista
    [Id] int NOT NULL,                      -- _id
    [Cognome] varchar(255) NULL,            -- _cognome
    CONSTRAINT [pk_Candidato] PRIMARY KEY ([Id])
)
go

-- DataLayer.CapoCoalizione
CREATE TABLE [CapoCoalizione] (
    [Simbolo] varchar(255) NULL,            -- _simbolo
    [Numero] int NOT NULL,                  -- _numero
    [Id] int NOT NULL,                      -- _id
    [Descrizione] varchar(255) NULL,        -- _descrizione
    [ConsultazioneId] int NOT NULL,         -- _consultazione
    CONSTRAINT [pk_CapoCoalizione] PRIMARY KEY ([Id])
)
go

-- DataLayer.Collegio
CREATE TABLE [Collegio] (
    [Numero] int NOT NULL,                  -- _numero
    [Id] int NOT NULL,                      -- _id
    [Descrizione] varchar(255) NULL,        -- _descrizione
    [ConsultazioneId] int NOT NULL,         -- _consultazione
    CONSTRAINT [pk_Collegio] PRIMARY KEY ([Id])
)
go

-- DataLayer.Comune
CREATE TABLE [Comune] (
    [Provincia] varchar(255) NULL,          -- _provincia
    [NumeroSezioni] int NOT NULL,           -- _numeroSezioni
    [Nome] varchar(255) NULL,               -- _nome
    [Id] int NOT NULL,                      -- _id
    [Descrizione] varchar(255) NULL,        -- _descrizione
    [CodiceISTAT] varchar(255) NULL,        -- _codiceISTAT
    CONSTRAINT [pk_Comune] PRIMARY KEY ([Id])
)
go

-- DataLayer.Consultazione
CREATE TABLE [Consultazione] (
    [Tipo] varchar(255) NULL,               -- _tipo
    [Numero] int NOT NULL,                  -- _numero
    [Id] int NOT NULL,                      -- _id
    [Descrizione] varchar(255) NULL,        -- _descrizione
    [ComuneId] int NOT NULL,                -- _comune
    CONSTRAINT [pk_Consultazione] PRIMARY KEY ([Id])
)
go

-- DataLayer.Lista
CREATE TABLE [Lista] (
    [Simbolo] varchar(255) NULL,            -- _simbolo
    [Numero] int NOT NULL,                  -- _numero
    [Id] int NOT NULL,                      -- _id
    [Descrizione] varchar(255) NULL,        -- _descrizione
    [CapoCoalizioneId] int NOT NULL,        -- _capoCoalizione
    CONSTRAINT [pk_Lista] PRIMARY KEY ([Id])
)
go

-- DataLayer.Operatore
CREATE TABLE [Operatore] (
    [Utente] tinyint NOT NULL,              -- _utente
    [Username] varchar(255) NULL,           -- _username
    [Telefono] varchar(255) NULL,           -- _telefono
    [Supervisor] tinyint NOT NULL,          -- _supervisor
    [passwd] varchar(255) NULL,             -- _password
    [Nome] varchar(255) NULL,               -- _nome
    [Id] int NOT NULL,                      -- _id
    [Email] varchar(255) NULL,              -- _email
    [ConsultazioneId] int NOT NULL,         -- _consultazione
    [ConfermaPassword] varchar(255) NULL,   -- _confermaPassword
    [Cognome] varchar(255) NULL,            -- _cognome
    [Amministratore] tinyint NOT NULL,      -- _amministratore
    CONSTRAINT [pk_Operatore] PRIMARY KEY ([Id])
)
go

-- DataLayer.Rilevamento
CREATE TABLE [Rilevamento] (
    [Uomini] int NOT NULL,                  -- _uomini
    [Totale] int NOT NULL,                  -- _totale
    [SezioneId] int NOT NULL,               -- _sezione
    [Id] int NOT NULL,                      -- _id
    [Donne] int NOT NULL,                   -- _donne
    [AffluenzaId] int NOT NULL,             -- _affluenza
    CONSTRAINT [pk_Rilevamento] PRIMARY KEY ([Id])
)
go

-- DataLayer.Scrutinio
CREATE TABLE [Scrutinio] (
    [Validi] int NOT NULL,                  -- _validi
    [SezioneId] int NOT NULL,               -- _sezione
    [Nulle] int NOT NULL,                   -- _nulle
    [Id] int NOT NULL,                      -- _id
    [Contestate] int NOT NULL,              -- _contestate
    [ConsultazioneId] int NOT NULL,         -- _consultazione
    [Bianche] int NOT NULL,                 -- _bianche
    CONSTRAINT [pk_Scrutinio] PRIMARY KEY ([Id])
)
go

-- DataLayer.ScrutinioCandidato
CREATE TABLE [ScrutinioCandidato] (
    [VotiAnnullati] int NOT NULL,           -- _votiAnnullati
    [Voti] int NOT NULL,                    -- _voti
    [SezioneId] int NOT NULL,               -- _sezione
    [Id] int NOT NULL,                      -- _id
    [CandidatoId] int NOT NULL,             -- _candidato
    CONSTRAINT [pk_ScrutinioCandidato] PRIMARY KEY ([Id])
)
go

-- DataLayer.ScrutinioCapoCoalizione
CREATE TABLE [ScrutinioCapoCoalizione] (
    [VotiAnnullati] int NOT NULL,           -- _votiAnnullati
    [Voti] int NOT NULL,                    -- _voti
    [SezioneId] int NOT NULL,               -- _sezione
    [Id] int NOT NULL,                      -- _id
    [CapoCoalizioneId] int NOT NULL,        -- _capoCoalizione
    CONSTRAINT [pk_ScrutinioCapoCoalizione] PRIMARY KEY ([Id])
)
go

-- DataLayer.ScrutinioLista
CREATE TABLE [ScrutinioLista] (
    [VotiAnnullati] int NOT NULL,           -- _votiAnnullati
    [Voti] int NOT NULL,                    -- _voti
    [SezioneId] int NOT NULL,               -- _sezione
    [ListaId] int NOT NULL,                 -- _lista
    [Id] int NOT NULL,                      -- _id
    CONSTRAINT [pk_ScrutinioLista] PRIMARY KEY ([Id])
)
go

-- DataLayer.SedeElettorale
CREATE TABLE [SedeElettorale] (
    [Telefono] varchar(255) NULL,           -- _telefono
    [Responsabile] varchar(255) NULL,       -- _responsabile
    [Mappa] varchar(255) NULL,              -- _mappa
    [Indirizzo] varchar(255) NULL,          -- _indirizzo
    [Id] int NOT NULL,                      -- _id
    [Fax] varchar(255) NULL,                -- _fax
    [ConsultazioneId] int NOT NULL,         -- _consultazione
    CONSTRAINT [pk_SedeElettorale] PRIMARY KEY ([Id])
)
go

-- DataLayer.Sezione
CREATE TABLE [Sezione] (
    [VotantiMaschi] int NOT NULL,           -- _votantiMaschi
    [VotantiFemmine] int NOT NULL,          -- _votantiFemmine
    [TotaleVotanti] int NOT NULL,           -- _totaleVotanti
    [SedeElettoraleId] int NOT NULL,        -- _sedeElettorale
    [OperatoreId] int NOT NULL,             -- _operatore
    [Id] int NOT NULL,                      -- _id
    CONSTRAINT [pk_Sezione] PRIMARY KEY ([Id])
)
go

-- DataLayer.SezioneCollegio
CREATE TABLE [SezioneCollegio] (
    [SezioneId] int NOT NULL,               -- _sezione
    [Id] int NOT NULL,                      -- _id
    [CollegioId] int NOT NULL,              -- _collegio
    CONSTRAINT [pk_SezioneCollegio] PRIMARY KEY ([Id])
)
go

CREATE INDEX [idx_Affluenza_ConsultazioneId] ON [Affluenza]([ConsultazioneId])
go

CREATE INDEX [idx_Candidato_ListaId] ON [Candidato]([ListaId])
go

CREATE INDEX [idx_CpClizione_ConsultazioneId] ON [CapoCoalizione]([ConsultazioneId])
go

CREATE INDEX [idx_Collegio_ConsultazioneId] ON [Collegio]([ConsultazioneId])
go

CREATE INDEX [idx_Consultazione_ComuneId] ON [Consultazione]([ComuneId])
go

CREATE INDEX [idx_Lista_CapoCoalizioneId] ON [Lista]([CapoCoalizioneId])
go

CREATE INDEX [idx_Operatore_ConsultazioneId] ON [Operatore]([ConsultazioneId])
go

CREATE INDEX [idx_Rilevamento_AffluenzaId] ON [Rilevamento]([AffluenzaId])
go

CREATE INDEX [idx_Rilevamento_SezioneId] ON [Rilevamento]([SezioneId])
go

CREATE INDEX [idx_Scrutinio_ConsultazioneId] ON [Scrutinio]([ConsultazioneId])
go

CREATE INDEX [idx_Scrutinio_SezioneId] ON [Scrutinio]([SezioneId])
go

CREATE INDEX [idx_ScrtnCandidato_CandidatoId] ON [ScrutinioCandidato]([CandidatoId])
go

CREATE INDEX [idx_ScrtnioCandidato_SezioneId] ON [ScrutinioCandidato]([SezioneId])
go

CREATE INDEX [idx_ScrtnCpClzn_CpCoalizioneId] ON [ScrutinioCapoCoalizione]([CapoCoalizioneId])
go

CREATE INDEX [idx_ScrtnCpCalizione_SezioneId] ON [ScrutinioCapoCoalizione]([SezioneId])
go

CREATE INDEX [idx_ScrutinioLista_ListaId] ON [ScrutinioLista]([ListaId])
go

CREATE INDEX [idx_ScrutinioLista_SezioneId] ON [ScrutinioLista]([SezioneId])
go

CREATE INDEX [idx_SdElttrale_ConsultazioneId] ON [SedeElettorale]([ConsultazioneId])
go

CREATE INDEX [idx_Sezione_OperatoreId] ON [Sezione]([OperatoreId])
go

CREATE INDEX [idx_Sezione_SedeElettoraleId] ON [Sezione]([SedeElettoraleId])
go

CREATE INDEX [idx_SezioneCollegio_CollegioId] ON [SezioneCollegio]([CollegioId])
go

CREATE INDEX [idx_SezioneCollegio_SezioneId] ON [SezioneCollegio]([SezioneId])
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

