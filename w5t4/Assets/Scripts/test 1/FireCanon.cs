using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireCanon : MonoBehaviour
{
    public GameObject Ui;
    public GameObject cannonball;
    private float cannonballSpeed;
    public Transform pof;
    public Transform barrel;
    public float scrollIncrements = 10;
    public float MaxcannonballSpeed;
    private bool fire;
    public Slider Power;
    public int ball;



    private void Awake()
    {
        Power.maxValue = MaxcannonballSpeed;
    }    
    void Update()
    {
        Power.value = cannonballSpeed;
        if (Input.GetMouseButtonDown(0) & ball > 0)
        {
            ball--;
            fire = true;
        }
        else if(ball ==0)
        {
            Ui.SetActive(true);
        }
        
        if (fire == true)
        {
            
            if (cannonballSpeed < MaxcannonballSpeed)
                
                cannonballSpeed += 10 * Time.deltaTime;       
            
            if (Input.GetMouseButtonUp(0))
            {
                FireCannonball();
                
                cannonballSpeed = 0;
                fire = false;
                
            }
        
        }
        
        Debug.Log(ball);
    }

        void FireCannonball()
    {
        GameObject ball = Instantiate(cannonball, pof.position, Quaternion.identity);
        Rigidbody rb = ball.AddComponent<Rigidbody>();
        rb.velocity = cannonballSpeed * pof.forward;
        StartCoroutine(RemoveCannonball(ball));
    }
    IEnumerator RemoveCannonball(GameObject ball)
    {
        yield return new WaitForSeconds(5f);
        Destroy(ball);
    }
}
