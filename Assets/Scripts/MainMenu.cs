using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void Death()
    {
        SceneManager.LoadScene("DeathScene");
    }

    public void GetInstr()
    {
        SceneManager.LoadScene("InstructionScene");
    }
}
