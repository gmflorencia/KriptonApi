namespace KriptonApi.DTOs
{
    public class CompraCriptoDto
    {
        public int IdCuentaOrigen { get; set; }
        public int IdCuentaDestino { get; set; }
        public int IdTipoTransaccion { get; set; }
        public int IdCripto { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaTransaccion { get; set; }
    }
}
