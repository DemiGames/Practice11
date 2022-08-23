using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseResume : MonoBehaviour
{
    public GameObject canv;
    public void PauseGame()
    {
        canv.SetActive(true);
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        canv.SetActive(false);
        Time.timeScale = 1;
    }
}
