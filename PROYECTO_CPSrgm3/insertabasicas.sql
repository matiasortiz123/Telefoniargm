/* ESTRUCTURA DE TABLAS NUEVAS
Escolaridad */
SET IDENTITY_INSERT Escolaridad ON
INSERT INTO Escolaridad (Id, Descripcion, Tipo) VALUES
	(1, 'Ninguno', 2),
	(2, 'Jardín', 2),
	(3, 'Primario', 3),
	(4, 'Secundario', 3),
	(5, 'Terciario', 3),
	(6, 'Universitario', 3),
	(7, 'Posgrado', 1),
	(8, 'Cursos', 1);
	SET IDENTITY_INSERT Escolaridad OFF

	-- --------------------------------------------------------
-- Host:                         localhost
-- VersiÃ³n del servidor:         10.4.8-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL VersiÃ³n:             10.2.0.5599
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Volcando estructura para tabla mysql.provinciasddjj


-- Volcando datos para la tabla mysql.provinciasddjj: ~24 rows (aproximadamente)
/*!40000 ALTER TABLE `provinciasddjjDISABLE KEYS */;
SET IDENTITY_INSERT provincia ON
INSERT INTO provincia(Latitud,Longitud, Id, Descripcion, DescripcionCompleta) VALUES
	('-26.8753965086829', '-54.6516966230371', '54', 'Misiones', 'Provincia de Misiones'),
	('-33.7577257449137', '-66.0281298195836', '74', 'San Luis', 'Provincia de San Luis'),
	('-30.8653679979618', '-68.8894908486844', '70', 'San Juan', 'Provincia de San Juan'),
	('-32.0588735436448', '-59.2014475514635', '30', 'Entre Ríos', 'Provincia de Entre Ríos'),
	('-48.8154851827063', '-69.9557621671973', '78', 'Santa Cruz', 'Provincia de Santa Cruz'),
	('-40.4057957178801', '-67.229329893694', '62', 'Río Negro', 'Provincia de Río Negro'),
	('-43.7886233529878', '-68.5267593943345', '26', 'Chubut', 'Provincia del Chubut'),
	('-32.142932663607', '-63.8017532741662', '14', 'Cordoba', 'Provincia de Córdoba'),
	('-34.6298873058957', '-68.5831228183798', '50', 'Mendoza', 'Provincia de Mendoza'),
	('-29.685776298315', '-67.1817359694432', '46', 'La Rioja', 'Provincia de La Rioja'),
	('-27.3358332810217', '-66.9476824299928', '10', 'Catamarca', 'Provincia de Catamarca'),
	('-37.1315537735949', '-65.4466546606951', '42', 'La Pampa', 'Provincia de La Pampa'),
	('-27.7824116550944', '-63.2523866568588', '86', 'Santiago del Estero', 'Provincia de Santiago del Estero'),
	('-28.7743047046407', '-57.8012191977913', '18', 'Corrientes', 'Provincia de Corrientes'),
	('-30.7069271588117', '-60.9498369430241', '82', 'Santa Fe', 'Provincia de Santa Fe'),
	('-26.9478001830786', '-65.3647579441481', '90', 'Tucumán', 'Provincia de Tucumán'),
	('-38.6417575824599', '-70.1185705180601', '58', 'Neuquén', 'Provincia del Neuquén'),
	('-24.2991344492002', '-64.8144629600627', '66', 'Salta', 'Provincia de Salta'),
	('-26.3864309061226', '-60.7658307438603', '22', 'Chaco', 'Provincia del Chaco'),
	('-24.894972594871', '-59.9324405800872', '34', 'Formosa', 'Provincia de Formosa'),
	('-23.3200784211351', '-65.7642522180337', '38', 'Jujuy', 'Provincia de Jujuy'),
	('-34.6144934119689', '-58.4458563545429', '02', 'Ciudad Autónoma de Buenos Aires', 'Ciudad Autónoma de Buenos Aires'),
	('-36.6769415180527', '-60.5588319815719', '06', 'Buenos Aires', 'Provincia de Buenos Aires'),
	('-82.52151781221', '-50.7427486049785', '94', 'Tierra del Fuego, Antártida e Islas del Atlántico Sur', 'Provincia de Tierra del Fuego, Antártida e Islas del Atlántico Sur');
	SET IDENTITY_INSERT provincia OFF
