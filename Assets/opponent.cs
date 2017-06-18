using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opponent : MonoBehaviour {
    public GameObject enemy;
    float time;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if(time>0.5)
        {
            time = 0;
            GameObject asd = Instantiate(enemy);
            Vector3 position = new Vector3();
            position.x = Random.Range(-8.0f, 8.0f);
            position.y = Random.Range(3.0f, 5.0f);
            asd.transform.position = position;
         
        }
	}
}
