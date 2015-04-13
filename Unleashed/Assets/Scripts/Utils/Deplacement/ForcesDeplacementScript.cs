using UnityEngine;
using System.Collections;

public class ForcesDeplacementScript : MonoBehaviour {

    [SerializeField]
    private PlayerClass _playerInfos;

    [SerializeField]
    private float _power;

    [SerializeField]
    private float _torquePower;

    private Vector3 _direction;


	// Use this for initialization
	void Start () {
        this._direction = Vector3.zero;
	}

    public void pullObject(Vector3 direction)
    {
        this._direction = (this._direction + direction).normalized;
        this._playerInfos.Rigidbody.AddForce(this._direction * this._power, ForceMode.Impulse);
        this._playerInfos.Rigidbody.AddTorque(Vector3.up * -this._torquePower, ForceMode.Impulse);
    }
}
