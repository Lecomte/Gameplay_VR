using UnityEngine;
using System.Collections;

public class InputHandlerScript : MonoBehaviour {

    [SerializeField]
    private PlayerClass _playerInfos;

    [SerializeField]
    private Camera _refCam;

    [SerializeField]
    private LayerMask _expectedLayer;

    private RaycastHit hit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    if(Input.GetMouseButton(0))
        {
            Ray mouseWorldPosition = this._refCam.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(mouseWorldPosition,out hit,Mathf.Infinity,_expectedLayer))
            {
                this._playerInfos.PositionDeplacement.setTarget(
                    hit.collider.gameObject,
                    -((this._playerInfos.GameObjectPlayer.transform.position - hit.collider.transform.position
                    ).normalized)
                    );
                /*this._playerInfos.Deplacement.pullObject(-((
                    this._playerInfos.GameObjectPlayer.transform.position - hit.collider.transform.position
                    ).normalized));*/
            }
        }
	}
}
