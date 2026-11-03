namespace UnityEngine.Rendering;

[Token(Token = "0x200008A")]
public class DebugFrameTiming
{
	[Token(Token = "0x40001BC")]
	private const string k_FpsFormatString = "{0:F1}"; //Field offset: 0x0
	[Token(Token = "0x40001BD")]
	private const string k_MsFormatString = "{0:F2}ms"; //Field offset: 0x0
	[Token(Token = "0x40001BE")]
	private const float k_RefreshRate = 0.2; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001BF")]
	internal FrameTimeSampleHistory m_FrameHistory; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001C0")]
	internal BottleneckHistory m_BottleneckHistory; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001C1")]
	private int <bottleneckHistorySize>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40001C2")]
	private int <sampleHistorySize>k__BackingField; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001C3")]
	private FrameTiming[] m_Timing; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001C4")]
	private FrameTimeSample m_Sample; //Field offset: 0x30

	[Token(Token = "0x1700005D")]
	public int bottleneckHistorySize
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600060E")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600060F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700005E")]
	public int sampleHistorySize
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000610")]
		 get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000611")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2BDA400", Offset = "0x2BD9800", Length = "0x1EB")]
	[Token(Token = "0x6000612")]
	public DebugFrameTiming() { }

	[Address(RVA = "0x2BD9850", Offset = "0x2BD8C50", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x6000616")]
	private object <RegisterDebugUI>b__17_0() { }

	[Address(RVA = "0x2BD9B10", Offset = "0x2BD8F10", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x6000617")]
	private object <RegisterDebugUI>b__17_1() { }

	[Address(RVA = "0x2BD9890", Offset = "0x2BD8C90", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x6000620")]
	private object <RegisterDebugUI>b__17_10() { }

	[Address(RVA = "0x2BD98D0", Offset = "0x2BD8CD0", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x6000621")]
	private object <RegisterDebugUI>b__17_11() { }

	[Address(RVA = "0x2BD9910", Offset = "0x2BD8D10", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x6000622")]
	private object <RegisterDebugUI>b__17_12() { }

	[Address(RVA = "0x2BD9950", Offset = "0x2BD8D50", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x6000623")]
	private object <RegisterDebugUI>b__17_13() { }

	[Address(RVA = "0x2BD9990", Offset = "0x2BD8D90", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x6000624")]
	private object <RegisterDebugUI>b__17_14() { }

	[Address(RVA = "0x2BD99D0", Offset = "0x2BD8DD0", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x6000625")]
	private object <RegisterDebugUI>b__17_15() { }

	[Address(RVA = "0x2BD9A10", Offset = "0x2BD8E10", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x6000626")]
	private object <RegisterDebugUI>b__17_16() { }

	[Address(RVA = "0x2BD9A50", Offset = "0x2BD8E50", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x6000627")]
	private object <RegisterDebugUI>b__17_17() { }

	[Address(RVA = "0x2BD9A90", Offset = "0x2BD8E90", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x6000628")]
	private object <RegisterDebugUI>b__17_18() { }

	[Address(RVA = "0x2BD9AD0", Offset = "0x2BD8ED0", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x6000629")]
	private object <RegisterDebugUI>b__17_19() { }

	[Address(RVA = "0x2BD9BD0", Offset = "0x2BD8FD0", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x6000618")]
	private object <RegisterDebugUI>b__17_2() { }

	[Address(RVA = "0x2BD9B50", Offset = "0x2BD8F50", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x600062A")]
	private object <RegisterDebugUI>b__17_20() { }

	[Address(RVA = "0x2BD9B90", Offset = "0x2BD8F90", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x600062B")]
	private object <RegisterDebugUI>b__17_21() { }

	[Address(RVA = "0x2BD9C10", Offset = "0x2BD9010", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x6000619")]
	private object <RegisterDebugUI>b__17_3() { }

	[Address(RVA = "0x2BD9C50", Offset = "0x2BD9050", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x600061A")]
	private object <RegisterDebugUI>b__17_4() { }

	[Address(RVA = "0x2BD9C90", Offset = "0x2BD9090", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x600061B")]
	private object <RegisterDebugUI>b__17_5() { }

	[Address(RVA = "0x2BD9CD0", Offset = "0x2BD90D0", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x600061C")]
	private object <RegisterDebugUI>b__17_6() { }

	[Address(RVA = "0x2BD9D10", Offset = "0x2BD9110", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x600061D")]
	private object <RegisterDebugUI>b__17_7() { }

	[Address(RVA = "0x2BD9D50", Offset = "0x2BD9150", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x600061E")]
	private object <RegisterDebugUI>b__17_8() { }

	[Address(RVA = "0x2BD9D90", Offset = "0x2BD9190", Length = "0x33")]
	[CompilerGenerated]
	[Token(Token = "0x600061F")]
	private object <RegisterDebugUI>b__17_9() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600060E")]
	public int get_bottleneckHistorySize() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000610")]
	public int get_sampleHistorySize() { }

	[Address(RVA = "0x2BD7CD0", Offset = "0x2BD70D0", Length = "0x1AD9")]
	[Token(Token = "0x6000614")]
	public void RegisterDebugUI(List<Widget> list) { }

	[Address(RVA = "0x2BD97B0", Offset = "0x2BD8BB0", Length = "0x94")]
	[Token(Token = "0x6000615")]
	internal void Reset() { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600060F")]
	public void set_bottleneckHistorySize(int value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000611")]
	public void set_sampleHistorySize(int value) { }

	[Address(RVA = "0x2BD9DD0", Offset = "0x2BD91D0", Length = "0x62C")]
	[Token(Token = "0x6000613")]
	public void UpdateFrameTiming() { }

}

