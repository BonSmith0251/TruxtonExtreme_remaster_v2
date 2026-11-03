namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x200001E")]
public class CT_ExtendedAttributeList : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000083")]
	private CT_ExtendedAttributeListExtendedAttribute[] extendedAttributeField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000084")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x18

	[Token(Token = "0x14000018")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B66760", Offset = "0x2B65B60", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600010D")]
		 add { } //Length: 158
		[Address(RVA = "0x2B66800", Offset = "0x2B65C00", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600010E")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000057")]
	[XmlElement("ExtendedAttribute")]
	public CT_ExtendedAttributeListExtendedAttribute[] ExtendedAttribute
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600010B")]
		 get { } //Length: 5
		[Address(RVA = "0x2B668A0", Offset = "0x2B65CA0", Length = "0xB9")]
		[Token(Token = "0x600010C")]
		 set { } //Length: 185
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000110")]
	public CT_ExtendedAttributeList() { }

	[Address(RVA = "0x2B66760", Offset = "0x2B65B60", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600010D")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600010B")]
	public CT_ExtendedAttributeListExtendedAttribute[] get_ExtendedAttribute() { }

	[Address(RVA = "0x2B666D0", Offset = "0x2B65AD0", Length = "0x86")]
	[Token(Token = "0x600010F")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B66800", Offset = "0x2B65C00", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600010E")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B668A0", Offset = "0x2B65CA0", Length = "0xB9")]
	[Token(Token = "0x600010C")]
	public void set_ExtendedAttribute(CT_ExtendedAttributeListExtendedAttribute[] value) { }

}

