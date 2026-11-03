namespace KANAI.Kernel;

[Token(Token = "0x2000037")]
public class TimeFactor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000DF")]
	private float _baseTimeFactor; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000E0")]
	private float _currentTimeFactor; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000E1")]
	private float _deltaTime; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000E2")]
	private float _deltaTimeScale; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000E3")]
	private bool _isPause; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000E4")]
	private List<TimeFactor> _children; //Field offset: 0x28

	[Token(Token = "0x1700002D")]
	public float DeltaTime
	{
		[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
		[Token(Token = "0x60001CA")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700002E")]
	public float DeltaTimeScale
	{
		[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
		[Token(Token = "0x60001CB")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1DF2910", Offset = "0x1DF1D10", Length = "0x7E")]
	[Token(Token = "0x60001C1")]
	private TimeFactor() { }

	[Address(RVA = "0x1DF23B0", Offset = "0x1DF17B0", Length = "0x64")]
	[Token(Token = "0x60001C2")]
	public static TimeFactor Create() { }

	[Address(RVA = "0x1DF22C0", Offset = "0x1DF16C0", Length = "0xEF")]
	[Token(Token = "0x60001C3")]
	public TimeFactor CreateChild() { }

	[Address(RVA = "0x1DF2420", Offset = "0x1DF1820", Length = "0x1A9")]
	[Token(Token = "0x60001C8")]
	public bool DeleteChild(TimeFactor tf) { }

	[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
	[Token(Token = "0x60001CA")]
	public float get_DeltaTime() { }

	[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
	[Token(Token = "0x60001CB")]
	public float get_DeltaTimeScale() { }

	[Address(RVA = "0xFBEB10", Offset = "0xFBDF10", Length = "0x6")]
	[Token(Token = "0x60001C7")]
	public float GetTimeFactor() { }

	[Address(RVA = "0x1DF25D0", Offset = "0x1DF19D0", Length = "0x199")]
	[Token(Token = "0x60001C9")]
	protected private void InternalUpadte(float t, float _dt) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[Token(Token = "0x60001C5")]
	public void Pause(bool v) { }

	[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
	[Token(Token = "0x60001C6")]
	public void SetTimeFactor(float r) { }

	[Address(RVA = "0x1DF2770", Offset = "0x1DF1B70", Length = "0x199")]
	[Token(Token = "0x60001C4")]
	public void Update(float _dt = 1) { }

}

