using UnityEngine;
using System.Collections;

public class GenradorObstaculos : MonoBehaviour {

    public GameObject objetoGenerar;
    public float velocidadGenerador;
    public float velocidadInicialGenerador;
    public float velocidadEstandarizadaObstaculos;
	// Use this for initialization
	void Start () {
        InvokeRepeating("GenerarObstaculos",velocidadInicialGenerador,velocidadEstandarizadaObstaculos);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(velocidadGenerador*Time.deltaTime*1,0,0);
	}

    void GenerarObstaculos() {
        if (objetoGenerar!=null)
        {
            Instantiate(objetoGenerar,transform.position, Quaternion.identity);
        }
    }
}
