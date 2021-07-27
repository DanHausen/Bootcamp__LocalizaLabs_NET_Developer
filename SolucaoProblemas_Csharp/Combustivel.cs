using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int distancia;
            double combustivelGasto, consumoMedio;

            distancia = Convert.ToInt32(Console.ReadLine());
            combustivelGasto = Convert.ToDouble(Console.ReadLine());

            consumoMedio =  Math.Round(distancia/combustivelGasto, 3); //atribua a formula para que o codigo funcione corretamente

            Console.WriteLine("{0:0.000} km/l", consumoMedio);

    }

}