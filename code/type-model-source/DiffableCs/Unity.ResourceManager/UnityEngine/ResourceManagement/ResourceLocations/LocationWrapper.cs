namespace UnityEngine.ResourceManagement.ResourceLocations;

[Token(Token = "0x2000070")]
internal class LocationWrapper : IResourceLocation
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400012D")]
	private IResourceLocation m_InternalLocation; //Field offset: 0x10

	[Token(Token = "0x17000077")]
	public override object Data
	{
		[Address(RVA = "0x2E458C0", Offset = "0x2E44CC0", Length = "0x49")]
		[Token(Token = "0x600028A")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000074")]
	public override IList<IResourceLocation> Dependencies
	{
		[Address(RVA = "0x2E45910", Offset = "0x2E44D10", Length = "0x49")]
		[Token(Token = "0x6000287")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000075")]
	public override int DependencyHashCode
	{
		[Address(RVA = "0x2E45960", Offset = "0x2E44D60", Length = "0x49")]
		[Token(Token = "0x6000288")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000076")]
	public override bool HasDependencies
	{
		[Address(RVA = "0x2E459B0", Offset = "0x2E44DB0", Length = "0x49")]
		[Token(Token = "0x6000289")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000072")]
	public override string InternalId
	{
		[Address(RVA = "0x2E45A00", Offset = "0x2E44E00", Length = "0x46")]
		[Token(Token = "0x6000285")]
		 get { } //Length: 70
	}

	[Token(Token = "0x17000078")]
	public override string PrimaryKey
	{
		[Address(RVA = "0x2E45A50", Offset = "0x2E44E50", Length = "0x49")]
		[Token(Token = "0x600028B")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000073")]
	public override string ProviderId
	{
		[Address(RVA = "0x2E45AA0", Offset = "0x2E44EA0", Length = "0x49")]
		[Token(Token = "0x6000286")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000079")]
	public override Type ResourceType
	{
		[Address(RVA = "0x2E45AF0", Offset = "0x2E44EF0", Length = "0x49")]
		[Token(Token = "0x600028C")]
		 get { } //Length: 73
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000284")]
	public LocationWrapper(IResourceLocation location) { }

	[Address(RVA = "0x2E458C0", Offset = "0x2E44CC0", Length = "0x49")]
	[Token(Token = "0x600028A")]
	public override object get_Data() { }

	[Address(RVA = "0x2E45910", Offset = "0x2E44D10", Length = "0x49")]
	[Token(Token = "0x6000287")]
	public override IList<IResourceLocation> get_Dependencies() { }

	[Address(RVA = "0x2E45960", Offset = "0x2E44D60", Length = "0x49")]
	[Token(Token = "0x6000288")]
	public override int get_DependencyHashCode() { }

	[Address(RVA = "0x2E459B0", Offset = "0x2E44DB0", Length = "0x49")]
	[Token(Token = "0x6000289")]
	public override bool get_HasDependencies() { }

	[Address(RVA = "0x2E45A00", Offset = "0x2E44E00", Length = "0x46")]
	[Token(Token = "0x6000285")]
	public override string get_InternalId() { }

	[Address(RVA = "0x2E45A50", Offset = "0x2E44E50", Length = "0x49")]
	[Token(Token = "0x600028B")]
	public override string get_PrimaryKey() { }

	[Address(RVA = "0x2E45AA0", Offset = "0x2E44EA0", Length = "0x49")]
	[Token(Token = "0x6000286")]
	public override string get_ProviderId() { }

	[Address(RVA = "0x2E45AF0", Offset = "0x2E44EF0", Length = "0x49")]
	[Token(Token = "0x600028C")]
	public override Type get_ResourceType() { }

	[Address(RVA = "0x2E45860", Offset = "0x2E44C60", Length = "0x58")]
	[Token(Token = "0x600028D")]
	public override int Hash(Type resultType) { }

}

