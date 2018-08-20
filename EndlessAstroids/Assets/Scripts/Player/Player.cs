using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : MonoBehaviour {

    public int m_health;

    public float m_shootSpeed;
    protected float m_timer;

    public GameObject[] m_bulletSpawnPoints;

    public void OnMouseDown()
    {
        OnMouseDownEvent();
    }

    public void OnMouseDrag()
    {
        OnMouseDragEvent();
    }

    public abstract void OnMouseDownEvent();

    public abstract void OnMouseDragEvent();

    public virtual void SpawnBullet(GameObject _bullet)
    {
        m_timer += Time.deltaTime;
        if (m_timer >= m_shootSpeed)
        {
            foreach (GameObject spawnPoint in m_bulletSpawnPoints)
            {
                Instantiate(_bullet, spawnPoint.transform.position, transform.rotation);
            }
            
            m_timer = 0;
        }
    }

}
