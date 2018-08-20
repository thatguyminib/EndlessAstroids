using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : Obstacle {

    Rigidbody m_rigidbody;

    public GameObject m_asteroid;

    Vector3 m_rotation;

    public float m_rotationSpeed;
    public float m_moveSpeed;

    public int m_amountOfAsteroidsToSpawn;

    private void Awake()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    void Start () {
        m_rotationSpeed = Random.Range(-3, 3);
        m_rotation = new Vector3(Random.value, Random.value, Random.value);
	}
	
	void Update () {
        transform.Rotate(m_rotation * m_rotationSpeed);
        transform.Translate(Vector3.back * m_moveSpeed * Time.deltaTime, Space.World);
    }

    public override void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerBullet")
        {
            SpawnSmallerAsteroids();
        }
        base.OnTriggerEnter(other);
    }

    void SpawnSmallerAsteroids()
    {
        for (int i = 0; i < m_amountOfAsteroidsToSpawn; i++)
        {
            GameObject spawnedAsteroid = Instantiate(m_asteroid, transform.position, transform.rotation);
            float randomScaleSize = Random.Range(.1f, m_asteroid.transform.localScale.x - .35f);
            spawnedAsteroid.transform.localScale = new Vector3(randomScaleSize, randomScaleSize, randomScaleSize);

            spawnedAsteroid.GetComponent<Rigidbody>().AddForce(Vector3.right * Random.Range(-5, 5), ForceMode.Impulse);
        }
    }
}
