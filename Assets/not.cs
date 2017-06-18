using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class not : MonoBehaviour {
    public float speed;
    float time;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = Random.insideUnitCircle;
        transform.Translate(direction * Time.deltaTime*speed);
        time += Time.deltaTime;
        if (time > 2)
        {
            Destroy(gameObject);
        }
	}
}
