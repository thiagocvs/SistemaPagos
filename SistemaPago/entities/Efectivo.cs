public class Efectivo : Pago
{
    private string Divisa;
    public Efectivo(string titular, double montoOriginal, DateTime fecha, string divisa) : base(titular, montoOriginal, fecha)
    {
        this.Divisa = divisa;
    }

    public string divisa { get => Divisa; set => Divisa = value; }

    public override double ProcesarPago()
    {
        return ObtenerMontoFinal(montoOriginal, CalcularComision());
    }

    public override double CalcularComision()
    {
        return 0;
    }

    public override double ObtenerMontoFinal(double montoOriginal, double comision)
    {
        return montoOriginal + comision;
    }
}