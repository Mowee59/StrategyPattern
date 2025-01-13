# Le Strategy Pattern

![diagram-discount](https://github.com/user-attachments/assets/2a2cac5f-7ee2-4bd8-9c18-35bfbd3d56a9)


Ce projet sert de support à l'article suivant :  [Le design pattern strategy](https://blog.aniss.dev/articles/le-design-pattern-strategy)

## Structure du projet

Le projet est divisé en deux parties principales :

1. **ConsoleApp** : L'application console qui utilise les stratégies de réduction.
2. **DiscountLibrary** : Une bibliothèque contenant les différentes stratégies de réduction.

## Fonctionnalités

- **Réduction fixe** : Applique une réduction fixe en euros.
- **Réduction en pourcentage** : Applique une réduction en pourcentage.
- **Réduction par seuil** : Applique une réduction si un certain seuil est atteint.
- **Réduction composite** : Combine plusieurs stratégies de réduction.

## Utilisation

1. Clonez le dépôt.
2. Ouvrez la solution `StrategyPattern.sln` dans Visual Studio.
3. Exécutez le projet `ConsoleApp`.

L'application vous demandera d'entrer un prix total, puis appliquera différentes stratégies de réduction et affichera les résultats.

## Configuration requise

- .NET 9.0 ou supérieur

