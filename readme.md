# GetSet

Comme c'est important de comprendre les get set (surtout si tu fais du java un jour), je t'ai préparé une petite activité!

## Objectif

- Être en mesure de comprendre comment un diagramme de classe représente les attributs d'une classe dans ton code.

- Appliquer le concept d'encapsulation.
  - private
  - public (ton constructeur est public)

## Descrption de la demande.

Ce travail permet d'afficher les informations relative à ta tasse de la technique dans un MessageBox en fonction des informations que l'utilisateur a entré.

À partir du menu (Il est déjà présent dans le code, voir comment il est programmé en XAML), tu peux afficher l'information qui provient des TextBox.

Voici un [lien](https://lucid.app/lucidchart/b3506825-66cb-4a0d-8003-16d72f5e9bdd/edit?viewport_loc=-1855%2C-203%2C3071%2C1511%2C0_0&invitationId=inv_5cf64bef-0880-4518-9e11-9b24568a36e0) vers un fichier lucid chart qui contient la classe que tu devras créer.

### SET Quand est-ce que je mets les attributs de la tasse à jour?

- Lorsque que tu cliques sur le bouton du menu **Afficher les informations** au tout début de la méthode `OnMenuAfficherInfoClick`.

### GET Quand est-ce que le lis les attributs de la tasse?

- Dans le constructeur `MainWindow`, après `InitializeComponent();` pour afficher les bonnes valeurs dans les champs textes à partir de l'objet `tasse` que tu vas créer.
- Dans le MessageBox pour afficher les informations à l'usager.

Petit rappel pour la string interpolation, on ajoute des accolades pour interpréter du code.

`$"Ceci est une string {interpolee.GetAttribut()}"`

### Et quand j'ai fini?

Soumettre ton code en ligne.

### Si j'ai besoin d'aide?

Comme c'est un devoir, tu **dois** poser tes questions dans discord à tes collègues. J'interviendrai au besoin si personne ne répond ou si les réponses sont à corriger.

### Et il y a un bonus?

Heu non... c'est un devoir. Pas de bonus pour un devoir.
