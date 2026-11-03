namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200031F")]
internal struct XblMultiplayerSessionReference
{
	[CompilerGenerated]
	[Token(Token = "0x2000320")]
	[UnsafeValueType]
	internal struct <Scid>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008E5")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x2000321")]
	[UnsafeValueType]
	internal struct <SessionName>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008E6")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x2000322")]
	[UnsafeValueType]
	internal struct <SessionTemplateName>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008E7")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(byte), 40)]
	[Token(Token = "0x40008E2")]
	private <Scid>e__FixedBuffer Scid; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[FixedBuffer(typeof(byte), 100)]
	[Token(Token = "0x40008E3")]
	private <SessionTemplateName>e__FixedBuffer SessionTemplateName; //Field offset: 0x28
	[FieldOffset(Offset = "0x8C")]
	[FixedBuffer(typeof(byte), 100)]
	[Token(Token = "0x40008E4")]
	private <SessionName>e__FixedBuffer SessionName; //Field offset: 0x8C

	[Address(RVA = "0x2BB76F0", Offset = "0x2BB6AF0", Length = "0x68")]
	[Token(Token = "0x6001188")]
	internal XblMultiplayerSessionReference(XblMultiplayerSessionReference publicObject) { }

	[Address(RVA = "0x2BA6490", Offset = "0x2BA5890", Length = "0xD")]
	[Token(Token = "0x6001185")]
	internal string GetScid() { }

	[Address(RVA = "0x2BB76B0", Offset = "0x2BB6AB0", Length = "0x14")]
	[Token(Token = "0x6001187")]
	internal string GetSessionName() { }

	[Address(RVA = "0x2BB76D0", Offset = "0x2BB6AD0", Length = "0x11")]
	[Token(Token = "0x6001186")]
	internal string GetSessionTemplateName() { }

}

