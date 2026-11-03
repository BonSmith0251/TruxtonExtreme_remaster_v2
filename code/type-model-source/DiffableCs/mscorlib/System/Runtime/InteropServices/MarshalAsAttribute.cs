namespace System.Runtime.InteropServices;

[AttributeUsage(10496, Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x200045F")]
public sealed class MarshalAsAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001230")]
	public string MarshalCookie; //Field offset: 0x10
	[ComVisible(True)]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001231")]
	public string MarshalType; //Field offset: 0x18
	[ComVisible(True)]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001232")]
	public Type MarshalTypeRef; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001233")]
	public Type SafeArrayUserDefinedSubType; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001234")]
	private UnmanagedType utype; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001235")]
	public UnmanagedType ArraySubType; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001236")]
	public VarEnum SafeArraySubType; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001237")]
	public int SizeConst; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001238")]
	public int IidParameterIndex; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4001239")]
	public short SizeParamIndex; //Field offset: 0x44

	[Token(Token = "0x170003F4")]
	public UnmanagedType Value
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x60020AB")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1F36BA0", Offset = "0x1F35FA0", Length = "0x24")]
	[Token(Token = "0x60020AA")]
	public MarshalAsAttribute(UnmanagedType unmanagedType) { }

	[Address(RVA = "0x1F36B40", Offset = "0x1F35F40", Length = "0x57")]
	[Token(Token = "0x60020AC")]
	internal MarshalAsAttribute Copy() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x60020AB")]
	public UnmanagedType get_Value() { }

}

