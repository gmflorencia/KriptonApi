namespace KriptonApi.DTOs
{
    public class TransaccionDto
    {
        public int IdCuentaOrigen { get; set; }
        public int IdCuentaDestino { get; set; }
        public int IdTipoTransaccion { get; set; }
        public double Monto { get; set; }
        public DateTime FechaTransferencia { get; set; }
    }
}
