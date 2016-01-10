#pragma strict

function OnTriggerEnter (node: Collider){
	if (node.tag == "Moneda")
	{
		Destroy(node.gameObject);
	}
}
