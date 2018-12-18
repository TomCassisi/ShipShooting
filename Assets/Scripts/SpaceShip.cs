using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
	[SerializeField]
	private float m_Speed;

	[SerializeField]
	private Bullet m_Bullet;

	public float Speed { get { return m_Speed; } set { m_Speed = value; } }

	// Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		// Movement
	    float horizontal = Input.GetAxis("Horizontal");
	    float vertical = Input.GetAxis("Vertical");

	    float verticalSpeed = m_Speed * vertical * Time.deltaTime;
	    float horizontalSpeed = m_Speed * horizontal * Time.deltaTime;

		Vector3 offset = new Vector3(horizontalSpeed, verticalSpeed, 0);
	    Vector3 currentPosition = transform.position;
	    Vector3 nextPosition = offset + currentPosition;

	    transform.position = nextPosition;

		// Shooting
	    if (Input.GetButtonDown("Fire1"))
	    {
		    Bullet bullet = Instantiate(m_Bullet, transform.position, Quaternion.identity);
			bullet.Velocity = new Vector3(1,0,0);	
	    }

    }

	void OnGUI()
	{
		GUILayout.Label(string.Format("Horizontal {0}", Input.GetAxis("Horizontal")));
		GUILayout.Label(string.Format("Vertical {0}", Input.GetAxis("Vertical")));
	}
}
