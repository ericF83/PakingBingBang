USE [ALTAI]
GO
/****** Object:  StoredProcedure [dbo].[SP_Packing_Insert]    Script Date: 01/16/2018 08:21:49 ******/
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
-- EJEMPLO			:  exec SP_Packing_Insert  'LISTA_ORDEN', 468, 1,4,null,'MOONCL'
-- ========================================================================================================================================
ALTER PROCEDURE [dbo].[SP_Packing_Insert]
@opcion VARCHAR(20),
@ID INT = NULL,
@ORDEN INT = NULL,
@CAJA INT = NULL,
@PRE_CINTO VARCHAR(30) = NULL,
@ART VARCHAR(30) = NULL
AS
BEGIN
	DECLARE @ID_NEW INT
	DECLARE @IDCAJA INT
	DECLARE @MODA VARCHAR(20)
	DECLARE @TOT INT 
	DECLARE @ROW INT
	DECLARE @EXISTE BIT
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
	
	IF @opcion = 'TOTAL_ORDEN'
	BEGIN 
		SET @TOT = (select SUM(Cantidad) from VentaD with(nolock) where ID = @ID)
		IF @TOT IS NULL
			SET @TOT = 0
		SELECT @TOT
	END
	
	IF @opcion = 'ACT_GRID'
	BEGIN
		
		SELECT isnull(SUM(Escaneados),0) FROM TBL_PACKING_DETALLE  WITH(NOLOCK) WHERE Id_Packing = @ID AND Id_Orden = @ORDEN and dbo.fnExtraerOpcionNumero(SubCuenta,'C') = @CAJA and Art = @ART
	END
	
	IF @opcion = 'VALIDA_CAJA'
	BEGIN
		
		SET @EXISTE = 0 

		DECLARE idcaja CURSOR FOR
			SELECT Id_Caja FROM TBL_PACKING_BOX WITH(NOLOCK) WHERE Id_Packing = @ID
		OPEN idcaja 
		FETCH idcaja INTO @ROW
		WHILE(@@FETCH_STATUS = 0)
		BEGIN
				IF EXISTS(SELECT * FROM TBL_PACKING_BOX WITH(NOLOCK) WHERE Id_Packing = @ID AND Id_Caja = @ROW AND (Tara IS NULL or PesoN IS NULL or PesoB IS NULL))
			BEGIN 	
				SET @EXISTE = 1
				BREAK
			END	
			FETCH idcaja INTO @ROW
	
		END
		CLOSE idcaja
		DEALLOCATE idcaja

		SELECT @EXISTE as ex
	END
	
	IF @opcion = 'CANCELA_CAJA'
	BEGIN
		DELETE TBL_PACKING_DETALLE WHERE Id_Caja = @ORDEN and Id_Packing = @ID
		DELETE TBL_PACKING_BOX WHERE Id_Packing = @ID AND Id_Caja = @ORDEN
		DELETE TBL_PRECINTO_PACKING WHERE Id_Packing = @ID AND Id_Caja = @ORDEN
		
		UPDATE TBL_PACKING_DETALLE WITH(ROWLOCK) SET Id_Caja = Id_Caja - 1 WHERE Id_Packing = @ID AND Id_Caja >= @ORDEN
		UPDATE TBL_PACKING_BOX WITH(ROWLOCK) SET Id_Caja = Id_Caja -1 WHERE Id_Packing = @ID AND Id_Caja >= @ORDEN
		UPDATE TBL_PRECINTO_PACKING WITH(ROWLOCK) SET Id_Caja = Id_Caja -1 WHERE Id_Packing = @ID AND Id_Caja >= @ORDEN
	END 
	
	IF @opcion = 'CONSUL_PREC'
	BEGIN
		SELECT Id_PreCinto FROM TBL_PRECINTO_PACKING WITH(NOLOCK) WHERE Id_Packing = @ID AND Id_Caja = @ORDEN
	END
	
	IF @opcion = 'TERMINAR_P'
	BEGIN
		UPDATE TBL_GENERA_PACKING WITH(ROWLOCK) SET Estatus = 'CONCLUIDO' WHERE Id_Packing = @ID
	END
	
	IF @opcion = 'PENDIENTE'
	BEGIN
		UPDATE TBL_PACKING_BOX WITH(ROWLOCK) SET Estatus = 'PENDIENTE' WHERE Id_Packing = @ID AND Id_Caja = @ORDEN
	END
	
	if @opcion =  "VERIFICA"
	BEGIN
			SET @IDCAJA = 0
			IF EXISTS(SELECT * FROM TBL_PACKING_BOX WITH(NOLOCK) WHERE Id_Packing = @ID AND Estatus = 'PENDIENTE')
			BEGIN
				SELECT @IDCAJA = MAX(Id_Caja) FROM TBL_PACKING_BOX WITH(NOLOCK) WHERE Id_Packing = @ID AND Estatus = 'PENDIENTE'
			END
			SELECT @IDCAJA
	END
	
	IF @opcion = "ART_EN_CP"
	BEGIN
		SELECT @TOT = SUM(Escaneados) FROM TBL_PACKING_DETALLE WITH(NOLOCK) WHERE Id_Packing = @ID AND Id_Caja = @ORDEN 
		SELECT @TOT
	END
	
	IF @opcion = 'PENDIENTES'
	BEGIN	
		
		if object_id('tempdb..#PivotPre') is not null
			drop table #PivotPre;
		CREATE TABLE #PivotPre(
			idpack INT null,			
			Precin VARCHAR(MAX) NULL
		)
	DECLARE @AUX VARCHAR(200)
	DECLARE @ID_AUX INT
	DECLARE @ID_orden INT 
	DECLARE @N INT
	DECLARE @CADENA VARCHAR(MAX) 
		SET @N = 1
		SET @CADENA = ''
		
	DECLARE IDP CURSOR FOR
		SELECT Id_Packing FROM TBL_GENERA_PACKING WITH(NOLOCK) WHERE Estatus = 'PENDIENTE'
	OPEN IDP
	FETCH IDP INTO @ID_AUX 
	WHILE (@@FETCH_STATUS = 0)
	BEGIN

		DECLARE IDPRE CURSOR FOR 
			SELECT DISTINCT  Id_Orden  FROM TBL_PACKING_DETALLE WITH(NOLOCK) WHERE Id_Packing = @ID_AUX
		OPEN IDPRE
		FETCH IDPRE INTO @ID_orden
		WHILE(@@FETCH_STATUS = 0)
		BEGIN			
				SET @AUX = (select  v.movid + ' : '+ c.Cliente + '  '+ c.Nombre AS Nombre from Venta v with(nolock) LEFT JOIN Cte c WITH(NOLOCK) ON c.Cliente = v.Cliente LEFT JOIN Agente a WITH(NOLOCK) ON a.Agente = v.Agente where Mov = 'Orden Surtido'  and v.MovID = cast(@ID_orden as varchar))
				SET @CADENA = @CADENA + @AUX + '/'		
			FETCH IDPRE INTO @ID_orden
		END
		CLOSE IDPRE
		DEALLOCATE IDPRE
	
		INSERT INTO #PivotPre
		SELECT  @ID_AUX ,@CADENA
		set @CADENA = ''
	
	FETCH IDP INTO @ID_AUX
	END
	CLOSE IDP
	DEALLOCATE IDP
	
	SELECT GP.Id_Packing,GP.Fecha_Creacion, P.Precin FROM TBL_GENERA_PACKING GP WITH(NOLOCK) INNER JOIN  #PivotPre P ON P.idpack = GP.Id_Packing	
		
	END
	
	IF @opcion = 'LISTA_ORDEN'
	BEGIN
		SELECT DISTINCT v.ID, Id_Orden FROM TBL_PACKING_DETALLE pd WITH(NOLOCK) LEFT JOIN Venta V WITH(NOLOCK) ON cast(pd.Id_Orden as varchar) = V.MovID AND V.Mov = 'Orden Surtido' WHERE Id_Packing = @ID
	END
		
	

END