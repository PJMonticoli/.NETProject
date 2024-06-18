USE [Bancos]
GO

/****** Object:  Table [dbo].[EcheqRecibidos]    Script Date: 18/06/2024 15:16:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EcheqRecibidos](
	[NroValor] [int] IDENTITY(1,1) NOT NULL,
	[nroCheque] [varchar](100) NULL,
	[cuitEmisor] [varchar](12) NULL,
	[razonSocial] [varchar](100) NULL,
	[bancoEmision] [varchar](50) NULL,
	[fechaEmision] [datetime] NULL,
	[fechaPago] [datetime] NULL,
	[importe] [decimal](15, 2) NULL,
	[Cmc7] [varchar](100) NULL,
	[IdCheque] [varchar](100) NULL,
	[estadoCheque] [varchar](20) NULL,
	[tipoEmision] [varchar](50) NULL,
	[CUITEndoso] [varchar](11) NULL,
	[razonSocialEndoso] [varchar](100) NULL,
	[fechaRegistro] [datetime] NULL,
 CONSTRAINT [PK_echeqrecibidos] PRIMARY KEY CLUSTERED 
(
	[NroValor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


