USE [ALTAI]
GO
/****** Object:  StoredProcedure [dbo].[SP_Packing_Insert]    Script Date: 12/21/2017 08:47:56 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
-- ========================================================================================================================================
-- NOMBRE           : SP_Packing_Insert 
-- AUTOR            : ERIC F MARTINEZ
-- FECHA CREACION   : 2017-11-14 
-- DESARROLLO       : PackicgBingBang
-- MODULO           :   
-- DESCRIPCION      : SP para generar registros en las tablas del packing
-- EJEMPLO			:  exec SP_Packing_Insert  'TOTAL_ART', 301 
-- ========================================================================================================================================
ALTER PROCEDURE [dbo].[SP_Packing_Insert]
@opcion VARCHAR(20),
@ID INT = NULL,
@ORDEN INT = NULL,
@CAJA INT = NULL,
@PRE_CINTO VARCHAR(30) = NULL
AS
BEGIN
	DECLARE @ID_NEW INT
	DECLARE @IDCAJA INT
	DECLARE @MODA VARCHAR(20)
	DECLARE @TOT INT 
	SET @ID_NEW = 0
	
	IF @opcion = 'G_IDPACKING'
	BEGIN
		INSERT INTO TBL_GENERA_PACKING VALUES (GETDATE(),'PENDIENTE',NULL)
		SET @ID_NEW = @@IDENTITY
		SELECT @ID_NEW
	END
	
	IF @opcion = "G_DETALLE_PACK"
	BEGIN
		INSERT TBL_PACKING_ORDEN VALUES(@ID,@ORDEN)
	END
	
	IF @opcion = "G_IDBOX"
	BEGIN 
		IF(SELECT COUNT(*) FROM TBL_PACKING_BOX WITH(NOLOCK) WHERE Id_Packing = @ID) > 0
		BEGIN
			SELECT @IDCAJA = MAX(Id_Caja) FROM TBL_PACKING_BOX WITH(NOLOCK) WHERE Id_Packing = @ID 
			
			IF(SELECT Estatus FROM TBL_PACKING_BOX WITH(NOLOCK) WHERE Id_Packing = @ID AND Id_Caja = @IDCAJA ) = 'ABIERTA'
			BEGIN
				SET @ID_NEW = @IDCAJA
			END
			ELSE
			BEGIN
				SET @ID_NEW = @IDCAJA + 1
				INSERT INTO TBL_PACKING_BOX (Id_Packing,Id_Caja,Estatus)VALUES(@ID,@ID_NEW,'ABIERTA')
			END
		END
		ELSE
		BEGIN
			SET @IDCAJA = 1
			INSERT INTO TBL_PACKING_BOX (Id_Packing,Id_Caja,Estatus)VALUES(@ID,@IDCAJA,'ABIERTA')
			SET @ID_NEW = @IDCAJA
		END
		SELECT @ID_NEW
	END
	
	IF @opcion = 'C_CERRARCAJA'
	BEGIN
		UPDATE TBL_PACKING_BOX WITH(ROWLOCK) SET Estatus = 'CERRADA' WHERE Id_Packing = @ID AND Id_Caja = @ORDEN		
	END
	
	IF @opcion = 'G_DELETE'
	BEGIN
		
		DELETE TBL_PACKING_BOX WHERE Id_Caja = @ORDEN AND Id_Packing = @ID
		DELETE TBL_PACKING_DETALLE WHERE Id_Caja = @ORDEN AND Id_Packing = @ID
		DELETE TBL_PRECINTO_PACKING WHERE Id_Caja = @ORDEN AND Id_Packing = @ID
 	END
 	
 	if object_id('tempdb..#CANCELA') is not null
			drop table #CANCELA;
			
	CREATE TABLE #CANCELA (
		Art VARCHAR(30) NULL,
		SubCuenta VARCHAR(30) NULL
	)
 	
 	IF @opcion = 'G_CANCELA'
 	BEGIN
 		INSERT INTO #CANCELA
 		SELECT Art,SubCuenta  FROM TBL_PACKING_DETALLE WHERE Id_Caja = @CAJA AND Id_Packing = @ID AND Id_Orden = @ORDEN
 		
 		SELECT * FROM #CANCELA
 	END
 	
	IF @opcion = 'G_IDoRDEN'
	BEGIN
		SELECT @ID_NEW = CAST(MovID AS INT) FROM Venta WITH(NOLOCK) WHERE ID = @ID;
		SELECT @ID_NEW
	END
	
	IF @opcion = 'EXISTEN_ART'
	BEGIN
		IF NOT EXISTS(SELECT * FROM TBL_PACKING_DETALLE WITH(NOLOCK) WHERE Id_Packing = @ID AND Id_Caja = @CAJA AND Id_Orden = @ORDEN)
			SET @ID_NEW = 1
		ELSE
			SET @ID_NEW = 0
			
		SELECT @ID_NEW
	END
	
	IF @opcion = 'UPDATE_MODA'
	BEGIN
		SELECT @MODA = DIMENCIONES FROM TBL_MODA_CAJAS WITH(NOLOCK) WHERE ID = @CAJA
		UPDATE TBL_PACKING_BOX WITH(ROWLOCK) SET Dimensiones = @MODA WHERE Id_Packing = @ID AND Id_Caja = @ORDEN		
	END
	
	IF @opcion = 'ADD_PRECINTO'
	BEGIN
		INSERT INTO TBL_PRECINTO_PACKING VALUES (@PRE_CINTO,@ID,@CAJA)
	END
	
	IF @opcion = 'ELIMINA_TODO'
	BEGIN
		DELETE TBL_GENERA_PACKING WHERE Id_Packing = @ID
		DELETE TBL_PACKING_ORDEN WHERE Id_Packing = @ID
		DELETE TBL_PACKING_DETALLE WHERE Id_Packing = @ID
		DELETE TBL_PACKING_BOX WHERE Id_Packing = @ID
		DELETE TBL_PRECINTO_PACKING WHERE Id_Packing = @ID
	END
	
	IF @opcion = 'TOTAL_ART'
	BEGIN
		 
		SET @TOT = (SELECT SUM(Escaneados) AS ESCA FROM TBL_PACKING_DETALLE WITH(NOLOCK) WHERE Id_Packing = @ID)
		IF @TOT IS NULL
			SET @TOT = 0
		SELECT @TOT
	END
	
	--IF @opcion <> 'G_CANCELA'
	--	SELECT @ID_NEW
	--ELSE
	--BEGIN
	--	SELECT * FROM #CANCELA 
	--END
		
	

END