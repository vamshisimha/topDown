using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    bool isfiring;
    [SerializeField]
    private float fireRate;
    [SerializeField]
    private int damage;
    ///private float timer = 0;
    [SerializeField]
    private Transform firePoint;
    public GameObject bullet;
    public float bulletSpeed;
 //   public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        
    }
   //public void firing()
   // {
   //     Debug.Log("fire..");
   // }
   public void pointerup()
    {
        isfiring = false;
    }
    public void pointerdown()
    {
        isfiring = true;
    }
    // Update is called once per frame
    void Update()
    { 
        if(isfiring)
        {
            GameObject BulletInst = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation) as GameObject;
            Rigidbody bulletInstRigid = BulletInst.GetComponent<Rigidbody>();
            bulletInstRigid.AddForce(BulletInst.transform.forward * bulletSpeed);
           // audio.Play();
        }
        
    }
}
