using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour {

    public int m_attackPower;
    public int m_moveSpeed;
    Rigidbody m_rigidbody;

    private void Start()
    {
        
    }

    protected virtual void Shoot()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        m_rigidbody.AddForce(transform.forward * m_moveSpeed);
    }
	
}
