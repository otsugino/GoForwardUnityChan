using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	private float speed = -12;
	private float deadLine = -10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(this.speed * Time.deltaTime, 0, 0);

		if(transform.position.x < this.deadLine)
        {
			Destroy(gameObject);
        }
	}

	// 他のオブジェクトと衝突時に音を再生
	private void OnCollisionEnter2D(Collision2D other)
	{
		// groundと衝突時に音を再生
		if (other.gameObject.tag == "GroundTag")
		{
			this.GetComponent<AudioSource>().Play();

		// Unitychanと衝突時は何も発生しない。
		}
		if (other.gameObject.tag == "UnityChan2DTag")
		{
		}

		// 他のcubeと衝突時に音を再生
		if (other.gameObject.tag == "CubeTag")
		{
			this.GetComponent<AudioSource>().Play();
			

		}
	}


}
