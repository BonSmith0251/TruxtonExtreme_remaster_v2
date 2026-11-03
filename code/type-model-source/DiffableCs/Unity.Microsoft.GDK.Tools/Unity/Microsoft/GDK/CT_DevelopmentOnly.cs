namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x200000C")]
public class CT_DevelopmentOnly : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400003E")]
	private string contentIdOverrideField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400003F")]
	private string eKBIDOverrideField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000040")]
	private CT_DebugNetworkPortList debugNetworkPortListField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000041")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x28

	[Token(Token = "0x14000008")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B65940", Offset = "0x2B64D40", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000077")]
		 add { } //Length: 158
		[Address(RVA = "0x2B659E0", Offset = "0x2B64DE0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000078")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1700002A")]
	public string ContentIdOverride
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000071")]
		 get { } //Length: 5
		[Address(RVA = "0x2B65A80", Offset = "0x2B64E80", Length = "0x58")]
		[Token(Token = "0x6000072")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700002C")]
	public CT_DebugNetworkPortList DebugNetworkPortList
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000075")]
		 get { } //Length: 5
		[Address(RVA = "0x2B65AE0", Offset = "0x2B64EE0", Length = "0x58")]
		[Token(Token = "0x6000076")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700002B")]
	public string EKBIDOverride
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000073")]
		 get { } //Length: 5
		[Address(RVA = "0x2B65B40", Offset = "0x2B64F40", Length = "0x58")]
		[Token(Token = "0x6000074")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600007A")]
	public CT_DevelopmentOnly() { }

	[Address(RVA = "0x2B65940", Offset = "0x2B64D40", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000077")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000071")]
	public string get_ContentIdOverride() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000075")]
	public CT_DebugNetworkPortList get_DebugNetworkPortList() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000073")]
	public string get_EKBIDOverride() { }

	[Address(RVA = "0x2B658B0", Offset = "0x2B64CB0", Length = "0x86")]
	[Token(Token = "0x6000079")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B659E0", Offset = "0x2B64DE0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000078")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B65A80", Offset = "0x2B64E80", Length = "0x58")]
	[Token(Token = "0x6000072")]
	public void set_ContentIdOverride(string value) { }

	[Address(RVA = "0x2B65AE0", Offset = "0x2B64EE0", Length = "0x58")]
	[Token(Token = "0x6000076")]
	public void set_DebugNetworkPortList(CT_DebugNetworkPortList value) { }

	[Address(RVA = "0x2B65B40", Offset = "0x2B64F40", Length = "0x58")]
	[Token(Token = "0x6000074")]
	public void set_EKBIDOverride(string value) { }

}

