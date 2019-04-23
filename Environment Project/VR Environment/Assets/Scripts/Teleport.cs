// 2017 Riccardo E. Giorato - giorat

using UnityEngine;

using System.Collections;
using UnityEngine.EventSystems;


[RequireComponent(typeof(Collider))]
public class Teleport : MonoBehaviour {
  

  public GameObject camera;
  private VReyecaster cameraEyeCast;
  

  void Start()
  {
    cameraEyeCast = camera.GetComponent<VReyecaster>();
  }

  public void Recenter() {

    //GvrCardboardHelpers.Recenter();

    GvrEditorEmulator emulator = FindObjectOfType<GvrEditorEmulator>();
    if (emulator == null) {
      return;
    }
    //emulator.Recenter();
  }

  public void TeleportRandomly()
  {
    Debug.Log("click");
    transform.position = cameraEyeCast.hitPoint();
    transform.position = new Vector3 (transform.position.x, transform.position.y + 1.2f, transform.position.z);
    
  }
}
