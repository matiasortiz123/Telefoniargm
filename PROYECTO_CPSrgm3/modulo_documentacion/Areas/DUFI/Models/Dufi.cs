using modulo_documentacion.Areas.Admin.Models.Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.DUFI.Models
{
    public class Dufi
    {

        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int EstadoId { get; set; }
        public Usuario Usuario { get; set; }
        public Estado Estado { get; set; }
        public byte? DeseaOOMMP { get; set; }
        public DateTime FechaElevacionJefePersonal { get; set; }
        public DateTime FechaElevacionJefeElemento { get; set; }
        public DateTime FechaElevacionDGP { get; set; }



        public CargoActual CargoActual { get; set; }
        public List<CargoDocenteProf> CargoDocenteProf { get; set; }
        public DestinoFuturo DestinoFuturo { get; set; }
        public List<ExpedienteCD> ExpedienteCD { get; set; }
        public GuarnicionFuturo GuarnicionFuturo { get; set; }
        public List<IdiomaDufi> IdiomaDufi { get; set; }
        public List<MisionComExt> MisionComExt { get; set; }
        public List<AptEspDufi> AptEspDufi { get; set; }
        public List<CursosEspDufi> CursosEspDufi { get; set; }
        public ConductorMotorista ConductorMotorista { get; set; }
        public List<RegistroConductorDufi> RegistroConductorDufi { get; set; }

    }
}
