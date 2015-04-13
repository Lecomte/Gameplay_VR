using UnityEngine;
using System.Collections;

public class PositionDeplacementScript : MonoBehaviour {

    [SerializeField]
    private PlayerClass _playerInfos;

    [SerializeField]
    private float _speed;

    private Vector3 _positionTarget;
    private Vector3 _direction;
    private bool isOnDeplacement;

	// Use this for initialization
	void Start () {
        isOnDeplacement = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!isOnDeplacement)
            return;

        this.gameObject.transform.position += this._direction * this._speed * Time.deltaTime;
        if (this.gameObject.transform.position == this._positionTarget)
            isOnDeplacement = false;
	}

    public void setTarget(GameObject target, Vector3 direction)
    {
        this._positionTarget = target.transform.position;
        this._direction = direction;
        isOnDeplacement = true;
    }
}
