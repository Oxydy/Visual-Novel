using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void switch0()
    {
        SceneManager.LoadScene(sceneBuildIndex:0);
    }
    public void switch1()
    {
        SceneManager.LoadScene(sceneBuildIndex:1);
    }
    public void switch2()
    {
        SceneManager.LoadScene(sceneBuildIndex:2);
    }
    public void switch3()
    {
        SceneManager.LoadScene(sceneBuildIndex:3);
    }
    public void switch4()
    {
        SceneManager.LoadScene(sceneBuildIndex:4);
 
   }

    public void doExitGame()
    {
        Application.Quit();
    }
}
