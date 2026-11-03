namespace UnityEngine.Rendering.Universal.UTess;

[Token(Token = "0x20000AC")]
internal struct IntersectionCompare : IComparer<int2>
{
	[CompilerGenerated]
	[Token(Token = "0x20000AD")]
	[UnsafeValueType]
	internal struct <xvasort>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000302")]
		public double FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20000AE")]
	[UnsafeValueType]
	internal struct <xvbsort>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000303")]
		public double FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002FE")]
	public NativeArray<double2> points; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002FF")]
	public NativeArray<int2> edges; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[FixedBuffer(typeof(double), 4)]
	[Token(Token = "0x4000300")]
	public <xvasort>e__FixedBuffer xvasort; //Field offset: 0x20
	[FieldOffset(Offset = "0x40")]
	[FixedBuffer(typeof(double), 4)]
	[Token(Token = "0x4000301")]
	public <xvbsort>e__FixedBuffer xvbsort; //Field offset: 0x40

	[Address(RVA = "0x2D4A710", Offset = "0x2D49B10", Length = "0x1CB")]
	[Token(Token = "0x60003B6")]
	public override int Compare(int2 a, int2 b) { }

}

