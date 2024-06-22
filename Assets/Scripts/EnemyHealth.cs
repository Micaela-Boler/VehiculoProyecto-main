using UnityEngine;

public class EnemyHealth : HealthAndDamage
{
    [Header("ENEMY DROP")]
    [HideInInspector] int randomIndex;
    [HideInInspector] GameObject randomDrop;
    [SerializeField] GameObject[] dropArray;

    

    protected override void TakeDamage()
    {
        base.TakeDamage();

        
        switch (health)
        {
            case 0:
                {
                    EnemyDrop();

                    //gameObject.GetComponent<GameManager>().KillCounter();
                    Destroy(gameObject);
                }
                break;
                

            case 1: particles.Play();
                break;
        }
    }

    private void EnemyDrop()
    {
        randomIndex = Random.Range(0, dropArray.Length);
        randomDrop = dropArray[randomIndex];

        Instantiate(randomDrop, transform.position, Quaternion.identity);
    }
    
    

}
