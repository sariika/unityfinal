using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
   [SerializeField] private string mainMenu ="Main Menu";
    public void PlayGame()
    {
        SceneManager.LoadScene(mainMenu);
    }
}
