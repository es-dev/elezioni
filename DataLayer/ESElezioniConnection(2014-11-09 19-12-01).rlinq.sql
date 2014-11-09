-- add column for field _dataFine
ALTER TABLE [Consultazione] ADD [DataFine] datetime NULL

go

UPDATE [Consultazione] SET [DataFine] = getdate()

go

ALTER TABLE [Consultazione] ALTER COLUMN [DataFine] datetime NOT NULL

go

-- add column for field _dataInizio
ALTER TABLE [Consultazione] ADD [DataInizio] datetime NULL

go

UPDATE [Consultazione] SET [DataInizio] = getdate()

go

ALTER TABLE [Consultazione] ALTER COLUMN [DataInizio] datetime NOT NULL

go

