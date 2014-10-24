-- add column for field _numero
ALTER TABLE [Sezione] ADD [Numero] int NULL

go

UPDATE [Sezione] SET [Numero] = 0

go

ALTER TABLE [Sezione] ALTER COLUMN [Numero] int NOT NULL

go

