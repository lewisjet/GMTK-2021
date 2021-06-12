using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
   [SerializeField] private InformationContainer _container;
    Image image;

    private void Awake() 
    {
        image = GetComponent<Image>();
    }

   private void Update() 
   {
       image.fillAmount = _container.hp / 100f;
   }
}
