// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateReadHistoryInbox : TLUpdateBase, ITLMultiPts 
	{
		public TLPeerBase Peer { get; set; }
		public Int32 MaxId { get; set; }
		public Int32 Pts { get; set; }
		public Int32 PtsCount { get; set; }

		public TLUpdateReadHistoryInbox() { }
		public TLUpdateReadHistoryInbox(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateReadHistoryInbox; } }

		public override void Read(TLBinaryReader from)
		{
			Peer = TLFactory.Read<TLPeerBase>(from);
			MaxId = from.ReadInt32();
			Pts = from.ReadInt32();
			PtsCount = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9961FD5C);
			to.WriteObject(Peer);
			to.Write(MaxId);
			to.Write(Pts);
			to.Write(PtsCount);
		}
	}
}