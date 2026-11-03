namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
[Token(Token = "0x2000372")]
public class Context
{
	[ContextStatic]
	[Token(Token = "0x4000E57")]
	private static Object[] local_slots; //Field offset: 0x0
	[Token(Token = "0x4000E58")]
	private static IMessageSink default_server_context_sink; //Field offset: 0x8
	[Token(Token = "0x4000E5C")]
	private static int global_count; //Field offset: 0x10
	[Token(Token = "0x4000E5E")]
	private static LocalDataStoreMgr _localDataStoreMgr; //Field offset: 0x18
	[Token(Token = "0x4000E5F")]
	private static DynamicPropertyCollection global_dynamic_properties; //Field offset: 0x20
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E53")]
	private int domain_id; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000E54")]
	private int context_id; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E55")]
	private UIntPtr static_data; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E56")]
	private UIntPtr data; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E59")]
	private IMessageSink server_context_sink_chain; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E5A")]
	private IMessageSink client_context_sink_chain; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E5B")]
	private List<IContextProperty> context_properties; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E5D")]
	private LocalDataStoreHolder _localDataStore; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E60")]
	private DynamicPropertyCollection context_dynamic_properties; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E61")]
	private ContextCallbackObject callback_object; //Field offset: 0x50

	[Token(Token = "0x170002F3")]
	public override int ContextID
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6001B9E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170002F4")]
	public override IContextProperty[] ContextProperties
	{
		[Address(RVA = "0x1EE0480", Offset = "0x1EDF880", Length = "0x60")]
		[Token(Token = "0x6001B9F")]
		 get { } //Length: 96
	}

