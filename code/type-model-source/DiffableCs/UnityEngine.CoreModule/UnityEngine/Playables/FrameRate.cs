namespace UnityEngine.Playables;

[NativeHeader("Runtime/Director/Core/FrameRate.h")]
[Token(Token = "0x2000315")]
[UsedByNativeCode("FrameRate")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.DirectorModule"})]
internal struct FrameRate : IEquatable<FrameRate>
{
	[Ignore]
	[Token(Token = "0x4000821")]
	public static readonly FrameRate k_24Fps; //Field offset: 0x0
	[Ignore]
	[Token(Token = "0x4000822")]
	public static readonly FrameRate k_23_976Fps; //Field offset: 0x4
	[Ignore]
	[Token(Token = "0x4000823")]
	public static readonly FrameRate k_25Fps; //Field offset: 0x8
	[Ignore]
	[Token(Token = "0x4000824")]
	public static readonly FrameRate k_30Fps; //Field offset: 0xC
	[Ignore]
	[Token(Token = "0x4000825")]
	public static readonly FrameRate k_29_97Fps; //Field offset: 0x10
	[Ignore]
	[Token(Token = "0x4000826")]
	public static readonly FrameRate k_50Fps; //Field offset: 0x14
	[Ignore]
	[Token(Token = "0x4000827")]
	public static readonly FrameRate k_60Fps; //Field offset: 0x18
	[Ignore]
	[Token(Token = "0x4000828")]
	public static readonly FrameRate k_59_94Fps; //Field offset: 0x1C
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000829")]
	private int m_Rate; //Field offset: 0x0

	[Token(Token = "0x170003A9")]
	public bool dropFrame
	{
		[Address(RVA = "0x209A540", Offset = "0x2099940", Length = "0x6")]
		[Token(Token = "0x60018E7")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170003AA")]
	public double rate
	{
		[Address(RVA = "0x3078F70", Offset = "0x3078370", Length = "0x66")]
		[Token(Token = "0x60018E8")]
		 get { } //Length: 102
	}

	[Address(RVA = "0x3078E80", Offset = "0x3078280", Length = "0xCC")]
	[Token(Token = "0x60018F2")]
	private static FrameRate() { }

	[Address(RVA = "0x3078F50", Offset = "0x3078350", Length = "0x16")]
	[Token(Token = "0x60018E9")]
	public FrameRate(uint frameRate = 0, bool drop = false) { }

	[Address(RVA = "0x3078AA0", Offset = "0x3077EA0", Length = "0x14B")]
	[Token(Token = "0x60018F1")]
	internal static FrameRate DoubleToFrameRate(double framerate) { }

	[Address(RVA = "0x2FD0220", Offset = "0x2FCF620", Length = "0x8")]
	[Token(Token = "0x60018EB")]
	public override bool Equals(FrameRate other) { }

	[Address(RVA = "0x3078BF0", Offset = "0x3077FF0", Length = "0x98")]
	[Token(Token = "0x60018EC")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x209A540", Offset = "0x2099940", Length = "0x6")]
	[Token(Token = "0x60018E7")]
	public bool get_dropFrame() { }

	[Address(RVA = "0x3078F70", Offset = "0x3078370", Length = "0x66")]
	[Token(Token = "0x60018E8")]
	public double get_rate() { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x60018EE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3078C90", Offset = "0x3078090", Length = "0x9")]
	[Token(Token = "0x60018EA")]
	public bool IsValid() { }

	[Address(RVA = "0x3078FE0", Offset = "0x30783E0", Length = "0x4F")]
	[Token(Token = "0x60018ED")]
	public static bool op_Equality(FrameRate a, FrameRate b) { }

	[Address(RVA = "0x3078E30", Offset = "0x3078230", Length = "0x4F")]
	[Token(Token = "0x60018EF")]
	public virtual string ToString() { }

	[Address(RVA = "0x3078CA0", Offset = "0x30780A0", Length = "0x18D")]
	[Token(Token = "0x60018F0")]
	public string ToString(string format, IFormatProvider formatProvider) { }

}

