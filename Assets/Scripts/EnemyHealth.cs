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

                    gameManager.GetComponent<GameManager>().KillCounter();
                    Destroy(gameObject);
                }
                break;
                

            case 1:
                {
                    particles.Play();
                    gameObject.GetComponent<EnemyAI>().enemyState = EnemyAI.EnemyState.Escaping;
                }

                break;
        }
    }

    private void EnemyDrop()
    {
        randomIndex = Random.Range(0, dropArray.Length);
        randomDrop = dropArray[randomIndex];

        Instantiate(randomDrop, transform.position, Quaternion.Euler(-90, 0, 0));
    }
}
