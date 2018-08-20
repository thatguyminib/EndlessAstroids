using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : Obstacle {

    public GameObject m_asteroid;

    Vector3 m_rotation;

    public float m_rotationSpeed;


	void Start () {
        m_rotationSpeed = Random.Range(-3, 3);
        m_rotation = new Vector3(Random.value, Random.value, Random.value);
	}
	
	void Update () {
        transform.Rotate(m_rotation * m_rotationSpeed);
	}

    
}
