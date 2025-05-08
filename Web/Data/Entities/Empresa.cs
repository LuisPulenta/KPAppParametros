using System.ComponentModel.DataAnnotations;

namespace Web.Data.Entities
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }
        public string NombreEmpresa { get; set; }
        public int HabilitaEmpresa { get; set; }
        public int HabilitaObras { get; set; }
        public int HabilitaInventarios { get; set; }
        public int HabilitaInstalaciones { get; set; }
        public int HabilitaFlotas { get; set; }
        public int HabilitaRRHH { get; set; }
        public int HabilitaReciboSueldos { get; set; }
        public string LinkApi { get; set; }
        public int HabilitaCompras { get; set; }
    }
}