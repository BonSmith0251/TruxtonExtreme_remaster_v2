namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000009")]
[XmlType(AnonymousType = True)]
public class CT_SaveGameStorageNoCodePCRoot : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000031")]
	private ST_GameSaveNoCodePcRootRelativeLocation relativeToField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000032")]
	private string valueField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000033")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x20

	[Token(Token = "0x14000006")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B68D90", Offset = "0x2B68190", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000067")]
		 add { } //Length: 158
		[Address(RVA = "0x2B68E30", Offset = "0x2B68230", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000068")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000027")]
	[XmlAttribute]
	public ST_GameSaveNoCodePcRootRelativeLocation RelativeTo
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000063")]
		 get { } //Length: 85
		[Address(RVA = "0x2B68ED0", Offset = "0x2B682D0", Length = "0x4A")]
		[Token(Token = "0x6000064")]
		 set { } //Length: 74
	}

	[Token(Token = "0x17000028")]
	[XmlText]
	public string Value
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000065")]
		 get { } //Length: 5
		[Address(RVA = "0x2B68F20", Offset = "0x2B68320", Length = "0x58")]
		[Token(Token = "0x6000066")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600006A")]
	public CT_SaveGameStorageNoCodePCRoot() { }

	[Address(RVA = "0x2B68D90", Offset = "0x2B68190", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000067")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000063")]
	public ST_GameSaveNoCodePcRootRelativeLocation get_RelativeTo() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000065")]
	public string get_Value() { }

	[Address(RVA = "0x2B68D00", Offset = "0x2B68100", Length = "0x86")]
	[Token(Token = "0x6000069")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B68E30", Offset = "0x2B68230", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000068")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B68ED0", Offset = "0x2B682D0", Length = "0x4A")]
	[Token(Token = "0x6000064")]
	public void set_RelativeTo(ST_GameSaveNoCodePcRootRelativeLocation value) { }

	[Address(RVA = "0x2B68F20", Offset = "0x2B68320", Length = "0x58")]
	[Token(Token = "0x6000066")]
	public void set_Value(string value) { }

}

