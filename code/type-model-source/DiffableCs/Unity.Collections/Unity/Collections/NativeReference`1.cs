namespace Unity.Collections;

[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[NativeContainer]
[Token(Token = "0x20000BB")]
public struct NativeReference : INativeDisposable, IDisposable, IEquatable<NativeReference`1<T>>
{
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	[Token(Token = "0x20000BC")]
	internal struct ReadOnly
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40003E6")]
		private readonly Void* m_Data; //Field offset: 0x0

		[Token(Token = "0x17000106")]
		public T Value
		{
			[Address(RVA = "0xEA5200", Offset = "0xEA4600", Length = "0x9C")]
			[Token(Token = "0x60008EE")]
			 get { } //Length: 156
		}

		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[Token(Token = "0x60008ED")]
		internal ReadOnly(Void* data) { }

		[Address(RVA = "0xEA5200", Offset = "0xEA4600", Length = "0x9C")]
		[Token(Token = "0x60008EE")]
		public T get_Value() { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40003E4")]
	internal Void* m_Data; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003E5")]
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x0

	[Token(Token = "0x17000105")]
	public bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x60008E0")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000104")]
	public T Value
	{
		[Address(RVA = "0xD92470", Offset = "0xD91870", Length = "0x9C")]
		[Token(Token = "0x60008DE")]
		 get { } //Length: 156
		[Address(RVA = "0xD926A0", Offset = "0xD91AA0", Length = "0xE1")]
		[Token(Token = "0x60008DF")]
		 set { } //Length: 225
	}

	[Address(RVA = "0xD92240", Offset = "0xD91640", Length = "0xE4")]
	[Token(Token = "0x60008DB")]
	public NativeReference`1(AllocatorHandle allocator, NativeArrayOptions options = 1) { }

	[Address(RVA = "0xD92330", Offset = "0xD91730", Length = "0x136")]
	[Token(Token = "0x60008DC")]
	public NativeReference`1(T value, AllocatorHandle allocator) { }

	[Address(RVA = "0xD91800", Offset = "0xD90C00", Length = "0xE7")]
	[Token(Token = "0x60008DD")]
	private static void Allocate(AllocatorHandle allocator, out NativeReference<T>& reference) { }

	[Address(RVA = "0xD70090", Offset = "0xD6F490", Length = "0x24")]
	[Token(Token = "0x60008EB")]
	public ReadOnly<T> AsReadOnly() { }

	[Address(RVA = "0xD91A10", Offset = "0xD90E10", Length = "0x87")]
	[Token(Token = "0x60008EA")]
	public static void Copy(NativeReference<T> dst, NativeReference<T> src) { }

	[Address(RVA = "0xD918F0", Offset = "0xD90CF0", Length = "0x8F")]
	[Token(Token = "0x60008E3")]
	public void CopyFrom(NativeReference<T> reference) { }

	[Address(RVA = "0xD91980", Offset = "0xD90D80", Length = "0x8F")]
	[Token(Token = "0x60008E4")]
	public void CopyTo(NativeReference<T> reference) { }

	[Address(RVA = "0xD91BD0", Offset = "0xD90FD0", Length = "0xA0")]
	[Token(Token = "0x60008E1")]
	public override void Dispose() { }

	[Address(RVA = "0xD91AA0", Offset = "0xD90EA0", Length = "0x122")]
	[Token(Token = "0x60008E2")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0xD91C70", Offset = "0xD91070", Length = "0x297")]
	[ExcludeFromBurstCompatTesting("Equals boxes because Value does not implement IEquatable<T>")]
	[Token(Token = "0x60008E5")]
	public override bool Equals(NativeReference<T> other) { }

	[Address(RVA = "0xD91F10", Offset = "0xD91310", Length = "0x13B")]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	[Token(Token = "0x60008E6")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x60008E0")]
	public bool get_IsCreated() { }

	[Address(RVA = "0xD92470", Offset = "0xD91870", Length = "0x9C")]
	[Token(Token = "0x60008DE")]
	public T get_Value() { }

	[Address(RVA = "0xD92050", Offset = "0xD91450", Length = "0x1F0")]
	[Token(Token = "0x60008E7")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xD92510", Offset = "0xD91910", Length = "0x87")]
	[Token(Token = "0x60008E8")]
	public static bool op_Equality(NativeReference<T> left, NativeReference<T> right) { }

	[Address(RVA = "0xD925A0", Offset = "0xD919A0", Length = "0x6D")]
	[Token(Token = "0x60008EC")]
	public static ReadOnly<T> op_Implicit(NativeReference<T> nativeReference) { }

	[Address(RVA = "0xD92610", Offset = "0xD91A10", Length = "0x8C")]
	[Token(Token = "0x60008E9")]
	public static bool op_Inequality(NativeReference<T> left, NativeReference<T> right) { }

	[Address(RVA = "0xD926A0", Offset = "0xD91AA0", Length = "0xE1")]
	[Token(Token = "0x60008DF")]
	public void set_Value(T value) { }

}

