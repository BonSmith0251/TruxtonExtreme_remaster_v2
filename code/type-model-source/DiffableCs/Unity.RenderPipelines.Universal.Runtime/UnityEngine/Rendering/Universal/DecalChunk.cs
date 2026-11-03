namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000083")]
internal abstract class DecalChunk : IDisposable
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400027D")]
	private int <count>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400027E")]
	private int <capacity>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400027F")]
	private JobHandle <currentJobHandle>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000D9")]
	public int capacity
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000312")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000313")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000D8")]
	public int count
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000310")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000311")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000DA")]
	public JobHandle currentJobHandle
	{
		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6000314")]
		 get { } //Length: 11
		[Address(RVA = "0x14125B0", Offset = "0x14119B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000315")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600031D")]
	protected DecalChunk() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000319")]
	public override void Dispose() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000312")]
	public int get_capacity() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000310")]
	public int get_count() { }

	[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x6000314")]
	public JobHandle get_currentJobHandle() { }

	[Address(RVA = "0xF4D7B0", Offset = "0xF4CBB0", Length = "0x4")]
	[Token(Token = "0x6000316")]
	public override void Push() { }

	[Token(Token = "0x6000317")]
	public abstract void RemoveAtSwapBack(int index) { }

	[Address(RVA = "0x7C8F40", Offset = "0x7C8340", Length = "0x17")]
	[Token(Token = "0x600031B")]
	protected void RemoveAtSwapBack(ref NativeArray<T>& array, int index, int count) { }

	[Address(RVA = "0x7C8F80", Offset = "0x7C8380", Length = "0x49")]
	[Token(Token = "0x600031C")]
	protected void RemoveAtSwapBack(ref T[] array, int index, int count) { }

	[Address(RVA = "0x2D745B0", Offset = "0x2D739B0", Length = "0xCB")]
	[Token(Token = "0x600031A")]
	protected void ResizeNativeArray(ref TransformAccessArray array, DecalProjector[] decalProjectors, int capacity) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000313")]
	protected void set_capacity(int value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000311")]
	protected void set_count(int value) { }

	[Address(RVA = "0x14125B0", Offset = "0x14119B0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000315")]
	public void set_currentJobHandle(JobHandle value) { }

	[Token(Token = "0x6000318")]
	public abstract void SetCapacity(int capacity) { }

}

