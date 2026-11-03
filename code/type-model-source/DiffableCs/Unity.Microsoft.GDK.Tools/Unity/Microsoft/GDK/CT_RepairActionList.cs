namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000012")]
public class CT_RepairActionList : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000058")]
	private CT_CustomInstallAction[] repairActionField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000059")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x18

	[Token(Token = "0x1400000E")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B68870", Offset = "0x2B67C70", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000B3")]
		 add { } //Length: 158
		[Address(RVA = "0x2B68910", Offset = "0x2B67D10", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000B4")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1700003E")]
	[XmlElement("RepairAction")]
	public CT_CustomInstallAction[] RepairAction
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60000B1")]
		 get { } //Length: 5
		[Address(RVA = "0x2B689B0", Offset = "0x2B67DB0", Length = "0xB9")]
		[Token(Token = "0x60000B2")]
		 set { } //Length: 185
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000B6")]
	public CT_RepairActionList() { }

	[Address(RVA = "0x2B68870", Offset = "0x2B67C70", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000B3")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60000B1")]
	public CT_CustomInstallAction[] get_RepairAction() { }

	[Address(RVA = "0x2B687E0", Offset = "0x2B67BE0", Length = "0x86")]
	[Token(Token = "0x60000B5")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B68910", Offset = "0x2B67D10", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000B4")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B689B0", Offset = "0x2B67DB0", Length = "0xB9")]
	[Token(Token = "0x60000B2")]
	public void set_RepairAction(CT_CustomInstallAction[] value) { }

}

