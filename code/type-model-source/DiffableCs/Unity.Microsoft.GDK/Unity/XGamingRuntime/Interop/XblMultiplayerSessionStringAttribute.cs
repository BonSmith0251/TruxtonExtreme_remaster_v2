namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000309")]
internal struct XblMultiplayerSessionStringAttribute
{
	[CompilerGenerated]
	[Token(Token = "0x200030A")]
	[UnsafeValueType]
	internal struct <name>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400088C")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x200030B")]
	[UnsafeValueType]
	internal struct <value>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400088D")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(byte), 100)]
	[Token(Token = "0x400088A")]
	private <name>e__FixedBuffer name; //Field offset: 0x0
	[FieldOffset(Offset = "0x64")]
	[FixedBuffer(typeof(byte), 100)]
	[Token(Token = "0x400088B")]
	private <value>e__FixedBuffer value; //Field offset: 0x64

	[Address(RVA = "0x2BB7780", Offset = "0x2BB6B80", Length = "0x4F")]
	[Token(Token = "0x600116F")]
	internal XblMultiplayerSessionStringAttribute(XblMultiplayerSessionStringAttribute publicObject) { }

	[Address(RVA = "0x2BB7080", Offset = "0x2BB6480", Length = "0xD")]
	[Token(Token = "0x600116D")]
	internal string GetName() { }

	[Address(RVA = "0x2BB7760", Offset = "0x2BB6B60", Length = "0x11")]
	[Token(Token = "0x600116E")]
	internal string GetValue() { }

}

