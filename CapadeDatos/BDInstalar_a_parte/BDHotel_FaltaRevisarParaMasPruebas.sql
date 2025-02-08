USE [DBHotelCusco]
GO
/****** Object:  Table [dbo].[tblAccesos]    Script Date: 8/02/2025 18:19:31 ******/
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
/****** Object:  Table [dbo].[tblCatalogoServicios]    Script Date: 8/02/2025 18:19:31 ******/
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
/****** Object:  Table [dbo].[tblCliente]    Script Date: 8/02/2025 18:19:31 ******/
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
/****** Object:  Table [dbo].[tblEmpleado]    Script Date: 8/02/2025 18:19:31 ******/
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
/****** Object:  Table [dbo].[tblHabitacion]    Script Date: 8/02/2025 18:19:31 ******/
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
/****** Object:  Table [dbo].[tblPago]    Script Date: 8/02/2025 18:19:31 ******/
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
/****** Object:  Table [dbo].[tblReserva]    Script Date: 8/02/2025 18:19:31 ******/
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
/****** Object:  Table [dbo].[tblRol]    Script Date: 8/02/2025 18:19:31 ******/
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
/****** Object:  Table [dbo].[tblServiciosExtras]    Script Date: 8/02/2025 18:19:31 ******/
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
/****** Object:  Table [dbo].[tblSocio]    Script Date: 8/02/2025 18:19:31 ******/
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
/****** Object:  Table [dbo].[tblSucursal]    Script Date: 8/02/2025 18:19:31 ******/
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
/****** Object:  Table [dbo].[tblTarifa]    Script Date: 8/02/2025 18:19:31 ******/
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
/****** Object:  Table [dbo].[tblUsuario]    Script Date: 8/02/2025 18:19:31 ******/
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
ALTER TABLE [dbo].[tblEmpleado]  WITH CHECK ADD FOREIGN KEY([ID_Rol])
REFERENCES [dbo].[tblRol] ([ID_Rol])
GO
ALTER TABLE [dbo].[tblEmpleado]  WITH CHECK ADD FOREIGN KEY([ID_Sucursal])
REFERENCES [dbo].[tblSucursal] ([ID_Sucursal])
GO
ALTER TABLE [dbo].[tblHabitacion]  WITH CHECK ADD FOREIGN KEY([ID_Sucursal])
REFERENCES [dbo].[tblSucursal] ([ID_Sucursal])
GO
ALTER TABLE [dbo].[tblPago]  WITH CHECK ADD FOREIGN KEY([ID_Reserva])
REFERENCES [dbo].[tblReserva] ([ID_Reserva])
GO
ALTER TABLE [dbo].[tblPago]  WITH CHECK ADD FOREIGN KEY([ID_Socio])
REFERENCES [dbo].[tblSocio] ([ID_Socio])
GO
ALTER TABLE [dbo].[tblReserva]  WITH CHECK ADD FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[tblCliente] ([ID_Cliente])
GO
ALTER TABLE [dbo].[tblReserva]  WITH CHECK ADD FOREIGN KEY([ID_Habitacion])
REFERENCES [dbo].[tblHabitacion] ([ID_Habitacion])
GO
ALTER TABLE [dbo].[tblServiciosExtras]  WITH CHECK ADD FOREIGN KEY([ID_Reserva])
REFERENCES [dbo].[tblReserva] ([ID_Reserva])
GO
ALTER TABLE [dbo].[tblServiciosExtras]  WITH CHECK ADD FOREIGN KEY([ID_Servicio])
REFERENCES [dbo].[tblCatalogoServicios] ([ID_Servicio])
GO
ALTER TABLE [dbo].[tblTarifa]  WITH CHECK ADD FOREIGN KEY([ID_Habitacion])
REFERENCES [dbo].[tblHabitacion] ([ID_Habitacion])
GO
ALTER TABLE [dbo].[tblUsuario]  WITH CHECK ADD FOREIGN KEY([ID_Empleado])
REFERENCES [dbo].[tblEmpleado] ([ID_Empleado])
GO
/****** Object:  StoredProcedure [dbo].[PR_LOGIN]    Script Date: 8/02/2025 18:19:31 ******/
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
