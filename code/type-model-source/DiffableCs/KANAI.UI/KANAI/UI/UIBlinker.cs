namespace KANAI.UI;

[Token(Token = "0x200000F")]
public class UIBlinker
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002E")]
	protected bool _countMode1; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x400002F")]
	protected bool _blinkMode1; //Field offset: 0x11
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000030")]
	protected float _blinkTime; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000031")]
	private bool _enableFlag; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4000032")]
	private bool _blinkFlag; //Field offset: 0x19
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000033")]
	private float _blinkRate; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000034")]
	private float _blinkMax; //Field offset: 0x20

	[Token(Token = "0x17000011")]
	public bool BlinkFlag
	{
		[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
		[Token(Token = "0x600005B")]
		 get { } //Length: 5
		[Address(RVA = "0x1E18710", Offset = "0x1E17B10", Length = "0x7")]
		[Token(Token = "0x600005C")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000013")]
	public float BlinkMax
	{
		[Address(RVA = "0x1D40680", Offset = "0x1D3FA80", Length = "0x6")]
		[Token(Token = "0x600005F")]
		 get { } //Length: 6
		[Address(RVA = "0x1D719C0", Offset = "0x1D70DC0", Length = "0x6")]
		[Token(Token = "0x6000060")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000012")]
	public float BlinkRate
	{
		[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
		[Token(Token = "0x600005D")]
		 get { } //Length: 6
		[Address(RVA = "0x1E18720", Offset = "0x1E17B20", Length = "0x6")]
		[Token(Token = "0x600005E")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000010")]
	public bool EnableFlag
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x6000059")]
		 get { } //Length: 5
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[Token(Token = "0x600005A")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1E18570", Offset = "0x1E17970", Length = "0x76")]
	[Token(Token = "0x6000054")]
	public UIBlinker(bool enableFlag = true, bool blinkFlag = false, float blinkRate = 1, float blinkMax = 1, bool countMode1 = false, bool blinkMode1 = true) { }

	[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
	[Token(Token = "0x600005B")]
	public bool get_BlinkFlag() { }

	[Address(RVA = "0x1D40680", Offset = "0x1D3FA80", Length = "0x6")]
	[Token(Token = "0x600005F")]
	public float get_BlinkMax() { }

	[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
	[Token(Token = "0x600005D")]
	public float get_BlinkRate() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x6000059")]
	public bool get_EnableFlag() { }

	[Address(RVA = "0x1E185F0", Offset = "0x1E179F0", Length = "0x10F")]
	[Token(Token = "0x6000055")]
	private float getNow() { }

	[Address(RVA = "0x1E18560", Offset = "0x1E17960", Length = "0x7")]
	[Token(Token = "0x6000057")]
	public float Lerp() { }

	[Address(RVA = "0x1E18480", Offset = "0x1E17880", Length = "0xD1")]
	[Token(Token = "0x6000058")]
	public Color Lerp(Color a, Color b) { }

	[Address(RVA = "0x1E18700", Offset = "0x1E17B00", Length = "0x8")]
	[Token(Token = "0x6000056")]
	public void reset() { }

	[Address(RVA = "0x1E18710", Offset = "0x1E17B10", Length = "0x7")]
	[Token(Token = "0x600005C")]
	public void set_BlinkFlag(bool value) { }

	[Address(RVA = "0x1D719C0", Offset = "0x1D70DC0", Length = "0x6")]
	[Token(Token = "0x6000060")]
	public void set_BlinkMax(float value) { }

	[Address(RVA = "0x1E18720", Offset = "0x1E17B20", Length = "0x6")]
	[Token(Token = "0x600005E")]
	public void set_BlinkRate(float value) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[Token(Token = "0x600005A")]
	public void set_EnableFlag(bool value) { }

}

