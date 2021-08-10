using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gamerestart : MonoBehaviour
{
    bool gamere = false;
    // Start is called before the first frame update
    public GameObject g;
    public void Completelevel()
    {
        g.SetActive(true);
    }
   public void Endgame()
    {
        if (gamere == false)
        {
           Invoke("restart",2f);
        }

    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
