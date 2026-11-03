namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200000E")]
internal class RunningAverage
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000048")]
	private Single[] m_Values; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000049")]
	private int m_NumValues; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400004A")]
	private int m_LastIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400004B")]
	private float m_AverageValue; //Field offset: 0x20

	[Address(RVA = "0x2F99190", Offset = "0x2F98590", Length = "0x85")]
	[Token(Token = "0x600008F")]
	public RunningAverage(int sampleWindowSize = 100) { }

	[Address(RVA = "0x2F99060", Offset = "0x2F98460", Length = "0x94")]
	[Token(Token = "0x6000094")]
	public void AddValue(float NewValue) { }

	[Address(RVA = "0x2F99100", Offset = "0x2F98500", Length = "0x10")]
	[Token(Token = "0x6000092")]
	public float GetAverageOr(float defaultValue) { }

	[Address(RVA = "0x2F99110", Offset = "0x2F98510", Length = "0x35")]
	[Token(Token = "0x6000093")]
	public float GetMostRecentValueOr(float defaultValue) { }

	[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
	[Token(Token = "0x6000090")]
	public int GetNumValues() { }

	[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
	[Token(Token = "0x6000091")]
	public int GetSampleWindowSize() { }

	[Address(RVA = "0x2F99150", Offset = "0x2F98550", Length = "0x37")]
	[Token(Token = "0x6000095")]
	public void Reset() { }

}

