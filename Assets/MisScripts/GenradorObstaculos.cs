using UnityEngine;
using System.Collections;

public class GenradorObstaculos : MonoBehaviour {

    public GameObject obstaculoNave;
    public float velocidadGenerador;
	// Use this for initialization
	void Start () {
        InvokeRepeating("GenerarObstaculos",1,4);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(velocidadGenerador*Time.deltaTime*1,0,0);
	}

    void GenerarObstaculos() {
        Instantiate(obstaculoNave,transform.position, Quaternion.identity);
    }
}
