using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using GameServer;

namespace GamerServer
{
    class Player
    {
        public int id;
        public string username;

        public Vector3 position;
        public Quaternion rotation;

        private float moveSpeed = 5f / Constants.TICKS_PER_SEC;
        private bool[] inputs;

        public Player(int _id, string _username, Vector3 _spawnPostion)
        {
            id = _id;
            username = _username;
            position = _spawnPostion;
            rotation = Quaternion.Identity;

            // TODO: create inputs for player
            
            inputs = new bool[4];
        }

        public void Update()
        {
            Vector2 _inputDirection = Vector2.Zero;
        }
    }
}
