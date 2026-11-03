namespace System;

[ClassInterface(ClassInterfaceType::None (0))]
[ComVisible(True)]
[Token(Token = "0x200019D")]
public sealed class AppDomain : MarshalByRefObject
{
	[ThreadStatic]
	[Token(Token = "0x400066E")]
	private static Dictionary<String, Object> type_resolve_in_progress; //Field offset: 0x80000000
	[ThreadStatic]
	[Token(Token = "0x400066F")]
	private static Dictionary<String, Object> assembly_resolve_in_progress; //Field offset: 0x80000008
	[ThreadStatic]
	[Token(Token = "0x4000670")]
	private static Dictionary<String, Object> assembly_resolve_in_progress_refonly; //Field offset: 0x80000010
	[Token(Token = "0x400066D")]
	private static string _process_guid; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400066C")]
	private IntPtr _mono_app_domain; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000671")]
	private object _evidence; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000672")]
	private object _granted; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000673")]
	private int _principalPolicy; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000674")]
	private AssemblyLoadEventHandler AssemblyLoad; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000675")]
	private ResolveEventHandler AssemblyResolve; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000676")]
	private EventHandler DomainUnload; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000677")]
	private EventHandler ProcessExit; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000678")]
	private ResolveEventHandler ResourceResolve; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000679")]
	private ResolveEventHandler TypeResolve; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400067A")]
	private UnhandledExceptionEventHandler UnhandledException; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400067B")]
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400067C")]
	private object _domain_manager; //Field offset: 0x78
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400067D")]
	private ResolveEventHandler ReflectionOnlyAssemblyResolve; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400067E")]
	private object _activation; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400067F")]
	private object _applicationIdentity; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000680")]
	private List<String> compatibility_switch; //Field offset: 0x98

