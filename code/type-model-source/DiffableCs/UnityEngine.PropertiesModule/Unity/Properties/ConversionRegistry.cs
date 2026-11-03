namespace Unity.Properties;

[IsReadOnly]
[Token(Token = "0x2000059")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct ConversionRegistry : IEqualityComparer<ConversionRegistry>
{
	[IsReadOnly]
	[Token(Token = "0x200005B")]
	private struct ConverterKey
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000082")]
		public readonly Type SourceType; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000083")]
		public readonly Type DestinationType; //Field offset: 0x8

		[Address(RVA = "0x60E3C0", Offset = "0x60D7C0", Length = "0x32")]
		[Token(Token = "0x6000156")]
		public ConverterKey(Type source, Type destination) { }

	}

	[Token(Token = "0x200005A")]
	private class ConverterKeyComparer : IEqualityComparer<ConverterKey>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000155")]
		public ConverterKeyComparer() { }

		[Address(RVA = "0x3141E60", Offset = "0x3141260", Length = "0x72")]
		[Token(Token = "0x6000153")]
		public override bool Equals(ConverterKey x, ConverterKey y) { }

		[Address(RVA = "0x3141EE0", Offset = "0x31412E0", Length = "0xBC")]
		[Token(Token = "0x6000154")]
		public override int GetHashCode(ConverterKey obj) { }

	}

	[Token(Token = "0x4000080")]
	private static readonly ConverterKeyComparer Comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000081")]
	private readonly Dictionary<ConverterKey, Delegate> m_Converters; //Field offset: 0x0

	[Address(RVA = "0x3141DE0", Offset = "0x31411E0", Length = "0x73")]
	[Token(Token = "0x6000152")]
	private static ConversionRegistry() { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x600014B")]
	private ConversionRegistry(Dictionary<ConverterKey, Delegate> storage) { }

	[Address(RVA = "0x3141AA0", Offset = "0x3140EA0", Length = "0xAA")]
	[Token(Token = "0x600014C")]
	public static ConversionRegistry Create() { }

	[Address(RVA = "0x3141B50", Offset = "0x3140F50", Length = "0x9")]
	[Token(Token = "0x6000150")]
	public override bool Equals(ConversionRegistry x, ConversionRegistry y) { }

	[Address(RVA = "0x3141B60", Offset = "0x3140F60", Length = "0xB9")]
	[Token(Token = "0x600014E")]
	public Delegate GetConverter(Type source, Type destination) { }

	[Address(RVA = "0x3141C20", Offset = "0x3141020", Length = "0x2F")]
	[Token(Token = "0x6000151")]
	public override int GetHashCode(ConversionRegistry obj) { }

	[Address(RVA = "0x3141C50", Offset = "0x3141050", Length = "0xFF")]
	[Token(Token = "0x600014D")]
	public void Register(Type source, Type destination, Delegate converter) { }

	[Address(RVA = "0x3141D50", Offset = "0x3141150", Length = "0x8C")]
	[Token(Token = "0x600014F")]
	public bool TryGetConverter(Type source, Type destination, out Delegate converter) { }

}

