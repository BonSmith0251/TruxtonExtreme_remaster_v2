namespace UnityEngine.AddressableAssets.ResourceLocators;

[Token(Token = "0x2000048")]
public class ContentCatalogDataEntry
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000FD")]
	private string <InternalId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000FE")]
	private string <Provider>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000FF")]
	private List<Object> <Keys>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000100")]
	private List<Object> <Dependencies>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000101")]
	private object <Data>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000102")]
	private Type <ResourceType>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x1700003E")]
	public object Data
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001DC")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60001DD")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700003D")]
	public private List<Object> Dependencies
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001DA")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60001DB")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700003A")]
	public string InternalId
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001D4")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60001D5")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700003C")]
	public private List<Object> Keys
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001D8")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60001D9")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700003B")]
	public private string Provider
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001D6")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60001D7")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700003F")]
	public private Type ResourceType
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001DE")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60001DF")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x27A8A20", Offset = "0x27A7E20", Length = "0x130")]
	[Token(Token = "0x60001E0")]
	public ContentCatalogDataEntry(Type type, string internalId, string provider, IEnumerable<Object> keys, IEnumerable<Object> dependencies = null, object extraData = null) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001DC")]
	public object get_Data() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001DA")]
	public List<Object> get_Dependencies() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001D4")]
	public string get_InternalId() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001D8")]
	public List<Object> get_Keys() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001D6")]
	public string get_Provider() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001DE")]
	public Type get_ResourceType() { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60001DD")]
	public void set_Data(object value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60001DB")]
	private void set_Dependencies(List<Object> value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60001D5")]
	public void set_InternalId(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60001D9")]
	private void set_Keys(List<Object> value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60001D7")]
	private void set_Provider(string value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60001DF")]
	private void set_ResourceType(Type value) { }

}

