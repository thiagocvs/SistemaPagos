using System;
class Program
{
    static void Main(string[] args)
    {
        List<Pago> pagos = new List<Pago>();
        int opcin;

        do
        {
            Console.WriteLine(@"Sistema de registro de pagos
            Ingrese una opcion:
            Opcion 1: Pago con Efectivo
            Opcion 2: Pago con Tarjeta");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    pagoEfectivo();
                    break;
                case 2:
                    pagoTarjeta();
                    break;
                case 3:
                    break;
                default:                  
                    Console.WriteLine("Opcion no valida, intente nuevamente.");
                    break;
            }
        }while (opcin != 3);

        void pagoEfectivo()
        {
            Console.WriteLine("Ingrese el nombre del titular:");
            string titular = Console.ReadLine();

            Console.WriteLine("Ingrese el monto original:");
            double montoOriginal = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la fecha (dd/MM/yyyy):");
            DateTime fecha = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.WriteLine("Ingrese la divisa:");
            string divisa = Console.ReadLine();

            Efectivo pagoEfectivo = new Efectivo(titular, montoOriginal, fecha, divisa);
            pagos.Add(pagoEfectivo);
            pagoEfectivo.MostrarDetalles();
        }

        void pagoTarjeta()
        {
            Console.WriteLine("Ingrese el nombre del titular:");
            string titular = Console.ReadLine();

            Console.WriteLine("Ingrese el monto original:");
            double montoOriginal = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de tarjeta:");
            string numeroTarjeta = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de tarjeta:");
            string tipoTarjeta = Console.ReadLine();

            Tarjeta pagoTarjeta = new Tarjeta(titular, montoOriginal, DateTime.Now, numeroTarjeta, tipoTarjeta);
            pagos.Add(pagoTarjeta);
            pagoTarjeta.MostrarDetalles();
        }

    }
}