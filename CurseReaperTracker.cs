using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using ItemAPI;

namespace ReaperTracker
{
    class CurseReaperTracker : MonoBehaviour
    {

        void Awake()
        {
            SpriteBuilder.SpriteFromResource("ReaperTracker/Resources/ReaperIcon", MinimapspriteObj);
        }

        GameObject MinimapspriteObj = new GameObject("minimap curse sprote");
        void Start()
        {
                       
        }

        void Update()
        {           
            Vector3 worldPosition = this.gameObject.transform.position;
            Vector3 minimapPosition = Minimap.Instance.transform.position + new Vector3(worldPosition.x * 0.125f, worldPosition.y * 0.125f, 1f);
            MinimapspriteObj.transform.position = minimapPosition.Quantize(0.0625f); ;                    
        }
        void OnDestroy()
        {
            Destroy(MinimapspriteObj);
        }
    }
}
