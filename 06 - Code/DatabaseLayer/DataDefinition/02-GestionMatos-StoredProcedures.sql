-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
USE [GestionMatos]
GO

/****** Object:  StoredProcedure [dbo].[GetMaterials]    Script Date: 02/12/2015 09:19:28 ******/
--DROP PROCEDURE [dbo].[GetMaterials]
--GO

/****** Object:  StoredProcedure [dbo].[GetMaterials]    Script Date: 02/12/2015 09:19:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Matthieu Garry
-- Create date: 01/12/2015
-- Description:	fetch materiels
-- =============================================
CREATE PROCEDURE [dbo].[GetMaterials] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		M.id_Materiel
		,M.nom_Materiel AS 'Nom de Matériel'
		,UPPER(M.guid_Materiel) AS 'Numéro de Série'
		,(SELECT nom_Client FROM [dbo].[Client] WHERE id_client=M.id_Client) AS 'Client associé'
		,(SELECT nom_Site FROM [dbo].[Site] WHERE id_Site=M.id_Site) AS 'Site de stockage'
		,(SELECT 'Batiment n°' + CONVERT(varchar, num_Batiment) FROM [dbo].[Batiment] WHERE id_Batiment=M.id_Batiment) AS 'Batiment'
		,(SELECT 'Etage n°' + CONVERT(varchar, num_Etage) FROM [dbo].[Etage] WHERE id_Etage=M.id_Etage) AS 'Etage'
		,(SELECT nom_Salle FROM [dbo].[Salle] WHERE id_Salle=M.id_Salle) AS 'Salle'
		,(SELECT nom_type_Materiel FROM [dbo].[Type_Materiel] WHERE id_type_Materiel=M.id_type_Materiel) AS 'Type de matériel'
		,M.date_dernier_Intervention AS 'Date dernière Intervention'
		,M.description As 'Description'
	FROM	
		[dbo].[Materiel] AS M
END

GO