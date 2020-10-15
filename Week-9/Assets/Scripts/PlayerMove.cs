using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    private float speed = 5;
   
    private Transform m_Transform;
  
    void Start()
    {
        
        m_Transform = this.transform;
        
    }

    void Update()
    {
        
        playerMove();
    }

    void playerMove()
    {	
        
            if (Input.GetKey(KeyCode.W))
            {
                m_Transform.localRotation = Quaternion.Euler(0, 0, 0);
                m_Transform.Translate(Vector2.up * speed * Time.deltaTime);     
            }
          
            if (Input.GetKey(KeyCode.S))
            {
                m_Transform.localRotation = Quaternion.Euler(0, 180, 0);
                m_Transform.Translate(Vector2.down* speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                m_Transform.localRotation = Quaternion.Euler(0, 0, 0);
                m_Transform.Translate(Vector2.left * speed * Time.deltaTime);
}
            if (Input.GetKey(KeyCode.D))
            {
                m_Transform.localRotation = Quaternion.Euler(0, 0, 0);
                m_Transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
            


        
        
    }
}