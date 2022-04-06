SET DATEFIRST 7
SET ANSI_NULLS OFF
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
SET LOCK_TIMEOUT -1  
SET QUOTED_IDENTIFIER OFF
SET NOCOUNT ON
SET IMPLICIT_TRANSACTIONS OFF
GO
-- ========================================================================================================================================    
-- NOMBRE           : SP_Cat_Modelo
-- AUTOR            : ERIC F MARTINEZ
-- FECHA CREACION   : 2017-10-03
-- DESARROLLO       : Formato Pedido
-- MODULO           :   
-- DESCRIPCION      :  
-- EJEMPLO			:  exec SP_Cat_Modelo 
-- ========================================================================================================================================
CREATE PROCEDURE SP_RepPacking 
@Id_Packing INT
AS 
BEGIN

	if object_id('tempdb..#Reporte') is not null
	drop table #Reporte;
	
	CREATE TABLE #Reporte (
	idcaja INT NULL,
	Dimenciones VARCHAR(20) NULL,
	Tara Decimal(10,2) NULL,
	PesoB DECIMAL(10,2) NULL,
	PesoN DECIMAL(10,2) NULL,
	Articulo VARCHAR(20) NULL,
	Descripcion VARCHAR(50) NULL,
	OrdenSurtido VARCHAR(20) NULL,
	Cant1 INT NULL,
	Cant2 INT NULL,
	Cant3 INT NULL,
	Cant4 INT NULL,
	Cant5 INT NULL,
	Cant6 INT NULL,
	Cant7 INT NULL,
	Cant8 INT NULL,
	Cant9 INT NULL,
	Cant10 INT NULL,
	Cant11 INT NULL,
	Cant12 INT NULL,
	Cant13 INt NULL,
	Cant14 INT NULL,
	Cant15 INT NULL
	)
	
	INSERT INTO #Reporte
	SELECT PB.Id_Caja, PB.Dimensiones, PB.Tara, PB.PesoB, PB.PesoN,PD.Art,A.Descripcion1,PD.Id_Orden,
	CASE WHEN ISNULL(dbo.fnExtraerOpcionNumero(PD.SubCuenta,'T'),-1) IN (0,28,240,98,0,999) THEN PD.Escaneados ELSE NULL END Cant1,  
	CASE WHEN dbo.fnExtraerOpcionNumero(PD.SubCuenta,'T') IN (1,29,245,99) THEN PD.Escaneados ELSE NULL END Cant2,  
	CASE WHEN dbo.fnExtraerOpcionNumero(PD.SubCuenta,'T') IN (3,30,250,100) THEN PD.Escaneados ELSE NULL END Cant3,  
	CASE WHEN dbo.fnExtraerOpcionNumero(PD.SubCuenta,'T') IN (5,31,255,101) THEN PD.Escaneados  ELSE NULL END Cant4,  
	CASE WHEN dbo.fnExtraerOpcionNumero(PD.SubCuenta,'T') IN (7,32,260,102) THEN PD.Escaneados ELSE NULL END Cant5,  
	CASE WHEN dbo.fnExtraerOpcionNumero(PD.SubCuenta,'T') IN (9,33,265,103) THEN PD.Escaneados ELSE NULL END Cant6,  
	CASE WHEN dbo.fnExtraerOpcionNumero(PD.SubCuenta,'T') IN (11,34,270,104) THEN PD.Escaneados ELSE NULL END Cant7,  
	CASE WHEN dbo.fnExtraerOpcionNumero(PD.SubCuenta,'T') IN (13,36,275,105) THEN PD.Escaneados ELSE NULL END Cant8,  
	CASE WHEN dbo.fnExtraerOpcionNumero(PD.SubCuenta,'T') IN (15,38,280,106) THEN PD.Escaneados ELSE NULL END Cant9,  
	CASE WHEN dbo.fnExtraerOpcionNumero(PD.SubCuenta,'T') IN (17,40,285,107) THEN PD.Escaneados ELSE NULL END Cant10,  
	CASE WHEN dbo.fnExtraerOpcionNumero(PD.SubCuenta,'T') IN (19,42,290,108) THEN PD.Escaneados ELSE NULL END Cant11,  
	CASE WHEN dbo.fnExtraerOpcionNumero(PD.SubCuenta,'T') IN (21,44,295,109) THEN PD.Escaneados ELSE NULL END Cant12,  
	CASE WHEN dbo.fnExtraerOpcionNumero(PD.SubCuenta,'T') IN (23,46,300,110) THEN PD.Escaneados ELSE NULL END Cant13,  
	CASE WHEN dbo.fnExtraerOpcionNumero(PD.SubCuenta,'T') IN (25,48,305,111) THEN PD.Escaneados ELSE NULL END Cant14,  
	CASE WHEN dbo.fnExtraerOpcionNumero(PD.SubCuenta,'T') IN (50,310,112) THEN PD.Escaneados ELSE NULL END Cant15
	FROM TBL_PACKING_BOX PB WITH(NOLOCK) INNER JOIN TBL_PACKING_DETALLE PD WITH(NOLOCK) ON PB.Id_Caja = PD.Id_Caja AND PB.Id_Packing = PD.Id_Packing LEFT JOIN Art A WITH(NOLOCK) ON A.Articulo = PD.Art  WHERE PB.Id_Packing = @Id_Packing  
	
	
	SELECT idcaja,Dimenciones, Tara, PesoB, PesoN, Articulo,Descripcion,OrdenSurtido 
	,SUM(Cant1) as Cant1
	,SUM(cant2) as Cant2
	,SUM(Cant3) as Cant3
	,SUM(Cant4) as Cant4
	,SUM(Cant5) as Cant5
	,SUM(Cant6) as Cant6
	,SUM(Cant7) as Cant7
	,SUM(Cant8) as Cant8
	,SUM(Cant9) as Cant9
	,SUM(Cant10) as Cant10
	,SUM(Cant11) as Cant11
	,SUM(Cant12) as Cant12
	,SUM(Cant13) as Cant13
	,SUM(Cant14) as Cant14
	,SUM(Cant15) as Cant15
	FROM #Reporte group by idcaja,Dimenciones, Tara, PesoB, PesoN, Articulo,Descripcion,OrdenSurtido
	
	if object_id('tempdb..#Reporte') is not null
	drop table #Reporte;
END