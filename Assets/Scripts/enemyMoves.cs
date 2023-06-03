using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMoves : MonoBehaviour
{
    public float speed;
    public bool MoveRight;
    public GameObject go;
    StateMachine goB;

    // Start is called before the first frame update
    
    private void Start() {
         goB = GameObject.Find("StateMachineO").GetComponent<StateMachine>();

    }
    // Update is called once per frame
    void Update()
    {
        if(MoveRight)
        {
            transform.Translate(2* Time.deltaTime * speed, 0,0);
        }
        else
        {
            transform.Translate(-2* Time.deltaTime * speed, 0,0);
        }

        
            }
            private void OnTriggerEnter2D(Collider2D collider)
            {
                goB.SubLife(1);
                Debug.Log("collide");
                Destroy(this.gameObject);
            }
}
