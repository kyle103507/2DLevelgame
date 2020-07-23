using UnityEngine;
using UnityEngine.SceneManagement;


public class ScenceControl : MonoBehaviour
{


    public void Quit()
    {
        Application.Quit();                          //應用程式.離開
    }
   
    public void LoadScene()
    {
        SceneManager.LoadScene("遊戲背景");          //切換場景
    }
       
    public void DelayQuit()
    {
        Invoke("Quit", 0.8f);                        //延遲離開場景
    }
    
    public  void DelayLoadScene()
    {
        Invoke("LoadScene", 0.8f);                      //延遲切換場景
    }

}


