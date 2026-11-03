namespace UnityEngine.UIElements;

[Token(Token = "0x200024F")]
public struct FilterParameterDeclaration
{
	[DontCreateProperty]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40008FD")]
	private string m_Name; //Field offset: 0x0
	[DontCreateProperty]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x40008FE")]
	private FilterParameter m_InterpolationDefaultValue; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008FF")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal FilterParameter defaultValue; //Field offset: 0x20

	[CreateProperty]
	[Token(Token = "0x170002E3")]
	public FilterParameter interpolationDefaultValue
	{
		[Address(RVA = "0xAEF270", Offset = "0xAEE670", Length = "0x15")]
		[Token(Token = "0x6000FE2")]
		 get { } //Length: 21
		[Address(RVA = "0x33D09D0", Offset = "0x33CFDD0", Length = "0x12")]
		[Token(Token = "0x6000FE3")]
		 set { } //Length: 18
	}

	[CreateProperty]
	[Token(Token = "0x170002E2")]
	public string name
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000FE0")]
		 get { } //Length: 4
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6000FE1")]
		 set { } //Length: 8
	}

	[Address(RVA = "0xAEF270", Offset = "0xAEE670", Length = "0x15")]
	[Token(Token = "0x6000FE2")]
	public FilterParameter get_interpolationDefaultValue() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000FE0")]
	public string get_name() { }

	[Address(RVA = "0x33D09D0", Offset = "0x33CFDD0", Length = "0x12")]
	[Token(Token = "0x6000FE3")]
	public void set_interpolationDefaultValue(FilterParameter value) { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x6000FE1")]
	public void set_name(string value) { }

}

