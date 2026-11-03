namespace System.Runtime.Remoting.Metadata;

[AttributeUsage(1052)]
[ComVisible(True)]
[Token(Token = "0x200039E")]
public sealed class SoapTypeAttribute : SoapAttribute
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E8B")]
	private bool _useAttribute; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E8C")]
	private string _xmlElementName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E8D")]
	private string _xmlNamespace; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E8E")]
	private string _xmlTypeName; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E8F")]
	private string _xmlTypeNamespace; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E90")]
	private bool _isType; //Field offset: 0x50
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x4000E91")]
	private bool _isElement; //Field offset: 0x51

	[Token(Token = "0x17000322")]
	internal bool IsInteropXmlElement
	{
		[Address(RVA = "0x1CF2AF0", Offset = "0x1CF1EF0", Length = "0x5")]
		[Token(Token = "0x6001C3E")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000323")]
	internal bool IsInteropXmlType
	{
		[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
		[Token(Token = "0x6001C3F")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700031D")]
	public virtual bool UseAttribute
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6001C39")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700031E")]
	public string XmlElementName
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6001C3A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700031F")]
	public virtual string XmlNamespace
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6001C3B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000320")]
	public string XmlTypeName
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6001C3C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000321")]
	public string XmlTypeNamespace
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6001C3D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6001C38")]
	public SoapTypeAttribute() { }

	[Address(RVA = "0x1CF2AF0", Offset = "0x1CF1EF0", Length = "0x5")]
	[Token(Token = "0x6001C3E")]
	internal bool get_IsInteropXmlElement() { }

	[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
	[Token(Token = "0x6001C3F")]
	internal bool get_IsInteropXmlType() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6001C39")]
	public virtual bool get_UseAttribute() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6001C3A")]
	public string get_XmlElementName() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6001C3B")]
	public virtual string get_XmlNamespace() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6001C3C")]
	public string get_XmlTypeName() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6001C3D")]
	public string get_XmlTypeNamespace() { }

	[Address(RVA = "0x1F14AD0", Offset = "0x1F13ED0", Length = "0x23D")]
	[Token(Token = "0x6001C40")]
	internal virtual void SetReflectionObject(object reflectionObject) { }

}

