namespace System.Reflection;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_Assembly))]
[ComVisible(True)]
[Token(Token = "0x2000516")]
internal class RuntimeAssembly : Assembly
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400145D")]
	internal IntPtr _mono_assembly; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400145E")]
	private object _evidence; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400145F")]
	internal ResolveEventHolder resolve_event_holder; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001460")]
	private object _minimum; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001461")]
	private object _optional; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001462")]
	private object _refuse; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001463")]
	private object _granted; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001464")]
	private object _denied; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001465")]
	internal bool fromByteArray; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001466")]
	internal string assemblyName; //Field offset: 0x58

	[Token(Token = "0x170004BC")]
	public virtual string CodeBase
	{
		[Address(RVA = "0x1F63D70", Offset = "0x1F63170", Length = "0x7")]
		[Token(Token = "0x600243D")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170004BD")]
	public virtual string FullName
	{
		[Address(RVA = "0x1F63D80", Offset = "0x1F63180", Length = "0x5")]
		[Token(Token = "0x600243E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004BF")]
	public virtual string Location
	{
		[Address(RVA = "0x1F63D90", Offset = "0x1F63190", Length = "0x1C")]
		[Token(Token = "0x6002440")]
		 get { } //Length: 28
	}

	[Token(Token = "0x170004BE")]
	internal virtual IntPtr MonoAssembly
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600243F")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x1F63D00", Offset = "0x1F63100", Length = "0x66")]
	[Token(Token = "0x600242E")]
	protected RuntimeAssembly() { }

	[Address(RVA = "0x1F63380", Offset = "0x1F62780", Length = "0xBA")]
	[Token(Token = "0x6002447")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x1F63490", Offset = "0x1F62890", Length = "0x5")]
	[Token(Token = "0x6002438")]
	private static string get_code_base(Assembly a, bool escaped) { }

	[Address(RVA = "0x1F63D70", Offset = "0x1F63170", Length = "0x7")]
	[Token(Token = "0x600243D")]
	public virtual string get_CodeBase() { }

	[Address(RVA = "0x1F63D80", Offset = "0x1F63180", Length = "0x5")]
	[Token(Token = "0x600243A")]
	internal static string get_fullname(Assembly a) { }

	[Address(RVA = "0x1F63D80", Offset = "0x1F63180", Length = "0x5")]
	[Token(Token = "0x600243E")]
	public virtual string get_FullName() { }

	[Address(RVA = "0x1F63DB0", Offset = "0x1F631B0", Length = "0x5")]
	[Token(Token = "0x6002439")]
	private string get_location() { }

	[Address(RVA = "0x1F63D90", Offset = "0x1F63190", Length = "0x1C")]
	[Token(Token = "0x6002440")]
	public virtual string get_Location() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600243F")]
	internal virtual IntPtr get_MonoAssembly() { }

	[Address(RVA = "0x1F63440", Offset = "0x1F62840", Length = "0x4F")]
	[Token(Token = "0x6002437")]
	internal static Byte[] GetAotId() { }

	[Address(RVA = "0x1E5F020", Offset = "0x1E5E420", Length = "0x5")]
	[Token(Token = "0x600243B")]
	internal static bool GetAotIdInternal(Byte[] aotid) { }

	[Address(RVA = "0x1F63490", Offset = "0x1F62890", Length = "0x5")]
	[Token(Token = "0x600243C")]
	internal static string GetCodeBase(Assembly a, bool escaped) { }

	[Address(RVA = "0x1F634A0", Offset = "0x1F628A0", Length = "0x59")]
	[Token(Token = "0x6002443")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F63500", Offset = "0x1F62900", Length = "0x6B")]
	[Token(Token = "0x6002444")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1E9E150", Offset = "0x1E9D550", Length = "0x7")]
	[Token(Token = "0x6002446")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1F63570", Offset = "0x1F62970", Length = "0x5")]
	[Token(Token = "0x6002441")]
	internal IntPtr GetManifestResourceInternal(string name, out int size, out Module module) { }

	[Address(RVA = "0x1F63580", Offset = "0x1F62980", Length = "0x16B")]
	[Token(Token = "0x6002434")]
	public virtual Module GetModule(string name) { }

	[Address(RVA = "0x1F63700", Offset = "0x1F62B00", Length = "0x137")]
	[Token(Token = "0x6002436")]
	public virtual Module[] GetModules(bool getResourceModules) { }

	[Address(RVA = "0x1F636F0", Offset = "0x1F62AF0", Length = "0x5")]
	[Token(Token = "0x6002445")]
	internal virtual Module[] GetModulesInternal() { }

	[Address(RVA = "0x1F63840", Offset = "0x1F62C40", Length = "0xCD")]
	[Token(Token = "0x6002432")]
	public virtual AssemblyName GetName(bool copiedName) { }

	[Address(RVA = "0x1F63910", Offset = "0x1F62D10", Length = "0x97")]
	[Token(Token = "0x600242F")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F639B0", Offset = "0x1F62DB0", Length = "0x7")]
	[Token(Token = "0x6002435")]
	public virtual AssemblyName[] GetReferencedAssemblies() { }

	[Address(RVA = "0x1F639C0", Offset = "0x1F62DC0", Length = "0xC9")]
	[Token(Token = "0x6002433")]
	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	[Address(RVA = "0x1F63A90", Offset = "0x1F62E90", Length = "0x6B")]
	[Token(Token = "0x6002442")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F63B00", Offset = "0x1F62F00", Length = "0xE1")]
	[Token(Token = "0x6002431")]
	internal static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x1F63BF0", Offset = "0x1F62FF0", Length = "0xBE")]
	[Token(Token = "0x6002430")]
	internal static RuntimeAssembly LoadWithPartialNameInternal(string partialName, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x1F63CB0", Offset = "0x1F630B0", Length = "0x47")]
	[Token(Token = "0x6002448")]
	public virtual string ToString() { }

}

