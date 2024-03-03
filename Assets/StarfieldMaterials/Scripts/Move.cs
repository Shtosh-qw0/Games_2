using UnityEngine; 
using System.Collections;

public class Move : MonoBehaviour
{
    float Target;
	public float straffeSpeed = 0.05f;
	void Start()
	{

	}

	void Update()
	{
        Target += Time.deltaTime / 125;

        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, Target), straffeSpeed);

	}
}