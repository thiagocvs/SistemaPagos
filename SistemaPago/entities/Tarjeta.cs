public class Tarjeta : Pago
{
    private string NumeroTarjeta;
    private string TipoTarjeta;

    public Tarjeta(string titular, double montoOriginal, DateTime fecha, string numeroTarjeta, string tipoTarjeta)
        : base(titular, montoOriginal, fecha)
    {
        this.NumeroTarjeta = numeroTarjeta;
        this.TipoTarjeta = tipoTarjeta;
    }

    public string numeroTarjeta { get => NumeroTarjeta; set => NumeroTarjeta = value; }
    public string tipoTarjeta { get => TipoTarjeta; set => TipoTarjeta = value; }

    public override double ProcesarPago()
    {
        double comision = CalcularComision();
        return ObtenerMontoFinal(montoOriginal, comision);
    }

    public override double CalcularComision()
    {
        return montoOriginal * 0.10;
    }

    public override double ObtenerMontoFinal(double montoOriginal, double comision)
    {
        return montoOriginal + comision;
    }
}