	[Token(Token = "0x14000003")]
	public override event EventHandler DomainUnload
	{
		[Address(RVA = "0x207A9C0", Offset = "0x2079DC0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000F31")]
		 add { } //Length: 158
		[Address(RVA = "0x207AB20", Offset = "0x2079F20", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000F32")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000004")]
	public override event UnhandledExceptionEventHandler UnhandledException
	{
		[Address(RVA = "0x207AA60", Offset = "0x2079E60", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000F33")]
		 add { } //Length: 158
		[Address(RVA = "0x207ABC0", Offset = "0x2079FC0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000F34")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000146")]
	public static AppDomain CurrentDomain
	{
		[Address(RVA = "0x207AB00", Offset = "0x2079F00", Length = "0x5")]
		[Token(Token = "0x6000F15")]
		 get { } //Length: 5
	}

	[MonoTODO]
	[Token(Token = "0x17000148")]
	public bool IsFullyTrusted
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000F36")]
		 get { } //Length: 3
	}

	[MonoTODO]
	[Token(Token = "0x17000147")]
	public bool IsHomogenous
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000F35")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F12")]
	private AppDomain() { }

	[Address(RVA = "0x207A9C0", Offset = "0x2079DC0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000F31")]
	public override void add_DomainUnload(EventHandler value) { }

	[Address(RVA = "0x207AA60", Offset = "0x2079E60", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000F33")]
	public override void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[Address(RVA = "0x2079AE0", Offset = "0x2078EE0", Length = "0x88")]
	[Token(Token = "0x6000F2B")]
	private void DoAssemblyLoad(Assembly assembly) { }

	[Address(RVA = "0x2079B70", Offset = "0x2078F70", Length = "0x38C")]
	[Token(Token = "0x6000F2C")]
	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	[Address(RVA = "0x2079F00", Offset = "0x2079300", Length = "0x21")]
	[Token(Token = "0x6000F2E")]
	private void DoDomainUnload() { }

	[Address(RVA = "0x2079F30", Offset = "0x2079330", Length = "0x318")]
	[Token(Token = "0x6000F2D")]
	internal Assembly DoTypeResolve(string name) { }

	[Address(RVA = "0x207AB00", Offset = "0x2079F00", Length = "0x5")]
	[Token(Token = "0x6000F15")]
	public static AppDomain get_CurrentDomain() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000F36")]
	public bool get_IsFullyTrusted() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000F35")]
	public bool get_IsHomogenous() { }

	[Address(RVA = "0x207A250", Offset = "0x2079650", Length = "0x7")]
	[Token(Token = "0x6000F17")]
	public override Assembly[] GetAssemblies() { }

	[Address(RVA = "0x207A260", Offset = "0x2079660", Length = "0x5")]
	[Token(Token = "0x6000F16")]
	private Assembly[] GetAssemblies(bool refOnly) { }

	[Address(RVA = "0x207AB00", Offset = "0x2079F00", Length = "0x5")]
	[Token(Token = "0x6000F14")]
	private static AppDomain getCurDomain() { }

	[Address(RVA = "0x207A270", Offset = "0x2079670", Length = "0x5")]
	[Token(Token = "0x6000F18")]
	public override object GetData(string name) { }

	[Address(RVA = "0x207AB10", Offset = "0x2079F10", Length = "0x7")]
	[Token(Token = "0x6000F29")]
	private int getDomainID() { }

	[Address(RVA = "0x207A9B0", Offset = "0x2079DB0", Length = "0x5")]
	[Token(Token = "0x6000F13")]
	private string getFriendlyName() { }

	[Address(RVA = "0x207A280", Offset = "0x2079680", Length = "0xBD")]
	[Token(Token = "0x6000F2F")]
	internal Byte[] GetMarshalledDomainObjRef() { }

	[Address(RVA = "0x207A340", Offset = "0x2079740", Length = "0xA1")]
	[Token(Token = "0x6000F26")]
	internal static string GetProcessGuid() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000F19")]
	public virtual object InitializeLifetimeService() { }

	[Address(RVA = "0x207A3F0", Offset = "0x20797F0", Length = "0x5")]
	[Token(Token = "0x6000F22")]
	internal static Context InternalGetContext() { }

	[Address(RVA = "0x207A3F0", Offset = "0x20797F0", Length = "0x5")]
	[Token(Token = "0x6000F23")]
	internal static Context InternalGetDefaultContext() { }

	[Address(RVA = "0x207A400", Offset = "0x2079800", Length = "0x5")]
	[Token(Token = "0x6000F24")]
	internal static string InternalGetProcessGuid(string newguid) { }

	[Address(RVA = "0x1E5F020", Offset = "0x1E5E420", Length = "0x5")]
	[Token(Token = "0x6000F27")]
	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	[Address(RVA = "0x207A410", Offset = "0x2079810", Length = "0x5")]
	[Token(Token = "0x6000F20")]
	internal static void InternalPopDomainRef() { }

	[Address(RVA = "0x207A420", Offset = "0x2079820", Length = "0x5")]
	[Token(Token = "0x6000F1F")]
	internal static void InternalPushDomainRefByID(int domain_id) { }

	[Address(RVA = "0x207A430", Offset = "0x2079830", Length = "0x5")]
	[Token(Token = "0x6000F21")]
	internal static Context InternalSetContext(Context context) { }

	[Address(RVA = "0x207A450", Offset = "0x2079850", Length = "0x5")]
	[Token(Token = "0x6000F1E")]
	private static AppDomain InternalSetDomain(AppDomain context) { }

	[Address(RVA = "0x207A440", Offset = "0x2079840", Length = "0x5")]
	[Token(Token = "0x6000F1D")]
	private static AppDomain InternalSetDomainByID(int domain_id) { }

	[Address(RVA = "0x207A460", Offset = "0x2079860", Length = "0x184")]
	[Token(Token = "0x6000F25")]
	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, Object[] args) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Intrinsic]
	[Token(Token = "0x6000F11")]
	internal static bool IsAppXModel() { }

	[Address(RVA = "0x207A5F0", Offset = "0x20799F0", Length = "0x16")]
	[Token(Token = "0x6000F28")]
	public bool IsFinalizingForUnload() { }

	[Address(RVA = "0x207A620", Offset = "0x2079A20", Length = "0x11D")]
	[Token(Token = "0x6000F1C")]
	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x207A740", Offset = "0x2079B40", Length = "0x12B")]
	[Token(Token = "0x6000F1B")]
	public override Assembly Load(string assemblyString) { }

	[Address(RVA = "0x207A610", Offset = "0x2079A10", Length = "0x5")]
	[Token(Token = "0x6000F1A")]
	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x207A870", Offset = "0x2079C70", Length = "0x138")]
	[Token(Token = "0x6000F30")]
	internal void ProcessMessageInDomain(Byte[] arrRequest, CADMethodCallMessage cadMsg, out Byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[Address(RVA = "0x207AB20", Offset = "0x2079F20", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000F32")]
	public override void remove_DomainUnload(EventHandler value) { }

	[Address(RVA = "0x207ABC0", Offset = "0x2079FC0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000F34")]
	public override void remove_UnhandledException(UnhandledExceptionEventHandler value) { }

	[Address(RVA = "0x207A9B0", Offset = "0x2079DB0", Length = "0x5")]
	[Token(Token = "0x6000F2A")]
	public virtual string ToString() { }

}

