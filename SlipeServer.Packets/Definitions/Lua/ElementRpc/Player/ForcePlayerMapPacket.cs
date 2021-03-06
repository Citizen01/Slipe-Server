﻿using SlipeServer.Packets.Builder;
using SlipeServer.Packets.Enums;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SlipeServer.Packets.Definitions.Lua.ElementRpc.Player
{
    public class ForcePlayerMapPacket : Packet
    {
        public override PacketId PacketId => PacketId.PACKET_ID_LUA;
        public override PacketFlags Flags => PacketFlags.PACKET_HIGH_PRIORITY | PacketFlags.PACKET_RELIABLE | PacketFlags.PACKET_SEQUENCED;

        public bool Visible { get; set; }

        public ForcePlayerMapPacket(bool visible)
        {
            this.Visible = visible;
        }

        public override void Read(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public override byte[] Write()
        {
            var builder = new PacketBuilder();
            builder.Write((byte)ElementRpcFunction.FORCE_PLAYER_MAP);
            builder.Write((byte)(Visible ? 1 : 0));
            return builder.Build();
        }
    }
}
