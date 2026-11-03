namespace Unity.Cinemachine;

[Token(Token = "0x20000B8")]
internal abstract class GaussianWindow1d
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002DD")]
	protected T[] m_Data; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002DE")]
	protected Single[] m_Kernel; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002DF")]
	protected int m_CurrentPos; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002E0")]
	private float <Sigma>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x170000CB")]
	public int BufferLength
	{
		[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
		[Token(Token = "0x60003A3")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170000CA")]
	public int KernelSize
	{
		[Address(RVA = "0xFBEA80", Offset = "0xFBDE80", Length = "0x1A")]
		[Token(Token = "0x600039A")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170000C9")]
	public private float Sigma
	{
		[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000398")]
		 get { } //Length: 6
		[Address(RVA = "0x1C1AA50", Offset = "0x1C19E50", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000399")]
		private set { } //Length: 6
	}

	[Address(RVA = "0x1C1A8C0", Offset = "0x1C19CC0", Length = "0xB2")]
	[Token(Token = "0x600039D")]
	public GaussianWindow1d`1(float sigma, int maxKernelRadius = 10) { }

	[Address(RVA = "0x1C19070", Offset = "0x1C18470", Length = "0xC9")]
	[Token(Token = "0x60003A0")]
	public void AddValue(T v) { }

	[Token(Token = "0x600039C")]
	protected abstract T Compute(int windowPos) { }

	[Address(RVA = "0x1C196D0", Offset = "0x1C18AD0", Length = "0x114")]
	[Token(Token = "0x60003A1")]
	public T Filter(T v) { }

	[Address(RVA = "0x1C19D40", Offset = "0x1C19140", Length = "0x289")]
	[Token(Token = "0x600039B")]
	private void GenerateKernel(float sigma, int maxKernelRadius) { }

	[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
	[Token(Token = "0x60003A3")]
	public int get_BufferLength() { }

	[Address(RVA = "0xFBEA80", Offset = "0xFBDE80", Length = "0x1A")]
	[Token(Token = "0x600039A")]
	public int get_KernelSize() { }

	[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000398")]
	public float get_Sigma() { }

	[Address(RVA = "0x1C1A320", Offset = "0x1C19720", Length = "0x38")]
	[Token(Token = "0x60003A5")]
	public T GetBufferValue(int index) { }

	[Address(RVA = "0x1C1A3F0", Offset = "0x1C197F0", Length = "0x7")]
	[Token(Token = "0x600039F")]
	public bool IsEmpty() { }

	[Address(RVA = "0x1960180", Offset = "0x195F580", Length = "0x8")]
	[Token(Token = "0x600039E")]
	public void Reset() { }

	[Address(RVA = "0x1C1AA50", Offset = "0x1C19E50", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000399")]
	private void set_Sigma(float value) { }

	[Address(RVA = "0x1C1A400", Offset = "0x1C19800", Length = "0x36")]
	[Token(Token = "0x60003A4")]
	public void SetBufferValue(int index, T value) { }

	[Address(RVA = "0x1C1A700", Offset = "0x1C19B00", Length = "0x34")]
	[Token(Token = "0x60003A2")]
	public T Value() { }

}

