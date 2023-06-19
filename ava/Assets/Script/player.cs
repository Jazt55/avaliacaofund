using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject projetil;
    public float MovX;
    public float MovY;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovY = Input.GetAxisRaw("Horizontal");
        MovX = Input.GetAxisRaw("Vertical");
        
        
        
        
        FireSystem();
    }



    public void FireSystem()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(projetil, transform.position, Quaternion.identity);

        }

        

    }
}
