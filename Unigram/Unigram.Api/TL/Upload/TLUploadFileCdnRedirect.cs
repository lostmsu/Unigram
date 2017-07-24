// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Upload
{
	public partial class TLUploadFileCdnRedirect : TLUploadFileBase 
	{
		public Int32 DCId { get; set; }
		public Byte[] FileToken { get; set; }
		public Byte[] EncryptionKey { get; set; }
		public Byte[] EncryptionIV { get; set; }
		public TLVector<TLCdnFileHash> CdnFileHashes { get; set; }

		public TLUploadFileCdnRedirect() { }
		public TLUploadFileCdnRedirect(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UploadFileCdnRedirect; } }

		public override void Read(TLBinaryReader from)
		{
			DCId = from.ReadInt32();
			FileToken = from.ReadByteArray();
			EncryptionKey = from.ReadByteArray();
			EncryptionIV = from.ReadByteArray();
			CdnFileHashes = TLFactory.Read<TLVector<TLCdnFileHash>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(DCId);
			to.WriteByteArray(FileToken);
			to.WriteByteArray(EncryptionKey);
			to.WriteByteArray(EncryptionIV);
			to.WriteObject(CdnFileHashes);
		}
	}
}