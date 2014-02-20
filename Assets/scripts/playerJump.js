#pragma strict
var jumpSpeed : float = 1;

function Start () {

wait();

}

function Update () {

transform.Translate(Vector3.up * jumpSpeed/4);

}

function wait(){

yield WaitForSeconds(0.1);

Destroy(this);

}
