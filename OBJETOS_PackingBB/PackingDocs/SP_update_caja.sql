SET DATEFIRST 7
SET ANSI_NULLS OFF
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
SET LOCK_TIMEOUT -1  
SET QUOTED_IDENTIFIER OFF
SET NOCOUNT ON
SET IMPLICIT_TRANSACTIONS OFF
GO
-- ========================================================================================================================================    
-- NOMBRE           : SP_update_caja
-- AUTOR            : ERIC F MARTINEZ
-- FECHA CREACION   : 2017-12-22
-- DESARROLLO       : packing
-- MODULO           :   
-- DESCRIPCION      :  
-- EJEMPLO			:  exec SP_update_caja 
-- ========================================================================================================================================
CREATE PROCEDURE SP_update_caja
@idpack INT,
@idcaja INT,
@IDdimenciones INT,
@PesoB DECIMAL(10,2),
@PesoN DECIMAL(10,2),
@Tara DECIMAL(10,2)
AS 
BEGIN
	DECLARE @DIM VARCHAR(20)
	
	
	SELECT @DIM = DIMENCIONES FROM TBL_MODA_CAJAS WITH(NOLOCK) WHERE ID = @IDdimenciones
	
	UPDATE TBL_PACKING_BOX WITH(ROWLOCK) SET Dimensiones = @DIM , Tara = @Tara, PesoN = @PesoN, PesoB = @PesoB WHERE Id_Caja = @idcaja and Id_Packing = @idpack


END 