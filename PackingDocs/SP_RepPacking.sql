USE [ALTAI]
GO
/****** Object:  StoredProcedure [dbo].[SP_RepPacking]    Script Date: 01/16/2018 08:17:28 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
-- ========================================================================================================================================    
-- NOMBRE           : SP_Cat_Modelo
-- AUTOR            : ERIC F MARTINEZ
-- FECHA CREACION   : 2017-10-03
-- DESARROLLO       : Formato Pedido
-- MODULO           :   
-- DESCRIPCION      :  
-- EJEMPLO			: exec SP_RepPacking 583
-- ========================================================================================================================================
ALTER PROCEDURE [dbo].[SP_RepPacking] 
@IdPacking INT
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
	Descripcion VARCHAR(200) NULL,
	OrdenSurtido VARCHAR(20) NULL,
	IdPacking INT NULL,
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
	Cant12 INT NULL,
	Cant13 INt NULL,
	Cant14 INT NULL,
	Cant15 INT NULL
	)
	
	if object_id('tempdb..#ReporteFIN') is not null
	drop table #ReporteFIN;
	
	CREATE TABLE #ReporteFIN (
	idcaja INT NULL,
	Dimenciones VARCHAR(20) NULL,
	Tara Decimal(10,2) NULL,
	PesoB DECIMAL(10,2) NULL,
	PesoN DECIMAL(10,2) NULL,
	Articulo VARCHAR(20) NULL,
	Descripcion VARCHAR(200) NULL,
	OrdenSurtido VARCHAR(20) NULL,
	IdPacking INT NULL,
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
	Cant12 INT NULL,
	Cant13 INt NULL,
	Cant14 INT NULL,
	Cant15 INT NULL,
	Precinto VARCHAR(30) NULL
	)
	
	if object_id('tempdb..#PivotPre') is not null
	drop table #PivotPre;
	CREATE TABLE #PivotPre(
		idpack INT null,
		idCaja INT null,
		Precin VARCHAR(MAX) NULL
	)
	
	
	INSERT INTO #Reporte 
	SELECT PB.Id_Caja, PB.Dimensiones, PB.Tara, PB.PesoB, PB.PesoN,PD.Art,A.Descripcion1,PD.Id_Orden,PD.Id_Packing,opdc.Nombre,
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
	FROM TBL_PACKING_BOX PB WITH(NOLOCK) INNER JOIN TBL_PACKING_DETALLE PD WITH(NOLOCK) ON PB.Id_Caja = PD.Id_Caja AND PB.Id_Packing = PD.Id_Packing LEFT JOIN Art A WITH(NOLOCK) ON A.Articulo = PD.Art  
	LEFT JOIN OpcionD opdc WITH(NOLOCK) ON opdc.Opcion = 'C' AND opdc.Numero = dbo.fnExtraerOpcionNumero(PD.Subcuenta,'C') 
	WHERE PB.Id_Packing = @IdPacking  
	
	INSERT INTO #ReporteFIN (idcaja,Dimenciones,Tara,PesoB,PesoN,Articulo,Descripcion,OrdenSurtido,IdPacking,Color,Cant1,Cant2,Cant3,Cant4,Cant5,Cant6,Cant7,Cant8,Cant9,Cant10,Cant11,Cant12,Cant13,Cant14,Cant15)
	SELECT idcaja,Dimenciones, Tara, PesoB, PesoN, Articulo,
CASE Articulo
    WHEN 'ARESDB' THEN 'Ares Dama Bermuda / Ares Women´s Bermuda'
    WHEN 'ARESDFC' THEN 'Ares Dama Falda Corta con Bolsas / Ares Women´s Short Skirt'
    WHEN 'ARESDFL' THEN 'Ares Dama Falda Lapiz / Ares Women´s Long Skirt'
    WHEN 'ARESDP' THEN 'Ares Pantalon Dama / Ares Women´s Pants'
    WHEN 'ASTRCC' THEN 'Astro Caballero Manga Corta / Astro Men´s Short Sleeve'
    WHEN 'ASTRCL' THEN 'Astro Caballero Manga larga / Astro Men´s Long Sleeve'
    WHEN 'ASTRD34P-1' THEN 'Astro Dama Manga 3/4 Pinzas V1 / Astro V1 Women´s 3/4 Sleeve with Darts'
    WHEN 'ASTRDC-1' THEN 'Astro Dama Manga corta V1 / Astro V1 Women´s Short Sleeve'
    WHEN 'ASTRDCP-1' THEN 'Astro Dama Manga corta Pinzas V1 / Astro V1 Women´s Short Sleeve With Darts'
    WHEN 'ASTRDL-1' THEN 'Astro Dama Manga larga V1 / Astro V1 Women´s Long Sleeve'
    WHEN 'ASTRDLP-1' THEN 'Astro Dama Manga larga Pinzas V1 / Astro V1 Women´s Long Sleeve With Darts'
    WHEN 'COMECC' THEN 'Comet Caballero Manga corta / Comet Men´s Short Sleeve'
    WHEN 'COMECL' THEN 'Comet Caballero Manga larga / Comet Men´s Long Sleeve'
    WHEN 'COMED34P-1' THEN 'Comet Dama Manga 3/4 Pinzas V1 / Comet V1 Women´s 3/4 Sleeve with Darts'
    WHEN 'COMEDC-1' THEN 'Comet Dama Manga corta V1 / Comet V1 Women´s Short Sleeve'
    WHEN 'COMEDCP-1' THEN 'Comet Dama Manga corta Pinzas V1 / Comet V1 Women´s Short Sleeve With Darts'
    WHEN 'COMEDL-1' THEN 'Comet Dama Manga larga V1 / Comet V1 Women´s Long Sleeve'
    WHEN 'COMEDLP-1' THEN 'Comet Dama Manga larga Pinzas V1 / Comet V1 Women´s Long Sleeve With Darts'
    WHEN 'COSMCC' THEN 'Cosmos Caballero Manga corta / Cosmos Men´s Short Sleeve'
    WHEN 'COSMCL' THEN 'Cosmos Caballero Manga larga / Cosmos Men´s Long Sleeve'
    WHEN 'COSMD34P-1' THEN 'Cosmos Dama Manga 3/4 Pinzas V1 / Cosmos V1 Women´s 3/4 Sleeve with Darts'
    WHEN 'COSMDC-1' THEN 'Cosmos Dama Manga corta V1 / Cosmos V1 Women´s Short Sleeve'
    WHEN 'COSMDCP-1' THEN 'Cosmos Dama Manga corta Pinzas V1 / Cosmos V1 Women´s Short Sleeve With Darts'
    WHEN 'COSMDL-1' THEN 'Cosmos Dama Manga larga V1 / Cosmos V1 Women´s Long Sleeve'
    WHEN 'COSMDLP-1' THEN 'Cosmos Dama Manga larga Pinzas V1 / Cosmos V1 Women´s Long Sleeve With Darts'
    WHEN 'DEIFCPS' THEN 'Deimos Flat Pantalon Caballero / Deimos Flat Men´s Pants'
    WHEN 'DEIFDPS' THEN 'Deimos Flat Pantalon Dama / Deimos Flat Women´s Pants'
    WHEN 'DENICC' THEN 'Denim Caballero Manga corta / Denim Men´s Short Sleeve'
    WHEN 'DENICL' THEN 'Denim Caballero Manga larga / Denim Men´s Long Sleeve'
    WHEN 'DENID34P-1' THEN 'Denim Dama Manga 3/4 Pinzas V1 / Denim V1 Women´s 3/4 Sleeve with Darts'
    WHEN 'DENIDCP-1' THEN 'Denim Dama Manga corta Pinzas V1 / Denim V1 Women´s Short Sleeve With Darts'
    WHEN 'DENIDLP-1' THEN 'Denim Dama Manga larga Pinzas V1 / Denim V1 Women´s Long Sleeve With Darts'
    WHEN 'DJEACL' THEN 'Denim-Jeans Caballero Manga larga / Denim Jeans Men´s Long Sleeve'
    WHEN 'DJEADCP' THEN 'Denim-Jeans Dama Manga corta Pinzas / Denim Jeans Women´s Short Sleeve With Darts'
    WHEN 'DJEADLP' THEN 'Denim-Jeans Dama Manga larga Pinzas / Denim Jeans Women´s Long Sleeve With Darts'
    WHEN 'EUROCC' THEN 'Euro Caballero Manga corta / Euro Men´s Short Sleeve'
    WHEN 'EUROCL' THEN 'Euro Caballero Manga larga / Euro Men´s Long Sleeve'
    WHEN 'EUROD34P-1' THEN 'Euro Dama Manga 3/4 Pinzas V-1 / Euro V1 Women´s 3/4 Sleeve with Darts'
    WHEN 'EURODC-1' THEN 'Euro Dama Manga corta V1 / Euro V1 Women´s Short Sleeve'
    WHEN 'EURODCP-1' THEN 'Euro Dama Manga corta Pinzas V1 / Euro V1 Women´s Short Sleeve With Darts'
    WHEN 'EURODLP-1' THEN 'Euro Dama Manga larga Pinzas V1 / Euro V1 Women´s Long Sleeve With Darts'
    WHEN 'HELICC' THEN 'Heli Caballero Manga Corta / Heli Men´s Short Sleeve'
    WHEN 'HELICL' THEN 'Heli Caballero Manga Larga / Heli Men´s Long Sleeve'
    WHEN 'HELID34P-1' THEN 'Heli Dama Manga 3/4 Pinzas V 1 / Heli Women´s 3/4 Sleeve with Darts'
    WHEN 'HELIDCP-1' THEN 'Heli Dama Manga Corta Pinzas V 1 / Heli Women´s Short Sleeve with Darts'
    WHEN 'HELIDLP-1' THEN 'Heli Dama Manga Larga Pinzas V 1 / Heli Women´s Long Sleeve with Darts'
    WHEN 'IOXXCC' THEN 'Io Caballero Manga corta / Io Men´s Short Sleeve'
    WHEN 'IOXXCL' THEN 'Io Caballero Manga larga / Io Men´s Long Sleeve'
    WHEN 'IOXXD34P-1' THEN 'Io Dama Manga 3/4 Pinzas V1 / Io V1 Women´s 3/4 Sleeve with Darts'
    WHEN 'IOXXDCP-1' THEN 'Io Dama Manga corta Pinzas V1 / Io V1 Women´s Short Sleeve With Darts'
    WHEN 'IOXXDLP-1' THEN 'Io Dama Manga larga Pinzas V1 / Io V1 Women´s Long Sleeve With Darts'
    WHEN 'LYONCC' THEN 'Lyon Caballero Manga Corta / Lyon Men´s Short Sleeve'
    WHEN 'LYONCL' THEN 'Lyon Caballero Manga larga / Lyon Men´s Long Sleeve'
    WHEN 'LYOND34P-1' THEN 'Lyon Dama Manga 34 pinzas  V1 / Lyon Women´s 3/4 Sleeve with Darts'
    WHEN 'LYONDCP-1' THEN 'Lyon Dama Manga corta pinzas  V1 / Lyon Women´s Short Sleeve With Darts'
    WHEN 'LYONDLP-1' THEN 'Lyon Dama Manga larga Pinzas V1 / Lyon Women´s Long Sleeve With Darts'
    WHEN 'MAUICC' THEN 'Maui Caballero Manga corta / Maui Men´s Short Sleeve'
    WHEN 'MAUICL' THEN 'Maui Caballero Manga Larga / Maui Men´s Long Sleeve'
    WHEN 'MAUICOCC' THEN 'Maui Caballero Confort Manga corta / Maui Men´s Comfort Short Sleeve'
    WHEN 'MAUICODC' THEN 'Maui Dama Confort Manga corta / Maui Women´s Comfort Short Sleeve'
    WHEN 'MAUID34P-1' THEN 'Maui Dama Manga 3/4 Pinzas / Maui Women´s 3/4 Sleeve with Darts'
    WHEN 'MAUIDCP-1' THEN 'Maui Dama Manga corta Pinzas V1 / Maui Women´s Short Sleeve With Darts'
    WHEN 'MAUIDLP-1' THEN 'Maui Dama Manga larga Pinzas V1 / Maui Women´s Long Sleeve With Darts'
    WHEN 'MOONCC' THEN 'Moon Caballero Manga corta / Moon Men´s Short Sleeve'
    WHEN 'MOONCL' THEN 'Moon Caballero Manga larga / Moon Men´s Long Sleeve'
    WHEN 'MOOND34P-1' THEN 'Moon Dama Manga 3/4 Pinzas V1 / Moon V1 Women´s 3/4 Sleeve with Darts'
    WHEN 'MOONDCP-1' THEN 'Moon Dama Manga corta Pinzas V1 / Moon V1 Women´s Short Sleeve With Darts'
    WHEN 'MOONDLP-1' THEN 'Moon Dama Manga larga Pinzas V1 / Moon V1 Women´s Long Sleeve With Darts'
    WHEN 'POPXCC' THEN 'Pop Caballero Manga corta / Pop Men´s Short Sleeve'
    WHEN 'POPXCL' THEN 'Pop Caballero Manga larga / Pop Men´s Long Sleeve'
    WHEN 'POPXD34P-1' THEN 'Pop Dama Manga 3/4 Pinzas V1 / Pop V1 Women´s 3/4 Sleeve with Darts'
    WHEN 'POPXDCP-1' THEN 'Pop Dama Manga corta Pinzas V1 / Pop V1 Women´s Short Sleeve With Darts'
    WHEN 'POPXDLP-1' THEN 'Pop Dama Manga larga Pinzas V1 / Pop V1 Women´s Long Sleeve With Darts'
    WHEN 'SPOPCC' THEN 'Super Pop Caballero Manga corta / Super Pop Men´s Short Sleeve'
    WHEN 'SPOPCL' THEN 'Super Pop Caballero Manga larga / Super Pop Men´s Long Sleeve'
    WHEN 'SPOPD34P-1' THEN 'Super Pop Dama Manga 3/4 Pinzas V1 / Super Pop V1 Women´s 3/4 Sleeve with Darts'
    WHEN 'SPOPDCP-1' THEN 'Super Pop Dama Manga corta Pinzas V1 / Super Pop V1 Women´s Short Sleeve With Darts'
    WHEN 'SPOPDLP-1' THEN 'Super Pop Dama Manga larga Pinzas V-1 / Super Pop V1 Women´s Long Sleeve With Darts'
    WHEN 'SUNXCC' THEN 'Sun Caballero Manga corta / Sun Men´s Short Sleeve'
    WHEN 'SUNXCL' THEN 'Sun Caballero Manga larga / Sun Men´s Long Sleeve'
    WHEN 'SUNXCOCC' THEN 'Sun Confort Caballero Manga corta / Sun Men´s Comfort Short Sleeve'
    WHEN 'SUNXCODC' THEN 'Sun Dama Manga corta V1 / Sun Women´s Comfort Short Sleeve'
    WHEN 'SUNXD34P-1' THEN 'Sun Dama Manga 3/4 Pinzas V1 / Sun V1 Women´s 3/4 Sleeve with Darts'
    WHEN 'SUNXDCP-1' THEN 'Sun Dama Manga corta Pinzas V1 / Sun V1 Women´s Short Sleeve With Darts'
    WHEN 'SUNXDLP-1' THEN 'Sun Dama Manga larga Pinzas V1 / Sun V1 Women´s Long Sleeve With Darts'
    WHEN 'THYOCC' THEN 'Thyone Caballero Manga Corta / Thyone Men´s Short Sleeve'
    WHEN 'THYOCL' THEN 'Thyone Caballero Manga larga / Thyone Men´s Long Sleeve'
    WHEN 'THYOD34P-1' THEN 'Thyone Dama Manga 3/4  Pinzas V1 / Thyone Women´s 3/4 Sleeve with Darts'
    WHEN 'THYODCP-1' THEN 'Thyone Dama Manga Corta Pinzas V1 / Thyone Women´s Short Sleeve With Darts'
    WHEN 'THYODLP-1' THEN 'Thyone Dama Manga larga Pinzas V1 / Thyone Women´s Long Sleeve With Darts'
    WHEN 'TITACP' THEN 'Titan Pantalon Caballero / Titan Men´s Pants'
    WHEN 'TITADP' THEN 'Titan Pantalon Dama / Titan Women´s Pants'
    WHEN 'ZODICC' THEN 'Zodiac Caballero Manga corta / Zodiac Men´s Short Sleeve'
    WHEN 'ZODICL' THEN 'Zodiac Caballero Manga larga / Zodiac Men´s Long Sleeve'
    WHEN 'ZODID34P-1' THEN 'Zodiac Dama Manga 3/4 Pinzas V1 / Zodiac V1 Women´s 3/4 Sleeve with Darts'
    WHEN 'ZODIDCP-1' THEN 'Zodiac Dama Manga corta Pinzas V1 / Zodiac V1 Women´s Short Sleeve With Darts'
    WHEN 'ZODIDLP-1' THEN 'Zodiac Dama Manga larga Pinzas V1 / Zodiac V1 Women´s Long Sleeve With Darts'
	ELSE Descripcion END AS Descripcion
,OrdenSurtido,IdPacking,
CASE Color
    WHEN 'Aqua'THEN 'Aqua / Aqua'
    WHEN 'Azul Celeste'THEN 'Azul Celeste / Skyway'
    WHEN 'Azul Jeans'THEN 'Azul Jeans / Denim Blue'
    WHEN 'Negro'THEN 'Negro / Black'
    WHEN 'Azul'THEN 'Azul / Blue'
    WHEN 'Ceniza'THEN 'Ceniza / Ash'
    WHEN 'Ciruela'THEN 'Ciruela / Plim'
    WHEN 'Cereza'THEN 'Cereza / Cherry'
    WHEN 'Azul Francia'THEN 'Azul Francia / French Blue'
    WHEN 'Gris Acero'THEN 'Gris Acero / Steel Gray'
    WHEN 'Verde'THEN 'Verde / Green'
    WHEN 'Gris'THEN 'Gris / Gray'
    WHEN 'Miel'THEN 'Miel / Honey'
    WHEN 'Indigo 7.5'THEN 'Indigo 7.5 / Indigo Blue'
    WHEN 'Indigo'THEN 'Indigo / Indigo Blue'
    WHEN 'Kaki'THEN 'Kaki / Khaki'
    WHEN 'Azul Cielo / Khaki'THEN 'Azul Cielo - Khaki / Sky Blue - Khaki'
    WHEN 'Lago'THEN 'Lago / Lake'
    WHEN 'Marino'THEN 'Marino / Navy Blue'
    WHEN 'Azul Cielo'THEN 'Azul Cielo / Sky Blue'
    WHEN 'Amarillo / Azul Marino'THEN 'Amarillo - Azul Marino / Yellow - Navy Blue'
    WHEN 'Ocre'THEN 'Ocre / Burnt Orange'
    WHEN 'Naranja'THEN 'Naranja / Orange'
    WHEN 'Rosa'THEN 'Rosa / Pink'
    WHEN 'Plumbago'THEN 'Plumbago / Plumbago'
    WHEN 'Azul Rey'THEN 'Azul Rey / Royal Blue'
    WHEN 'Naranja / Azul Rey'THEN 'Naranja - Azul Rey / Orange - Royal Blue'
    WHEN 'Rojo'THEN 'Rojo / Red'
    WHEN 'Arena'THEN 'Arena / Sand'
    WHEN 'Trigo'THEN 'Trigo / Wheat'
    WHEN 'Blanco'THEN 'Blanco / White'
    WHEN 'Azul'THEN 'Azul / Blue'
    WHEN 'Azul Marino'THEN 'Azul Marino / Navy Blue'
    WHEN 'Uva'THEN 'Uva / Grape'
    WHEN 'Tinto'THEN 'Tinto / Maroon'
    WHEN 'Amarillo'THEN 'Amarillo / Yellow'
	ELSE Color END AS Color
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
	FROM #Reporte group by idcaja,Dimenciones, Tara, PesoB, PesoN, Articulo,Descripcion,OrdenSurtido,IdPacking,Color
	
	--SELECT distinct R.*,P.Id_PreCinto FROM #ReporteFIN R LEFT JOIN TBL_PRECINTO_PACKING P ON R.IdPacking = P.Id_Packing AND R.idcaja = P.Id_Caja 
	
	DECLARE @ID_PRE VARCHAR(50)
DECLARE @ID_CAJ INT 
DECLARE @N INT
DECLARE @CADENA VARCHAR(50) 
SET @N = 1
SET @CADENA = ''

DECLARE IDPRE CURSOR FOR 
	SELECT Id_PreCinto,Id_Caja  FROM TBL_PRECINTO_PACKING WITH(NOLOCK) WHERE Id_Packing = @IdPacking 
OPEN IDPRE
FETCH IDPRE INTO @ID_PRE , @ID_CAJ
WHILE(@@FETCH_STATUS = 0)
BEGIN
	IF @N <> @ID_CAJ
	BEGIN
		INSERT INTO #PivotPre
		SELECT  @IdPacking ,@N,@CADENA
		SET @N = @ID_CAJ
		SET @CADENA = ''
	END
	IF @N = @ID_CAJ
	BEGIN		
		SET @CADENA = @CADENA  + @ID_PRE + ' , '				
	END
	FETCH IDPRE INTO @ID_PRE , @ID_CAJ
END
CLOSE IDPRE
DEALLOCATE IDPRE

INSERT INTO #PivotPre
SELECT  @IdPacking ,@N,@CADENA

SELECT distinct R.idcaja,R.Dimenciones,isnull(R.Tara,0) Tara,isnull(R.PesoB,0) PesoB,isnull(R.PesoN,0) PesoN,R.Articulo,R.Descripcion,R.OrdenSurtido,R.IdPacking,R.Color,ISNULL(R.Cant1,0) Cant1,ISNULL(R.Cant2,0) Cant2,ISNULL(R.Cant3,0) Cant3,ISNULL(R.Cant4,0) Cant4,ISNULL(R.Cant5,0) Cant5,ISNULL(R.Cant6,0) Cant6,ISNULL(R.Cant7,0) Cant7,ISNULL(R.Cant8,0) Cant8,ISNULL(R.Cant9,0) Cant9,ISNULL(R.Cant10,0) Cant10,ISNULL(R.Cant11,0) Cant11,ISNULL(R.Cant12,0) Cant12,ISNULL(R.Cant13,0) Cant13,ISNULL(R.Cant14,0) Cant14,ISNULL(R.Cant15,0) Cant15,ISNULL(P.Precin,'') Precin  
,(SELECT MAX(Id_Caja) as maxCaja FROM TBL_PACKING_BOX WITH(NOLOCK) WHERE Id_Packing = @IdPacking)as maxCaja
,(select isnull(SUM(PesoB),0) as sumPeso FROM TBL_PACKING_BOX WITH(NOLOCK) WHERE Id_Packing = @IdPacking)as sumPeso
,(SELECT COUNT( DISTINCT Id_Orden)  AS maxOrden FROM TBL_PACKING_DETALLE WITH(NOLOCK) WHERE Id_Packing = @IdPacking)AS maxOrden
,(SELECT SUM(Escaneados) AS TotalEsc  FROM TBL_PACKING_DETALLE WITH(NOLOCK) WHERE Id_Packing = @IdPacking) AS TotalEsc
FROM #ReporteFIN R LEFT JOIN #PivotPre P ON R.IdPacking = P.idpack AND R.idcaja = P.idCaja 
	
	if object_id('tempdb..#Reporte') is not null
	drop table #Reporte;
	
	if object_id('tempdb..#ReporteFIN') is not null
	drop table #ReporteFIN;
	
	if object_id('tempdb..#PivotPre') is not null
	drop table #PivotPre;
	
	
END