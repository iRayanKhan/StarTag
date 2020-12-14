using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getDistance : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public float Distance;
    bool playerTagged = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(player1.transform.position,player2.transform.position);
        Debug.Log(Distance);

      //  if (Input.GetMouseButtonDown(0)) {

            if (Distance <= 2.5) {
                
                if (playerTagged) {
                    playerTagged = false;
                    Debug.Log("You've been tagged" + Distance);
                  //   yield return new WaitForSecondsRealtime(15);
                }
                else if (!playerTagged) {
                    playerTagged = true;
                    Debug.Log("Enemy has been tagged" + Distance);
                   // yield return new WaitForSecondsRealtime(15);
                }
            }
      //  }
    }
}
