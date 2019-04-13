IF DB_ID('db_diabetes') IS NULL
	BEGIN
		CREATE DATABASE db_diabetes;
		PRINT 'Creada la bbdd DB_DIABETES.'
    END;
ELSE
	BEGIN
		PRINT 'La bbdd DB_DIABETES existe.'
	END;