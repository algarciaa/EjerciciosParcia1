namespace EjerciciosParcia1
{
    public class ConceptoPoo
    {
        public static void Main()
        {
            //crear objeto
            /*Persona persona1 = new Persona();
            persona1.Nombre = "Alex";
            persona1.Edad = 42;
            persona1.Saludar();*/

            CuentaBancaria cuentaPersonal = new CuentaBancaria();
            cuentaPersonal.Depositar(12.25m);

            Console.WriteLine($"Mi saldo actual es {cuentaPersonal.Saldo}");

            cuentaPersonal.Depositar(120.00m);

            Console.WriteLine($"Mi saldo actual es {cuentaPersonal.Saldo}");

            /*Animal animal = new Animal();
		
		animal.Comer();
		
		Perro perro = new Perro();
		
		perro.Comer();
		perro.Ladrar();
		
		Animal perro2 = new Perro();
		perro2.Comer();
		((Perro)perro2).Ladrar();*/

            Animal gato = new Gato();
            gato.HacerSonido();

            IFigura figura = new Circulo { Radio = 5 };

            Console.WriteLine($"Area del circulo: {figura.CalcularArea()}");
        }
    }

    //Definicion de clase
    public class Persona
    {
        //Atributos (campos o propiedades)
        public string Nombre;
        public int Edad;

        //Metodo
        public void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
        }
    }

    public class CuentaBancaria
    {
        private decimal saldo; //campo privado

        public decimal Saldo
        {
            get { return saldo; }          //lee valor
            private set { saldo = value; } //solo se puede modificar dentro de la clase
        }

        public void Depositar(decimal monto)
        {
            if (monto > 0)
            {
                Saldo += monto;
            }
        }
    }
    // Herencia
    /*public class Animal
    {
        public void Comer()
        {
            Console.WriteLine("El animal esta comiendo.");
        }
    }

    public class Perro : Animal
    {
        public void Ladrar()
        {
            Console.WriteLine("El perro esta ladrando.");
        }
    }*/

    // Polimorfismo
    public class Animal
    {
        public virtual void HacerSonido()
        {
            Console.WriteLine("Sonido generico de animal");
        }
    }

    public class Gato : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("Miau");
        }
    }

    // Abstraccion
    /*public abstract class Figura
    {
        public abstract double CalcularArea();
    }

    public class Circulo : Figura
    {
        public double Radio { get; set; }
        public override double CalcularArea() => Math.PI * Radio * Radio;
    }*/

    public interface IFigura
    {
        double CalcularArea();
    }

    public class Circulo : IFigura
    {
        public double Radio { get; set; }

        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }
    }
}
