using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneName;
    public void LoadScene() => SceneManager.LoadScene(sceneName);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
