namespace UnityEngine.Timeline;

[Token(Token = "0x2000040")]
internal abstract class RuntimeElement : IInterval
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000121")]
	private int <intervalBit>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170000B0")]
	public abstract bool enable
	{
		[Token(Token = "0x6000267")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170000AF")]
	public int intervalBit
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000265")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000266")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000AE")]
	public abstract long intervalEnd
	{
		[Token(Token = "0x6000264")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000AD")]
	public abstract long intervalStart
	{
		[Token(Token = "0x6000263")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600026A")]
	protected RuntimeElement() { }

	[Token(Token = "0x6000269")]
	public abstract void DisableAt(double localTime, double rootDuration, FrameData frameData) { }

	[Token(Token = "0x6000268")]
	public abstract void EvaluateAt(double localTime, FrameData frameData) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000265")]
	public int get_intervalBit() { }

	[Token(Token = "0x6000264")]
	public abstract long get_intervalEnd() { }

	[Token(Token = "0x6000263")]
	public abstract long get_intervalStart() { }

	[Token(Token = "0x6000267")]
	public abstract void set_enable(bool value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000266")]
	public void set_intervalBit(int value) { }

}

