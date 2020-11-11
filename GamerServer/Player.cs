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


        public Player(int _id, string _username, Vector3 _spawnPostion)
        {
            id = _id;
            username = _username;
            position = _spawnPostion;
            rotation = Quaternion.Identity;

            // TODO: create inputs for player
        }

        public void Update()
        {
            //Vector2 _inputDirection = Vector2.Zero;

            ServerSend.PlayerPosition(this);
        }

        public void SetPosition(Vector3 _position)
        {
            this.position = _position;
            // Console.WriteLine($"Player: {this.id} position has been set to {this.position}");
        }
    }
}
