namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200030C")]
internal struct XblMultiplayerSessionTag
{
	[CompilerGenerated]
	[Token(Token = "0x200030D")]
	[UnsafeValueType]
	internal struct <value>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400088F")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(byte), 100)]
	[Token(Token = "0x400088E")]
	private <value>e__FixedBuffer value; //Field offset: 0x0

	[Address(RVA = "0x2BB77D0", Offset = "0x2BB6BD0", Length = "0x2A")]
	[Token(Token = "0x6001171")]
	internal XblMultiplayerSessionTag(XblMultiplayerSessionTag publicObject) { }

	[Address(RVA = "0x2BB7080", Offset = "0x2BB6480", Length = "0xD")]
	[Token(Token = "0x6001170")]
	internal string GetValue() { }

}

