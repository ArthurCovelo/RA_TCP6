using UnityEngine;

public class CombinationScript : MonoBehaviour
{
    public GameObject hydrogen;
    public GameObject oxygen;
    public GameObject waterPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == hydrogen && oxygen != null)
        {
            Destroy(hydrogen);
            Destroy(oxygen);

            Instantiate(waterPrefab, transform.position, Quaternion.identity);
        }
    }
}
