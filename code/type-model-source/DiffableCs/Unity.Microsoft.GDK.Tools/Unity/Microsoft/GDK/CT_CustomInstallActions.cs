namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000014")]
public class CT_CustomInstallActions : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400005C")]
	private string folderField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400005D")]
	private CT_InstallActionList installActionListField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400005E")]
	private CT_RepairActionList repairActionListField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400005F")]
	private CT_UninstallActionList uninstallActionListField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000060")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x30

	[Token(Token = "0x14000010")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B63E90", Offset = "0x2B63290", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000C5")]
		 add { } //Length: 158
		[Address(RVA = "0x2B63F30", Offset = "0x2B63330", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000C6")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000040")]
	public string Folder
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60000BD")]
		 get { } //Length: 5
		[Address(RVA = "0x2B63FD0", Offset = "0x2B633D0", Length = "0x58")]
		[Token(Token = "0x60000BE")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000041")]
	public CT_InstallActionList InstallActionList
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60000BF")]
		 get { } //Length: 5
		[Address(RVA = "0x2B64030", Offset = "0x2B63430", Length = "0x58")]
		[Token(Token = "0x60000C0")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000042")]
	public CT_RepairActionList RepairActionList
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60000C1")]
		 get { } //Length: 5
		[Address(RVA = "0x2B64090", Offset = "0x2B63490", Length = "0x58")]
		[Token(Token = "0x60000C2")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000043")]
	public CT_UninstallActionList UninstallActionList
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60000C3")]
		 get { } //Length: 5
		[Address(RVA = "0x2B640F0", Offset = "0x2B634F0", Length = "0x58")]
		[Token(Token = "0x60000C4")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000C8")]
	public CT_CustomInstallActions() { }

	[Address(RVA = "0x2B63E90", Offset = "0x2B63290", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000C5")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60000BD")]
	public string get_Folder() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60000BF")]
	public CT_InstallActionList get_InstallActionList() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60000C1")]
	public CT_RepairActionList get_RepairActionList() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60000C3")]
	public CT_UninstallActionList get_UninstallActionList() { }

	[Address(RVA = "0x2B63E00", Offset = "0x2B63200", Length = "0x86")]
	[Token(Token = "0x60000C7")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B63F30", Offset = "0x2B63330", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000C6")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B63FD0", Offset = "0x2B633D0", Length = "0x58")]
	[Token(Token = "0x60000BE")]
	public void set_Folder(string value) { }

	[Address(RVA = "0x2B64030", Offset = "0x2B63430", Length = "0x58")]
	[Token(Token = "0x60000C0")]
	public void set_InstallActionList(CT_InstallActionList value) { }

	[Address(RVA = "0x2B64090", Offset = "0x2B63490", Length = "0x58")]
	[Token(Token = "0x60000C2")]
	public void set_RepairActionList(CT_RepairActionList value) { }

	[Address(RVA = "0x2B640F0", Offset = "0x2B634F0", Length = "0x58")]
	[Token(Token = "0x60000C4")]
	public void set_UninstallActionList(CT_UninstallActionList value) { }

}

