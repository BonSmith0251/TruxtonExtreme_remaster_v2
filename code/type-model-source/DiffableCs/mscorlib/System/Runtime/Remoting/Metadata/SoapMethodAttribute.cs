namespace System.Runtime.Remoting.Metadata;

[AttributeUsage(AttributeTargets::Method (64))]
[ComVisible(True)]
[Token(Token = "0x200039C")]
public sealed class SoapMethodAttribute : SoapAttribute
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E85")]
	private string _responseElement; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E86")]
	private string _responseNamespace; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E87")]
	private string _returnElement; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E88")]
	private string _soapAction; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E89")]
	private bool _useAttribute; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E8A")]
	private string _namespace; //Field offset: 0x50

	[Token(Token = "0x1700031B")]
	public virtual bool UseAttribute
	{
		[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
		[Token(Token = "0x6001C34")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700031C")]
	public virtual string XmlNamespace
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6001C35")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6001C33")]
	public SoapMethodAttribute() { }

	[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
	[Token(Token = "0x6001C34")]
	public virtual bool get_UseAttribute() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6001C35")]
	public virtual string get_XmlNamespace() { }

	[Address(RVA = "0x1F148D0", Offset = "0x1F13CD0", Length = "0x1FB")]
	[Token(Token = "0x6001C36")]
	internal virtual void SetReflectionObject(object reflectionObject) { }

}

