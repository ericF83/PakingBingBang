USE [ALTAI]
GO
/****** Object:  StoredProcedure [dbo].[SP_Detalle_Packing]    Script Date: 01/16/2018 08:20:44 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
-- ========================================================================================================================================
-- NOMBRE           : SP_Detalle_Packing 
-- AUTOR            : ERIC F MARTINEZ
-- FECHA CREACION   : 2017-11-06 
-- DESARROLLO       : PackicgBingBang
-- MODULO           :   
-- DESCRIPCION      : SP para el detalle del orden de surtido
-- EJEMPLO			:  exec SP_Detalle_Packing  642723 , 'TODO', null,179,1
-- ========================================================================================================================================
ALTER PROCEDURE [dbo].[SP_Detalle_Packing] 
@ID INT,
@opcion VARCHAR(10),
@Filtro VARCHAR(20) = NULL,
@IdPacking INT = 0,
@orden INT = 0
AS
BEGIN
-- declare @ID INT 
-- set @ID = 482468
DECLARE @SQL NVARCHAR(MAX), @WHERE VARCHAR(MAX)
SET @WHERE = ''

if object_id('tempdb..#VentaC1') is not null
 drop table #VentaC1;
 
 if object_id('tempdb..#VentaC2') is not null
 drop table #VentaC2;
 
 CREATE TABLE #VentaC2 (
	ID INT NOT NULL,
	MovID VARCHAR(20) NULL,
	Articulo VARCHAR(100) NULL,
	descripcion1 VARCHAR(200) NULL,
	Categoria VARCHAR(50) NULL,
	Familia VARCHAR(50) NULL,
	Grupo VARCHAR(50) NULL,
	Nombre VARCHAR(50) NULL,
	Impuesto1 FLOAT NULL,
	Precio FLOAT NULL,
	Cantidad INT NULL,
	Subcuenta VARCHAR(30),
	nColor VARCHAR(50),
	Categorizador VARCHAR(30),
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
	Cant13 INT NULL,
	Cant14 INT NULL,
	Cant15 INT NULL
	
 )

INSERT INTO #VentaC2
SELECT  
Venta.ID,
Venta.MovID,  
Art.Articulo,
Art.Descripcion1,  
Art.Categoria,  
Art.Familia,  
Art.Grupo,  
opdc.Nombre,  
VentaD.Impuesto1,  
VentaD.Precio,  
Cantidad = VentaD.Cantidad,
VentaD.Subcuenta, 
dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'C') as Ncolor,
CASE WHEN ISNULL(dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T'),0) IN (999) THEN /*1*/ 'UNITALLA' ELSE --UNITALLA  
--CASE WHEN ISNULL(dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T'),0) IN (240,245,250,255,260,265,270,275,280,285,290,295,300,305,310,315) THEN 2 ELSE --ZAPATOS  
CASE WHEN ISNULL(dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T'),0) IN (28,29,30,31,32,33,34,36,38,40,42,44,46,48,50) THEN /*3*/ 'BOTTOMS - CAB' ELSE --BOTTOMS - CAB  
CASE WHEN ISNULL(dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T'),-1) IN (0,1,3,5,4,7,9,11,13,15,17,19,21,23,25) THEN /*4*/ 'BOTTOMS - DAM' ELSE --BOTTOMS - DAM  
CASE WHEN ISNULL(dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T'),0) IN (98,99,100,101,102,103,104,105,106,107,108,109,110,111,112) THEN /*5*/ 'TOPS' --TOPS  
ELSE /*0*/ 'OTROS' --OTROS  
END /*END*/ END END  
END Categorizador,  
   
--Cantidad  
  
CASE WHEN ISNULL(dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T'),-1) IN (0,28,240,98,0,999) THEN VentaD.Cantidad - ISNULL(VentaD.CantidadCancelada,0) ELSE NULL END Cant1,  
CASE WHEN dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T') IN (1,29,245,99) THEN VentaD.Cantidad - ISNULL(VentaD.CantidadCancelada,0) ELSE NULL END Cant2,  
CASE WHEN dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T') IN (3,30,250,100) THEN VentaD.Cantidad - ISNULL(VentaD.CantidadCancelada,0) ELSE NULL END Cant3,  
CASE WHEN dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T') IN (5,31,255,101) THEN VentaD.Cantidad - ISNULL(VentaD.CantidadCancelada,0) ELSE NULL END Cant4,  
CASE WHEN dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T') IN (7,32,260,102) THEN VentaD.Cantidad - ISNULL(VentaD.CantidadCancelada,0) ELSE NULL END Cant5,  
CASE WHEN dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T') IN (9,33,265,103) THEN VentaD.Cantidad - ISNULL(VentaD.CantidadCancelada,0) ELSE NULL END Cant6,  
CASE WHEN dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T') IN (11,34,270,104) THEN VentaD.Cantidad - ISNULL(VentaD.CantidadCancelada,0) ELSE NULL END Cant7,  
CASE WHEN dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T') IN (13,36,275,105) THEN VentaD.Cantidad - ISNULL(VentaD.CantidadCancelada,0) ELSE NULL END Cant8,  
CASE WHEN dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T') IN (15,38,280,106) THEN VentaD.Cantidad - ISNULL(VentaD.CantidadCancelada,0) ELSE NULL END Cant9,  
CASE WHEN dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T') IN (17,40,285,107) THEN VentaD.Cantidad - ISNULL(VentaD.CantidadCancelada,0) ELSE NULL END Cant10,  
CASE WHEN dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T') IN (19,42,290,108) THEN VentaD.Cantidad - ISNULL(VentaD.CantidadCancelada,0) ELSE NULL END Cant11,  
CASE WHEN dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T') IN (21,44,295,109) THEN VentaD.Cantidad - ISNULL(VentaD.CantidadCancelada,0) ELSE NULL END Cant12,  
CASE WHEN dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T') IN (23,46,300,110) THEN VentaD.Cantidad - ISNULL(VentaD.CantidadCancelada,0) ELSE NULL END Cant13,  
CASE WHEN dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T') IN (25,48,305,111) THEN VentaD.Cantidad - ISNULL(VentaD.CantidadCancelada,0) ELSE NULL END Cant14,  
CASE WHEN dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T') IN (50,310,112) THEN VentaD.Cantidad - ISNULL(VentaD.CantidadCancelada,0) ELSE NULL END Cant15 
--INTO #VentaC1 
FROM Venta JOIN VentaD WITH(NOLOCK) ON Venta.ID = VentaD.ID  
           JOIN Art WITH(NOLOCK) ON Art.Articulo = VentaD.Articulo  
           JOIN Cte WITH(NOLOCK) ON Venta.Cliente = Cte.Cliente  
           LEFT JOIN OpcionD opdc WITH(NOLOCK) ON opdc.Opcion = 'C' AND opdc.Numero = dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'C')  
           LEFT JOIN OpcionD opdt WITH(NOLOCK) ON opdt.Opcion = 'T' AND opdt.Numero = dbo.fnExtraerOpcionNumero(VentaD.Subcuenta,'T')  
           LEFT JOIN Agente WITH(NOLOCK) ON Venta.Agente = Agente.Agente  
     LEFT JOIN CteEnviarA WITH(NOLOCK) ON Venta.Cliente = CteEnviarA.Cliente AND Venta.EnviarA = CteEnviarA.ID  
WHERE  
  Venta.ID = @ID 
  
  IF @opcion = 'TODO'
  BEGIN
 		 IF @Filtro IS NOT NULL
 		 BEGIN
			IF @Filtro = 'TOPS'
				SET @WHERE = @WHERE + ' AND Categorizador = '''+'TOPS'+''''
			ELSE IF @Filtro = 'BD' 
				SET @WHERE = @WHERE + ' AND Categorizador = '''+'BOTTOMS - DAM'+''''
			ELSE IF @Filtro = 'BC'
				SET @WHERE = @WHERE + ' AND Categorizador = '''+'BOTTOMS - CAB'+''''
			ELSE IF @Filtro = 'UN'
				SET @WHERE = @WHERE + ' AND Categorizador = '''+'UNITALLA'+''''
			
 		 END

	if object_id('tempdb..#detalle') is not null
			drop table #detalle;
			
	CREATE TABLE #detalle (
		ID INT NULL,
		Articulo VARCHAR(50) NULL,
		descripcion1 VARCHAR(100) NULL,
		Color VARCHAR(50) NULL,
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
		Cant12 INt NUll,
		Cant13 INT NULL,
		Cant14 INT NULL,
		Cant15 INT NULL,
		Cantidad INT NULL,
		nColor INT NULL,
		Categorizador VARCHAR(30) NULL
	)
			
  
 SET @SQL='SELECT   
		ID,  
		Articulo,
		descripcion1, 
		v.Nombre as Color,   
		SUM(Cant1) Cant1,  
		SUM(Cant2) Cant2,  
		SUM(Cant3) Cant3,  
		SUM(Cant4) Cant4,  
		SUM(Cant5) Cant5,  
		SUM(Cant6) Cant6,  
		SUM(Cant7) Cant7,  
		SUM(Cant8) Cant8,  
		SUM(Cant9) Cant9,  
		SUM(Cant10) Cant10,  
		SUM(Cant11) Cant11,  
		SUM(Cant12) Cant12,  
		SUM(Cant13) Cant13,  
		SUM(Cant14) Cant14,  
		SUM(Cant15) Cant15,
		SUM(Cantidad) Cantidad,
		nColor,
		Categorizador		
		FROM #VentaC2 v  
		LEFT JOIN OpcionD opdt ON opdt.Opcion = '''+'T'+''' AND opdt.Numero = dbo.fnExtraerOpcionNumero(Subcuenta,'''+'T'+''')
		WHERE 1 = 1 '+ @WHERE +' 
		GROUP BY  
		ID,  
		Articulo,   
		descripcion1,		
		v.Nombre, 
		nColor,    
		Categorizador
		ORDER BY Categorizador'
		--PRINT @SQL
		INSERT INTO #detalle
		EXEC (@SQL)
		
		SELECT ID,Articulo,descripcion1,Color,Cant1,Cant2,Cant3,Cant4,Cant5,Cant6,Cant7,Cant8,Cant9,Cant10,Cant11,Cant12,Cant13,Cant14,Cant15,Cantidad,nColor,Categorizador FROM #detalle 
	
	
  END 

	IF @opcion = 'CAT'
	BEGIN
		SELECT DISTINCT Categorizador FROM #VentaC2 
	END
	
	IF @opcion = 'DET_LINEAL'
	BEGIN
	--	INSERT INTO TBL_PACKING_DETALLE(Id_Caja,Id_Packing,Id_Orden, Art, SubCuenta, Cantidad, Escaneados, Codigo) 		
	--	SELECT NULL,@IdPacking, Articulo,v.Subcuenta, V.Cantidad,0, C.Codigo AS CODIGO,v.MovID FROM #VentaC2 v inner join OpcionD o with(nolock) on dbo.fnExtraerOpcionNumero(v.Subcuenta,'T') = o.Numero and o.Opcion = 'T'
	--LEFT JOIN CB c ON C.Cuenta = V.Articulo	AND C.SubCuenta = v.Subcuenta AND c.Cantidad = 1 ORDER BY Articulo ASC
	
		SELECT v.ID,V.Subcuenta, Articulo,Familia, v.nombre, V.Cantidad , isnull(DET.Escaneados,0) as EnCaja, o.Nombre, C.Codigo AS CODIGO,v.MovID FROM #VentaC2 v inner join OpcionD o with(nolock) on dbo.fnExtraerOpcionNumero(v.Subcuenta,'T') = o.Numero and o.Opcion = 'T' LEFT JOIN CB c ON C.Cuenta = V.Articulo	AND C.SubCuenta = v.Subcuenta AND c.Cantidad = 1 LEFT JOIN TBL_PACKING_DETALLE DET WITH(NOLOCK) ON DET.Art = v.Articulo and DET.SubCuenta = v.Subcuenta and DET.Id_Packing = @IdPacking and DET.Id_Orden = @orden ORDER BY Articulo ASC
	END

	IF @opcion = 'DET_CAJA'
	BEGIN
		SELECT Id_Orden AS ORDEN,Art AS ARTICULO,O.Nombre AS TALLA,oO.Nombre AS COLOR,Cantidad AS CANTIDAD,Escaneados AS EN_CAJA FROM TBL_PACKING_DETALLE T  WITH(NOLOCK) LEFT join OpcionD o with(nolock) on dbo.fnExtraerOpcionNumero(T.Subcuenta,'T') = o.Numero and o.Opcion = 'T' LEFT join OpcionD oO with(nolock) on dbo.fnExtraerOpcionNumero(T.Subcuenta,'C') = oO.Numero and oO.Opcion = 'C' WHERE Id_Caja = @orden AND Id_Packing = @ID
	END
	
	IF @opcion = 'DAT_CAJA'
	BEGIN
		SELECT isnull(TM.TIPO+' '+TM.DIMENCIONES,'') as Dimensiones,CAST(isnull(Tara,0) AS VARCHAR(10)) AS Tara,CAST(isnull(PesoN,0) AS VARCHAR(10)) AS PesoN,CAST(isnull(PesoB,0) AS VARCHAR(10)) AS PesoB FROM TBL_PACKING_BOX TB WITH(NOLOCK) LEFT JOIN TBL_MODA_CAJAS TM WITH(NOLOCK) ON TM.DIMENCIONES = TB.Dimensiones WHERE Id_Caja = @orden AND Id_Packing = @ID
	END

	IF @opcion = 'MODAS'
	BEGIN
		SELECT ID, TIPO + '  '+DIMENCIONES AS MODA FROM TBL_MODA_CAJAS WITH(NOLOCK) 
	END


if object_id('tempdb..#VentaC1') is not null
 drop table #VentaC1;
 
 if object_id('tempdb..#VentaC2') is not null
 drop table #VentaC2;
 
END