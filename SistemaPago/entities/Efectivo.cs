public class Efectivo : Pago
{
    private string Divisa;
    public Efectivo(string titular, double montoOriginal, DateTime fecha, string divisa) : base(titular, montoOriginal, fecha)
    {
        this.Divisa1 = divisa;
    }

    public string divisa { get => Divisa; set => Divisa = value; }

    public override decimal ProcesarPago()
    {
        return montoOriginal;
    }
}