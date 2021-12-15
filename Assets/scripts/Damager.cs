using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Damager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public int health=100;
    public Text Phealth;
    // Update is called once per frame
    void Update()
    {
        Phealth.text = health.ToString();
        changeScene();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health -= 5;
        }
       
    }
    public void changeScene()
    {
        if(health<=0)
        {
            SceneManager.LoadScene(4);
        }
    }
}
