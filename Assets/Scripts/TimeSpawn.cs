using UnityEngine;


public class TimeSpawn : MonoBehaviour
{
    //public GameObject go;
        StateMachine goB;
   
    public GameObject spawnee;
    public bool stopSpawning;
    public float spawnTime;
    public float spawnDelay;
      
    



    // Start is called before the first frame update
    void Start()
    {  
        //stopSpawning = false;
        goB = GameObject.Find("StateMachineO").GetComponent<StateMachine>();

        // Spawner repeating
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        
    }


public void SpawnObject(){

    Instantiate(spawnee, transform.position , transform.rotation);
    if (!goB.getGameIsRunning()){
        //do Something
        CancelInvoke("SpawnObject");


}


}
    
}
