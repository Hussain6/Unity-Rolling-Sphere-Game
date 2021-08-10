using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endtrigger : MonoBehaviour
{
    // Start is called before the first frame update
     void OnTriggerEnter()
    {
        SceneManager.LoadScene(SceneManager.GetSceneAt(1).buildIndex);
    }
}
