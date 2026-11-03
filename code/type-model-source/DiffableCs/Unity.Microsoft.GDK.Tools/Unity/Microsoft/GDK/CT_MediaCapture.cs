namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000026")]
public class CT_MediaCapture : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000A6")]
	private bool gameDVRSystemComponentField; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40000A7")]
	private bool gameDVRSystemComponentFieldSpecified; //Field offset: 0x11
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x40000A8")]
	private bool blockBroadcastField; //Field offset: 0x12
	[FieldOffset(Offset = "0x13")]
	[Token(Token = "0x40000A9")]
	private bool blockBroadcastFieldSpecified; //Field offset: 0x13
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000AA")]
	private bool blockGameDVRField; //Field offset: 0x14
	[FieldOffset(Offset = "0x15")]
	[Token(Token = "0x40000AB")]
	private bool blockGameDVRFieldSpecified; //Field offset: 0x15
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000AC")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x18

	[Token(Token = "0x1400001E")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B679E0", Offset = "0x2B66DE0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600015D")]
		 add { } //Length: 158
		[Address(RVA = "0x2B67A80", Offset = "0x2B66E80", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600015E")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000070")]
	public bool BlockBroadcast
	{
		[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
		[Token(Token = "0x6000155")]
		 get { } //Length: 5
		[Address(RVA = "0x2B67B70", Offset = "0x2B66F70", Length = "0x4C")]
		[Token(Token = "0x6000156")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000071")]
	[XmlIgnore]
	public bool BlockBroadcastSpecified
	{
		[Address(RVA = "0x10AAD90", Offset = "0x10AA190", Length = "0x5")]
		[Token(Token = "0x6000157")]
		 get { } //Length: 5
		[Address(RVA = "0x2B67B20", Offset = "0x2B66F20", Length = "0x4C")]
		[Token(Token = "0x6000158")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000072")]
	public bool BlockGameDVR
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[Token(Token = "0x6000159")]
		 get { } //Length: 5
		[Address(RVA = "0x2B67C10", Offset = "0x2B67010", Length = "0x4C")]
		[Token(Token = "0x600015A")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000073")]
	[XmlIgnore]
	public bool BlockGameDVRSpecified
	{
		[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
		[Token(Token = "0x600015B")]
		 get { } //Length: 5
		[Address(RVA = "0x2B67BC0", Offset = "0x2B66FC0", Length = "0x4C")]
		[Token(Token = "0x600015C")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700006E")]
	public bool GameDVRSystemComponent
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x6000151")]
		 get { } //Length: 5
		[Address(RVA = "0x2B67CB0", Offset = "0x2B670B0", Length = "0x4C")]
		[Token(Token = "0x6000152")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700006F")]
	[XmlIgnore]
	public bool GameDVRSystemComponentSpecified
	{
		[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
		[Token(Token = "0x6000153")]
		 get { } //Length: 5
		[Address(RVA = "0x2B67C60", Offset = "0x2B67060", Length = "0x4C")]
		[Token(Token = "0x6000154")]
		 set { } //Length: 76
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000160")]
	public CT_MediaCapture() { }

	[Address(RVA = "0x2B679E0", Offset = "0x2B66DE0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600015D")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
	[Token(Token = "0x6000155")]
	public bool get_BlockBroadcast() { }

	[Address(RVA = "0x10AAD90", Offset = "0x10AA190", Length = "0x5")]
	[Token(Token = "0x6000157")]
	public bool get_BlockBroadcastSpecified() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[Token(Token = "0x6000159")]
	public bool get_BlockGameDVR() { }

	[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
	[Token(Token = "0x600015B")]
	public bool get_BlockGameDVRSpecified() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x6000151")]
	public bool get_GameDVRSystemComponent() { }

	[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
	[Token(Token = "0x6000153")]
	public bool get_GameDVRSystemComponentSpecified() { }

	[Address(RVA = "0x2B67950", Offset = "0x2B66D50", Length = "0x86")]
	[Token(Token = "0x600015F")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B67A80", Offset = "0x2B66E80", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600015E")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B67B70", Offset = "0x2B66F70", Length = "0x4C")]
	[Token(Token = "0x6000156")]
	public void set_BlockBroadcast(bool value) { }

	[Address(RVA = "0x2B67B20", Offset = "0x2B66F20", Length = "0x4C")]
	[Token(Token = "0x6000158")]
	public void set_BlockBroadcastSpecified(bool value) { }

	[Address(RVA = "0x2B67C10", Offset = "0x2B67010", Length = "0x4C")]
	[Token(Token = "0x600015A")]
	public void set_BlockGameDVR(bool value) { }

	[Address(RVA = "0x2B67BC0", Offset = "0x2B66FC0", Length = "0x4C")]
	[Token(Token = "0x600015C")]
	public void set_BlockGameDVRSpecified(bool value) { }

	[Address(RVA = "0x2B67CB0", Offset = "0x2B670B0", Length = "0x4C")]
	[Token(Token = "0x6000152")]
	public void set_GameDVRSystemComponent(bool value) { }

	[Address(RVA = "0x2B67C60", Offset = "0x2B67060", Length = "0x4C")]
	[Token(Token = "0x6000154")]
	public void set_GameDVRSystemComponentSpecified(bool value) { }

}

