//https://web.digitalinnovation.one/coding/desafios-aritmeticos-em-c/algorithm/comunicacao-em-piralandia?back=/track/localizalabs-net-developer

using System; 

class URI {
  static void Main(string[] args) {
    
    string n = Console.ReadLine();
    char[] array = n.ToCharArray();
    
    Array.Reverse(array);
    string val = new string(array);
    Console.WriteLine(val);
  }
}