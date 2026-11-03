namespace UnityEngine.Rendering;

[NativeHeader("Modules/Terrain/Public/SpeedTreeWind.h")]
[Token(Token = "0x2000012")]
[UsedByNativeCode]
internal struct SpeedTreeWindParamsBufferIterator
{
	[CompilerGenerated]
	[Token(Token = "0x2000013")]
	[UnsafeValueType]
	internal struct <uintParamOffsets>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000033")]
		public int FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002E")]
	public IntPtr bufferPtr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[FixedBuffer(typeof(int), 16)]
	[Token(Token = "0x400002F")]
	public <uintParamOffsets>e__FixedBuffer uintParamOffsets; //Field offset: 0x8
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000030")]
	public int uintStride; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000031")]
	public int elementOffset; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000032")]
	public int elementsCount; //Field offset: 0x50

}

