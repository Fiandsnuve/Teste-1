using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour {

    [Tooltip("What joystick to use.")]
    public Joystick _Joystick;
    public float MoveSpeed;
	public float RotationSpeed;
	CharacterController cc;
	private Animator anim;
	protected Vector3 gravidade = Vector3.zero;
	protected Vector3 move = Vector3.zero;
	private bool jump = false;


	
	void Start()
	{
		cc = GetComponent<CharacterController> ();
		anim = GetComponent<Animator>();
		anim.SetTrigger("Parado");
	}

	void Update()
	{
        Vector3 move;
        if (_Joystick.JoystickInput.y != 0)
        {
            move = _Joystick.JoystickInput.y * transform.TransformDirection(Vector3.forward) * MoveSpeed;
        }
        else
        //if (Input.GetAxis("Vertical") != 0)
        {
            move = Input.GetAxis("Vertical") * transform.TransformDirection(Vector3.forward) * MoveSpeed;
        }

        
        if (_Joystick.JoystickInput.x != 0)
        {
            transform.Rotate(new Vector3(0, _Joystick.JoystickInput.x * RotationSpeed * Time.deltaTime, 0));
        }
        else
        //if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * RotationSpeed * Time.deltaTime, 0));
        }
        

        if (!cc.isGrounded) {
			gravidade += Physics.gravity * Time.deltaTime;
		} 
		else 
		{
			gravidade = Vector3.zero;
			if(jump)
			{
				gravidade.y = 6f;
				jump = false;
			}
		}
		move += gravidade;
		cc.Move (move* Time.deltaTime);
		Anima ();
	}
	 
	void Anima()
	{
		if (!Input.anyKey)
		{
			anim.SetTrigger("Parado");
		} 
		else 
		{
			if(Input.GetKeyDown("space"))
			{
				anim.SetTrigger("Pula");
				jump = true;
			}
			else
			{
				anim.SetTrigger("Corre");
			}
		}
	}
}
