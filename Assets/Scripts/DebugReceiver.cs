using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugReceiver : MonoBehaviour
{
public void AddDebugText( string txt)
    {
        GetComponent<Text>().text += "\n" + txt;
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
