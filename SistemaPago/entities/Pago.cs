public abstract class Pago
{
    private string Titular;
    private double MontoOriginal;
    private DateTime Fecha;

    public Pago(string titular, double montoOriginal, DateTime fecha)
    {
        this.Titular = titular;
        this.MontoOriginal = montoOriginal;
        this.Fecha = fecha;
        this.MontoOriginal = montoOriginal;
    }

    public string titular { get => Titular; set => Titular = value; }
    public double montoOriginal { get => MontoOriginal; set => MontoOriginal = value; }
    public DateTime fecha { get => Fecha; set => Fecha = value; }

    
    public abstract double ProcesarPago();
    public abstract double CalcularComision();
    public abstract double ObtenerMontoFinal(double montoOriginal, double comision);

    public void MostrarDetalles()
    {
       Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Monto original: ${MontoOriginal}");
        Console.WriteLine($"Fecha: {Fecha.ToShortDateString()}");
        Console.WriteLine("Procesando pago...");
        Console.WriteLine($"Comisión aplicada: ${CalcularComision()}");
        Console.WriteLine($"Monto final: ${ObtenerMontoFinal(MontoOriginal, CalcularComision())}");
        Console.WriteLine("Pago realizado correctamente.");
        Console.WriteLine("-------------------------------");
    }
}