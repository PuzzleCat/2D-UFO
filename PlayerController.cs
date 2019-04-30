using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed;
	public GameObject flare;
	public GameObject blackFlare;
	public Text alienCount;
	public Text done;
	
	private Rigidbody2D rb;
	private bool cont;
	private int aCount;
	
	void Start(){
		rb = GetComponent<Rigidbody2D>();
		cont = true;
		aCount = 0;
		alienCount.text = "Count: 0";
		done.text = "";
	}
	
	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		
		rb.AddForce (movement*speed);
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.CompareTag ("Alien")) {
			if(cont==true){
				flare.SetActive(true);
				aCount = aCount + 1;
				alienCount.text = "Count: " + aCount.ToString();
				other.gameObject.SetActive (false);
				StartCoroutine(delay());
				if(aCount==24){
					cont = false;
				}
			}
		}
		if (other.gameObject.CompareTag ("BlackAlien")) {
			blackFlare.SetActive(true);
			other.gameObject.SetActive (false);
			StartCoroutine(delay());
			if (aCount < 24 && cont == true) {
				cont = false;
				done.text = "You Lose!";
			} else {
				done.text = "You Win!";
			}
		}
	}

	IEnumerator delay(){
		yield return new WaitForSeconds (1);
		flareOff ();
	}

	void flareOff(){
		flare.SetActive (false);
		blackFlare.SetActive (false);
	}

}