namespace UnityEngine.AddressableAssets;

[Token(Token = "0x200003E")]
internal class DynamicResourceLocator : IResourceLocator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000C8")]
	private AddressablesImpl m_Addressables; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000C9")]
	private string m_AtlasSpriteProviderId; //Field offset: 0x18

	[Token(Token = "0x17000037")]
	public override IEnumerable<IResourceLocation> AllLocations
	{
		[Address(RVA = "0x27A9AF0", Offset = "0x27A8EF0", Length = "0x32")]
		[Token(Token = "0x60001AA")]
		 get { } //Length: 50
	}

	[Token(Token = "0x17000036")]
	private string AtlasSpriteProviderId
	{
		[Address(RVA = "0x27A9B30", Offset = "0x27A8F30", Length = "0x24D")]
		[Token(Token = "0x60001A9")]
		private get { } //Length: 589
	}

	[Token(Token = "0x17000035")]
	public override IEnumerable<Object> Keys
	{
		[Address(RVA = "0x27A9D80", Offset = "0x27A9180", Length = "0x32")]
		[Token(Token = "0x60001A8")]
		 get { } //Length: 50
	}

	[Token(Token = "0x17000034")]
	public override string LocatorId
	{
		[Address(RVA = "0x27A9DC0", Offset = "0x27A91C0", Length = "0x2C")]
		[Token(Token = "0x60001A7")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60001AB")]
	public DynamicResourceLocator(AddressablesImpl addr) { }

	[Address(RVA = "0x27A93B0", Offset = "0x27A87B0", Length = "0x3D1")]
	[Token(Token = "0x60001AD")]
	internal void CreateDynamicLocations(Type type, IList<IResourceLocation> locations, string locName, string subKey, IResourceLocation mainLoc) { }

	[Address(RVA = "0x27A9AF0", Offset = "0x27A8EF0", Length = "0x32")]
	[Token(Token = "0x60001AA")]
	public override IEnumerable<IResourceLocation> get_AllLocations() { }

	[Address(RVA = "0x27A9B30", Offset = "0x27A8F30", Length = "0x24D")]
	[Token(Token = "0x60001A9")]
	private string get_AtlasSpriteProviderId() { }

	[Address(RVA = "0x27A9D80", Offset = "0x27A9180", Length = "0x32")]
	[Token(Token = "0x60001A8")]
	public override IEnumerable<Object> get_Keys() { }

	[Address(RVA = "0x27A9DC0", Offset = "0x27A91C0", Length = "0x2C")]
	[Token(Token = "0x60001A7")]
	public override string get_LocatorId() { }

	[Address(RVA = "0x27A9790", Offset = "0x27A8B90", Length = "0x355")]
	[Token(Token = "0x60001AC")]
	public override bool Locate(object key, Type type, out IList<IResourceLocation>& locations) { }

}

