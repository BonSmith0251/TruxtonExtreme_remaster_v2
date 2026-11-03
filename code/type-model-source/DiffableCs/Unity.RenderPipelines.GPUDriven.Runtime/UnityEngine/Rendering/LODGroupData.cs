namespace UnityEngine.Rendering;

[Token(Token = "0x20000B6")]
internal struct LODGroupData
{
	[CompilerGenerated]
	[Token(Token = "0x20000B7")]
	[UnsafeValueType]
	internal struct <fadeTransitionWidth>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000376")]
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20000B8")]
	[UnsafeValueType]
	internal struct <screenRelativeTransitionHeights>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000377")]
		public float FixedElementField; //Field offset: 0x0

	}

	[Token(Token = "0x4000370")]
	public const int k_MaxLODLevelsCount = 8; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000371")]
	public bool valid; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000372")]
	public int lodCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000373")]
	public int rendererCount; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[FixedBuffer(typeof(float), 8)]
	[Token(Token = "0x4000374")]
	public <screenRelativeTransitionHeights>e__FixedBuffer screenRelativeTransitionHeights; //Field offset: 0xC
	[FieldOffset(Offset = "0x2C")]
	[FixedBuffer(typeof(float), 8)]
	[Token(Token = "0x4000375")]
	public <fadeTransitionWidth>e__FixedBuffer fadeTransitionWidth; //Field offset: 0x2C

}

