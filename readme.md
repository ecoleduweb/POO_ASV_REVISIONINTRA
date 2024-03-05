# ASV

Il est temps de réchauffer tes neuronnes pour l'examen!

Voici un lien vers un fichier lucid chart qui ne contient rien! Je t'invite à y créer une feuille avec ton nom et à y ajouter la classes manquante.

Voici le lien sur lucid chart : https://lucid.app/lucidchart/b3506825-66cb-4a0d-8003-16d72f5e9bdd/edit?beaconFlowId=CC889FDC72EEFC89&invitationId=inv_5cf64bef-0880-4518-9e11-9b24568a36e0&page=0_0#

## Objectif

- Être en mesure de comprendre comment un diagramme de classe représente des classes dans ton code.
- Être en mesure de créer une interface WPF.
  - Grid
  - TextBox
  - Label
  - Menu
- Appliquer le concept d'encapsulation.
  - public
  - protected

## Descrption de la demande.

Ce travail permet d'afficher les informations age sexe ville dans un MessageBox en fonction de ce que l'utilisateur a entré.

Pour se faire, tu devras créer une classe `Personne` qui contientles attributs suivants :
Age (int)
Sexe (string)
Ville (string)

Tous les attributs de cette classe sont protected.
Son constructeur prend les trois en paramètre.

À l'ouverture du programme, les champs sont déjà remplis en fonction de l'information accessible de la classe Personne.

À partir du menu (Il est déjà présent dans le code, voir comment il est programmé en XAML), tu peux afficher l'information qui provient des TextBox.

### Quand est-ce que je met l'attribut personne à jour?

Lorsque que tu clics sur le bouton du menu **Afficher les informations**, tu mets à jour les attributs de l'objet Personne.

### Quand est-ce que le contenu des champs est mis à jour?

Dans le constructeur après avoir créé un nouvel objet Personne. Tu dois accéder aux informations des attributs, mais ils sont protected! Comment faire!??

### Et quand j'ai fini?
Tu montre ton code, ton diagramme de classe à tes amis qui ont aussi fini et ensuite au prof. Pas de remise en ligne dans notre cas, tout se fera en classe.

### Et il y a un bonus?
Non, mais je veux que tu crées une classe Enfant qui étend de parent, mais qui valide si l'âge passée dans son constructeur est en base de 18 ans.
De plus, enfant a comme ville et sexe la valeur "N/A".

Tu pourras tester ta nouvelle classe dans ton logiciel une fois qu'elle sera codée.

Bonne révision!