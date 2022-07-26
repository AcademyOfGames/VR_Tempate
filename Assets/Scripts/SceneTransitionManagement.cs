using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManagement : MonoBehaviour
{   
        public bool loadLastNode;
        
        private static SceneTransitionManagement _instance;
        public static SceneTransitionManagement Instance { get { return _instance; } }

        private void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(this.gameObject);
            } else {
                _instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }

        public void LoadScene(string sceneName)
        {
            FindObjectOfType<GoogleSheets>().AddEventData("Entered " + sceneName);
            SceneManager.LoadScene(sceneName);
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
