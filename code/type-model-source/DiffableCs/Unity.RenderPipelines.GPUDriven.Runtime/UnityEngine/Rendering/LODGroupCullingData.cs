namespace UnityEngine.Rendering;

[Token(Token = "0x20000B9")]
internal struct LODGroupCullingData
{
	[CompilerGenerated]
	[Token(Token = "0x20000BA")]
	[UnsafeValueType]
	internal struct <percentageFlags>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400037F")]
		public bool FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20000BB")]
	[UnsafeValueType]
	internal struct <sqrDistances>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000380")]
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20000BC")]
	[UnsafeValueType]
	internal struct <transitionDistances>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000381")]
		public float FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000378")]
	public float3 worldSpaceReferencePoint; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000379")]
	public int lodCount; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[FixedBuffer(typeof(float), 8)]
	[Token(Token = "0x400037A")]
	public <sqrDistances>e__FixedBuffer sqrDistances; //Field offset: 0x10
	[FieldOffset(Offset = "0x30")]
	[FixedBuffer(typeof(float), 8)]
	[Token(Token = "0x400037B")]
	public <transitionDistances>e__FixedBuffer transitionDistances; //Field offset: 0x30
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400037C")]
	public float worldSpaceSize; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[FixedBuffer(typeof(bool), 8)]
	[Token(Token = "0x400037D")]
	public <percentageFlags>e__FixedBuffer percentageFlags; //Field offset: 0x54
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400037E")]
	public byte forceLODMask; //Field offset: 0x5C

}

