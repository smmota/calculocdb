namespace CalculoCDBWebAPI.Application.DTO.DTO
{
    public class CalculoDTO
    {
        public Decimal ValorAplicado { get; set; }
        public int QuantidadeMeses { get; set; }
        public Decimal ValorBruto { get; set; }
        public Decimal ValorLiquido { get; set; }

        public CalculoDTO() { }

        public CalculoDTO(decimal? valorAplicado, int? quantidadeMeses, double taxaCDI, double taxaTBDecimal)
        {
            Calculo(valorAplicado, quantidadeMeses, taxaCDI, taxaTBDecimal);
        }

        public CalculoDTO Calculo(decimal? valorAplicado, int? quantidadeMeses, double taxaCDI, double taxaTB)
        {
            var taxas = Convert.ToDecimal(taxaCDI * taxaTB);

            ValorAplicado = valorAplicado?? 0;
            QuantidadeMeses = quantidadeMeses?? 0;
            ValorBruto = Math.Round(ValorAplicado * (QuantidadeMeses + (taxas)), 2);
            ValorLiquido = 100;

            return new CalculoDTO();
        }
    }
}
