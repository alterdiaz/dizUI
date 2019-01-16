CREATE PROCEDURE [dbo].[spAMIGD201801]
@id as bigint
AS
BEGIN
select ass.idassessment, 
rm.nama, 
convert(varchar,rm.tanggallahir,105) as tanggallahir, 
dbo.fFormatNoRM(rm.rekammedisno) as norm, 
r.registrasino, 
convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as registrasidate, 
payt.generalcode as payertype,
ass.assessmentno, 
convert(varchar,ass.assessmentdate,105)+' '+convert(varchar,ass.assessmentdate,108) as assessmentdate, 
ass.skalatriage as idskalatriage,
st.generalcode as skalatriage,
convert(varchar,ass.tanggaldatang,105) +' '+ convert(varchar,ass.tanggaldatang,108) as waktujamdatang,
convert(varchar,ass.tanggaldatang,105) as waktudatang,
convert(varchar,ass.tanggaldatang,108) as jamdatang,
convert(varchar,ass.tanggalkejadian,105) +' '+ convert(varchar,ass.tanggalkejadian,108) as waktujamkejadian,
convert(varchar,ass.tanggalkejadian,105) as waktukejadian,
convert(varchar,ass.tanggalkejadian,108) as jamkejadian,
ass.gcse,
ass.gcsv,
ass.gcsm,
'E.'+convert(varchar,ass.gcse)+'/V.'+convert(varchar,ass.gcsv)+'/M.'+convert(varchar,ass.gcsm) as gcsevm,
ksd.generalcode as kesadaran,
convert(varchar,ass.pupila) +'mm' as pupila,
convert(varchar,ass.pupilb) +'mm' as pupilb,
convert(varchar,ass.pupila) +'mm'+'/'+ convert(varchar,ass.pupilb) +'mm' as pupilab,
rcah.generalcode as refcahaya,
ass.tdsis,
ass.tddias,
convert(varchar,ass.tdsis)+'/'+convert(varchar,ass.tddias)+'mmHg' as TD,
convert(varchar,ass.denyutnadi) +'x/menit' as denyutnadi,
isn.generalcode as nadi,
convert(varchar,ass.suhu) +'°' as suhu,
convert(varchar,ass.nafas) +'x/menit' as nafas,
convert(varchar,ass.oksigendarah) + '%' as oksigendarah, 
akr.generalcode as akral, 
case when dbo.fRPAMIGD2018(r.idrekammedis,r.idregistrasi)=0 then 'Tidak' else 'Ya' end as isriwayat, 
gp.generalcode as gangguanperilaku, 
pb.generalcode as perilakubahaya, 
inf.generalcode as isinformasi, 
ass.namainformasi, 
ft.generalcode as hubungan, 
cm.generalcode as caramasuk, 
ipg.generalcode as ispengantar, 
ass.namapengantar, 
apx.generalcode as asalpx, 
case 
when ass.asalpx=2 then apd.generalcode 
when ass.asalpx=1 then apj.generalcode 
end as asalpx2,
case 
when ass.asalpx=1 then 'dari:'
when ass.asalpx=2 then 'Tahu dari:'
end as colasalpx2,
case 
when ass.asalpx2=1 then par.nama 
when ass.asalpx2=2 then bp.nama 
else ''
end as asalrujukan,
case 
when ass.asalpx2=1 then 'Dokter:'
when ass.asalpx2=2 then 'RS/Klinik:'
else ''
end as colasalrujukan,
case 
when ass.asalpx2=2 then par2.nama 
else ''
end as namadokter,
case 
when ass.asalpx2=2 then 'Dokter:'
else ''
end as colnamadokter,
ipb.generalcode as ispenyebab,
ass.penyebab,
gh.generalcode as gayahidup,
ass.gayahidupnote,
p.nama as dokterruangan 
from assessment ass 
left join registrasi r on ass.idregistrasi=r.idregistrasi 
left join paramedis p on r.iddokterruangan=p.idparamedis 
left join rekammedis rm on rm.idrekammedis=r.idrekammedis 
left join sys_generalcode payt on payt.idgeneral=r.payertype and payt.gctype='PAYERTYPE' 
left join sys_generalcode st on st.idgeneral=ass.skalatriage and st.gctype='SKALATRIAGE' 
left join sys_generalcode ksd on ksd.idgeneral=ass.iskesadaran and ksd.gctype='ISKESADARAN' 
left join sys_generalcode rcah on rcah.idgeneral=ass.isrefcahaya and rcah.gctype='ISREFCAHAYA' 
left join sys_generalcode akr on akr.idgeneral=ass.isakral and akr.gctype='ISAKRAL' 
left join sys_generalcode gp on gp.idgeneral=ass.isgangguanperilaku and gp.gctype='ISGANGGUANPERILAKU' 
left join sys_generalcode pb on pb.idgeneral=ass.isperilakubahaya and pb.gctype='ISPERILAKUBERBAHAYA' 
left join sys_generalcode inf on inf.idgeneral=ass.isinformasi and inf.gctype='ISINFORMASI' 
left join sys_generalcode ft on ft.idgeneral=ass.familytype and ft.gctype='FAMILYTYPE' 
left join sys_generalcode cm on cm.idgeneral=ass.iscaramasuk and cm.gctype='ISCARAMASUK' 
left join sys_generalcode ipg on ipg.idgeneral=ass.ispengantar and ipg.gctype='ISPENGANTAR' 
left join sys_generalcode ipb on ipb.idgeneral=ass.ispenyebab and ipb.gctype='ISPENYEBAB' 
left join sys_generalcode gh on gh.idgeneral=ass.gayahidup and gh.gctype='GAYAHIDUP' 
left join sys_generalcode isn on isn.idgeneral=ass.isnadi and isn.gctype='ISNADI' 
left join sys_generalcode apx on ass.asalpx=apx.idgeneral and apx.gctype='ASALPX' 
left join sys_generalcode apd on ass.asalpx2=apd.idgeneral and apd.gctype='ASALPXDTG' 
left join sys_generalcode apj on ass.asalpx2=apj.idgeneral and apj.gctype='ASALPXRUJ' 
left join sys_generalcode apj2 on ass.asalrujukan=apj2.idgeneral and apj2.gctype='ASALPXRUJ' 
left join paramedis par on ass.asalrujukan=par.idparamedis 
left join businesspartner bp on ass.asalrujukan=bp.idbusinesspartner 
left join paramedis par2 on ass.iddokterrujukan=par2.idparamedis 
where ass.idassessment=@id
END
