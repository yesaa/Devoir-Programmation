using UnityEngine;
using System.Collections;
using UnityEditor.Animations;

public class EnnemyMove : MonoBehaviour {

	Animator _Animator;
	Transform _PlayerTr;
	Rigidbody _Rigidbody;

	NavMeshAgent _NavMeshAgent;


	public float _SeeDistance = 10;
	public float _Speed = 5;

	public float _HitPower = 2;

	bool _Immobile;


	// Use this for initialization
	void Awake () 
	{
		_Animator = GetComponent<Animator> ();
		_PlayerTr = GameObject.FindGameObjectWithTag ("Player").transform;
		_Rigidbody = GetComponent<Rigidbody> ();
		_NavMeshAgent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		SetAnim ();
		_NavMeshAgent.destination = _PlayerTr.position;
	}

	void FixedUpdate()
	{
		//Move ();
	}

	void Move()
	{
		if (!CanSeePlayer()) return;
		GoForwardTarget (_PlayerTr);
	}

	void SetAnim()
	{
		_Animator.SetBool ("Immobile", _Immobile);
	}

	bool CanSeePlayer()
	{
		RaycastHit _hit;

		if(Physics.Raycast(transform.position, _PlayerTr.position - transform.position, out _hit, _SeeDistance))
		{
			if (_hit.transform == _PlayerTr) 
			{
				_Immobile = false;
				return true;
			}
		}
		_Immobile = true;
		return false;
	}


	void GoForwardTarget(Transform _Target)
	{

		transform.LookAt (_Target);
		Vector3 _Direction = _PlayerTr.position - transform.position;


		_Rigidbody.velocity = new Vector3(_Direction.x, 0, _Direction.z).normalized * _Speed;



	}


	void OnDrawGizmosSelected()
	{
		Gizmos.DrawWireSphere (transform.position, _SeeDistance);
	}

	void OnTriggerEnter(Collider _Coll)
	{
		if (_Coll.transform == _PlayerTr) 
		{
			HitPlayer ();
		}
	}

	void HitPlayer()
	{
		_Animator.SetTrigger ("attaque");
		Vector3 _Dir = _PlayerTr.position - transform.position;
		_PlayerTr.position += new Vector3(_Dir.x, 0, _Dir.z).normalized * _HitPower;
	}



}
