namespace TMPro.SpriteAssetUtilities;

[Token(Token = "0x20000BC")]
public class TexturePacker_JsonArray
{
	[Token(Token = "0x20000BF")]
	internal struct Frame
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A4")]
		public string filename; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40006A5")]
		public SpriteFrame frame; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006A6")]
		public bool rotated; //Field offset: 0x18
		[FieldOffset(Offset = "0x19")]
		[Token(Token = "0x40006A7")]
		public bool trimmed; //Field offset: 0x19
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40006A8")]
		public SpriteFrame spriteSourceSize; //Field offset: 0x1C
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40006A9")]
		public SpriteSize sourceSize; //Field offset: 0x2C
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40006AA")]
		public Vector2 pivot; //Field offset: 0x34

	}

	[Token(Token = "0x20000C0")]
	internal struct Meta
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006AB")]
		public string app; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40006AC")]
		public string version; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006AD")]
		public string image; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006AE")]
		public string format; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006AF")]
		public SpriteSize size; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40006B0")]
		public float scale; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40006B1")]
		public string smartupdate; //Field offset: 0x30

	}

	[Token(Token = "0x20000C1")]
	internal class SpriteDataObject
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006B2")]
		public List<Frame> frames; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006B3")]
		public Meta meta; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600071E")]
		public SpriteDataObject() { }

	}

	[Token(Token = "0x20000BD")]
	internal struct SpriteFrame
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400069E")]
		public float x; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400069F")]
		public float y; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40006A0")]
		public float w; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40006A1")]
		public float h; //Field offset: 0xC

		[Address(RVA = "0x2F195B0", Offset = "0x2F189B0", Length = "0x1C0")]
		[Token(Token = "0x600071C")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x20000BE")]
	internal struct SpriteSize
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A2")]
		public float w; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40006A3")]
		public float h; //Field offset: 0x4

		[Address(RVA = "0x2F19780", Offset = "0x2F18B80", Length = "0x96")]
		[Token(Token = "0x600071D")]
		public virtual string ToString() { }

	}


	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600071B")]
	public TexturePacker_JsonArray() { }

}

