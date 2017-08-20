using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playcontrol : MonoBehaviour {
    private Rigidbody rb;//ตัวแปรที่ใช้ในการเคลื่อนที่
    public float speed;
    // Use this for initialization
	void Start() {
        rb = GetComponent<Rigidbody>();

	}

    // Update is called once per frame
//void Update() {
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 moveMent = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(moveMent*speed);
        
	}

    void OntriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Boxa"))
        {
            other.gameObject.SetActive(false);
        }
    }

}
