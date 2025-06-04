using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject panelDashboard;
    public GameObject panelGame1;
    public GameObject panelGame2;
<<<<<<< HEAD
<<<<<<< HEAD
    public GameObject minimap;
=======
    public KeyTracker keyTracker;
>>>>>>> b1244a1516988fff1e1d8eebee47d0f09eb62e59
=======
>>>>>>> parent of 096e887 (juego 2 terminado)
    public GameManager gameManager;

    public void OpenPanelGame1()
    {
        panelDashboard.SetActive(false);
        panelGame1.SetActive(true);

        if (keyTracker != null)
            keyTracker.MostrarTodasLasLlaves();

        if (gameManager != null)
        {
            Debug.Log("📲 Enviando mensaje de inicio de minijuego desde PanelSwitcher");
            gameManager.SendStartKeyGameCommand();
        }
        else
        {
            Debug.LogError("❌ GameManager no está asignado en PanelSwitcher");
        }
    }

    public void OpenPanelGame2()
    {
        panelDashboard.SetActive(false);
        panelGame2.SetActive(true);
    }

    public void ReturnToDashboard()
    {
        panelGame1.SetActive(false);
        panelGame2.SetActive(false);
        panelDashboard.SetActive(true);
    }
}
