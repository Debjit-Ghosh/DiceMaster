using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Domino : MonoBehaviour
{
        public GameObject tile;
        public GameObject table;

        public void Tile()
        {
            tile.SetActive(true);
            table.SetActive(false);
        }
        public void Table()
        {
            tile.SetActive(false);
            table.SetActive(true);

        }
}
