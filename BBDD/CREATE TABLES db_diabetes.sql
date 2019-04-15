USE db_diabetes;
-- --------------------------------------------------------------------------
-- CREATE TABLE USUARIOS IF NOT EXISTS
-- --------------------------------------------------------------------------
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Usuarios')
	BEGIN
		PRINT '> La tabla USUARIOS creada'
		CREATE TABLE Usuarios
		( 
			id_usuario bigint IDENTITY PRIMARY KEY ,
			nombre varchar(25) NOT NULL,
			apellido varchar(50)  NOT NULL,
			usuario varchar (50) NULL,
			passcode varchar (50) NOT NULL,
			correo varchar (50) NOT NULL UNIQUE, 
			edad tinyint NOT NULL,
			peso tinyint  NOT NULL,					--controlar en backend que no supere 255, valor expresado en Kg
			altura decimal(10,2) NOT NULL,			-- valor expresado en cm
			glucemia_min tinyint NOT NULL,			--rango minimo lo introduce el usuario y usualmente ronda los 80 mg/dl
			glucemia_max tinyint NOT NULL,			--rango maximo lo introduce el usuario y usualmente ronda los 120 mg/dl
			r_insulina_carb tinyint NOT NULL,		-- valor expresado en U/CH
			r_insulina_gluc tinyint NOT NULL,		-- valor expresado en U/glucemia
			total_insulina_diaria SMALLINT NOT NULL
		);
	END
ELSE
	BEGIN
		PRINT '> La tabla USUARIOS existe'
	END
-- --------------------------------------------------------------------------
-- CREATE TABLE ANALISIS IF NOT EXIST
-- --------------------------------------------------------------------------
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Analisis')
	BEGIN
		PRINT '> La tabla ANALISIS creada'
		CREATE TABLE Analisis
		( 
			id_analisis bigint PRIMARY KEY IDENTITY,
			valor tinyint  NOT NULL,
			fecha_hora datetime NOT NULL,
			intensidad_deporte tinyint NULL, -- especificar mediante a back/front entre 0 y 100
			id_usuario bigint NOT NULL,
			CONSTRAINT FK_id_usuario
			FOREIGN KEY (id_usuario)
			REFERENCES usuarios(id_usuario)
		);
	END
ELSE
	BEGIN
		PRINT '> La tabla ANALISIS existe'
	END
-- --------------------------------------------------------------------------
-- INSERT DEMO ANALISIS
-- --------------------------------------------------------------------------
/*
INSERT INTO ANALISIS (valor, fecha_hora, intensidad_deporte, id_usuario) VALUES 
(50, SYSDATETIME(), 100, 1);

select * from analisis;
*/
-- --------------------------------------------------------------------------
-- CREATE TABLE ALIMENTOS IF NOT EXIST
-- --------------------------------------------------------------------------
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Alimentos')
	BEGIN
		PRINT '> La tabla ALIMENTOS creada'
		CREATE TABLE Alimentos
		( 
			id_alimento bigint PRIMARY KEY IDENTITY,
			nombre varchar(100) NOT NULL,
			carbohidratos decimal(10,2) NOT NULL,
			proteinas decimal(10,2) NOT NULL,
			grasas decimal(10,2) NOT NULL
		);
	END
ELSE
	BEGIN
		PRINT '> La tabla ALIMENTOS existe'
	END
-- --------------------------------------------------------------------------
-- INSERT DEMO ALIMENTOS
-- --------------------------------------------------------------------------
/*
INSERT INTO ALIMENTOS (nombre, carbohidratos, proteinas, grasas) VALUES
('AGUACATE', 30, 5, 60.66);
SELECT * FROM alimentos;
*/
-- --------------------------------------------------------------------------
-- CREATE TABLE COMIDAS IF NOT EXIST
-- --------------------------------------------------------------------------
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Comidas')
	BEGIN
		PRINT '> La tabla COMIDAS creada'
		CREATE TABLE Comidas
		( 
			id_comida bigint PRIMARY KEY IDENTITY,
			fecha_hora datetime NOT NULL,
			tipocomida VARCHAR(25),
			carbo_totales decimal(10,2),
			id_analisis bigint,
			FOREIGN KEY (id_analisis) REFERENCES analisis(id_analisis)
		);
	END
ELSE
	BEGIN
		PRINT '> La tabla COMIDAS existe'
	END
-- --------------------------------------------------------------------------
-- INSERT DEMO COMIDAS
-- --------------------------------------------------------------------------
/*
INSERT INTO COMIDAS (fecha_hora, tipocomida, carbo_totales, id_analisis) VALUES
(SYSDATETIME(), 'DESAYUNO', 500, 1);
INSERT INTO COMIDAS (fecha_hora, tipocomida, carbo_totales, id_analisis) VALUES
(SYSDATETIME(), 'DESAYUNO', 500, NULL);
SELECT * FROM comidas;
*/
-- --------------------------------------------------------------------------
-- CREATE TABLE COMIDAS_ALIMENTOS (N:M)
-- --------------------------------------------------------------------------
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Comidas_alimentos')
	BEGIN
		PRINT '> La tabla COMIDAS_ALIMENTOS (N:M) creada'
		CREATE TABLE Comidas_alimentos
		( 
			id_comidas_alimentos bigint PRIMARY KEY IDENTITY,
			id_comida bigint,
			id_alimento bigint,
			CONSTRAINT FK_id_alimento
			FOREIGN KEY (id_alimento)
			REFERENCES alimentos(id_alimento),
			CONSTRAINT FK_id_comida2
			FOREIGN KEY (id_comida)
			REFERENCES comidas(id_comida)
		);
	END
ELSE
	BEGIN
		PRINT '> La tabla COMIDAS_ALIMENTOS (N:M) existe'
	END
-- --------------------------------------------------------------------------
-- INSERT DEMO COMIDAS_ALIMENTOS
-- --------------------------------------------------------------------------
/*
INSERT INTO comidas_alimentos (id_comida, id_alimento) VALUES (1, 1);
select * from comidas_alimentos;*/

-- https://dataedo.com/kb/tools/ssms/create-database-diagram
-- https://www.promotic.eu/en/pmdoc/Subsystems/Db/MsSQL/DataTypes.htm