namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x200034F")]
public class ObjRef : IObjectReference, ISerializable
{
	[Token(Token = "0x4000DE2")]
	private static int MarshalledObjectRef; //Field offset: 0x0
	[Token(Token = "0x4000DE3")]
	private static int WellKnowObjectRef; //Field offset: 0x4
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DDC")]
	private IChannelInfo channel_info; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000DDD")]
	private string uri; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000DDE")]
	private IRemotingTypeInfo typeInfo; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000DDF")]
	private IEnvoyInfo envoyInfo; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000DE0")]
	private int flags; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000DE1")]
	private Type _serverType; //Field offset: 0x38

	[Token(Token = "0x170002CB")]
	public override IChannelInfo ChannelInfo
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x6001A99")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002CC")]
	public override IEnvoyInfo EnvoyInfo
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6001A9A")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6001A9B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002CA")]
	internal bool IsReferenceToWellKnow
	{
		[Address(RVA = "0x1EE50A0", Offset = "0x1EE44A0", Length = "0x5A")]
		[Token(Token = "0x6001A98")]
		internal get { } //Length: 90
	}

	[Token(Token = "0x170002CF")]
	internal Type ServerType
	{
		[Address(RVA = "0x1EE5100", Offset = "0x1EE4500", Length = "0xD4")]
		[Token(Token = "0x6001AA3")]
		internal get { } //Length: 212
	}

	[Token(Token = "0x170002CD")]
	public override IRemotingTypeInfo TypeInfo
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6001A9C")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6001A9D")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002CE")]
	public override string URI
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6001A9E")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6001A9F")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1EE4970", Offset = "0x1EE3D70", Length = "0x4E")]
	[Token(Token = "0x6001AA4")]
	private static ObjRef() { }

	[Address(RVA = "0x1EE4AE0", Offset = "0x1EE3EE0", Length = "0x541")]
	[Token(Token = "0x6001A97")]
	protected ObjRef(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1EE49C0", Offset = "0x1EE3DC0", Length = "0x111")]
	[Token(Token = "0x6001A96")]
	internal ObjRef(Type type, string url, object remoteChannelData) { }

	[Address(RVA = "0x1EE5080", Offset = "0x1EE4480", Length = "0x1F")]
	[Token(Token = "0x6001A92")]
	public ObjRef() { }

	[Address(RVA = "0x1EE5030", Offset = "0x1EE4430", Length = "0x4E")]
	[Token(Token = "0x6001A93")]
	internal ObjRef(string uri, IChannelInfo cinfo) { }

	[Address(RVA = "0x1EE4480", Offset = "0x1EE3880", Length = "0x138")]
	[Token(Token = "0x6001A94")]
	internal ObjRef DeserializeInTheCurrentDomain(int domainId, Byte[] tInfo) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001A99")]
	public override IChannelInfo get_ChannelInfo() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6001A9A")]
	public override IEnvoyInfo get_EnvoyInfo() { }

	[Address(RVA = "0x1EE50A0", Offset = "0x1EE44A0", Length = "0x5A")]
	[Token(Token = "0x6001A98")]
	internal bool get_IsReferenceToWellKnow() { }

	[Address(RVA = "0x1EE5100", Offset = "0x1EE4500", Length = "0xD4")]
	[Token(Token = "0x6001AA3")]
	internal Type get_ServerType() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6001A9C")]
	public override IRemotingTypeInfo get_TypeInfo() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6001A9E")]
	public override string get_URI() { }

	[Address(RVA = "0x1EE45C0", Offset = "0x1EE39C0", Length = "0x198")]
	[Token(Token = "0x6001AA0")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1EE4760", Offset = "0x1EE3B60", Length = "0xCD")]
	[Token(Token = "0x6001AA1")]
	public override object GetRealObject(StreamingContext context) { }

	[Address(RVA = "0x1EE4830", Offset = "0x1EE3C30", Length = "0x8D")]
	[Token(Token = "0x6001A95")]
	internal Byte[] SerializeType() { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6001A9B")]
	public override void set_EnvoyInfo(IEnvoyInfo value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6001A9D")]
	public override void set_TypeInfo(IRemotingTypeInfo value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6001A9F")]
	public override void set_URI(string value) { }

	[Address(RVA = "0x1EE48C0", Offset = "0x1EE3CC0", Length = "0xA4")]
	[Token(Token = "0x6001AA2")]
	internal void UpdateChannelInfo() { }

}

