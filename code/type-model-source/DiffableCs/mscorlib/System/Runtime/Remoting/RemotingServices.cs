namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x2000356")]
public static class RemotingServices
{
	[Token(Token = "0x2000357")]
	private class CACD
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000E0D")]
		public object d; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000E0E")]
		public object c; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001B06")]
		public CACD() { }

	}

	[Token(Token = "0x4000E05")]
	private static Hashtable uri_hash; //Field offset: 0x0
	[Token(Token = "0x4000E06")]
	private static BinaryFormatter _serializationFormatter; //Field offset: 0x8
	[Token(Token = "0x4000E07")]
	private static BinaryFormatter _deserializationFormatter; //Field offset: 0x10
	[Token(Token = "0x4000E08")]
	private static string app_id; //Field offset: 0x18
	[Token(Token = "0x4000E09")]
	private static readonly object app_id_lock; //Field offset: 0x20
	[Token(Token = "0x4000E0A")]
	private static int next_id; //Field offset: 0x28
	[Token(Token = "0x4000E0B")]
	private static readonly MethodInfo FieldSetterMethod; //Field offset: 0x30
	[Token(Token = "0x4000E0C")]
	private static readonly MethodInfo FieldGetterMethod; //Field offset: 0x38

	[Address(RVA = "0x1EEE630", Offset = "0x1EEDA30", Length = "0x395")]
	[Token(Token = "0x6001ADC")]
	private static RemotingServices() { }

	[Address(RVA = "0x1EEA4D0", Offset = "0x1EE98D0", Length = "0xEA")]
	[ComVisible(True)]
	[Token(Token = "0x6001AE2")]
	public static object Connect(Type classToProxy, string url, object data) { }

	[Address(RVA = "0x1EEA5C0", Offset = "0x1EE99C0", Length = "0xDD")]
	[ComVisible(True)]
	[Token(Token = "0x6001AE1")]
	public static object Connect(Type classToProxy, string url) { }

	[Address(RVA = "0x1EEA6A0", Offset = "0x1EE9AA0", Length = "0xAC")]
	[Token(Token = "0x6001AF8")]
	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	[Address(RVA = "0x1EEAB20", Offset = "0x1EE9F20", Length = "0x122")]
	[Token(Token = "0x6001AF1")]
	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	[Address(RVA = "0x1EEAC50", Offset = "0x1EEA050", Length = "0x10B")]
	[Token(Token = "0x6001AEF")]
	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, Object[] activationAttributes) { }

	[Address(RVA = "0x1EEA8F0", Offset = "0x1EE9CF0", Length = "0x225")]
	[Token(Token = "0x6001AF0")]
	internal static object CreateClientProxy(Type objectType, string url, Object[] activationAttributes) { }

	[Address(RVA = "0x1EEA750", Offset = "0x1EE9B50", Length = "0x192")]
	[Token(Token = "0x6001AF2")]
	internal static object CreateClientProxyForContextBound(Type type, Object[] activationAttributes) { }

	[Address(RVA = "0x1EEAD60", Offset = "0x1EEA160", Length = "0xF7")]
	[Token(Token = "0x6001AF7")]
	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	[Address(RVA = "0x1EEAE60", Offset = "0x1EEA260", Length = "0x122")]
	[Token(Token = "0x6001AF9")]
	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	[Address(RVA = "0x1EEAF90", Offset = "0x1EEA390", Length = "0x26A")]
	[Token(Token = "0x6001AFE")]
	internal static object DeserializeCallData(Byte[] array) { }

	[Address(RVA = "0x1EEB200", Offset = "0x1EEA600", Length = "0x252")]
	[Token(Token = "0x6001B01")]
	internal static void DisposeIdentity(Identity ident) { }

	[Address(RVA = "0x1EEB460", Offset = "0x1EEA860", Length = "0x139")]
	[Token(Token = "0x6001AEC")]
	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	[Address(RVA = "0x1EEB5A0", Offset = "0x1EEA9A0", Length = "0x128")]
	[Token(Token = "0x6001AF6")]
	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	[Address(RVA = "0x1EEB6D0", Offset = "0x1EEAAD0", Length = "0x34E")]
	[Token(Token = "0x6001AF3")]
	internal static Identity GetIdentityForUri(string uri) { }

	[Address(RVA = "0x1EEBA20", Offset = "0x1EEAE20", Length = "0x348")]
	[Token(Token = "0x6001B02")]
	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	[Address(RVA = "0x1EEBD70", Offset = "0x1EEB170", Length = "0x1F3")]
	[Token(Token = "0x6001AEA")]
	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	[Address(RVA = "0x1EEBF70", Offset = "0x1EEB370", Length = "0x1EA")]
	[Token(Token = "0x6001AEB")]
	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	[Address(RVA = "0x1EEC160", Offset = "0x1EEB560", Length = "0x63")]
	[Token(Token = "0x6001B05")]
	private static string GetNormalizedUri(string uri) { }

	[Address(RVA = "0x1EEC1D0", Offset = "0x1EEB5D0", Length = "0xA4")]
	[Token(Token = "0x6001AED")]
	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1EEC280", Offset = "0x1EEB680", Length = "0x83F")]
	[Token(Token = "0x6001AF5")]
	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	[Address(RVA = "0x1EECAC0", Offset = "0x1EEBEC0", Length = "0xF5")]
	[Token(Token = "0x6001AFB")]
	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	[Address(RVA = "0x1EECBC0", Offset = "0x1EEBFC0", Length = "0x47")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001AE9")]
	public static RealProxy GetRealProxy(object proxy) { }

	[Address(RVA = "0x1EECC10", Offset = "0x1EEC010", Length = "0x6D")]
	[Token(Token = "0x6001AFC")]
	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	[Address(RVA = "0x1EECC80", Offset = "0x1EEC080", Length = "0x93")]
	[Token(Token = "0x6001AE3")]
	public static Type GetServerTypeForUri(string URI) { }

	[Address(RVA = "0x1EECD20", Offset = "0x1EEC120", Length = "0x5")]
	[Token(Token = "0x6001ADE")]
	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	[Address(RVA = "0x1EED4B0", Offset = "0x1EEC8B0", Length = "0x5")]
	[Token(Token = "0x6001ADD")]
	internal static object InternalExecute(MethodBase method, object obj, Object[] parameters, out Object[] out_args) { }

	[Address(RVA = "0x1EECD30", Offset = "0x1EEC130", Length = "0x777")]
	[Token(Token = "0x6001AE0")]
	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	[Address(RVA = "0x1EED4C0", Offset = "0x1EEC8C0", Length = "0x80")]
	[Token(Token = "0x6001AEE")]
	public static bool IsOneWay(MethodBase method) { }

	[Address(RVA = "0x1EED550", Offset = "0x1EEC950", Length = "0x3E")]
	[Token(Token = "0x6001ADF")]
	public static bool IsTransparentProxy(object proxy) { }

	[Address(RVA = "0x1EED590", Offset = "0x1EEC990", Length = "0x6B")]
	[Token(Token = "0x6001AE7")]
	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	[Address(RVA = "0x1EED600", Offset = "0x1EECA00", Length = "0x41")]
	[Token(Token = "0x6001AE6")]
	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	[Address(RVA = "0x1EED650", Offset = "0x1EECA50", Length = "0x347")]
	[Token(Token = "0x6001AE8")]
	private static string NewUri() { }

	[Address(RVA = "0x1EED9A0", Offset = "0x1EECDA0", Length = "0x40")]
	[Token(Token = "0x6001B00")]
	private static void RegisterInternalChannels() { }

	[Address(RVA = "0x1EED9E0", Offset = "0x1EECDE0", Length = "0x20C")]
	[Token(Token = "0x6001AFA")]
	private static void RegisterServerIdentity(ServerIdentity identity) { }

	[Address(RVA = "0x1EEDBF0", Offset = "0x1EECFF0", Length = "0xF6")]
	[Token(Token = "0x6001AF4")]
	private static string RemoveAppNameFromUri(string uri) { }

	[Address(RVA = "0x1EEDCF0", Offset = "0x1EED0F0", Length = "0x25F")]
	[Token(Token = "0x6001AFD")]
	internal static Byte[] SerializeCallData(object obj) { }

	[Address(RVA = "0x1EEDF50", Offset = "0x1EED350", Length = "0xE7")]
	[Token(Token = "0x6001AFF")]
	internal static Byte[] SerializeExceptionData(Exception ex) { }

	[Address(RVA = "0x1EEE040", Offset = "0x1EED440", Length = "0xB9")]
	[Token(Token = "0x6001B03")]
	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	[Address(RVA = "0x1EEE150", Offset = "0x1EED550", Length = "0x365")]
	[Token(Token = "0x6001AE5")]
	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	[Address(RVA = "0x1EEE100", Offset = "0x1EED500", Length = "0x4C")]
	[Token(Token = "0x6001AE4")]
	public static object Unmarshal(ObjRef objectRef) { }

	[Address(RVA = "0x1EEE4C0", Offset = "0x1EED8C0", Length = "0x163")]
	[Token(Token = "0x6001B04")]
	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

}

