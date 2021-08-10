using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorechange : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform t;
    public Text score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = ((t.position.x - 1021.8)*-1).ToString("0");
    }
}
