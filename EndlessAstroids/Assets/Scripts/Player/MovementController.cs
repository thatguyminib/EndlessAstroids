using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    GameObject m_player;
    Vector3 m_screenPoint;
    Vector3 m_offset;
    Vector3 m_playerPos;

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
        m_player.transform.position = m_playerPos;
    }
}
