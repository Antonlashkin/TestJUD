using UnityEngine;

public class OpenClosePopUp : MonoBehaviour
{
    [SerializeField] private GameObject popUp;

    public void OpenPopUp()
    {
        popUp.SetActive(true);
    }
    
    public void ClosePopUp()
    {
        popUp.SetActive(false);
    }
}
