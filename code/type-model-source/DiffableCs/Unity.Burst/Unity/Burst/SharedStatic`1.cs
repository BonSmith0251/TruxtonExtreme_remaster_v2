namespace Unity.Burst;

[IsReadOnly]
[Token(Token = "0x200002F")]
public struct SharedStatic
{
	[Token(Token = "0x400017F")]
	private const uint DefaultAlignment = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400017E")]
	private readonly Void* _buffer; //Field offset: 0x0

	[Token(Token = "0x1700001B")]
	public T Data
	{
		[Address(RVA = "0xD70090", Offset = "0xD6F490", Length = "0x24")]
		[Token(Token = "0x60000E6")]
		 get { } //Length: 36
	}

	[Token(Token = "0x1700001C")]
	public Void* UnsafeDataPointer
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x60000E7")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x60000E5")]
	private SharedStatic`1(Void* buffer) { }

	[Address(RVA = "0x945130", Offset = "0x944530", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x60000EF")]
	private static void CheckIf_T_IsUnmanagedOrThrow() { }

	[Address(RVA = "0xD70090", Offset = "0xD6F490", Length = "0x24")]
	[Token(Token = "0x60000E6")]
	public T get_Data() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60000E7")]
	public Void* get_UnsafeDataPointer() { }

	[Address(RVA = "0x6A2570", Offset = "0x6A1970", Length = "0xC2")]
	[Token(Token = "0x60000E8")]
	public static SharedStatic<T> GetOrCreate(uint alignment = 0) { }

	[Address(RVA = "0x6A2340", Offset = "0x6A1740", Length = "0xBE")]
	[Token(Token = "0x60000E9")]
	public static SharedStatic<T> GetOrCreate(uint alignment = 0) { }

	[Address(RVA = "0xF62250", Offset = "0xF61650", Length = "0x5A")]
	[Token(Token = "0x60000ED")]
	public static SharedStatic<T> GetOrCreate(Type contextType, uint alignment = 0) { }

	[Address(RVA = "0xF624A0", Offset = "0xF618A0", Length = "0x75")]
	[Token(Token = "0x60000EE")]
	public static SharedStatic<T> GetOrCreate(Type contextType, Type subContextType, uint alignment = 0) { }

	[Address(RVA = "0x6A20F0", Offset = "0x6A14F0", Length = "0xDE")]
	[Token(Token = "0x60000EB")]
	public static SharedStatic<T> GetOrCreatePartiallyUnsafeWithHashCode(uint alignment, long hashCode) { }

	[Address(RVA = "0x6A21D0", Offset = "0x6A15D0", Length = "0xDE")]
	[Token(Token = "0x60000EC")]
	public static SharedStatic<T> GetOrCreatePartiallyUnsafeWithSubHashCode(uint alignment, long subHashCode) { }

	[Address(RVA = "0xF61D40", Offset = "0xF61140", Length = "0x84")]
	[Token(Token = "0x60000EA")]
	public static SharedStatic<T> GetOrCreateUnsafe(uint alignment, long hashCode, long subHashCode) { }

}

