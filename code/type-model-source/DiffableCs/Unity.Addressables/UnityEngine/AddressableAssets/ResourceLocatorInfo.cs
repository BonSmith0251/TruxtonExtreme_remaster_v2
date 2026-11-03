namespace UnityEngine.AddressableAssets;

[Token(Token = "0x2000009")]
public class ResourceLocatorInfo
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000E")]
	private IResourceLocator <Locator>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000F")]
	private string <LocalHash>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000010")]
	private IResourceLocation <CatalogLocation>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000011")]
	private bool <ContentUpdateAvailable>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000008")]
	public bool CanUpdateContent
	{
		[Address(RVA = "0x27B1A50", Offset = "0x27B0E50", Length = "0xA9")]
		[Token(Token = "0x600001F")]
		 get { } //Length: 169
	}

	[Token(Token = "0x17000005")]
	public private IResourceLocation CatalogLocation
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000019")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600001A")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000006")]
	internal bool ContentUpdateAvailable
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600001B")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600001C")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000007")]
	public IResourceLocation HashLocation
	{
		[Address(RVA = "0x27B1B00", Offset = "0x27B0F00", Length = "0x6E")]
		[Token(Token = "0x600001E")]
		 get { } //Length: 110
	}

	[Token(Token = "0x17000004")]
	public private string LocalHash
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000017")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000018")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000003")]
	public private IResourceLocator Locator
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000015")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000016")]
		private set { } //Length: 13
	}

	[Address(RVA = "0xA96E10", Offset = "0xA96210", Length = "0x6B")]
	[Token(Token = "0x600001D")]
	public ResourceLocatorInfo(IResourceLocator loc, string localHash, IResourceLocation remoteCatalogLocation) { }

	[Address(RVA = "0x27B1A50", Offset = "0x27B0E50", Length = "0xA9")]
	[Token(Token = "0x600001F")]
	public bool get_CanUpdateContent() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000019")]
	public IResourceLocation get_CatalogLocation() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600001B")]
	internal bool get_ContentUpdateAvailable() { }

	[Address(RVA = "0x27B1B00", Offset = "0x27B0F00", Length = "0x6E")]
	[Token(Token = "0x600001E")]
	public IResourceLocation get_HashLocation() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000017")]
	public string get_LocalHash() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000015")]
	public IResourceLocator get_Locator() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600001A")]
	private void set_CatalogLocation(IResourceLocation value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600001C")]
	internal void set_ContentUpdateAvailable(bool value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000018")]
	private void set_LocalHash(string value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000016")]
	private void set_Locator(IResourceLocator value) { }

	[Address(RVA = "0x27B19F0", Offset = "0x27B0DF0", Length = "0x57")]
	[Token(Token = "0x6000020")]
	internal void UpdateContent(IResourceLocator locator, string hash, IResourceLocation loc) { }

}

