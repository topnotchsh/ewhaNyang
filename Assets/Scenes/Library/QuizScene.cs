using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizScene : MonoBehaviour
{
    public GameObject Quiz1;
    public GameObject Quiz2;
    // Start is called before the first frame update
    void Start()
    {
        Quiz2.SetActive(false);
    }

    // Update is called once per frame
    public void Pass1()
    {
        Quiz1.SetActive(false);
        Quiz2.SetActive(true);
    }

    public void Pass2()
    {
        SceneManager.LoadScene(23);
    }
}
