using UnityEngine;

public class EnemyHealth : HealthAndDamage
{
    [Header("ENEMY DROP")]
    [HideInInspector] int randomIndex;
    [HideInInspector] GameObject randomDrop;
    [SerializeField] GameObject[] dropArray;

    [SerializeField] protected ParticleSystem enemyParticles;


    protected override void TakeDamage()
    {
        base.TakeDamage();

        
        switch (health)
        {

            case 1: particles.Play();

                break;


            case 0:
                {
                    EnemyDrop();

                    gameManager.GetComponent<GameManager>().KillCounter();
                    enemyParticles.Play();

                    Destroy(gameObject, 0.5f);
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
