using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameplaycontroller : MonoBehaviour
{
    public GameObject pausePannel;
    public Button ButtonResume;
    public void PlayerDie()
    {
        pausePannel.SetActive(true);
    }
    public void ResumeGame()
    {
        pausePannel.SetActive(false);
        //Application.LoadLevel("Gameplay");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
