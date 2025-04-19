using TreeEditor;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.Find("PlayerWithAnimation");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, 3 * Time.deltaTime);        
    }

}
