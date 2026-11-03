namespace Unity.Collections.LowLevel.Unsafe;

[NativeHeader("Runtime/Export/BurstLike/BurstLike.bindings.h")]
[StaticAccessor("BurstLike", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000064")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule", "UnityEngine.AudioModule"})]
internal static class BurstLike
{
	[Token(Token = "0x2000066")]
	public static class SharedStatic
	{

		[Address(RVA = "0x2FEA010", Offset = "0x2FE9410", Length = "0x75")]
		[Token(Token = "0x6000140")]
		public static Void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment) { }

	}

	[IsReadOnly]
	[Token(Token = "0x2000065")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule", "UnityEngine.AudioModule"})]
	public struct SharedStatic
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000110")]
		private readonly Void* _buffer; //Field offset: 0x0

		[Token(Token = "0x17000029")]
		public T Data
		{
			[Address(RVA = "0xD70090", Offset = "0xD6F490", Length = "0x24")]
			[Token(Token = "0x600013E")]
			 get { } //Length: 36
		}

		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[Token(Token = "0x600013D")]
		private SharedStatic`1(Void* buffer) { }

		[Address(RVA = "0xD70090", Offset = "0xD6F490", Length = "0x24")]
		[Token(Token = "0x600013E")]
		public T get_Data() { }

		[Address(RVA = "0x6A22B0", Offset = "0x6A16B0", Length = "0x88")]
		[Token(Token = "0x600013F")]
		public static SharedStatic<T> GetOrCreate(uint alignment = 0) { }

	}


}

