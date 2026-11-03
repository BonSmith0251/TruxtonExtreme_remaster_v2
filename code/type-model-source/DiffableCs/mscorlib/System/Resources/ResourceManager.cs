namespace System.Resources;

[ComVisible(True)]
[Token(Token = "0x20004C1")]
public class ResourceManager
{
	[Token(Token = "0x20004C2")]
	public class CultureNameResourceSetPair
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60021C8")]
		public CultureNameResourceSetPair() { }

	}

	[Token(Token = "0x20004C3")]
	public class ResourceManagerMediator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40012D1")]
		private ResourceManager _rm; //Field offset: 0x10

		[Address(RVA = "0x1F3AB50", Offset = "0x1F39F50", Length = "0x7E")]
		[Token(Token = "0x60021C9")]
		internal ResourceManagerMediator(ResourceManager rm) { }

	}

	[Token(Token = "0x40012CA")]
	public static readonly int MagicNumber; //Field offset: 0x0
	[Token(Token = "0x40012CB")]
	public static readonly int HeaderVersionNumber; //Field offset: 0x4
	[Token(Token = "0x40012CC")]
	private static readonly Type _minResourceSet; //Field offset: 0x8
	[Token(Token = "0x40012CD")]
	internal static readonly string ResReaderTypeName; //Field offset: 0x10
	[Token(Token = "0x40012CE")]
	internal static readonly string ResSetTypeName; //Field offset: 0x18
	[Token(Token = "0x40012CF")]
	internal static readonly string MscorlibName; //Field offset: 0x20
	[Token(Token = "0x40012D0")]
	internal static readonly int DEBUG; //Field offset: 0x28
	[FieldOffset(Offset = "0x10")]
	[Obsolete("call InternalGetResourceSet instead")]
	[Token(Token = "0x40012BF")]
	protected Hashtable ResourceSets; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40012C0")]
	private Dictionary<String, ResourceSet> _resourceSets; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40012C1")]
	protected Assembly MainAssembly; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40012C2")]
	private CultureInfo _neutralResourcesCulture; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40012C3")]
	private CultureNameResourceSetPair _lastUsedResourceCache; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40012C4")]
	private bool UseManifest; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x40012C5")]
	private bool UseSatelliteAssem; //Field offset: 0x39
	[FieldOffset(Offset = "0x3C")]
	[OptionalField]
	[Token(Token = "0x40012C6")]
	private UltimateResourceFallbackLocation _fallbackLoc; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x40012C7")]
	private Assembly _callingAssembly; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[OptionalField(VersionAdded = 4)]
	[Token(Token = "0x40012C8")]
	private RuntimeAssembly m_callingAssembly; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40012C9")]
	private IResourceGroveler resourceGroveler; //Field offset: 0x50

	[Address(RVA = "0x1F3B1D0", Offset = "0x1F3A5D0", Length = "0x207")]
	[Token(Token = "0x60021C7")]
	private static ResourceManager() { }

	[Address(RVA = "0x1F3B3E0", Offset = "0x1F3A7E0", Length = "0xF4")]
	[Token(Token = "0x60021C2")]
	protected ResourceManager() { }

	[Address(RVA = "0x1F3ABD0", Offset = "0x1F39FD0", Length = "0x23F")]
	[Token(Token = "0x60021C6")]
	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2) { }

	[Address(RVA = "0x1F3AE10", Offset = "0x1F3A210", Length = "0xB9")]
	[Token(Token = "0x60021C1")]
	private void Init() { }

	[Address(RVA = "0x1F3AED0", Offset = "0x1F3A2D0", Length = "0x225")]
	[OnDeserialized]
	[Token(Token = "0x60021C4")]
	private void OnDeserialized(StreamingContext ctx) { }

	[Address(RVA = "0x1F3B100", Offset = "0x1F3A500", Length = "0x47")]
	[OnDeserializing]
	[Token(Token = "0x60021C3")]
	private void OnDeserializing(StreamingContext ctx) { }

	[Address(RVA = "0x1F3B150", Offset = "0x1F3A550", Length = "0x74")]
	[OnSerializing]
	[Token(Token = "0x60021C5")]
	private void OnSerializing(StreamingContext ctx) { }

}

