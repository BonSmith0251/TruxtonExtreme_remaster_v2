namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000027")]
public class CT_ExecutableList : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000AD")]
	private CT_ExecutableListExecutable[] executableField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000AE")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x18

	[Token(Token = "0x1400001F")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B66240", Offset = "0x2B65640", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000163")]
		 add { } //Length: 158
		[Address(RVA = "0x2B662E0", Offset = "0x2B656E0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000164")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000074")]
	[XmlElement("Executable")]
	public CT_ExecutableListExecutable[] Executable
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000161")]
		 get { } //Length: 5
		[Address(RVA = "0x2B66380", Offset = "0x2B65780", Length = "0xB9")]
		[Token(Token = "0x6000162")]
		 set { } //Length: 185
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000166")]
	public CT_ExecutableList() { }

	[Address(RVA = "0x2B66240", Offset = "0x2B65640", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000163")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000161")]
	public CT_ExecutableListExecutable[] get_Executable() { }

	[Address(RVA = "0x2B661B0", Offset = "0x2B655B0", Length = "0x86")]
	[Token(Token = "0x6000165")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B662E0", Offset = "0x2B656E0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000164")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B66380", Offset = "0x2B65780", Length = "0xB9")]
	[Token(Token = "0x6000162")]
	public void set_Executable(CT_ExecutableListExecutable[] value) { }

}

