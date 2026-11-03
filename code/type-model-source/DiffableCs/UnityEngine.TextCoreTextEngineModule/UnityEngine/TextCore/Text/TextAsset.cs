namespace UnityEngine.TextCore.Text;

[ExcludeFromObjectFactory]
[Token(Token = "0x200003A")]
public abstract class TextAsset : ScriptableObject
{
	[Token(Token = "0x4000190")]
	private static Dictionary<Int32, WeakReference`1<TextAsset>> kTextAssetByInstanceId; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400018B")]
	internal string m_Version; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400018C")]
	internal int m_InstanceID; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400018D")]
	internal int m_HashCode; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("material")]
	[SerializeField]
	[Token(Token = "0x400018E")]
	internal Material m_Material; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400018F")]
	internal int m_MaterialHashCode; //Field offset: 0x30

	[Token(Token = "0x1700003D")]
	public int hashCode
	{
		[Address(RVA = "0x31B2B00", Offset = "0x31B1F00", Length = "0x32")]
		[Token(Token = "0x6000178")]
		 get { } //Length: 50
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[Token(Token = "0x6000179")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700003C")]
	public int instanceID
	{
		[Address(RVA = "0x2EAF600", Offset = "0x2EAEA00", Length = "0x28")]
		[Token(Token = "0x6000177")]
		 get { } //Length: 40
	}

	[Token(Token = "0x1700003E")]
	public Material material
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600017A")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x600017B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700003F")]
	public int materialHashCode
	{
		[Address(RVA = "0x31B2B40", Offset = "0x31B1F40", Length = "0x92")]
		[Token(Token = "0x600017C")]
		 get { } //Length: 146
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[Token(Token = "0x600017D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700003B")]
	public internal string version
	{
		[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
		[Token(Token = "0x6000175")]
		 get { } //Length: 7
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000176")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x31B2A70", Offset = "0x31B1E70", Length = "0x84")]
	[Token(Token = "0x6000182")]
	private static TextAsset() { }

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x6000181")]
	protected TextAsset() { }

	[Address(RVA = "0x31B2B00", Offset = "0x31B1F00", Length = "0x32")]
	[Token(Token = "0x6000178")]
	public int get_hashCode() { }

	[Address(RVA = "0x2EAF600", Offset = "0x2EAEA00", Length = "0x28")]
	[Token(Token = "0x6000177")]
	public int get_instanceID() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x600017A")]
	public Material get_material() { }

	[Address(RVA = "0x31B2B40", Offset = "0x31B1F40", Length = "0x92")]
	[Token(Token = "0x600017C")]
	public int get_materialHashCode() { }

	[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
	[Token(Token = "0x6000175")]
	public string get_version() { }

	[Address(RVA = "0x31B2810", Offset = "0x31B1C10", Length = "0xC7")]
	[Token(Token = "0x600017E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static TextAsset GetTextAssetByID(int id) { }

	[Address(RVA = "0x31B28E0", Offset = "0x31B1CE0", Length = "0x97")]
	[Token(Token = "0x600017F")]
	internal override void OnDestroy() { }

	[Address(RVA = "0x31B2980", Offset = "0x31B1D80", Length = "0xE9")]
	[Token(Token = "0x6000180")]
	internal override void OnEnable() { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[Token(Token = "0x6000179")]
	public void set_hashCode(int value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x600017B")]
	public void set_material(Material value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[Token(Token = "0x600017D")]
	public void set_materialHashCode(int value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000176")]
	internal void set_version(string value) { }

}

