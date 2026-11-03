namespace TMPro;

[Token(Token = "0x200002B")]
public abstract class TMP_Asset : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000130")]
	internal string m_Version; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000131")]
	internal int m_InstanceID; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000132")]
	internal int m_HashCode; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000133")]
	internal FaceInfo m_FaceInfo; //Field offset: 0x28
	[FieldOffset(Offset = "0x88")]
	[FormerlySerializedAs("material")]
	[SerializeField]
	[Token(Token = "0x4000134")]
	internal Material m_Material; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000135")]
	internal int m_MaterialHashCode; //Field offset: 0x90

	[Token(Token = "0x17000036")]
	public FaceInfo faceInfo
	{
		[Address(RVA = "0x2EAF550", Offset = "0x2EAE950", Length = "0x33")]
		[Token(Token = "0x600014D")]
		 get { } //Length: 51
		[Address(RVA = "0x2EAF700", Offset = "0x2EAEB00", Length = "0x3A")]
		[Token(Token = "0x600014E")]
		 set { } //Length: 58
	}

	[Token(Token = "0x17000035")]
	public int hashCode
	{
		[Address(RVA = "0x2EAF590", Offset = "0x2EAE990", Length = "0x6D")]
		[Token(Token = "0x600014B")]
		 get { } //Length: 109
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[Token(Token = "0x600014C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000034")]
	public int instanceID
	{
		[Address(RVA = "0x2EAF600", Offset = "0x2EAEA00", Length = "0x28")]
		[Token(Token = "0x600014A")]
		 get { } //Length: 40
	}

	[Token(Token = "0x17000037")]
	public Material material
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x600014F")]
		 get { } //Length: 8
		[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
		[Token(Token = "0x6000150")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000038")]
	public int materialHashCode
	{
		[Address(RVA = "0x2EAF630", Offset = "0x2EAEA30", Length = "0xCA")]
		[Token(Token = "0x6000151")]
		 get { } //Length: 202
		[Address(RVA = "0x1E26130", Offset = "0x1E25530", Length = "0x7")]
		[Token(Token = "0x6000152")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000033")]
	public internal string version
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000148")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000149")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x6000153")]
	protected TMP_Asset() { }

	[Address(RVA = "0x2EAF550", Offset = "0x2EAE950", Length = "0x33")]
	[Token(Token = "0x600014D")]
	public FaceInfo get_faceInfo() { }

	[Address(RVA = "0x2EAF590", Offset = "0x2EAE990", Length = "0x6D")]
	[Token(Token = "0x600014B")]
	public int get_hashCode() { }

	[Address(RVA = "0x2EAF600", Offset = "0x2EAEA00", Length = "0x28")]
	[Token(Token = "0x600014A")]
	public int get_instanceID() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x600014F")]
	public Material get_material() { }

	[Address(RVA = "0x2EAF630", Offset = "0x2EAEA30", Length = "0xCA")]
	[Token(Token = "0x6000151")]
	public int get_materialHashCode() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000148")]
	public string get_version() { }

	[Address(RVA = "0x2EAF700", Offset = "0x2EAEB00", Length = "0x3A")]
	[Token(Token = "0x600014E")]
	public void set_faceInfo(FaceInfo value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[Token(Token = "0x600014C")]
	public void set_hashCode(int value) { }

	[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
	[Token(Token = "0x6000150")]
	public void set_material(Material value) { }

	[Address(RVA = "0x1E26130", Offset = "0x1E25530", Length = "0x7")]
	[Token(Token = "0x6000152")]
	public void set_materialHashCode(int value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000149")]
	internal void set_version(string value) { }

}

