CREATE VIEW [dbo].[xrBeforeReviewPPP] AS 
SELECT     hd.idbank, hd.tanggalpemohon, hd.noaruspengajuan, gchd.generalcode AS statushd, dt.nomorurut, dt.keperluan, dt.nodokumen, dt.jumlahuang, 
                      CASE WHEN dt.posisidk = 1 THEN 'PENERIMAAN' WHEN dt.posisidk = 2 THEN 'PENGELUARAN' END AS posisidk, gcdt.generalcode AS statusdt
FROM         dbo.ArusPengajuan AS hd LEFT OUTER JOIN
                      dbo.Bank AS b ON hd.idbank = b.idbank LEFT OUTER JOIN
                      dbo.ArusPengajuanDT AS dt ON hd.idaruspengajuan = dt.idaruspengajuan LEFT OUTER JOIN
                      dbo.sys_GeneralCode AS gchd ON hd.isdeleted = gchd.idgeneral AND gchd.gctype = 'REJECT' LEFT OUTER JOIN
                      dbo.sys_GeneralCode AS gcdt ON dt.isdeleted = gcdt.idgeneral AND gcdt.gctype = 'REJECT'
WHERE     (dt.posisidk = 1 OR
                      dt.posisidk = 2) AND (hd.isdeleted <> 1) AND (dt.isdeleted <> 1)
