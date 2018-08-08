﻿using LeaguePackets.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace LeaguePackets.GamePackets
{
    public class SPM_SamplingProfilerUpdate : GamePacket, IUnusedPacket // 0xC7
    {
        public override GamePacketID ID => GamePacketID.SPM_SamplingProfilerUpdate;
        public static SPM_SamplingProfilerUpdate CreateBody(PacketReader reader, ChannelID channelID, NetID senderNetID) 
        {
            var result = new SPM_SamplingProfilerUpdate();
            result.SenderNetID = senderNetID;
            result.ChannelID = channelID;

            return result;
        }
        public override void WriteBody(PacketWriter writer) {}
    }
}