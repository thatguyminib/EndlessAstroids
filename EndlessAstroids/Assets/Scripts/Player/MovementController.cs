using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    GameObject m_player;
    Vector3 m_screenPoint;
    Vector3 m_offset;
    Vector3 m_playerPos;

    public float m_boundaryPos;

    

    private void Awake()
    {
        m_player = transform.parent.gameObject;
        m_playerPos = m_player.transform.position;
    }



  
    void OnMouseDown()
    {
        m_screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        m_offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, m_screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, m_screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + m_offset;
        
        m_playerPos = new Vector3(curPosition.x, -3.35f, 0);
        transform.position = m_playerPos;
        m_player.transform.position = m_playerPos;

        if (m_playerPos.x >= m_boundaryPos)
        {
            m_player.transform.position = new Vector3(m_boundaryPos, m_playerPos.y, m_playerPos.z);
        }
        else if (m_playerPos.x <= -m_boundaryPos)
        {
            m_player.transform.position = new Vector3(-m_boundaryPos, m_playerPos.y, m_playerPos.z);
        }
    }
}
