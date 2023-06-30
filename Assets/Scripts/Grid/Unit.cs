using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectPikachu.Grid
{
    public class Unit : MonoBehaviour
    {
        #region Properties
        public SpriteRenderer spriteRenderer;

        int index;
        #endregion

        #region UnityFunctions
        void Awake()
        {

        }


        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        #endregion

        #region Methods
        public void Init(int index)
        {
            this.index = index;
        }
        public void LoadUnit()
        {
        }
        #endregion
    }
}

