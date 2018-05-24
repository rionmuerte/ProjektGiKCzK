using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed;
    public GameObject timer;
    private Rigidbody body;
	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //Budowanie na komputer - odkomentować to:
        float up = Input.GetAxis("Horizontal");
        float side = Input.GetAxis("Vertical");
        //budowanie na telefon - odkomentować to:
        //float up = Input.acceleration.x;
        //float side = Input.acceleration.z;

        Vector3 move = new Vector3(up, 0, side);

        body.AddForce(move * speed);

	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SmallPowerup"))
        {
            
            other.gameObject.SetActive(false);
            timer.GetComponent<LocalTimer>().timeForLevel += 10;
        }
        if (other.gameObject.CompareTag("BigPowerup"))
        {
            timer.GetComponent<LocalTimer>().timeForLevel += 15;
            other.gameObject.SetActive(false);
        }

    }
    public Rigidbody State()
    {
        return body;
    }
    public void Activate(Rigidbody state)
    {
        body = state;
    }
}
