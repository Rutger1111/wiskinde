using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject imageje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {

    }
    // Update is called once per frame
    public void naarOpdracht1()
    {
        SceneManager.LoadScene("Opdracht1");
    }
    public void naarOpdracht2()
    {
        SceneManager.LoadScene("Opdracht2");
    }
    public void naarOpdracht3()
    {
        SceneManager.LoadScene("Opdracht3");
    }
    public void naarOpdracht4()
    {
        SceneManager.LoadScene("Opdracht4");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void naarOpdrachtenMenu()
    {
        SceneManager.LoadScene("OpdrachtenMenu");
    }
    public void naarMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Resume()
    {
        imageje.SetActive(false);
    }
}
