using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    private LevelLoader levelLoader;

    private void Start()
    {
        levelLoader = FindObjectOfType<LevelLoader>();
    }
    private void OnTriggerEnter(Collider other)
    {
        levelLoader.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
