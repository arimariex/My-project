using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class PlayerDestroy : MonoBehaviour
{
    public float deathY = -5.0f;
    void Start()
    {
        Debug.Log("VS Code is working");
    }

    // Update is called once per frame
    void Update()
    {
       if(transform.position.y <= deathY)
        {
            Scene scene = SceneManager.GetActiveScene();
               
        Debug.Log("working");
        Destroy(gameObject);
        SceneManager.LoadScene(scene.name);

        

        } 
    }
}
