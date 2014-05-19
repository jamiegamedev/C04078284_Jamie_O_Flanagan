#pragma strict


var prefab : GameObject;
var timeDelay = 3;

function Start() 
{
	while (true) 
	{
	yield WaitForSeconds(timeDelay);
	Instantiate( prefab, transform.position, Quaternion.identity );
	}
}
     