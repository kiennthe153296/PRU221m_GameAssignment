using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScene");
    }
}
