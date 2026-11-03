namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000302")]
internal struct XblMultiplayerSessionNumberAttribute
{
	[CompilerGenerated]
	[Token(Token = "0x2000303")]
	[UnsafeValueType]
	internal struct <name>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400085F")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(byte), 100)]
	[Token(Token = "0x400085D")]
	private <name>e__FixedBuffer name; //Field offset: 0x0
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400085E")]
	internal readonly double value; //Field offset: 0x68

	[Address(RVA = "0x2BB7090", Offset = "0x2BB6490", Length = "0x42")]
	[Token(Token = "0x6001160")]
	internal XblMultiplayerSessionNumberAttribute(XblMultiplayerSessionNumberAttribute publicObject) { }

	[Address(RVA = "0x2BB7080", Offset = "0x2BB6480", Length = "0xD")]
	[Token(Token = "0x600115F")]
	internal string GetName() { }

}

