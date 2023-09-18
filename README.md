# Création d’un projet avec des appels API en .NET 6 avec C#
Voici le code pour les **modèles**, les **contrôleurs** et la configuration de la classe **Program.cs** 

**Modèles :** 
Les modèles sont des classes qui représentent les données que votre API va manipuler. Par exemple, si vous voulez créer une API pour gérer des produits, vous pouvez créer une classe **Produit** avec les propriétés suivantes, voir l'image ci-desous :

![image](https://github.com/fsmaili77/APIdemo/assets/65200251/28c60557-3ee7-4b07-9aa7-fb3570bf0b9c)

**Contrôleurs :** Les contrôleurs sont des classes qui définissent les actions que votre API peut effectuer. Par exemple, si vous voulez créer un contrôleur pour gérer les produits, vous pouvez créer une classe **ProduitsController** qui hérite de la classe **ControllerBase** et utilise l’attribut **[ApiController]**. Vous pouvez ensuite définir des méthodes pour réaliser les opérations **CRUD (créer, lire, mettre à jour, supprimer)** sur les produits, en utilisant l’attribut **[Route]** pour spécifier l’URL de chaque action et l’attribut **[HttpGet]**, **[HttpPost]**, **[HttpPut]** ou **[HttpDelete]** pour spécifier la méthode **HTTP** de chaque action. Voir l'exemple ci-dessous:
![image](https://github.com/fsmaili77/APIdemo/assets/65200251/da9b6909-5253-458a-b3d3-a97e11f88e19)
Configuration de la classe **Program.cs :** La classe Program.cs est le point d’entrée de votre application.
![image](https://github.com/fsmaili77/APIdemo/assets/65200251/3f6df2bc-597a-4aca-a123-a8417b2972a8)