/*!40000 ALTER TABLE `provinciasddjjENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;


/*Djurada Estados */
SET IDENTITY_INSERT Estado ON
INSERT INTO Estado (Id, Codigo, Descripcion) VALUES
	(1, 'A', 'No Confeccionado'),
	(2, 'B', 'Confeccionado por el Causante y Sin Confirmar'),
	(3, 'C', 'Elevado al Área de Personal'),
	(4, 'D', 'Completado por el Área de Personal'),
	(5, 'E', 'Observado por el Área de personal'),
	(6, 'F', 'Elevado al Jefe de Elemento'),
	(7, 'G', 'Completado por Aux Jefe de Elemento'),
	(8, 'H', 'Observado por el Jefe de Elemento'),
	(9, 'I', 'Elevado a la Dirección General de Personal'),
	(10, 'J', 'Solicitud de modificación'),
	(11, 'K', 'Autorizar Solicitud de modificación'),
	(12, 'L', 'Ultima elevada a la DGPB');
	SET IDENTITY_INSERT Estado OFF


	SET IDENTITY_INSERT EstadoCivil ON
	INSERT INTO EstadoCivilOtraSituacion(Id, Descripcion) VALUES
	(1, 'Separado/a'),
	(2, 'Convivencia con Certificado de Convivencia'),
	(3, 'Convivencia con Certificado de Unión Civil'),
	(4, 'Ninguna'),
	(5, 'Otras');
	SET IDENTITY_INSERT EstadoCivil OFF

	SET IDENTITY_INSERT EstadoCivil ON
	INSERT INTO EstadoCivil(Id, Descripcion) VALUES
	(1, 'Soltero/a'),
	(2, 'Casado/a'),
	(3, 'Divorciado/a'),
	(4, 'Viudo/a');
	SET IDENTITY_INSERT EstadoCivil OFF


	
	INSERT INTO Genero( Descripcion) VALUES
	('Masculino'),
	('Femenino');

	INSERT INTO Parentesco( Descripcion) VALUES
	('Conyuge'),
	('Conviviente '),
	('Guarda'),
	('Hijo/a'),
	('Madre'),
	('Padre'),
	('Tenencia'),
	('Tutela');

	INSERT INTO SituacionLaboral( Descripcion) VALUES
	('Personal Militar FFAA'),
	('Personal Civil FFAA'),
	('Personal Fuerza de Seguridad'),
	('Personal Civil Fuerza de Seguridad'),
	('Ama de Casa'),
	('Otros'),
	('Ninguno');
	SET IDENTITY_INSERT TipoDocumento ON
	INSERT INTO TipoDocumento(Id, Descripcion) VALUES
	(1, 'DNI'),
	(2, 'L.E.'),
	(3, 'Pasaporte'),
	(4, 'Otros');
	SET IDENTITY_INSERT TipoDocumento OFF


	SET IDENTITY_INSERT TipoDocumentoAdjunto ON
	INSERT INTO	TipoDocumentoAdjunto(Id, Descripcion) VALUES
	(1, 'DNI / LE / CI'),
	(2, 'LE'),
	(3, 'Pasaporte'),
	(4, 'Certificado de Estudios\r\n\r\n'),
	(5, 'Acta de Matrimonio'),
	(6, 'Acta de Nacimiento'),
	(7, 'Acta de Defunción '),
	(8, 'Certificado de discapacidad'),
	(9, 'Acta de Divorcio '),
	(10, 'Titulo Terciario / Universitario'),
	(11, 'Titulo Licenciatura / Maestria / Doctorado'),
	(12, 'Otros documentos');
		SET IDENTITY_INSERT TipoDocumentoAdjunto OFF