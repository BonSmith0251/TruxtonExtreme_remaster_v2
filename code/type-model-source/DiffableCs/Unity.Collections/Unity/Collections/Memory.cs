namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000083")]
internal struct Memory
{
	[GenerateTestsForBurstCompatibility]
	[Token(Token = "0x2000086")]
	public struct Array
	{

		[Address(RVA = "0x9EF750", Offset = "0x9EEB50", Length = "0x57")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x60006E0")]
		internal static void Clear(T* pointer, long count) { }

		[Address(RVA = "0x9EF7B0", Offset = "0x9EEBB0", Length = "0x67")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x60006E1")]
		internal static void Copy(T* dest, T* src, long count) { }

		[Address(RVA = "0x9EFDB0", Offset = "0x9EF1B0", Length = "0x105")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x60006DF")]
		internal static void Set(T* pointer, long count, T t = null) { }

	}

	[GenerateTestsForBurstCompatibility]
	[Token(Token = "0x2000084")]
	public struct Unmanaged
	{
		[GenerateTestsForBurstCompatibility]
		[Token(Token = "0x2000085")]
		public struct Array
		{

			[Address(RVA = "0x9EF690", Offset = "0x9EEA90", Length = "0x52")]
			[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
			[Token(Token = "0x60006DD")]
			internal static T* Allocate(long count, AllocatorHandle allocator) { }

			[Address(RVA = "0x28C6400", Offset = "0x28C5800", Length = "0xCD")]
			[Token(Token = "0x60006DA")]
			private static Void* CustomResize(Void* oldPointer, long oldCount, long newCount, AllocatorHandle allocator, long size, int align) { }

			[Address(RVA = "0x9EF820", Offset = "0x9EEC20", Length = "0x67")]
			[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
			[Token(Token = "0x60006DE")]
			internal static void Free(T* pointer, long count, AllocatorHandle allocator) { }

			[Address(RVA = "0x28A88F0", Offset = "0x28A7CF0", Length = "0x8")]
			[Token(Token = "0x60006D9")]
			private static bool IsCustom(AllocatorHandle allocator) { }

			[Address(RVA = "0x28C64D0", Offset = "0x28C58D0", Length = "0x17D")]
			[Token(Token = "0x60006DB")]
			internal static Void* Resize(Void* oldPointer, long oldCount, long newCount, AllocatorHandle allocator, long size, int align) { }

			[Address(RVA = "0x9EF920", Offset = "0x9EED20", Length = "0x89")]
			[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
			[Token(Token = "0x60006DC")]
			internal static T* Resize(T* oldPointer, long oldCount, long newCount, AllocatorHandle allocator) { }

		}


		[Address(RVA = "0x28D0EE0", Offset = "0x28D02E0", Length = "0x2D")]
		[Token(Token = "0x60006D5")]
		internal static Void* Allocate(long size, int align, AllocatorHandle allocator) { }

		[Address(RVA = "0x9FB900", Offset = "0x9FAD00", Length = "0x48")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x60006D7")]
		internal static T* Allocate(AllocatorHandle allocator) { }

		[Address(RVA = "0x28D0F10", Offset = "0x28D0310", Length = "0xE3")]
		[Token(Token = "0x60006D6")]
		internal static void Free(Void* pointer, AllocatorHandle allocator) { }

		[Address(RVA = "0x9FB9E0", Offset = "0x9FADE0", Length = "0x88")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x60006D8")]
		internal static void Free(T* pointer, AllocatorHandle allocator) { }

	}

	[Token(Token = "0x40003AA")]
	internal const long k_MaximumRamSizeInBytes = 1099511627776; //Field offset: 0x0

	[Address(RVA = "0x28C7F90", Offset = "0x28C7390", Length = "0x112")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60006D4")]
	internal static void CheckByteCountIsReasonable(long size) { }

}

