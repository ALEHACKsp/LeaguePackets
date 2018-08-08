﻿using System;
using LeaguePackets.Common;

namespace LeaguePackets.CommonData.EventArgs
{
    public abstract class ArgsItemCallout : ArgsBase
    {
        public ItemID ItemID { get; set; }
        public uint ItemCount { get; set; }
        public TeamID TeamID { get; set; }
        public override void ReadArgs(PacketReader reader)
        {
            ItemID = reader.ReadItemID();
            ItemCount = reader.ReadUInt32();
            reader.ReadPad(24);
            TeamID = reader.ReadTeamID();
        }
        public override void WriteArgs(PacketWriter writer)
        {
            writer.WriteItemID(ItemID);
            writer.WriteUInt32(ItemCount);
            writer.WritePad(24);
            writer.WriteTeamID(TeamID);
        }
    }
}
