namespace UnityEngine.UIElements;

[Token(Token = "0x200041C")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct StyleDataRef : IEquatable<StyleDataRef`1<T>>
{
	[Token(Token = "0x200041D")]
	private class RefCounted
	{
		[Token(Token = "0x4000DB8")]
		private static uint m_NextId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000DB9")]
		private int m_RefCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000DBA")]
		private readonly uint m_Id; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000DBB")]
		public T value; //Field offset: 0x0

		[Token(Token = "0x170008BA")]
		public int refCount
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[Token(Token = "0x6001F40")]
			 get { } //Length: 85
		}

		[Address(RVA = "0xF4E560", Offset = "0xF4D960", Length = "0x56")]
		[Token(Token = "0x6001F45")]
		private static RefCounted() { }

		[Address(RVA = "0xF4E700", Offset = "0xF4DB00", Length = "0xBB")]
		[Token(Token = "0x6001F41")]
		public RefCounted() { }

		[Address(RVA = "0xF4D7B0", Offset = "0xF4CBB0", Length = "0x4")]
		[Token(Token = "0x6001F42")]
		public void Acquire() { }

		[Address(RVA = "0xF4DB00", Offset = "0xF4CF00", Length = "0x23B")]
		[Token(Token = "0x6001F44")]
		public RefCounted<T> Copy() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6001F40")]
		public int get_refCount() { }

		[Address(RVA = "0xF4E550", Offset = "0xF4D950", Length = "0x4")]
		[Token(Token = "0x6001F43")]
		public void Release() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000DB7")]
	private RefCounted<T> m_Ref; //Field offset: 0x0

	[Address(RVA = "0xFD0510", Offset = "0xFCF910", Length = "0x50")]
	[Token(Token = "0x6001F35")]
	public StyleDataRef<T> Acquire() { }

	[Address(RVA = "0xFD0C00", Offset = "0xFD0000", Length = "0x116")]
	[Token(Token = "0x6001F37")]
	public void CopyFrom(StyleDataRef<T> other) { }

	[Address(RVA = "0xFD0F60", Offset = "0xFD0360", Length = "0x9C")]
	[Token(Token = "0x6001F3A")]
	public static StyleDataRef<T> Create() { }

	[Address(RVA = "0xFD1C70", Offset = "0xFD1070", Length = "0x123")]
	[Token(Token = "0x6001F3D")]
	public override bool Equals(StyleDataRef<T> other) { }

	[Address(RVA = "0xFD1B60", Offset = "0xFD0F60", Length = "0x103")]
	[Token(Token = "0x6001F3E")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xFD21A0", Offset = "0xFD15A0", Length = "0x4C")]
	[Token(Token = "0x6001F3B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xFD2BA0", Offset = "0xFD1FA0", Length = "0xE9")]
	[Token(Token = "0x6001F3C")]
	public static bool op_Equality(StyleDataRef<T> lhs, StyleDataRef<T> rhs) { }

	[Address(RVA = "0xFD21F0", Offset = "0xFD15F0", Length = "0x1A")]
	[Token(Token = "0x6001F38")]
	public T Read() { }

	[Address(RVA = "0xFD2260", Offset = "0xFD1660", Length = "0x9")]
	[Token(Token = "0x6001F3F")]
	public bool ReferenceEquals(StyleDataRef<T> other) { }

	[Address(RVA = "0xFD2270", Offset = "0xFD1670", Length = "0x5D")]
	[Token(Token = "0x6001F36")]
	public void Release() { }

	[Address(RVA = "0xFD2440", Offset = "0xFD1840", Length = "0xCA")]
	[Token(Token = "0x6001F39")]
	public T Write() { }

}

