using UnityEngine;

public class ChemistryController : MonoBehaviour
{
    public GameObject elementO;
    public GameObject elementH;
    public GameObject resultH2O;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Element"))
        {
            GameObject collidedElement = collision.gameObject;
            collidedElement.SetActive(false);

            if (!elementO.activeSelf && !elementH.activeSelf)
            {
                resultH2O.SetActive(true);
            }
        }
    }
}
