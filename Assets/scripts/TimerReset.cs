using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerReset : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        CentalHub.Instance.timer = 0;//有车进入则重置时间
    }
}
