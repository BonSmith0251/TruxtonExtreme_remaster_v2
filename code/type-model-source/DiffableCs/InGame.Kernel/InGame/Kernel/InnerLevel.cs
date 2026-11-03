namespace InGame.Kernel;

[Token(Token = "0x200009B")]
public class InnerLevel
{
	[Token(Token = "0x40004C4")]
	private const int MinLevel = 0; //Field offset: 0x0
	[Token(Token = "0x40004C5")]
	private const int MaxLevel = 30; //Field offset: 0x0
	[Token(Token = "0x40004C6")]
	private const int defaultLevel = 10; //Field offset: 0x0
	[Token(Token = "0x40004C7")]
	private const int difficultRange = 20; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004C8")]
	private int _currentLevel; //Field offset: 0x10

	[Token(Token = "0x17000119")]
	public int Current
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60005BE")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x1D398E0", Offset = "0x1D38CE0", Length = "0xE")]
	[Token(Token = "0x60005BF")]
	public InnerLevel() { }

	[Address(RVA = "0x1D39580", Offset = "0x1D38980", Length = "0x9D")]
	[Token(Token = "0x60005B7")]
	public bool ChangeLevel(int nstep) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60005BE")]
	public int get_Current() { }

	[Address(RVA = "0x1D39620", Offset = "0x1D38A20", Length = "0x98")]
	[Token(Token = "0x60005B9")]
	public float GetBulletSpeedRate() { }

	[Address(RVA = "0x1D396C0", Offset = "0x1D38AC0", Length = "0x5E")]
	[Token(Token = "0x60005BB")]
	public float GetDeadBulletDistance() { }

	[Address(RVA = "0x1D39720", Offset = "0x1D38B20", Length = "0x98")]
	[Token(Token = "0x60005BA")]
	public float GetEnemySpeedRate() { }

	[Address(RVA = "0x1D397C0", Offset = "0x1D38BC0", Length = "0x37")]
	[Token(Token = "0x60005BD")]
	private float HighRate() { }

	[Address(RVA = "0x1D39800", Offset = "0x1D38C00", Length = "0x8")]
	[Token(Token = "0x60005B6")]
	public void Initialize() { }

	[Address(RVA = "0x1D39810", Offset = "0x1D38C10", Length = "0x2D")]
	[Token(Token = "0x60005BC")]
	private float LowRate() { }

	[Address(RVA = "0x1D39840", Offset = "0x1D38C40", Length = "0x9A")]
	[Token(Token = "0x60005B8")]
	public bool SetLevel(int nlevel) { }

}

