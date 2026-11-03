namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x2000277")]
public sealed class RenderGraphObjectPool
{
	[Token(Token = "0x2000279")]
	private class SharedObjectPool : SharedObjectPoolBase
	{
		[CompilerGenerated]
		[Token(Token = "0x200027A")]
		private sealed class <>c
		{
			[Token(Token = "0x4000B25")]
			public static readonly <>c<T> <>9; //Field offset: 0x0
			[Token(Token = "0x4000B26")]
			public static Func<T> <>9__1_0; //Field offset: 0x0

			[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
			[Token(Token = "0x60011A8")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60011A9")]
			public <>c() { }

			[Address(RVA = "0xA347A0", Offset = "0xA33BA0", Length = "0x14")]
			[Token(Token = "0x60011AA")]
			internal T <AllocatePool>b__1_0() { }

		}

		[Token(Token = "0x4000B24")]
		private static readonly ObjectPool<T> s_Pool; //Field offset: 0x0

		[Address(RVA = "0xF61A30", Offset = "0xF60E30", Length = "0xBA")]
		[Token(Token = "0x60011A7")]
		private static SharedObjectPool`1() { }

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60011A6")]
		public SharedObjectPool`1() { }

		[Address(RVA = "0xF61290", Offset = "0xF60690", Length = "0x3A2")]
		[Token(Token = "0x60011A2")]
		private static ObjectPool<T> AllocatePool() { }

		[Address(RVA = "0xF61640", Offset = "0xF60A40", Length = "0x87")]
		[Token(Token = "0x60011A3")]
		public virtual void Clear() { }

		[Address(RVA = "0xF616D0", Offset = "0xF60AD0", Length = "0x176")]
		[Token(Token = "0x60011A4")]
		public static T Get() { }

		[Address(RVA = "0xF61850", Offset = "0xF60C50", Length = "0x1D4")]
		[Token(Token = "0x60011A5")]
		public static void Release(T toRelease) { }

	}

	[Token(Token = "0x2000278")]
	private class SharedObjectPoolBase
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60011A0")]
		public SharedObjectPoolBase() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60011A1")]
		public override void Clear() { }

	}

	[Token(Token = "0x4000B20")]
	private static DynamicArray<SharedObjectPoolBase> s_AllocatedPools; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B21")]
	private Dictionary<ValueTuple`2<Type, Int32>, Stack`1<Object>> m_ArrayPool; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B22")]
	private List<ValueTuple`2<Object, ValueTuple`2<Type, Int32>>> m_AllocatedArrays; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B23")]
	private List<MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks; //Field offset: 0x20

	[Address(RVA = "0x2C9CAF0", Offset = "0x2C9BEF0", Length = "0x84")]
	[Token(Token = "0x600119F")]
	private static RenderGraphObjectPool() { }

	[Address(RVA = "0x2C9CB80", Offset = "0x2C9BF80", Length = "0x103")]
	[Token(Token = "0x6001197")]
	internal RenderGraphObjectPool() { }

	[Address(RVA = "0x2C9C460", Offset = "0x2C9B860", Length = "0x19C")]
	[Token(Token = "0x600119E")]
	internal void Cleanup() { }

	[Address(RVA = "0x8E73D0", Offset = "0x8E67D0", Length = "0x53")]
	[Token(Token = "0x600119C")]
	internal T Get() { }

	[Address(RVA = "0x8E7050", Offset = "0x8E6450", Length = "0x37A")]
	[Token(Token = "0x6001198")]
	public T[] GetTempArray(int size) { }

	[Address(RVA = "0x2C9C600", Offset = "0x2C9BA00", Length = "0x100")]
	[Token(Token = "0x6001199")]
	public MaterialPropertyBlock GetTempMaterialPropertyBlock() { }

	[Address(RVA = "0x2C9C710", Offset = "0x2C9BB10", Length = "0x63")]
	[Token(Token = "0x600119B")]
	internal bool IsEmpty() { }

	[Address(RVA = "0x8E7430", Offset = "0x8E6830", Length = "0x63")]
	[Token(Token = "0x600119D")]
	internal void Release(T value) { }

	[Address(RVA = "0x2C9C780", Offset = "0x2C9BB80", Length = "0x360")]
	[Token(Token = "0x600119A")]
	internal void ReleaseAllTempAlloc() { }

}

