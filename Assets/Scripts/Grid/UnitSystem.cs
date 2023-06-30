using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectPikachu.Grid
{
    public class UnitSystem : MonoBehaviour
    {
        [SerializeField]List<Node>lstNode = new List<Node>();
        public int height =9;
        public int width =16;
        public float offSetX;
        public float offSetY;
        [SerializeField] Unit unit;
        private void Start()
        {
            Init();
        }
        public void Init()
        {
            LoadList_Node();
            SpawnUnit();
        }
        public void GameStart()
        {
            
        }
        public void GameEnd()
        {

        }
        public void LoadList_Node()
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
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
                Unit c = Instantiate(unit);
                pos.x = ((node.x - (offSetX * node.x)) * c.transform.localScale.x );
                pos.y = ((node.y - (offSetY * node.y)) * c.transform.localScale.x) ;
                c.transform.position = pos;
                c.transform.SetParent(transform);
          
            }
        }
        public Node GetNode(int index)
        {
            return lstNode[index];
        }
    }
}

