namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000323")]
internal struct XblMultiplayerSessionReferenceUri
{
	[CompilerGenerated]
	[Token(Token = "0x2000324")]
	[UnsafeValueType]
	internal struct <value>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008E9")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(byte), 284)]
	[Token(Token = "0x40008E8")]
	private <value>e__FixedBuffer value; //Field offset: 0x0

	[Address(RVA = "0x2BB7680", Offset = "0x2BB6A80", Length = "0x2A")]
	[Token(Token = "0x600118A")]
	internal XblMultiplayerSessionReferenceUri(XblMultiplayerSessionReferenceUri publicObject) { }

	[Address(RVA = "0x2BB7670", Offset = "0x2BB6A70", Length = "0xD")]
	[Token(Token = "0x6001189")]
	internal string GetValue() { }

}

