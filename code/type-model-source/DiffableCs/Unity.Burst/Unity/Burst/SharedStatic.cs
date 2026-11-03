namespace Unity.Burst;

[Token(Token = "0x2000030")]
internal static class SharedStatic
{
	[Token(Token = "0x2000031")]
	public class PreserveAttribute : Attribute
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60000F3")]
		public PreserveAttribute() { }

	}


	[Address(RVA = "0x27E5970", Offset = "0x27E4D70", Length = "0x60")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x60000F1")]
	private static void CheckResult(Void* result) { }

	[Address(RVA = "0x27E59D0", Offset = "0x27E4DD0", Length = "0x7B")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x60000F0")]
	private static void CheckSizeOf(uint sizeOf) { }

	[Address(RVA = "0x27E5A50", Offset = "0x27E4E50", Length = "0x48")]
	[Preserve]
	[Token(Token = "0x60000F2")]
	public static Void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment) { }

}

