namespace UnityEngine.AddressableAssets.ResourceLocators;

[Token(Token = "0x200005A")]
public class ResourceLocationData
{
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("m_keys")]
	[SerializeField]
	[Token(Token = "0x400013F")]
	private String[] m_Keys; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("m_internalId")]
	[SerializeField]
	[Token(Token = "0x4000140")]
	private string m_InternalId; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_provider")]
	[SerializeField]
	[Token(Token = "0x4000141")]
	private string m_Provider; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_dependencies")]
	[SerializeField]
	[Token(Token = "0x4000142")]
	private String[] m_Dependencies; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000143")]
	private SerializedType m_ResourceType; //Field offset: 0x30
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000144")]
	private Byte[] SerializedData; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000145")]
	private object _Data; //Field offset: 0x58

	[Token(Token = "0x17000061")]
	public object Data
	{
		[Address(RVA = "0x27B00E0", Offset = "0x27AF4E0", Length = "0x51")]
		[Token(Token = "0x6000235")]
		 get { } //Length: 81
		[Address(RVA = "0x27B0150", Offset = "0x27AF550", Length = "0xAD")]
		[Token(Token = "0x6000236")]
		 set { } //Length: 173
	}

	[Token(Token = "0x1700005F")]
	public String[] Dependencies
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000233")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005D")]
	public string InternalId
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000231")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005C")]
	public String[] Keys
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000230")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005E")]
	public string Provider
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000232")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000060")]
	public Type ResourceType
	{
		[Address(RVA = "0x27B0140", Offset = "0x27AF540", Length = "0xB")]
		[Token(Token = "0x6000234")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x27AFF80", Offset = "0x27AF380", Length = "0x15B")]
	[Token(Token = "0x6000237")]
	public ResourceLocationData(String[] keys, string id, Type provider, Type t, String[] dependencies = null) { }

	[Address(RVA = "0x27B00E0", Offset = "0x27AF4E0", Length = "0x51")]
	[Token(Token = "0x6000235")]
	public object get_Data() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000233")]
	public String[] get_Dependencies() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000231")]
	public string get_InternalId() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000230")]
	public String[] get_Keys() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000232")]
	public string get_Provider() { }

	[Address(RVA = "0x27B0140", Offset = "0x27AF540", Length = "0xB")]
	[Token(Token = "0x6000234")]
	public Type get_ResourceType() { }

	[Address(RVA = "0x27B0150", Offset = "0x27AF550", Length = "0xAD")]
	[Token(Token = "0x6000236")]
	public void set_Data(object value) { }

}

