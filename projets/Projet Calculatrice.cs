using System;

class Program {
  public static void Main (string[] args) {
    Double nombre1 = 0; 
    Double nombre2 = 0; 
    int nombreChoisis;  
    Double number = 0;  
    string reponse = "oui"; 

    while (reponse == "oui") 
    { 
      Console.WriteLine("--------Calculatrice-------");
      Console.WriteLine ("\n Saisissez 1 pour une addition \n Saisissez 2 pour une soustraction \n Saisissez 3 pour une multiplication \n Saisissez 4 pour une division \n Saisissez 5 pour afficher une la table de multiplication d'un nombre choisis \n");
      nombreChoisis = Convert.ToInt32(Console.ReadLine()); 
      Console.WriteLine("---------------------------");

      if (nombreChoisis > 0 && nombreChoisis < 5) { 
        Console.WriteLine ("Saisissez le premier nombre");
        nombre1 = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine ("Saisissez le deuxieme nombre");
        nombre2 = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine("---------------------------");
        }


      switch(nombreChoisis) 
      {

      case 1 :
        Console.WriteLine("Le resultat de votre addition est {0}",nombre1 + nombre2);
        break;
      case 2 : 
        Console.WriteLine("Le resultat de votre soustraction est {0}",nombre1 - nombre2);
        break;
      case 3 : 
        Console.WriteLine("Le resultat de votre multiplication est {0}",nombre1 * nombre2);
        break;
      case 4 : 
        Console.WriteLine("Le resultat de votre division est {0}",nombre1 / nombre2);
        break;
      case 5 : 
        Console.WriteLine ("Saississez un nombre");
        number = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine("---------------------------");

        for (int i = 0; i < 10; i++) 
        {
          Console.WriteLine(i*number); 
        }
        break;
      default :
        Console.WriteLine ("Il y a une erreur dans la saisie"); 
        break;

      }
      Console.WriteLine("---------------------------");
      Console.WriteLine ("Voulez vous refaire un calcul ou afficher une table de multiplication ?"); 
      reponse = Console.ReadLine(); 
      reponse = reponse.ToLower(); 
      
    }
    
    if (reponse == "non"){ 
      Console.WriteLine("---------------------------");
      Console.WriteLine ("Fin du traitement");       
      }    
  }
}