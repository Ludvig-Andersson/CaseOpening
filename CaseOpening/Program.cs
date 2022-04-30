using CaseOpening;

Game g1 = new Game();

string fråga;
string svar2;
int amount = 0;

List<Cases> ListOfCases = new List<Cases>(); //skapar en lista för lådorna att samlas i
List<Gloves> ListOfGloves = new List<Gloves>();

while (true) {
    Console.Clear();
System.Console.WriteLine("Vill du köpa Cases eller en GloveCases eller nå ditt inventory?");
System.Console.WriteLine("Skriv 1 för Case och 2 för GloveCase och 3 för att nå ditt inventory");

fråga = Console.ReadLine();

int svar;

bool success = int.TryParse(fråga, out svar); //ifall man skriver fel så kan de skriva om

 if (success == false)
    {
        Console.WriteLine("Fel");
    }

if (svar == 1) {
    System.Console.WriteLine("Hur många lådor vill du köpa?");
    svar2 = Console.ReadLine();

    bool success2 = int.TryParse(svar2, out amount);

    if (success2 == false)
        {
            Console.WriteLine("Fel");
        }
    
    else
        {
            for (int i = 0; i < amount; i++) //spelaren får skriva in hur många cases de vill köpa och den loopar så många gånger den personen skrivit in
            {
                Cases C = new Cases();
                

                
                int.TryParse(Console.ReadLine(), out C.cases); 

                
                ListOfCases.Add(C); // den lägger till alla lådor i listan som for loopen sagt till den att göra

                



            }

            
        }
}

if (svar == 2) { //samma som ovan fast med en annan klass
    System.Console.WriteLine("Hur många lådor vill du köpa?");
    svar2 = Console.ReadLine();

    bool success2 = int.TryParse(svar2, out amount);

    if (success2 == false)
        {
            Console.WriteLine("Fel");
        }
    
    else
        {
            for (int i = 0; i < amount; i++)
            {
                Gloves G = new Gloves();
                

                
                int.TryParse(Console.ReadLine(), out G.glovecases);

                
                ListOfGloves.Add(G);

                



            }

            
        }
}

if (svar == 3) {

     foreach (Cases C in ListOfCases) //den kollar igenom listan och sedan visar vad som finns i listan
        {
            Console.WriteLine($"{C.cases}.Case");
        }

    foreach (Gloves G in ListOfGloves)
        {
            //Console.WriteLine(G.glovecases);
            Console.WriteLine($"{G.glovecases}.GloveCase");

            
        }

    
}


Console.ReadLine();

}

