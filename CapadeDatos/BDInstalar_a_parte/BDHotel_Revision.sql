USE [DBHotelCusco]
GO
/****** Object:  Table [dbo].[tblAccesos]    Script Date: 8/02/2025 19:08:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAccesos](
	[NumeroRegistro] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Ingreso] [datetime] NULL,
	[Fecha_Salida] [datetime] NULL,
	[Usuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NumeroRegistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCatalogoServicios]    Script Date: 8/02/2025 19:08:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCatalogoServicios](
	[ID_Servicio] [int] IDENTITY(1,1) NOT NULL,
	[ServicioNombre] [varchar](100) NOT NULL,
	[Descripcion] [text] NOT NULL,
	[serPrecioUni] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCliente]    Script Date: 8/02/2025 19:08:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCliente](
	[ID_Cliente] [int] NOT NULL,
	[cliNombre] [varchar](100) NOT NULL,
	[cliApellido] [varchar](100) NOT NULL,
	[cliTelefono] [varchar](30) NULL,
	[cliCorreo] [varchar](100) NULL,
	[cliEstado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEmpleado]    Script Date: 8/02/2025 19:08:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmpleado](
	[ID_Empleado] [int] NOT NULL,
	[emNombre] [varchar](1) NOT NULL,
	[emApellido] [varchar](1) NOT NULL,
	[emFechaNacimiento] [datetime] NOT NULL,
	[emFechaIngreso] [datetime] NULL,
	[emEstado] [varchar](1) NULL,
	[ID_Sucursal] [int] NOT NULL,
	[ID_Rol] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHabitacion]    Script Date: 8/02/2025 19:08:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHabitacion](
	[ID_Habitacion] [int] IDENTITY(1,1) NOT NULL,
	[hbNumero] [int] NOT NULL,
	[hbTipo] [varchar](50) NOT NULL,
	[hbDescripcion] [varchar](200) NOT NULL,
	[hbEstado] [varchar](20) NULL,
	[ID_Sucursal] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Habitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPago]    Script Date: 8/02/2025 19:08:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPago](
	[ID_Pago] [int] IDENTITY(1,1) NOT NULL,
	[ID_Reserva] [int] NULL,
	[ID_Socio] [int] NULL,
	[PagoMonto] [decimal](10, 2) NULL,
	[FechaPago] [datetime] NULL,
	[MetodoPago] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblReserva]    Script Date: 8/02/2025 19:08:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblReserva](
	[ID_Reserva] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cliente] [int] NULL,
	[ID_Habitacion] [int] NULL,
	[FechaEntrada] [datetime] NOT NULL,
	[FechaSalida] [datetime] NOT NULL,
	[PrecioVenta] [decimal](10, 2) NOT NULL,
	[Adelanto] [decimal](10, 2) NULL,
	[EstadoReserva] [varchar](30) NULL,
	[EstadoPago] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRol]    Script Date: 8/02/2025 19:08:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRol](
	[ID_Rol] [int] NOT NULL,
	[rolNombre] [varchar](1) NOT NULL,
	[rolDescripcion] [varchar](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblServiciosExtras]    Script Date: 8/02/2025 19:08:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblServiciosExtras](
	[ID_ServiciosExtras] [int] IDENTITY(1,1) NOT NULL,
	[ID_Reserva] [int] NOT NULL,
	[ID_Servicio] [int] NULL,
	[NombrePerzonalizado] [varchar](100) NULL,
	[Descripcion] [text] NULL,
	[PrecioExtra] [decimal](10, 2) NOT NULL,
	[CantidadSolicitada] [int] NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_ServiciosExtras] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSocio]    Script Date: 8/02/2025 19:08:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSocio](
	[ID_Socio] [int] NOT NULL,
	[socNombre] [varchar](100) NOT NULL,
	[socTipoFondo] [varchar](50) NOT NULL,
	[socTasa] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Socio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSucursal]    Script Date: 8/02/2025 19:08:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSucursal](
	[ID_Sucursal] [int] IDENTITY(1,1) NOT NULL,
	[SucNombre] [varchar](50) NOT NULL,
	[SucDireccion] [varchar](100) NOT NULL,
	[SucResponzable] [varchar](100) NOT NULL,
	[SucTelefono] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTarifa]    Script Date: 8/02/2025 19:08:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTarifa](
	[ID_Tarifa] [int] IDENTITY(1,1) NOT NULL,
	[ID_Habitacion] [int] NULL,
	[taModo] [varchar](10) NULL,
	[taPrecioSugerido] [decimal](10, 2) NOT NULL,
	[taPrecioMax] [decimal](10, 2) NOT NULL,
	[taPrecioMin] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Tarifa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUsuario]    Script Date: 8/02/2025 19:08:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUsuario](
	[ID_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](100) NOT NULL,
	[Contraseña] [varchar](100) NOT NULL,
	[RolUsuario] [varchar](50) NOT NULL,
	[FechaCreacion] [datetime] NULL,
	[Estado] [varchar](20) NULL,
	[Responsable] [varchar](100) NULL,
	[Telefono] [varchar](15) NULL,
	[ID_Empleado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblCliente] ([ID_Cliente], [cliNombre], [cliApellido], [cliTelefono], [cliCorreo], [cliEstado]) VALUES (12321452, N'Tomas', N'Alves', N'+51 123456789', N'Tomas@gmail.com', 0)
GO
INSERT [dbo].[tblCliente] ([ID_Cliente], [cliNombre], [cliApellido], [cliTelefono], [cliCorreo], [cliEstado]) VALUES (12345678, N'Juan', N'Quispe', N'+51 123456789', N'Juan@gmail.com', 1)
GO
INSERT [dbo].[tblCliente] ([ID_Cliente], [cliNombre], [cliApellido], [cliTelefono], [cliCorreo], [cliEstado]) VALUES (23325231, N'Rosas', N'Torres', N'+51 987654321', N'Rosas@gmail.com', 1)
GO
INSERT [dbo].[tblCliente] ([ID_Cliente], [cliNombre], [cliApellido], [cliTelefono], [cliCorreo], [cliEstado]) VALUES (23423523, N'Concurdo', N'Avelardo', N'+51 123456789', N'Concurdo@gmail.com', 2)
GO
SET IDENTITY_INSERT [dbo].[tblHabitacion] ON 
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (1, 101, N'Matrimonial', N'Habitación privada, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (2, 102, N'Matrimonial', N'Habitación privada, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (3, 104, N'Matrimonial', N'Habitación privada, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (4, 105, N'Doble', N'Dos camas de plaza y media, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (5, 106, N'Simple', N'Una cama de plaza y media', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (6, 201, N'Cuádruple', N'Una cama matrimonial y dos camas simples, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (7, 202, N'Triple', N'Tres camas de plaza y media, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (8, 203, N'Doble', N'Dos camas de plaza y media, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (9, 204, N'Doble', N'Dos camas de plaza y media, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (10, 205, N'Matrimonial', N'Habitación privada, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (11, 206, N'Doble', N'Dos camas de plaza y media, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (12, 207, N'Familiar', N'Una cama matrimonial y una simple, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (13, 301, N'Doble', N'Dos camas de plaza y media, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (14, 302, N'Sextuple', N'Seis camas individuales, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (15, 101, N'Matrimonial', N'Habitación privada, baño privado', N'Disponible', 2)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (16, 102, N'Triple', N'Tres camas de plaza y media, baño privado', N'Disponible', 2)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (17, 201, N'Doble', N'Dos camas de plaza y media, baño privado', N'Disponible', 2)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (18, 202, N'Doble', N'Dos camas de plaza y media, baño privado', N'Disponible', 2)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (19, 203, N'Matrimonial', N'Habitación privada, baño compartido', N'Disponible', 2)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (20, 204, N'Familiar', N'Una cama matrimonial y una simple, baño privado', N'Disponible', 2)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (21, 205, N'Simple', N'Una cama de plaza y media, baño compartido', N'Disponible', 2)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (22, 301, N'Familiar', N'Una cama matrimonial y una simple, baño privado', N'Disponible', 2)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (23, 302, N'Matrimonial', N'Habitación privada, baño privado', N'Disponible', 2)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (24, 303, N'Matrimonial', N'Habitación privada, baño privado', N'Disponible', 2)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (25, 101, N'Matrimonial', N'Habitación privada, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (26, 102, N'Matrimonial', N'Habitación privada, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (27, 104, N'Matrimonial', N'Habitación privada, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (28, 105, N'Doble', N'Dos camas de plaza y media, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (29, 106, N'Simple', N'Una cama de plaza y media', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (30, 201, N'Cuádruple', N'Una cama matrimonial y dos camas simples, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (31, 202, N'Triple', N'Tres camas de plaza y media, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (32, 203, N'Doble', N'Dos camas de plaza y media, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (33, 204, N'Doble', N'Dos camas de plaza y media, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (34, 205, N'Matrimonial', N'Habitación privada, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (35, 206, N'Doble', N'Dos camas de plaza y media, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (36, 207, N'Familiar', N'Una cama matrimonial y una simple, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (37, 301, N'Doble', N'Dos camas de plaza y media, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (38, 302, N'Sextuple', N'Seis camas individuales, baño privado', N'Disponible', 1)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (39, 101, N'Matrimonial', N'Habitación privada, baño privado', N'Disponible', 2)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (40, 102, N'Triple', N'Tres camas de plaza y media, baño privado', N'Disponible', 2)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (41, 201, N'Doble', N'Dos camas de plaza y media, baño privado', N'Disponible', 2)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (42, 202, N'Doble', N'Dos camas de plaza y media, baño privado', N'Disponible', 2)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (43, 203, N'Matrimonial', N'Habitación privada, baño compartido', N'Disponible', 2)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (44, 204, N'Familiar', N'Una cama matrimonial y una simple, baño privado', N'Disponible', 2)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (45, 205, N'Simple', N'Una cama de plaza y media, baño compartido', N'Disponible', 2)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (46, 301, N'Familiar', N'Una cama matrimonial y una simple, baño privado', N'Disponible', 2)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (47, 302, N'Matrimonial', N'Habitación privada, baño privado', N'Disponible', 2)
GO
INSERT [dbo].[tblHabitacion] ([ID_Habitacion], [hbNumero], [hbTipo], [hbDescripcion], [hbEstado], [ID_Sucursal]) VALUES (48, 303, N'Matrimonial', N'Habitación privada, baño privado', N'Disponible', 2)
GO
SET IDENTITY_INSERT [dbo].[tblHabitacion] OFF
GO
SET IDENTITY_INSERT [dbo].[tblSucursal] ON 
GO
INSERT [dbo].[tblSucursal] ([ID_Sucursal], [SucNombre], [SucDireccion], [SucResponzable], [SucTelefono]) VALUES (1, N'Sucursal 1', N'Sin definir', N'Andres', N'+51 123456789')
GO
INSERT [dbo].[tblSucursal] ([ID_Sucursal], [SucNombre], [SucDireccion], [SucResponzable], [SucTelefono]) VALUES (2, N'Sucursal 2', N'Sin definir', N'Fernando', N'+51 987654321')
GO
SET IDENTITY_INSERT [dbo].[tblSucursal] OFF
GO
SET IDENTITY_INSERT [dbo].[tblTarifa] ON 
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (1, 1, N'Normal', CAST(100.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (2, 1, N'Simple', CAST(60.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (3, 2, N'Normal', CAST(100.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (4, 2, N'Simple', CAST(60.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (5, 3, N'Normal', CAST(100.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (6, 3, N'Simple', CAST(60.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (7, 4, N'Normal', CAST(100.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (8, 4, N'Simple', CAST(60.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (9, 5, N'Normal', CAST(60.00 AS Decimal(10, 2)), CAST(90.00 AS Decimal(10, 2)), CAST(40.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (10, 6, N'Normal', CAST(160.00 AS Decimal(10, 2)), CAST(200.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (11, 7, N'Normal', CAST(140.00 AS Decimal(10, 2)), CAST(180.00 AS Decimal(10, 2)), CAST(105.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (12, 8, N'Normal', CAST(100.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (13, 8, N'Simple', CAST(60.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (14, 9, N'Normal', CAST(100.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (15, 9, N'Simple', CAST(60.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (16, 10, N'Normal', CAST(100.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (17, 10, N'Simple', CAST(60.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (18, 11, N'Normal', CAST(100.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (19, 11, N'Simple', CAST(60.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (20, 12, N'Normal', CAST(120.00 AS Decimal(10, 2)), CAST(150.00 AS Decimal(10, 2)), CAST(80.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (21, 13, N'Normal', CAST(100.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (22, 13, N'Simple', CAST(60.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (23, 14, N'Normal', CAST(150.00 AS Decimal(10, 2)), CAST(300.00 AS Decimal(10, 2)), CAST(40.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (24, 15, N'Normal', CAST(100.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (25, 15, N'Simple', CAST(60.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (26, 16, N'Normal', CAST(140.00 AS Decimal(10, 2)), CAST(180.00 AS Decimal(10, 2)), CAST(105.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (27, 17, N'Normal', CAST(100.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (28, 17, N'Simple', CAST(60.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (29, 18, N'Normal', CAST(100.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (30, 18, N'Simple', CAST(60.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (31, 19, N'Normal', CAST(80.00 AS Decimal(10, 2)), CAST(100.00 AS Decimal(10, 2)), CAST(60.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (32, 19, N'Simple', CAST(50.00 AS Decimal(10, 2)), CAST(60.00 AS Decimal(10, 2)), CAST(40.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (33, 20, N'Normal', CAST(120.00 AS Decimal(10, 2)), CAST(150.00 AS Decimal(10, 2)), CAST(80.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (34, 21, N'Normal', CAST(60.00 AS Decimal(10, 2)), CAST(80.00 AS Decimal(10, 2)), CAST(40.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (35, 22, N'Normal', CAST(120.00 AS Decimal(10, 2)), CAST(150.00 AS Decimal(10, 2)), CAST(80.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (36, 23, N'Normal', CAST(100.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (37, 23, N'Simple', CAST(60.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (38, 24, N'Normal', CAST(100.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblTarifa] ([ID_Tarifa], [ID_Habitacion], [taModo], [taPrecioSugerido], [taPrecioMax], [taPrecioMin]) VALUES (39, 24, N'Simple', CAST(60.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[tblTarifa] OFF
GO
SET IDENTITY_INSERT [dbo].[tblUsuario] ON 
GO
INSERT [dbo].[tblUsuario] ([ID_Usuario], [Usuario], [Contraseña], [RolUsuario], [FechaCreacion], [Estado], [Responsable], [Telefono], [ID_Empleado]) VALUES (1, N'User1', N'admin123', N'Administrador', CAST(N'2025-02-08T18:14:40.430' AS DateTime), N'Activo', N'Carlos Fernández', N'987654321', NULL)
GO
INSERT [dbo].[tblUsuario] ([ID_Usuario], [Usuario], [Contraseña], [RolUsuario], [FechaCreacion], [Estado], [Responsable], [Telefono], [ID_Empleado]) VALUES (2, N'User2', N'recep2024', N'Recepcionista', CAST(N'2025-02-08T18:14:40.430' AS DateTime), N'Activo', N'María López', N'945678123', NULL)
GO
INSERT [dbo].[tblUsuario] ([ID_Usuario], [Usuario], [Contraseña], [RolUsuario], [FechaCreacion], [Estado], [Responsable], [Telefono], [ID_Empleado]) VALUES (3, N'User3', N'limpieza01', N'Supervisor de Limpieza', CAST(N'2025-02-08T18:14:40.430' AS DateTime), N'Activo', N'Juan Pérez', N'912345678', NULL)
GO
SET IDENTITY_INSERT [dbo].[tblUsuario] OFF
GO
ALTER TABLE [dbo].[tblAccesos] ADD  DEFAULT (getdate()) FOR [Fecha_Ingreso]
GO
ALTER TABLE [dbo].[tblEmpleado] ADD  DEFAULT (getdate()) FOR [emFechaIngreso]
GO
ALTER TABLE [dbo].[tblEmpleado] ADD  DEFAULT ('Disponible') FOR [emEstado]
GO
ALTER TABLE [dbo].[tblHabitacion] ADD  DEFAULT ('Disponible') FOR [hbEstado]
GO
ALTER TABLE [dbo].[tblPago] ADD  DEFAULT ((0)) FOR [PagoMonto]
GO
ALTER TABLE [dbo].[tblPago] ADD  DEFAULT (getdate()) FOR [FechaPago]
GO
ALTER TABLE [dbo].[tblReserva] ADD  DEFAULT ((0)) FOR [Adelanto]
GO
ALTER TABLE [dbo].[tblReserva] ADD  DEFAULT ('Reservada') FOR [EstadoReserva]
GO
ALTER TABLE [dbo].[tblReserva] ADD  DEFAULT ('Pendiente') FOR [EstadoPago]
GO
ALTER TABLE [dbo].[tblServiciosExtras] ADD  DEFAULT ((1)) FOR [CantidadSolicitada]
GO
ALTER TABLE [dbo].[tblServiciosExtras] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[tblUsuario] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[tblUsuario] ADD  DEFAULT ('Activo') FOR [Estado]
GO
/****** Object:  StoredProcedure [dbo].[PR_LOGIN]    Script Date: 8/02/2025 19:08:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PR_LOGIN]
	@Usuario VARCHAR(50),
	@Contraseña VARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @IDUsuario INT;
	DECLARE @Rol VARCHAR(50);
	DECLARE @Estado VARCHAR(20);
	DECLARE @Responsable VARCHAR(100);
	DECLARE @Mensaje VARCHAR(255);

	SELECT  
		@IDUsuario = ID_Usuario,
		@Rol = RolUsuario,
		@Estado = Estado,
		@Responsable = Responsable
	FROM tblUsuario 
	WHERE Usuario = @Usuario;

	 -- Validaciones y respuesta
    IF @IDUsuario IS NULL
    BEGIN
        SET @Mensaje = 'Usuario no encontrado.';
        SELECT NULL AS ID_Usuario, NULL AS RolUsuario, NULL AS Responsable, @Mensaje AS Mensaje;
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM tblUsuario WHERE Usuario = @Usuario AND Contraseña = @Contraseña)
    BEGIN
        SET @Mensaje = 'Contraseña incorrecta.';
        SELECT NULL AS ID_Usuario, NULL AS RolUsuario, NULL AS Responsable, @Mensaje AS Mensaje;
        RETURN;
    END

    IF @Estado <> 'Activo'
    BEGIN
        SET @Mensaje = 'El usuario está inactivo. Contacte con el administrador.';
        SELECT NULL AS ID_Usuario, NULL AS RolUsuario, NULL AS Responsable, @Mensaje AS Mensaje;
        RETURN;
    END

    -- Si pasa todas las validaciones, el inicio de sesión es exitoso
    SET @Mensaje = 'Inicio de sesión exitoso.';
    SELECT @IDUsuario AS ID_Usuario, @Rol AS RolUsuario, @Responsable AS Responsable, @Mensaje AS Mensaje;
END;
GO
