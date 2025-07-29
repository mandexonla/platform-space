using UnityEngine;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{

    [SerializeField] private Button OptionButton;
    [SerializeField] private GameObject MenuPanel;
    [SerializeField] private Button CloseButton;
    [SerializeField] private Button OKButton;

    private void Awake()
    {
        MenuPanel.SetActive(false);

        OptionButton.onClick.AddListener(() =>
        {
            MenuPanel.SetActive(true);
        });

        if (CloseButton != null)
        {
            CloseButton.onClick.AddListener(() =>
            {
                MenuPanel.SetActive(false);
            });
        }
    }
}
