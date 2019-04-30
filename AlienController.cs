using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AlienController : MonoBehaviour {

	public float speed;
	private Rigidbody2D rb;
	private Vector2 movement;

	void Start(){
		rb = GetComponent<Rigidbody2D> ();

		float h = Random.value;
		float v = Random.value;

		float moveHorizontal = h * 2 - 1;
		float moveVertical = v * 2 - 1;

		movement = new Vector2 (moveHorizontal, moveVertical);

		rb.velocity = movement * speed;
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.CompareTag ("Wall")) {
			float Horizontal = Random.value * 2 - 1;
			float Vertical = Random.value * 2 - 1;
			movement = new Vector2 (Horizontal, Vertical);
			rb.velocity = movement * speed;
		} 
		else if (other.gameObject.CompareTag ("Alien")) {
			float Horizontal = Random.value * 2 - 1;
			float Vertical = Random.value * 2 - 1;
			movement = new Vector2 (Horizontal, Vertical);
			rb.velocity = movement * speed;
		}
		else if (other.gameObject.CompareTag ("BlackAlien")) {
			float Horizontal = Random.value * 2 - 1;
			float Vertical = Random.value * 2 - 1;
			movement = new Vector2 (Horizontal, Vertical);
			rb.velocity = movement * speed;
		}
	}

	/**public float speed;
	public Vector2 newDir;
	
	private Rigidbody2D rb;
	private Vector2 movement;
	
	void Start(){
		rb = GetComponent<Rigidbody2D>();

		float h = Random.value;
		float v = Random.value;

		float moveHorizontal = h * 2 - 1;
		float moveVertical = v * 2 - 1;
		
		movement = new Vector2 (moveHorizontal, moveVertical);

		move ();
	}

	void move(){
		rb.AddForce (movement * speed);
	}

	void OnCollisionEnter2D(Collider2D other){
			
		movement = new Vector2 (Random.value*2-1, Random.value*2-1);

		move ();
	}

	void Update(){
		move ();
	}
**/
}