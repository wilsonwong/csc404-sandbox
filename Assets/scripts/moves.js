#pragma strict
var moveSpeed : float = 2;
var canjump = false;
function Start () {

}

function Update () {
	rigidbody.AddForce(3 * Physics.gravity);
	if (Input.GetButton("w")) {
	
		transform.Translate(Vector3.forward * moveSpeed/3);
	}
	if (Input.GetButton("a")) {
	
		transform.Translate(Vector3.left * moveSpeed/3);
	}
	if (Input.GetButton("s")) {
	
		transform.Translate(Vector3.back * moveSpeed/3);
	}
	if (Input.GetButton("d")) {
	
		transform.Translate(Vector3.right * moveSpeed/3);
	}
	if (Input.GetButton ("space")){

		if (canjump){

		gameObject.AddComponent("playerJump");

		}
	}
}
	
function OnTriggerEnter(other : Collider) {
	if(other.tag == "floor"){
		canjump = true;
	}
}

function OnTriggerExit(other : Collider){

	if (other.tag == "floor"){

	canjump = false;

	}

}
	


