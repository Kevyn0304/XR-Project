using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    [SerializeField]
    BranchManager manager;
    
    // Start is called before the first frame update
    void Start()
    {
        //manager = GetComponent<BranchManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("Collidedd");
        if (other.gameObject.tag == "Pickup")
        {
            Debug.Log("Grabbed branch");
            //Update counter
            manager.numBranches++;
            //Delete game object
            Destroy(other.gameObject);
        }
    }
}