	[Token(Token = "0x170002F2")]
	public static Context DefaultContext
	{
		[Address(RVA = "0x1EE04E0", Offset = "0x1EDF8E0", Length = "0x7")]
		[Token(Token = "0x6001B9D")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170002F8")]
	internal bool HasDynamicSinks
	{
		[Address(RVA = "0x1EE04F0", Offset = "0x1EDF8F0", Length = "0x41")]
		[Token(Token = "0x6001BA8")]
		internal get { } //Length: 65
	}

	[Token(Token = "0x170002F9")]
	internal bool HasExitSinks
	{
		[Address(RVA = "0x1EE0540", Offset = "0x1EDF940", Length = "0x16D")]
		[Token(Token = "0x6001BA9")]
		internal get { } //Length: 365
	}

	[Token(Token = "0x170002F7")]
	internal static bool HasGlobalDynamicSinks
	{
		[Address(RVA = "0x1EE06B0", Offset = "0x1EDFAB0", Length = "0xA1")]
		[Token(Token = "0x6001BA6")]
		internal get { } //Length: 161
	}

	[Token(Token = "0x170002F5")]
	internal bool IsDefaultContext
	{
		[Address(RVA = "0x1EE0760", Offset = "0x1EDFB60", Length = "0x8")]
		[Token(Token = "0x6001BA0")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170002FA")]
	private LocalDataStore MyLocalStore
	{
		[Address(RVA = "0x1EE0770", Offset = "0x1EDFB70", Length = "0x176")]
		[Token(Token = "0x6001BB5")]
		private get { } //Length: 374
	}

	[Token(Token = "0x170002F6")]
	internal bool NeedsContextSink
	{
		[Address(RVA = "0x1EE08F0", Offset = "0x1EDFCF0", Length = "0xE5")]
		[Token(Token = "0x6001BA1")]
		internal get { } //Length: 229
	}

	[Address(RVA = "0x1EE0380", Offset = "0x1EDF780", Length = "0x78")]
	[Token(Token = "0x6001BBC")]
	private static Context() { }

	[Address(RVA = "0x1EE0400", Offset = "0x1EDF800", Length = "0x77")]
	[Token(Token = "0x6001B9B")]
	public Context() { }

	[Address(RVA = "0x1EDE550", Offset = "0x1EDD950", Length = "0x5F")]
	[Token(Token = "0x6001BB6")]
	public static LocalDataStoreSlot AllocateDataSlot() { }

	[Address(RVA = "0x1EDE5B0", Offset = "0x1EDD9B0", Length = "0x69")]
	[Token(Token = "0x6001BB7")]
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	[Address(RVA = "0x1EDE620", Offset = "0x1EDDA20", Length = "0x19F")]
	[Token(Token = "0x6001BB1")]
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	[Address(RVA = "0x1EDE7C0", Offset = "0x1EDDBC0", Length = "0x6BC")]
	[Token(Token = "0x6001BB3")]
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	[Address(RVA = "0x1EDEE80", Offset = "0x1EDE280", Length = "0x165")]
	[Token(Token = "0x6001BB0")]
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	[Address(RVA = "0x1EDEFF0", Offset = "0x1EDE3F0", Length = "0x12E")]
	[Token(Token = "0x6001BB4")]
	public void DoCallBack(CrossContextDelegate deleg) { }

	[Address(RVA = "0x1EDF120", Offset = "0x1EDE520", Length = "0x86")]
	[Token(Token = "0x6001B9C")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1EDF1B0", Offset = "0x1EDE5B0", Length = "0x69")]
	[Token(Token = "0x6001BB8")]
	public static void FreeNamedDataSlot(string name) { }

	[Address(RVA = "0x1EDF220", Offset = "0x1EDE620", Length = "0x1BC")]
	[Token(Token = "0x6001BAC")]
	public override void Freeze() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x6001B9E")]
	public override int get_ContextID() { }

	[Address(RVA = "0x1EE0480", Offset = "0x1EDF880", Length = "0x60")]
	[Token(Token = "0x6001B9F")]
	public override IContextProperty[] get_ContextProperties() { }

	[Address(RVA = "0x1EE04E0", Offset = "0x1EDF8E0", Length = "0x7")]
	[Token(Token = "0x6001B9D")]
	public static Context get_DefaultContext() { }

	[Address(RVA = "0x1EE04F0", Offset = "0x1EDF8F0", Length = "0x41")]
	[Token(Token = "0x6001BA8")]
	internal bool get_HasDynamicSinks() { }

	[Address(RVA = "0x1EE0540", Offset = "0x1EDF940", Length = "0x16D")]
	[Token(Token = "0x6001BA9")]
	internal bool get_HasExitSinks() { }

	[Address(RVA = "0x1EE06B0", Offset = "0x1EDFAB0", Length = "0xA1")]
	[Token(Token = "0x6001BA6")]
	internal static bool get_HasGlobalDynamicSinks() { }

	[Address(RVA = "0x1EE0760", Offset = "0x1EDFB60", Length = "0x8")]
	[Token(Token = "0x6001BA0")]
	internal bool get_IsDefaultContext() { }

	[Address(RVA = "0x1EE0770", Offset = "0x1EDFB70", Length = "0x176")]
	[Token(Token = "0x6001BB5")]
	private LocalDataStore get_MyLocalStore() { }

	[Address(RVA = "0x1EE08F0", Offset = "0x1EDFCF0", Length = "0xE5")]
	[Token(Token = "0x6001BA1")]
	internal bool get_NeedsContextSink() { }

	[Address(RVA = "0x1EDF3E0", Offset = "0x1EDE7E0", Length = "0x197")]
	[Token(Token = "0x6001BAF")]
	internal IMessageSink GetClientContextSinkChain() { }

	[Address(RVA = "0x1EDF580", Offset = "0x1EDE980", Length = "0x3C")]
	[Token(Token = "0x6001BBA")]
	public static object GetData(LocalDataStoreSlot slot) { }

	[Address(RVA = "0x1EDF5C0", Offset = "0x1EDE9C0", Length = "0x1AD")]
	[Token(Token = "0x6001BA4")]
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	[Address(RVA = "0x1EDF770", Offset = "0x1EDEB70", Length = "0x69")]
	[Token(Token = "0x6001BB9")]
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	[Address(RVA = "0x1EDF7E0", Offset = "0x1EDEBE0", Length = "0x171")]
	[Token(Token = "0x6001BAA")]
	public override IContextProperty GetProperty(string name) { }

	[Address(RVA = "0x1EDF960", Offset = "0x1EDED60", Length = "0x1A3")]
	[Token(Token = "0x6001BAE")]
	internal IMessageSink GetServerContextSinkChain() { }

	[Address(RVA = "0x1EDFB10", Offset = "0x1EDEF10", Length = "0x91")]
	[Token(Token = "0x6001BA7")]
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	[Address(RVA = "0x1EDFBB0", Offset = "0x1EDEFB0", Length = "0x11B")]
	[Token(Token = "0x6001BA5")]
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	[Address(RVA = "0x1EDFCD0", Offset = "0x1EDF0D0", Length = "0x5")]
	[Token(Token = "0x6001B99")]
	private static void RegisterContext(Context ctx) { }

	[Address(RVA = "0x1EDFCE0", Offset = "0x1EDF0E0", Length = "0x1F7")]
	[Token(Token = "0x6001BA2")]
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	[Address(RVA = "0x1EDFEE0", Offset = "0x1EDF2E0", Length = "0x5")]
	[Token(Token = "0x6001B9A")]
	private static void ReleaseContext(Context ctx) { }

	[Address(RVA = "0x1EDFEF0", Offset = "0x1EDF2F0", Length = "0x4B")]
	[Token(Token = "0x6001BBB")]
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	[Address(RVA = "0x1EDFF40", Offset = "0x1EDF340", Length = "0x1D9")]
	[Token(Token = "0x6001BAB")]
	public override void SetProperty(IContextProperty prop) { }

	[Address(RVA = "0x1EE0120", Offset = "0x1EDF520", Length = "0x7")]
	[Token(Token = "0x6001BB2")]
	internal static Context SwitchToContext(Context newContext) { }

	[Address(RVA = "0x1EE0130", Offset = "0x1EDF530", Length = "0x47")]
	[Token(Token = "0x6001BAD")]
	public virtual string ToString() { }

	[Address(RVA = "0x1EE0180", Offset = "0x1EDF580", Length = "0x1F7")]
	[Token(Token = "0x6001BA3")]
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

}

