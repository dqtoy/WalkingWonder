using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PazzleNodeParent2 : MonoBehaviour
{
    int lastNode = 3;

    [SerializeField] List<GameObject> correctOrder;

    [SerializeField] List<GameObject> removeThese;

    [SerializeField] Vector3 removeVelocity;
  

    public void ReceiveNode(GameObject _nextNode)
    {
        if (correctOrder.Count > 0)
        {
            if (_nextNode == correctOrder[0])
            {
                print("found " + _nextNode.name);

                correctOrder.RemoveAt(0);
            }
        }
        else
        {
            print("all found");
            for (int i = 0; i < removeThese.Count; i++)
            {
         

                removeThese[i].AddComponent<PuzzleResultBehavior>();
                removeThese[i].GetComponent<PuzzleResultBehavior>().myVelocity = removeVelocity;
              Destroy(removeThese[i], 20);
            }

            GameObject successSoundObj = transform.Find("SuccessSound").gameObject;
            successSoundObj.transform.parent = null;
            successSoundObj.GetComponent<AudioSource>().Play();
            Destroy(successSoundObj, 7);



            Destroy(this.gameObject);
        }



    }


}
