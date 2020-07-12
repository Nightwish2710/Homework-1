using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
	public float maxPos = 10f;
	public float minPos = -10f;
	public float currentPos = -10f;
	public float speed = 5f;

	private Vector2 startPos;

	// Start is called before the first frame update
	void Start()
    {
		startPos = transform.position;
	}

    // Update is called once per frame
    void Update()
    {
		currentPos += Time.deltaTime * speed;

		if (currentPos >= maxPos)
		{
			currentPos = minPos;
		}

		transform.position = new Vector2(currentPos, startPos.y);
	}
}
