using UnityEngine;
public class MovementController : MonoBehaviour
{
	public float movementSpeed = 3.0f;
	Vector2 movement = new Vector2();
	Rigidbody2D rb2D;

	private void Start()
	{
		rb2D = GetComponent<Rigidbody2D>();
	}
	private void Update()
	{
	}

	void FixedUpdate()
	{
		movement.x = Input.GetAxisRaw("Horizontal");
		movement.y = Input.GetAxisRaw("Vertical");

		movement.Normalize();

		rb2D.velocity = movement * movementSpeed;
	}
}
