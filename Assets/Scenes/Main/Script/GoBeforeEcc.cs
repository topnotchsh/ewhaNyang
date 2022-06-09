using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBeforeEcc : MonoBehaviour
{
    // Start is called before the first frame update
    public void NextScene()
    {
        SceneManager.LoadScene(16);
    }
}
