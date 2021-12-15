using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
       private void OnTriggerExit(Collider other)
    {
        if(gameObject.tag=="Finish")
        {
            if(other.tag=="Player")
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
