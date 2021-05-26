using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour {

    public void Jouer()
    {
        SceneManager.LoadScene("BrightDay"); // Mettre la première scène au démarrage du jeu
    }
    public void Quitter()
    {
        Application.Quit(); // Quitter l'app
    }
    // Ajout du réglage pour plus tard
    public void Settings()
    {
        SceneManager.LoadScene("Reglage");
    }
} 
