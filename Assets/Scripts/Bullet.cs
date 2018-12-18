using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	[SerializeField]
	private Vector3 m_Velocity; 

	public Vector3 Velocity { get { return m_Velocity; } set { m_Velocity = value; } }

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    Vector3 offset = m_Velocity * Time.deltaTime;
		Vector3 currentPosition = transform.position;
	    Vector3 nextPosition = offset + currentPosition;

	    transform.position = nextPosition;
	}
}
