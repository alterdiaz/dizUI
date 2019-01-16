CREATE TABLE [dbo].[Assessment] (
    [idassessment]       BIGINT         IDENTITY (1, 1) NOT NULL,
    [idregistrasi]       BIGINT         DEFAULT ((0)) NOT NULL,
    [transactiontype]    BIGINT         DEFAULT ((0)) NOT NULL,
    [assessmentno]       VARCHAR (50)   DEFAULT ('-') NOT NULL,
    [assessmentdate]     DATETIME       DEFAULT (getdate()) NOT NULL,
    [skalatriage]        BIGINT         DEFAULT ((0)) NOT NULL,
    [tanggaldatang]      DATETIME       DEFAULT (getdate()) NOT NULL,
    [tanggalkejadian]    DATETIME       DEFAULT (getdate()) NOT NULL,
    [gcse]               BIGINT         DEFAULT ((0)) NOT NULL,
    [gcsv]               BIGINT         DEFAULT ((0)) NOT NULL,
    [gcsm]               BIGINT         DEFAULT ((0)) NOT NULL,
    [iskesadaran]        BIGINT         DEFAULT ((0)) NOT NULL,
    [pupila]             BIGINT         DEFAULT ((0)) NOT NULL,
    [pupilb]             BIGINT         DEFAULT ((0)) NOT NULL,
    [isrefcahaya]        BIGINT         DEFAULT ((0)) NOT NULL,
    [tdsis]              BIGINT         DEFAULT ((0)) NOT NULL,
    [tddias]             BIGINT         DEFAULT ((0)) NOT NULL,
    [denyutnadi]         BIGINT         DEFAULT ((0)) NOT NULL,
    [isnadi]             BIGINT         DEFAULT ((0)) NOT NULL,
    [suhu]               DECIMAL (6, 1) CONSTRAINT [DF__Assessment__suhu__01F40C98] DEFAULT ((0)) NOT NULL,
    [nafas]              BIGINT         DEFAULT ((0)) NOT NULL,
    [oksigendarah]       BIGINT         DEFAULT ((0)) NOT NULL,
    [isakral]            BIGINT         DEFAULT ((0)) NOT NULL,
    [isgangguanperilaku] BIGINT         DEFAULT ((0)) NOT NULL,
    [isperilakubahaya]   BIGINT         DEFAULT ((0)) NOT NULL,
    [isinformasi]        BIGINT         DEFAULT ((0)) NOT NULL,
    [familytype]         BIGINT         DEFAULT ((0)) NOT NULL,
    [namainformasi]      VARCHAR (300)  DEFAULT ('-') NOT NULL,
    [iscaramasuk]        BIGINT         DEFAULT ((0)) NOT NULL,
    [ispengantar]        BIGINT         DEFAULT ((0)) NOT NULL,
    [namapengantar]      VARCHAR (300)  DEFAULT ('-') NOT NULL,
    [ispenyebab]         BIGINT         DEFAULT ((0)) NOT NULL,
    [penyebab]           VARCHAR (500)  DEFAULT ('-') NOT NULL,
    [gayahidup]          BIGINT         DEFAULT ((0)) NOT NULL,
    [gayahidupnote]      VARCHAR (200)  DEFAULT ('-') NOT NULL,
    [asalpx]             BIGINT         DEFAULT ((0)) NOT NULL,
    [asalpx2]            BIGINT         DEFAULT ((0)) NOT NULL,
    [asalrujukan]        BIGINT         DEFAULT ((0)) NOT NULL,
    [iddokterrujukan]    BIGINT         DEFAULT ((0)) NOT NULL,
    [isdeleted]          BIGINT         DEFAULT ((0)) NOT NULL,
    [createdby]          BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]        DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]          BIGINT         NULL,
    [updateddate]        DATETIME       NULL,
    [idcompany]          BIGINT         DEFAULT ((0)) NOT NULL,
    [nomorform]          VARCHAR (30)   DEFAULT ('-') NOT NULL,
    [guid]               VARCHAR (1000) DEFAULT ('-') NOT NULL,
    [warnakulit]         BIGINT         DEFAULT ((0)) NOT NULL,
    [airway]             BIGINT         DEFAULT ((0)) NOT NULL,
    [bb]                 BIGINT         DEFAULT ((0)) NOT NULL,
    [tb]                 BIGINT         DEFAULT ((0)) NOT NULL,
    [imt]                DECIMAL (6, 2) DEFAULT ((0)) NOT NULL,
    [statusgizi]         VARCHAR (20)   DEFAULT ('-') NOT NULL,
    [breathing]          BIGINT         DEFAULT ((0)) NOT NULL,
    [nadi2]              BIGINT         DEFAULT ((0)) NOT NULL,
    [crt]                BIGINT         DEFAULT ((0)) NOT NULL,
    [turgor]             BIGINT         DEFAULT ((0)) NOT NULL,
    [pendarahan]         BIGINT         DEFAULT ((0)) NOT NULL,
    [skalanyeri]         VARCHAR (20)   DEFAULT ('0') NOT NULL,
    [jenisskalanyeri]    BIGINT         DEFAULT ((0)) NOT NULL,
    [frekuensinyeri]     BIGINT         DEFAULT ((0)) NOT NULL,
    [menjalar]           BIGINT         DEFAULT ((0)) NOT NULL,
    [menjalarke]         BIGINT         DEFAULT ((0)) NOT NULL,
    [kualitasnyeri]      BIGINT         DEFAULT ((0)) NOT NULL,
    [kualitasnyerinote]  VARCHAR (20)   DEFAULT ('-') NOT NULL,
    [pemicupemberat]     VARCHAR (200)  DEFAULT ('-') NOT NULL,
    [pengurangnyeri]     VARCHAR (200)  DEFAULT ('-') NOT NULL,
    [aktifitasharian]    BIGINT         DEFAULT ((0)) NOT NULL,
    [statpsikologis]     BIGINT         DEFAULT ((0)) NOT NULL,
    [isjatuh]            BIGINT         DEFAULT ((0)) NOT NULL,
    [isalatbantu]        BIGINT         DEFAULT ((0)) NOT NULL,
    [issulitjalan]       BIGINT         DEFAULT ((0)) NOT NULL,
    [isyakinlayan]       BIGINT         DEFAULT ((0)) NOT NULL,
    [yakinlayan]         VARCHAR (200)  DEFAULT ('-') NOT NULL,
    [ishamil]            BIGINT         DEFAULT ((0)) NOT NULL,
    [gravida]            BIGINT         DEFAULT ((0)) NOT NULL,
    [para]               BIGINT         DEFAULT ((0)) NOT NULL,
    [abortus]            BIGINT         DEFAULT ((0)) NOT NULL,
    [hpht]               DATE           NULL,
    [isnafas]            BIGINT         DEFAULT ((0)) NOT NULL,
    [psikologis]         BIGINT         DEFAULT ((0)) NOT NULL,
    [ishambatanedukasi]  BIGINT         DEFAULT ((0)) NOT NULL,
    [jenishambatan]      BIGINT         DEFAULT ((0)) NOT NULL,
    [pendidikan]         BIGINT         DEFAULT ((0)) NOT NULL,
    [ispenerjemah]       BIGINT         DEFAULT ((0)) NOT NULL,
    [penerjemahbahasa]   VARCHAR (1)    DEFAULT ((0)) NULL,
    [jenistindaklanjut]  BIGINT         DEFAULT ((0)) NOT NULL,
    [idlocation]         BIGINT         DEFAULT ((0)) NOT NULL,
    [idbusinesspartner]  BIGINT         DEFAULT ((0)) NOT NULL,
    [indikasi]           VARCHAR (500)  DEFAULT ('-') NOT NULL,
    [jenispulang]        BIGINT         DEFAULT ((0)) NOT NULL,
    [rparamedis]         VARCHAR (50)   DEFAULT ('-') NOT NULL,
    [rspesialis]         VARCHAR (50)   DEFAULT ('-') NOT NULL,
    [rtanggal]           DATETIME       DEFAULT (getdate()) NOT NULL,
    [tindakan]           VARCHAR (200)  DEFAULT ('-') NOT NULL,
    [transpulang]        BIGINT         DEFAULT ((0)) NOT NULL,
    [transpulangnote]    VARCHAR (50)   DEFAULT ('-') NOT NULL,
    [fungsitubuh]        VARCHAR (8000) CONSTRAINT [DF__Assessmen__fungs__497AA94B] DEFAULT ('-') NOT NULL,
    [strukturtubuh]      VARCHAR (8000) CONSTRAINT [DF__Assessmen__struk__4A6ECD84] DEFAULT ('-') NOT NULL,
    [aktifitas]          VARCHAR (8000) CONSTRAINT [DF__Assessmen__aktif__4B62F1BD] DEFAULT ('-') NOT NULL,
    [partisipasi]        VARCHAR (8000) CONSTRAINT [DF__Assessmen__parti__4C5715F6] DEFAULT ('-') NOT NULL,
    [faktorlingkungan]   VARCHAR (8000) CONSTRAINT [DF__Assessmen__fakto__4D4B3A2F] DEFAULT ('-') NOT NULL,
    [faktorpersonal]     VARCHAR (8000) CONSTRAINT [DF__Assessmen__fakto__4E3F5E68] DEFAULT ('-') NOT NULL,
    [caramasuk]          VARCHAR (20)   DEFAULT ('-') NOT NULL,
    PRIMARY KEY CLUSTERED ([idassessment] ASC)
);




GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'jenis kamar 
assp igd', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assessment', @level2type = N'COLUMN', @level2name = N'idlocation';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'idrs/klinik
assp igd', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assessment', @level2type = N'COLUMN', @level2name = N'idbusinesspartner';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'periksa dokter
assp igd', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assessment', @level2type = N'COLUMN', @level2name = N'rparamedis';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'periksa dokter
assp igd', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assessment', @level2type = N'COLUMN', @level2name = N'rspesialis';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'periksa dokter assp igd', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assessment', @level2type = N'COLUMN', @level2name = N'rtanggal';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'pulangtindakan assp igd', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assessment', @level2type = N'COLUMN', @level2name = N'tindakan';

