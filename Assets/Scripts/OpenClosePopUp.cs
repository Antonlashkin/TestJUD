using UnityEngine;

//This class opens and closes setting popup
public class OpenClosePopUp : MonoBehaviour
{
    [SerializeField] private GameObject popUp;

    //open settings popup
    public void OpenPopUp()
    {
        popUp.SetActive(true);
    }
    
    //close settings popup
    public void ClosePopUp()
    {
        popUp.SetActive(false);
    }
}
