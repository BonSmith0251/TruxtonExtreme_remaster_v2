namespace UnityEngine.Rendering;

[Token(Token = "0x20000A2")]
internal struct InstanceNumInfo
{
	[CompilerGenerated]
	[Token(Token = "0x20000A3")]
	[UnsafeValueType]
	internal struct <InstanceNums>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000310")]
		public int FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(int), 2)]
	[Token(Token = "0x400030F")]
	public <InstanceNums>e__FixedBuffer InstanceNums; //Field offset: 0x0

	[Address(RVA = "0x2CF5F80", Offset = "0x2CF5380", Length = "0xF")]
	[Token(Token = "0x60002F4")]
	public InstanceNumInfo(InstanceType type, int instanceNum) { }

	[Address(RVA = "0x2CF5F90", Offset = "0x2CF5390", Length = "0x9")]
	[Token(Token = "0x60002F5")]
	public InstanceNumInfo(int meshRendererNum = 0, int speedTreeNum = 0) { }

	[Address(RVA = "0x9E0B20", Offset = "0x9DFF20", Length = "0x7")]
	[Token(Token = "0x60002F6")]
	public int GetInstanceNum(InstanceType type) { }

	[Address(RVA = "0x2CF5DB0", Offset = "0x2CF51B0", Length = "0x1B2")]
	[Token(Token = "0x60002F7")]
	public int GetInstanceNumIncludingChildren(InstanceType type) { }

	[Address(RVA = "0x2CF5F70", Offset = "0x2CF5370", Length = "0x8")]
	[Token(Token = "0x60002F8")]
	public int GetTotalInstanceNum() { }

	[Address(RVA = "0x604930", Offset = "0x603D30", Length = "0x8")]
	[Token(Token = "0x60002F3")]
	public void InitDefault() { }

}

