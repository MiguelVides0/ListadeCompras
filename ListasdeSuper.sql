USE [ListasdeSuper]
GO
/****** Object:  Table [dbo].[Listas]    Script Date: 15/9/2022 22:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Listas](
	[Idlista] [int] IDENTITY(1,1) NOT NULL,
	[Codigolista] [varchar](150) NOT NULL,
	[Fechacompra] [varchar](150) NOT NULL,
	[Supermercado] [varchar](150) NOT NULL,
	[Producto] [varchar](150) NOT NULL,
	[Precio] [int] NOT NULL,
 CONSTRAINT [PK_Listas] PRIMARY KEY CLUSTERED 
(
	[Idlista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Listas] ON 
GO
INSERT [dbo].[Listas] ([Idlista], [Codigolista], [Fechacompra], [Supermercado], [Producto], [Precio]) VALUES (5, N'lista0', N'25/11/2021', N'la tiendona', N'zanahoria', 6)
GO
INSERT [dbo].[Listas] ([Idlista], [Codigolista], [Fechacompra], [Supermercado], [Producto], [Precio]) VALUES (6, N'lista0', N'25/11/2021', N'la tiendona', N'Guisquiles', 3)
GO
INSERT [dbo].[Listas] ([Idlista], [Codigolista], [Fechacompra], [Supermercado], [Producto], [Precio]) VALUES (7, N'lista0', N'25/11/2021', N'la tiendona', N'apios', 2)
GO
INSERT [dbo].[Listas] ([Idlista], [Codigolista], [Fechacompra], [Supermercado], [Producto], [Precio]) VALUES (8, N'lista0', N'25/11/2021', N'la tiendona', N'cebollas', 6)
GO
INSERT [dbo].[Listas] ([Idlista], [Codigolista], [Fechacompra], [Supermercado], [Producto], [Precio]) VALUES (9, N'lista0', N'25/11/2021', N'la tiendona', N'sandía', 5)
GO
INSERT [dbo].[Listas] ([Idlista], [Codigolista], [Fechacompra], [Supermercado], [Producto], [Precio]) VALUES (10, N'lista0', N'25/11/2021', N'la tiendona', N'papaya', 4)
GO
INSERT [dbo].[Listas] ([Idlista], [Codigolista], [Fechacompra], [Supermercado], [Producto], [Precio]) VALUES (11, N'lista1', N'26/11/2021', N'Maxi Despensa', N'Mayonesa', 4)
GO
INSERT [dbo].[Listas] ([Idlista], [Codigolista], [Fechacompra], [Supermercado], [Producto], [Precio]) VALUES (12, N'lista1', N'26/11/2021', N'Maxi Despensa', N'Jamón', 1)
GO
INSERT [dbo].[Listas] ([Idlista], [Codigolista], [Fechacompra], [Supermercado], [Producto], [Precio]) VALUES (13, N'lista1', N'26/11/2021', N'Maxi Despensa', N'Pan de caja', 2)
GO
INSERT [dbo].[Listas] ([Idlista], [Codigolista], [Fechacompra], [Supermercado], [Producto], [Precio]) VALUES (14, N'lista1', N'26/11/2021', N'Maxi Despensa', N'Ketchup', 4)
GO
INSERT [dbo].[Listas] ([Idlista], [Codigolista], [Fechacompra], [Supermercado], [Producto], [Precio]) VALUES (17, N'lista2', N'27/11/2021', N'Super Selectos', N'carne', 15)
GO
INSERT [dbo].[Listas] ([Idlista], [Codigolista], [Fechacompra], [Supermercado], [Producto], [Precio]) VALUES (18, N'lista2', N'27/11/2021', N'Super Selectos', N'pollo', 30)
GO
INSERT [dbo].[Listas] ([Idlista], [Codigolista], [Fechacompra], [Supermercado], [Producto], [Precio]) VALUES (20, N'lista2', N'27/11/2021', N'Super Selectos', N'Arroz', 20)
GO
SET IDENTITY_INSERT [dbo].[Listas] OFF
GO
