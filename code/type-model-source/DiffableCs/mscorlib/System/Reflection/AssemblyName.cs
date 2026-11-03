namespace System.Reflection;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_AssemblyName))]
[ComVisible(True)]
[Token(Token = "0x2000511")]
public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback, _AssemblyName
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400143C")]
	private string name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400143D")]
	private string codebase; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400143E")]
	private int major; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400143F")]
	private int minor; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001440")]
	private int build; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001441")]
	private int revision; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001442")]
	private CultureInfo cultureinfo; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001443")]
	private AssemblyNameFlags flags; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001444")]
	private AssemblyHashAlgorithm hashalg; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001445")]
	private StrongNameKeyPair keypair; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001446")]
	private Byte[] publicKey; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001447")]
	private Byte[] keyToken; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001448")]
	private AssemblyVersionCompatibility versioncompat; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001449")]
	private Version version; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400144A")]
	private ProcessorArchitecture processor_architecture; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400144B")]
	private AssemblyContentType contentType; //Field offset: 0x6C

	[Token(Token = "0x170004B3")]
	public CultureInfo CultureInfo
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6002405")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004B4")]
	public AssemblyNameFlags Flags
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6002406")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170004B5")]
	public string FullName
	{
		[Address(RVA = "0x1F4B2B0", Offset = "0x1F4A6B0", Length = "0x3E6")]
		[Token(Token = "0x6002407")]
		 get { } //Length: 998
	}

	[Token(Token = "0x170004B7")]
	private bool IsPublicKeyValid
	{
		[Address(RVA = "0x1F4B6A0", Offset = "0x1F4AAA0", Length = "0xB8")]
		[Token(Token = "0x600240C")]
		private get { } //Length: 184
	}

	[Token(Token = "0x170004B2")]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6002404")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004B6")]
	public Version Version
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6002408")]
		 get { } //Length: 5
		[Address(RVA = "0x1F4B770", Offset = "0x1F4AB70", Length = "0x70")]
		[Token(Token = "0x6002409")]
		 set { } //Length: 112
	}

	[Address(RVA = "0x1F4AD00", Offset = "0x1F4A100", Length = "0x1D")]
	[Token(Token = "0x6002400")]
	public AssemblyName() { }

	[Address(RVA = "0x1F4AAB0", Offset = "0x1F49EB0", Length = "0x245")]
	[Token(Token = "0x6002402")]
	public AssemblyName(string assemblyName) { }

	[Address(RVA = "0x1F4AD20", Offset = "0x1F4A120", Length = "0x582")]
	[Token(Token = "0x6002403")]
	internal AssemblyName(SerializationInfo si, StreamingContext sc) { }

	[Address(RVA = "0x1F49FD0", Offset = "0x1F493D0", Length = "0xFE")]
	[Token(Token = "0x6002411")]
	public override object Clone() { }

	[Address(RVA = "0x1F4A0D0", Offset = "0x1F494D0", Length = "0x93")]
	[Token(Token = "0x600240F")]
	private Byte[] ComputePublicKeyToken() { }

	[Address(RVA = "0x1F4A170", Offset = "0x1F49570", Length = "0xE7")]
	[Token(Token = "0x6002415")]
	internal static AssemblyName Create(Assembly assembly, bool fillCodebase) { }

	[Address(RVA = "0x1F4A260", Offset = "0x1F49660", Length = "0x2CE")]
	[Token(Token = "0x6002414")]
	internal void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6002405")]
	public CultureInfo get_CultureInfo() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6002406")]
	public AssemblyNameFlags get_Flags() { }

	[Address(RVA = "0x1F4B2B0", Offset = "0x1F4A6B0", Length = "0x3E6")]
	[Token(Token = "0x6002407")]
	public string get_FullName() { }

	[Address(RVA = "0x1F4B6A0", Offset = "0x1F4AAA0", Length = "0xB8")]
	[Token(Token = "0x600240C")]
	private bool get_IsPublicKeyValid() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6002404")]
	public string get_Name() { }

	[Address(RVA = "0x1F4B760", Offset = "0x1F4AB60", Length = "0x5")]
	[Token(Token = "0x600240E")]
	private static void get_public_token(Byte* token, Byte* pubkey, int len) { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6002408")]
	public Version get_Version() { }

	[Address(RVA = "0x1F4A530", Offset = "0x1F49930", Length = "0x5")]
	[Token(Token = "0x6002413")]
	private static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr) { }

	[Address(RVA = "0x1F4A540", Offset = "0x1F49940", Length = "0x2C9")]
	[Token(Token = "0x6002410")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F4A810", Offset = "0x1F49C10", Length = "0xEF")]
	[Token(Token = "0x600240B")]
	public Byte[] GetPublicKeyToken() { }

	[Address(RVA = "0x1F4A900", Offset = "0x1F49D00", Length = "0xE4")]
	[Token(Token = "0x600240D")]
	private Byte[] InternalGetPublicKeyToken() { }

	[Address(RVA = "0x1F4A9F0", Offset = "0x1F49DF0", Length = "0x70")]
	[Token(Token = "0x6002412")]
	public override void OnDeserialization(object sender) { }

	[Address(RVA = "0x1F4AA70", Offset = "0x1F49E70", Length = "0x5")]
	[Token(Token = "0x6002401")]
	private static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined) { }

	[Address(RVA = "0x1F4B770", Offset = "0x1F4AB70", Length = "0x70")]
	[Token(Token = "0x6002409")]
	public void set_Version(Version value) { }

	[Address(RVA = "0x1F4AA80", Offset = "0x1F49E80", Length = "0x2A")]
	[Token(Token = "0x600240A")]
	public virtual string ToString() { }

}

