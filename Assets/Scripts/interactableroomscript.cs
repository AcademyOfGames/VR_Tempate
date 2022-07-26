using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactableroomscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneTransitionManagement.Instance.loadLastNode = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
