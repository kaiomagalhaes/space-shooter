using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

  private Rigidbody rigidBody;
  public float speed;

	void Start () {
    rigidBody = GetComponent<Rigidbody>();
    rigidBody.velocity = transform.forward * speed;
	}
}
