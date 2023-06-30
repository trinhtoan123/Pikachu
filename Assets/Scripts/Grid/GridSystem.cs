using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectPikachu.Grid
{
    public class GridSystem : MonoBehaviour
    {
        [SerializeField]List<Node>lstNode = new List<Node>();
        public int height =9;
        public int width =16;
        [SerializeField] GameObject unit;
        private void Start()
        {
            Init();
        }
        public void Init()
        {
            LoadData();
            SpawnUnit();
        }
        public void GameStart()
        {
            
        }
        public void GameEnd()
        {

        }
        public void LoadData()
        {
            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    Node node = new Node();
                    node.x = x;
                    node.y = y;
                    lstNode.Add(node);

                }
            }
        }
        public void SpawnUnit()
        {
            Vector3 pos = Vector3.zero;
            foreach (Node node in lstNode)
            {
                GameObject c = Instantiate(unit, transform);
            }
        }
    }
}

