USE [ALTAI]
GO
/****** Object:  StoredProcedure [dbo].[SP_Packing_DetCaja]    Script Date: 01/16/2018 08:21:17 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
-- ========================================================================================================================================
-- NOMBRE           : SP_Packing_DetCaja 
-- AUTOR            : ERIC F MARTINEZ
-- FECHA CREACION   : 2017-11-15 
-- DESARROLLO       : PackicgBingBang
-- MODULO           :   
-- DESCRIPCION      : SP para insertar el detalle de articulos en las cajas
-- EJEMPLO			:  
-- ========================================================================================================================================
ALTER PROCEDURE [dbo].[SP_Packing_DetCaja]
	@Id_Caja INT,
	@Id_Packing INT,
	@Id_Orden INT,
	@Art VARCHAR(20),
	@SubCuenta VARCHAR(20),
	@Cantidad INT,
	@Escaneados INT,
	@Codigo VARCHAR(20)
AS
BEGIN
	if not exists(SELECT * FROM TBL_PACKING_DETALLE WITH(NOLOCK) WHERE Id_Caja = @Id_Caja AND Id_Packing = @Id_Packing AND Id_Orden = @Id_Orden AND Art = @Art AND SubCuenta = @SubCuenta)
	BEGIN
		INSERT INTO TBL_PACKING_DETALLE VALUES (@Id_Caja,@Id_Packing,@Id_Orden,@Art,@SubCuenta,@Cantidad,@Escaneados,@Codigo)

	END	
	ELSE
	BEGIN
		
			UPDATE TBL_PACKING_DETALLE WITH(ROWLOCK) SET Escaneados = Escaneados + @Escaneados WHERE Id_Caja = @Id_Caja AND Id_Packing = @Id_Packing AND Id_Orden = @Id_Orden AND Art = @Art AND SubCuenta = @SubCuenta
		
	END
END

