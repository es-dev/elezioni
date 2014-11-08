ALTER TABLE [Scrutinio] DROP CONSTRAINT [ref_Scrutinio_Consultazione]

go

ALTER TABLE [Scrutinio] DROP CONSTRAINT [ref_Scrutinio_Sezione]

go

ALTER TABLE [ScrutinioCandidato] DROP CONSTRAINT [ref_ScrtnioCandidato_Candidato]

go

-- Index 'idx_Scrutinio_SezioneId' was detected in the database but with a different configuration. It will be recreated
DROP INDEX [idx_Scrutinio_SezioneId] ON [Scrutinio]

go

-- Index 'idx_Scrutinio_ConsultazioneId' was detected in the database but with a different configuration. It will be recreated
DROP INDEX [idx_Scrutinio_ConsultazioneId] ON [Scrutinio]

go

-- Index 'idx_ScrtnCandidato_CandidatoId' was detected in the database but with a different configuration. It will be recreated
DROP INDEX [idx_ScrtnCandidato_CandidatoId] ON [ScrutinioCandidato]

go

-- Column was read from database as: [Numero] int not null
-- modify column for field _numero
ALTER TABLE [Candidato] ALTER COLUMN [Numero] int NULL

go

-- Column was read from database as: [Numero] int not null
-- modify column for field _numero
ALTER TABLE [CapoCoalizione] ALTER COLUMN [Numero] int NULL

go

-- Column was read from database as: [Numero] int not null
-- modify column for field _numero
ALTER TABLE [Collegio] ALTER COLUMN [Numero] int NULL

go

-- Column was read from database as: [Numero] int not null
-- modify column for field _numero
ALTER TABLE [Lista] ALTER COLUMN [Numero] int NULL

go

-- Column was read from database as: [Donne] int not null
-- modify column for field _donne
ALTER TABLE [Rilevamento] ALTER COLUMN [Donne] int NULL

go

-- Column was read from database as: [Totale] int not null
-- modify column for field _totale
ALTER TABLE [Rilevamento] ALTER COLUMN [Totale] int NULL

go

-- Column was read from database as: [Uomini] int not null
-- modify column for field _uomini
ALTER TABLE [Rilevamento] ALTER COLUMN [Uomini] int NULL

go

-- Column was read from database as: [Bianche] int not null
-- modify column for field _bianche
ALTER TABLE [Scrutinio] ALTER COLUMN [Bianche] int NULL

go

-- Column was read from database as: [ConsultazioneId] int not null
-- modify column for field _consultazione
ALTER TABLE [Scrutinio] ALTER COLUMN [ConsultazioneId] int NULL

go

-- Column was read from database as: [Contestate] int not null
-- modify column for field _contestate
ALTER TABLE [Scrutinio] ALTER COLUMN [Contestate] int NULL

go

-- Column was read from database as: [Nulle] int not null
-- modify column for field _nulle
ALTER TABLE [Scrutinio] ALTER COLUMN [Nulle] int NULL

go

-- Column was read from database as: [SezioneId] int not null
-- modify column for field _sezione
ALTER TABLE [Scrutinio] ALTER COLUMN [SezioneId] int NULL

go

-- Column was read from database as: [Validi] int not null
-- modify column for field _validi
ALTER TABLE [Scrutinio] ALTER COLUMN [Validi] int NULL

go

-- Column was read from database as: [CandidatoId] int not null
-- modify column for field _candidato
ALTER TABLE [ScrutinioCandidato] ALTER COLUMN [CandidatoId] int NULL

go

-- Column was read from database as: [VotiAnnullati] int not null
-- modify column for field _votiAnnullati
ALTER TABLE [ScrutinioCandidato] ALTER COLUMN [VotiAnnullati] int NULL

go

-- Column was read from database as: [Voti] int not null
-- modify column for field _voti
ALTER TABLE [ScrutinioCapoCoalizione] ALTER COLUMN [Voti] int NULL

go

-- Column was read from database as: [VotiAnnullati] int not null
-- modify column for field _votiAnnullati
ALTER TABLE [ScrutinioCapoCoalizione] ALTER COLUMN [VotiAnnullati] int NULL

go

-- Column was read from database as: [Voti] int not null
-- modify column for field _voti
ALTER TABLE [ScrutinioLista] ALTER COLUMN [Voti] int NULL

go

-- Column was read from database as: [VotiAnnullati] int not null
-- modify column for field _votiAnnullati
ALTER TABLE [ScrutinioLista] ALTER COLUMN [VotiAnnullati] int NULL

go

-- Column was read from database as: [TotaleVotanti] int not null
-- modify column for field _totaleVotanti
ALTER TABLE [Sezione] ALTER COLUMN [TotaleVotanti] int NULL

go

-- Column was read from database as: [VotantiFemmine] int not null
-- modify column for field _votantiFemmine
ALTER TABLE [Sezione] ALTER COLUMN [VotantiFemmine] int NULL

go

-- Column was read from database as: [VotantiMaschi] int not null
-- modify column for field _votantiMaschi
ALTER TABLE [Sezione] ALTER COLUMN [VotantiMaschi] int NULL

go

ALTER TABLE [Scrutinio] ADD CONSTRAINT [ref_Scrutinio_Consultazione] FOREIGN KEY ([ConsultazioneId]) REFERENCES [Consultazione]([Id])

go

ALTER TABLE [Scrutinio] ADD CONSTRAINT [ref_Scrutinio_Sezione] FOREIGN KEY ([SezioneId]) REFERENCES [Sezione]([Id])

go

ALTER TABLE [ScrutinioCandidato] ADD CONSTRAINT [ref_ScrtnioCandidato_Candidato] FOREIGN KEY ([CandidatoId]) REFERENCES [Candidato]([Id])

go

-- Index 'idx_Scrutinio_SezioneId' was detected in the database but with a different configuration. It will be recreated
CREATE INDEX [idx_Scrutinio_SezioneId] ON [Scrutinio]([SezioneId])

go

-- Index 'idx_Scrutinio_ConsultazioneId' was detected in the database but with a different configuration. It will be recreated
CREATE INDEX [idx_Scrutinio_ConsultazioneId] ON [Scrutinio]([ConsultazioneId])

go

-- Index 'idx_ScrtnCandidato_CandidatoId' was detected in the database but with a different configuration. It will be recreated
CREATE INDEX [idx_ScrtnCandidato_CandidatoId] ON [ScrutinioCandidato]([CandidatoId])

go

