using UnityEngine;

public class Credits : MonoBehaviour
{
    [SerializeField] private GameObject _menuObject;

    public void BackToMain()
    {
        gameObject.SetActive(false);
        _menuObject.SetActive(true);
    }
}