using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string[] levels;
    private int currentLevel = 0;

    public void LoadLevel()
    {
        SceneManager.LoadScene(levels[++currentLevel]);
    }
}
