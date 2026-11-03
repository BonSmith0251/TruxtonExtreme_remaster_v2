namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x200002A")]
internal struct TypeConverterRegistry : IEqualityComparer<TypeConverterRegistry>
{
	[IsReadOnly]
	[Token(Token = "0x200002C")]
	private struct ConverterKey
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000067")]
		public readonly Type SourceType; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000068")]
		public readonly Type DestinationType; //Field offset: 0x8

		[Address(RVA = "0x60E3C0", Offset = "0x60D7C0", Length = "0x32")]
		[Token(Token = "0x60000DE")]
		public ConverterKey(Type source, Type destination) { }

	}

	[Token(Token = "0x200002B")]
	private class ConverterKeyComparer : IEqualityComparer<ConverterKey>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000DD")]
		public ConverterKeyComparer() { }

		[Address(RVA = "0x3141E60", Offset = "0x3141260", Length = "0x72")]
		[Token(Token = "0x60000DB")]
		public override bool Equals(ConverterKey x, ConverterKey y) { }

		[Address(RVA = "0x3141EE0", Offset = "0x31412E0", Length = "0xBC")]
		[Token(Token = "0x60000DC")]
		public override int GetHashCode(ConverterKey obj) { }

	}

	[Token(Token = "0x4000065")]
	private static readonly ConverterKeyComparer k_Comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000066")]
	private readonly Dictionary<ConverterKey, Delegate> m_Converters; //Field offset: 0x0

	[Address(RVA = "0x3210160", Offset = "0x320F560", Length = "0x73")]
	[Token(Token = "0x60000DA")]
	private static TypeConverterRegistry() { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x60000D2")]
	private TypeConverterRegistry(Dictionary<ConverterKey, Delegate> storage) { }

	[Address(RVA = "0x320FBF0", Offset = "0x320EFF0", Length = "0x269")]
	[Token(Token = "0x60000D5")]
	internal void Apply(TypeConverterRegistry registry) { }

	[Address(RVA = "0x320FE60", Offset = "0x320F260", Length = "0xAA")]
	[Token(Token = "0x60000D3")]
	public static TypeConverterRegistry Create() { }

	[Address(RVA = "0x3141B50", Offset = "0x3140F50", Length = "0x9")]
	[Token(Token = "0x60000D8")]
	public override bool Equals(TypeConverterRegistry x, TypeConverterRegistry y) { }

	[Address(RVA = "0x320FF10", Offset = "0x320F310", Length = "0xB9")]
	[Token(Token = "0x60000D6")]
	public Delegate GetConverter(Type source, Type destination) { }

	[Address(RVA = "0x3141C20", Offset = "0x3141020", Length = "0x2F")]
	[Token(Token = "0x60000D9")]
	public override int GetHashCode(TypeConverterRegistry obj) { }

	[Address(RVA = "0x320FFD0", Offset = "0x320F3D0", Length = "0xFF")]
	[Token(Token = "0x60000D4")]
	public void Register(Type source, Type destination, Delegate converter) { }

	[Address(RVA = "0x32100D0", Offset = "0x320F4D0", Length = "0x8C")]
	[Token(Token = "0x60000D7")]
	public bool TryGetConverter(Type source, Type destination, out Delegate converter) { }

}

