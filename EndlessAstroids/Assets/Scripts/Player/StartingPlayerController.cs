using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingPlayerController : Player {

    public GameObject m_bullet;

    void Start () {
		
	}
	
	void Update () {
		
	}

    public override void OnMouseDownEvent()
    {

    }

    public override void OnMouseDragEvent()
    {
        SpawnBullet(m_bullet);
    }

    public override void SpawnBullet(GameObject _bullet)
    {
        base.SpawnBullet(_bullet);
    }

}
