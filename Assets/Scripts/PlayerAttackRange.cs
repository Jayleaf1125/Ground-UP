using UnityEngine;

public class PlayerAttackRange : MonoBehaviour
{
    public bool isInAttackRange = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        { 
            this.GetComponentInParent<FollowPlayer>().enabled = false; 
            isInAttackRange = true;
            GetComponent<SpriteRenderer>().color = Color.yellow;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            this.GetComponentInParent<FollowPlayer>().enabled = true;
            isInAttackRange = false;
            GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
