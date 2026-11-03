namespace UnityEngine.AddressableAssets.ResourceLocators;

[Token(Token = "0x200005B")]
public class ResourceLocationMap : IResourceLocator
{
	[CompilerGenerated]
	[Token(Token = "0x200005C")]
	private sealed class <>c
	{
		[Token(Token = "0x4000148")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000149")]
		public static Func<KeyValuePair`2<Object, IList`1<IResourceLocation>>, IEnumerable`1<IResourceLocation>> <>9__8_0; //Field offset: 0x8

		[Address(RVA = "0x27B59B0", Offset = "0x27B4DB0", Length = "0x67")]
		[Token(Token = "0x6000242")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000243")]
		public <>c() { }

		[Address(RVA = "0x27B4B20", Offset = "0x27B3F20", Length = "0x39")]
		[Token(Token = "0x6000244")]
		internal IEnumerable<IResourceLocation> <get_AllLocations>b__8_0(KeyValuePair<Object, IList`1<IResourceLocation>> k) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000146")]
	private string <LocatorId>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000147")]
	private Dictionary<Object, IList`1<IResourceLocation>> locations; //Field offset: 0x18

	[Token(Token = "0x17000063")]
	public override IEnumerable<IResourceLocation> AllLocations
	{
		[Address(RVA = "0x27B1370", Offset = "0x27B0770", Length = "0x111")]
		[Token(Token = "0x600023C")]
		 get { } //Length: 273
	}

	[Token(Token = "0x17000065")]
	public override IEnumerable<Object> Keys
	{
		[Address(RVA = "0x27B1490", Offset = "0x27B0890", Length = "0x44")]
		[Token(Token = "0x600023E")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000064")]
	public Dictionary<Object, IList`1<IResourceLocation>> Locations
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600023D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000062")]
	public private override string LocatorId
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000239")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600023A")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x27B09B0", Offset = "0x27AFDB0", Length = "0xA1")]
	[Token(Token = "0x6000238")]
	public ResourceLocationMap(string id, int capacity = 0) { }

	[Address(RVA = "0x27B0A60", Offset = "0x27AFE60", Length = "0x905")]
	[Token(Token = "0x600023B")]
	public ResourceLocationMap(string id, IList<ResourceLocationData> locations) { }

	[Address(RVA = "0x27B0200", Offset = "0x27AF600", Length = "0x110")]
	[Token(Token = "0x6000240")]
	public void Add(object key, IResourceLocation location) { }

	[Address(RVA = "0x27B0320", Offset = "0x27AF720", Length = "0x63")]
	[Token(Token = "0x6000241")]
	public void Add(object key, IList<IResourceLocation> locations) { }

	[Address(RVA = "0x27B1370", Offset = "0x27B0770", Length = "0x111")]
	[Token(Token = "0x600023C")]
	public override IEnumerable<IResourceLocation> get_AllLocations() { }

	[Address(RVA = "0x27B1490", Offset = "0x27B0890", Length = "0x44")]
	[Token(Token = "0x600023E")]
	public override IEnumerable<Object> get_Keys() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600023D")]
	public Dictionary<Object, IList`1<IResourceLocation>> get_Locations() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000239")]
	public override string get_LocatorId() { }

	[Address(RVA = "0x27B0390", Offset = "0x27AF790", Length = "0x615")]
	[Token(Token = "0x600023F")]
	public override bool Locate(object key, Type type, out IList<IResourceLocation>& locations) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600023A")]
	private void set_LocatorId(string value) { }

}

