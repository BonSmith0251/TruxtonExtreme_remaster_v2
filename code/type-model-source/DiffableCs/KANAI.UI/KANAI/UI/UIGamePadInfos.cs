namespace KANAI.UI;

[Token(Token = "0x2000023")]
public struct UIGamePadInfos
{
	[Token(Token = "0x40000D6")]
	public const float RapidDistance = 0.0625; //Field offset: 0x0
	[Token(Token = "0x40000D7")]
	private const float RepeatFirst = 0.5; //Field offset: 0x0
	[Token(Token = "0x40000D8")]
	private const float RepeatDistance = 0.1; //Field offset: 0x0
	[Token(Token = "0x40000D9")]
	private const float RepeatDistanceFast = 0.04; //Field offset: 0x0
	[Token(Token = "0x40000DA")]
	private const float RepeatChangeSeconds = 2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000DB")]
	public bool _isOn; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x40000DC")]
	private bool _isPreOn; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x40000DD")]
	private bool _isRapid; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x40000DE")]
	private bool _isRepeat; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000DF")]
	private float _rapidCounter; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000E0")]
	private float _repeatCounter; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000E1")]
	private float _repeatTime; //Field offset: 0xC

	[Token(Token = "0x17000020")]
	public bool IsOff
	{
		[Address(RVA = "0x1E1AD30", Offset = "0x1E1A130", Length = "0xD")]
		[Token(Token = "0x60000F4")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000021")]
	public bool IsOn
	{
		[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
		[Token(Token = "0x60000F5")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700001F")]
	public bool IsPresent
	{
		[Address(RVA = "0x1E1AD40", Offset = "0x1E1A140", Length = "0x10")]
		[Token(Token = "0x60000F3")]
		 get { } //Length: 16
	}

	[Token(Token = "0x17000022")]
	public bool IsRapid
	{
		[Address(RVA = "0x1E1AD50", Offset = "0x1E1A150", Length = "0x5")]
		[Token(Token = "0x60000F6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000023")]
	public bool IsRepeat
	{
		[Address(RVA = "0x604A20", Offset = "0x603E20", Length = "0x5")]
		[Token(Token = "0x60000F7")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1E1AC00", Offset = "0x1E1A000", Length = "0x10")]
	[Token(Token = "0x60000EF")]
	public void Clear() { }

	[Address(RVA = "0x1E1ABF0", Offset = "0x1E19FF0", Length = "0xE")]
	[Token(Token = "0x60000F0")]
	public void ClearRapid() { }

	[Address(RVA = "0x1E1AC10", Offset = "0x1E1A010", Length = "0x1C")]
	[Token(Token = "0x60000F2")]
	public void DownRepeat() { }

	[Address(RVA = "0x1E1AD30", Offset = "0x1E1A130", Length = "0xD")]
	[Token(Token = "0x60000F4")]
	public bool get_IsOff() { }

	[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
	[Token(Token = "0x60000F5")]
	public bool get_IsOn() { }

	[Address(RVA = "0x1E1AD40", Offset = "0x1E1A140", Length = "0x10")]
	[Token(Token = "0x60000F3")]
	public bool get_IsPresent() { }

	[Address(RVA = "0x1E1AD50", Offset = "0x1E1A150", Length = "0x5")]
	[Token(Token = "0x60000F6")]
	public bool get_IsRapid() { }

	[Address(RVA = "0x604A20", Offset = "0x603E20", Length = "0x5")]
	[Token(Token = "0x60000F7")]
	public bool get_IsRepeat() { }

	[Address(RVA = "0x1E1AC30", Offset = "0x1E1A030", Length = "0x1C")]
	[Token(Token = "0x60000F1")]
	public void ResetRepeat() { }

	[Address(RVA = "0x1E1AC50", Offset = "0x1E1A050", Length = "0xD5")]
	[Token(Token = "0x60000F8")]
	public void UpdateCounter(float dt, bool isPadOn) { }

}

