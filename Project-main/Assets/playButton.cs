using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour

{
    [SerializeField] private string startGame ="project";
    public void PlayGame()
    {
        SceneManager.LoadScene(startGame);
    }
}
