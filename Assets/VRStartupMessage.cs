using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class VRStartupMessage : MonoBehaviour
{
    public GameObject messagePanel;
    public Button okButton;

    public ActionBasedContinuousMoveProvider moveProvider;
    public ActionBasedSnapTurnProvider turnProvider; // Optional

    void Start()
    {
        messagePanel.SetActive(true);

        // Disable movement
        if (moveProvider) moveProvider.enabled = false;
        if (turnProvider) turnProvider.enabled = false;

        okButton.onClick.AddListener(OnOkClicked);
    }

    void OnOkClicked()
    {
        messagePanel.SetActive(false);

        // Re-enable movement
        if (moveProvider) moveProvider.enabled = true;
        if (turnProvider) turnProvider.enabled = true;
    }
}
