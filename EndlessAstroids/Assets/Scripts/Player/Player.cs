using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : MonoBehaviour {

    public int m_health;
    //TODO: may need to remove
    public int m_shipSpeed;
    public float m_shootSpeed;
    protected float m_timer;

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
            Instantiate(_bullet, transform.position, transform.rotation);
            m_timer = 0;
        }
    }

}
