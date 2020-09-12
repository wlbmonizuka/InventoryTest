using UnityEngine;

namespace Rav3.View
{
    public class EntryPointView : MonoBehaviour
    {
        private void Awake()
        {
            var model = new Model.EntryPoint();
            model.Main();
        }
    }
}