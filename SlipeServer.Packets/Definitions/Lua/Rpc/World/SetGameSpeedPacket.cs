﻿using SlipeServer.Packets.Builder;
using SlipeServer.Packets.Definitions.Lua.ElementRpc;
using SlipeServer.Packets.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeServer.Packets.Definitions.Lua.Rpc.World
{
    public class SetGameSpeedPacket : Packet
    {
        public override PacketId PacketId => PacketId.PACKET_ID_LUA;

        public override PacketFlags Flags => PacketFlags.PACKET_MEDIUM_PRIORITY;

        public float GameSpeed { get; set; }

        public SetGameSpeedPacket(float gameSpeed)
        {
            this.GameSpeed = gameSpeed;
        }

        public override void Read(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public override byte[] Write()
        {
            PacketBuilder builder = new PacketBuilder();
            builder.Write((byte)ElementRpcFunction.SET_GAME_SPEED);
            builder.Write(this.GameSpeed);

            return builder.Build();
        }
    }
}
