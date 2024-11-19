# 🕹️ Mini-Jeu Console – POO en C#  
**Version : 1.0**  

## 📘 Introduction  
Ce projet est un **mini-jeu console** développé en C#. L'objectif est simple : combattre des monstres de différents niveaux en utilisant des jets de dés. Le joueur accumule des points en fonction des monstres vaincus, tout en gérant ses points de vie.  

---

## 🎯 Règles du Jeu  

### ⚡ Départ  
- Le joueur commence avec **100 points de vie**.  

### 👾 Monstres  
Deux types de monstres peuvent apparaître :  
1. **Monstre Niveau 1**  
   - Attaque simple.  
   - Rapporte **1 point** lorsqu’il est vaincu.  

2. **Monstre Niveau 2**  
   - Possède une attaque supplémentaire avec un sort magique.  
   - Rapporte **2 points** lorsqu’il est vaincu.  

### ⚔️ Combat  
- **Attaque du joueur** :  
  Le joueur lance un dé. Si le score est **supérieur ou égal** à celui du monstre, le monstre est vaincu.  

- **Riposte des monstres** :  
  Les monstres lancent leurs propres dés. Si leur score est supérieur à celui du joueur, des dégâts sont infligés.  

- **Utilisation du bouclier** :  
  Lorsqu’un monstre attaque, le joueur peut activer un bouclier (jet de dé). Si le score obtenu est **inférieur ou égal à 2**, aucun dégât n’est reçu.  

### 🛑 Fin de Partie  
La partie se termine lorsque les **points de vie** du joueur atteignent **0**.  

---

## 🌟 Points Forts  
- **Programmation Orientée Objet (POO)** : Structure claire avec des classes dédiées pour le joueur, les monstres et les dés.  
- **Rejouabilité** : Jets de dés générés aléatoirement pour des parties toujours différentes.  
- **Calcul Automatique des Scores** : Totalisation des points basée sur le nombre et le type de monstres vaincus.  

---

## 🛠️ Structure des Classes  
- **Joueur** :  
  - Attributs : nom, points de vie.  
  - Méthodes : attaque, réception des dégâts.  
- **MonstreNiveau1** :  
  - Monstre basique avec des attaques simples.  
- **MonstreNiveau2** :  
  - Hérite de MonstreNiveau1. Dispose d’attaques spéciales et d’un sort magique.  
- **De (Dé)** :  
  - Simule un dé classique pour générer des nombres aléatoires.  

---

## 📝 Exemple de Résultat  
```plaintext  
Bravo, vous avez tué 6 monstres de niveau 1 et 8 monstres de niveau 2.  
Score final : 22 points.  
