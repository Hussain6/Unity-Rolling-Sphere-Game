using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endgame : MonoBehaviour
{
    public gamerestart g;
    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        g.Completelevel();
    }
}
