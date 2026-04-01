using System;

class Program {
  public static void Main (string[] args) {
    

    string Continuer = "oui";
    Double prix = 0;
    Double result = 0;
    int nombreEnfant = 0;
    int nombreAdulte = 0;
    Double prixChambre = 0;
    Double reduction = 0;
    Double volEnfant = 420;
    Double volAdulte = 510;
    int nombreTotalChambre = 0;
    int personneTotal = 0;
    int nombrePersonneMax = 20;
    while (personneTotal <= nombrePersonneMax){ 
    while (Continuer == "oui"){
        Console.WriteLine("Combien de personnes participe au voyage ? \n 510 € pour un adulte \n 420 € pour un enfant" );
        int nombrePersonne = Convert.ToInt32(Console.ReadLine());
        if (nombrePersonne > 3 |  nombrePersonne < 1){  
          Console.WriteLine ("Il y a une erreur dans la saisie ! \n Fin du traitement ! ");
          Continuer = "non";
        }
          
        else { 
          Console.WriteLine("Préciser le nombre d'adultes");
          nombreAdulte = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Il y a {0} adultes",nombreAdulte);
          Console.WriteLine("Préciser le nombre d'enfants");
          nombreEnfant = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Il y a {0} enfants",nombreEnfant);
          if (nombreEnfant + nombreAdulte == nombrePersonne ){ 
      
            if (nombreEnfant + nombreAdulte == 1){ 
            Console.WriteLine ("Quelle chambre désirez vous ? \n 1 : Chambre Simple 28 € \n 2 : Chambre Simple + Lit 29 € \n 3 : Chambre Double 34 €\n 4 : Chambre Double + Lit 41 € \n 5 : Chambre Triple 45 €");
              }
            if (nombreEnfant + nombreAdulte == 2){ 
            Console.WriteLine ("Quelle chambre désirez vous ? \n 2 : Chambre Simple + Lit 29 € \n 3 : Chambre Double 34 €\n 4 : Chambre Double + Lit 41 € \n 5 : Chambre Triple 45 €");
              }
            if (nombreEnfant + nombreAdulte == 3){ 
              Console.WriteLine ("Quelle chambre désirez vous ? \n 4 : Chambre Double + Lit 41 € \n 5 : Chambre Triple 45 €");
              }
            int chambreDesirer =  Convert.ToInt16(Console.ReadLine());
              switch (chambreDesirer)
              {
              case 1 :
                Console.WriteLine("Vous avez choisis la chambre simple à 28 € la nuit ");
                prixChambre = 28;
                nombreTotalChambre = 1;
                
                break;
              case 2 : 
                Console.WriteLine("Vous avez choisis la chambre simple + lit à 29 € la nuit ");
                prixChambre = 29;
                nombreTotalChambre = 2;
                break;
              case 3 : 
                Console.WriteLine("Vous avez choisis la chambre double à 34 € la nuit");
                prixChambre = 34;
                nombreTotalChambre = 2;
                break;
              case 4 : 
                Console.WriteLine("Vous avez choisis la chambre double + lit à 41 la nuit € ");
                prixChambre = 41;
                nombreTotalChambre = 3;
                break;
              case 5 : 
                Console.WriteLine("Vous avez choisis la chambre triple à 45 € la nuit ");
                prixChambre = 45;
                nombreTotalChambre = 3;
                break;   
              default : 
                Console.WriteLine("Vous n'avez pas choisis de chambre ");
                Continuer = "non";
                break;    
              }
            if (nombreTotalChambre >= nombreAdulte + nombreEnfant){ 
              if (chambreDesirer > 0 && chambreDesirer <= 5) {
                Console.WriteLine ("Combien de nuits allez vous prendre ? ");
                int nuitPasser = Convert.ToInt16(Console.ReadLine());
                if (nuitPasser > 0){ 
                  Console.WriteLine("Avez vous une carte de réduction ? \n Si oui la quelle ? \n J : Jeune \n S : Sénior \n E : Evasion \n Sinon écrivez non ? ");
                  string CarteReduction = Console.ReadLine();
                  string carteReduction = CarteReduction.ToLower();
                
                  switch(carteReduction)
                  {
                    case "j" :
                      reduction = 0.85;
                      prix = reduction*nuitPasser * prixChambre + (nombreEnfant * volEnfant) + (nombreAdulte * volAdulte) ;
                      break;
                    case "s" : 
                      reduction = 0.88;
                      prix = reduction*(nuitPasser * prixChambre) + (nombreEnfant * volEnfant) + (nombreAdulte * volAdulte);
                      break;
                    case "e" : 
                      reduction = 0.92;
                      prix = reduction*(nuitPasser * prixChambre) + (nombreEnfant * volEnfant) + (nombreAdulte * volAdulte);
                      break;
                    case "non" : 
                      prix = (nuitPasser * prixChambre) + (nombreEnfant * volEnfant) + (nombreAdulte * volAdulte);
                      break;
                    default : 
                      Console.WriteLine("Cette carte n'existe pas, donc vous n'avez pas de réduction");
                      prix = (nuitPasser * prixChambre) + (nombreEnfant * volEnfant) + (nombreAdulte * volAdulte);
                      break;
                    }
                  personneTotal = nombrePersonne + personneTotal;
                  Console.WriteLine("Ils restent {0} places dans l'avion",nombrePersonneMax-personneTotal);
                  Console.WriteLine("Votre voyage vous reviens à {0} euros",prix);  
                  result = prix + result;
                  if (personneTotal != nombrePersonneMax){ 
                    Console.WriteLine("Voulez vous continuer ?");
                    Continuer = Console.ReadLine();
                    Continuer = Continuer.ToLower();
                    }
                  }
                }
                }
                  else{
                    Console.WriteLine("Il y a une erreur dans la saisie ! ");
                    Continuer = "non";
                      }
            }
            
          
            
      
              
              else {
                Console.WriteLine("Il y a une erreur dans la saisie ! \n Fin du traitement ");
                Continuer = "non";
                }
            }
        if (personneTotal == nombrePersonneMax){
            Continuer = "non";
          }
        if (Continuer == "non"){
          Console.WriteLine("Les prix total des dossiers sont de {0} €",result);
          }
        if (personneTotal > 20) {
          Console.WriteLine("Il y a trop de personne");
          }
        }
        }
        }
    }
    
  