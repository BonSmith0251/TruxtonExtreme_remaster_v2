namespace UnityEngine.Tilemaps;

[HelpURL("https://docs.unity3d.com/Manual/Tilemap-TileAsset.html")]
[RequiredByNativeCode]
[Token(Token = "0x2000003")]
public class Tile : TileBase
{
	[Token(Token = "0x2000004")]
	internal enum ColliderType : int
	{
		None = 0,
		Sprite = 1,
		Grid = 2,
	}

	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000006")]
	private Sprite m_Sprite; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000007")]
	private Color m_Color; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000008")]
	private Matrix4x4 m_Transform; //Field offset: 0x30
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000009")]
	private GameObject m_InstancedGameObject; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x400000A")]
	private TileFlags m_Flags; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x400000B")]
	private ColliderType m_ColliderType; //Field offset: 0x7C

	[Token(Token = "0x17000006")]
	public ColliderType colliderType
	{
		[Address(RVA = "0x31D0540", Offset = "0x31CF940", Length = "0x6")]
		[Token(Token = "0x6000010")]
		 get { } //Length: 6
		[Address(RVA = "0x1D16670", Offset = "0x1D15A70", Length = "0x4")]
		[Token(Token = "0x6000011")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000002")]
	public Color color
	{
		[Address(RVA = "0x31D0550", Offset = "0x31CF950", Length = "0xB")]
		[Token(Token = "0x6000008")]
		 get { } //Length: 11
		[Address(RVA = "0x1E523A0", Offset = "0x1E517A0", Length = "0x8")]
		[Token(Token = "0x6000009")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000005")]
	public TileFlags flags
	{
		[Address(RVA = "0x30D0FD0", Offset = "0x30D03D0", Length = "0x6")]
		[Token(Token = "0x600000E")]
		 get { } //Length: 6
		[Address(RVA = "0x1D16090", Offset = "0x1D15490", Length = "0x4")]
		[Token(Token = "0x600000F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000004")]
	public GameObject gameObject
	{
		[Address(RVA = "0x2F94520", Offset = "0x2F93920", Length = "0x7")]
		[Token(Token = "0x600000C")]
		 get { } //Length: 7
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[Token(Token = "0x600000D")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000001")]
	public Sprite sprite
	{
		[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
		[Token(Token = "0x6000006")]
		 get { } //Length: 7
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000007")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000003")]
	public Matrix4x4 transform
	{
		[Address(RVA = "0x31D0560", Offset = "0x31CF960", Length = "0x23")]
		[Token(Token = "0x600000A")]
		 get { } //Length: 35
		[Address(RVA = "0x31D0590", Offset = "0x31CF990", Length = "0x20")]
		[Token(Token = "0x600000B")]
		 set { } //Length: 32
	}

	[Address(RVA = "0x31D04C0", Offset = "0x31CF8C0", Length = "0x7C")]
	[Token(Token = "0x6000013")]
	public Tile() { }

	[Address(RVA = "0x31D0540", Offset = "0x31CF940", Length = "0x6")]
	[Token(Token = "0x6000010")]
	public ColliderType get_colliderType() { }

	[Address(RVA = "0x31D0550", Offset = "0x31CF950", Length = "0xB")]
	[Token(Token = "0x6000008")]
	public Color get_color() { }

	[Address(RVA = "0x30D0FD0", Offset = "0x30D03D0", Length = "0x6")]
	[Token(Token = "0x600000E")]
	public TileFlags get_flags() { }

	[Address(RVA = "0x2F94520", Offset = "0x2F93920", Length = "0x7")]
	[Token(Token = "0x600000C")]
	public GameObject get_gameObject() { }

	[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
	[Token(Token = "0x6000006")]
	public Sprite get_sprite() { }

	[Address(RVA = "0x31D0560", Offset = "0x31CF960", Length = "0x23")]
	[Token(Token = "0x600000A")]
	public Matrix4x4 get_transform() { }

	[Address(RVA = "0x31D0360", Offset = "0x31CF760", Length = "0x153")]
	[Token(Token = "0x6000012")]
	public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	[Address(RVA = "0x1D16670", Offset = "0x1D15A70", Length = "0x4")]
	[Token(Token = "0x6000011")]
	public void set_colliderType(ColliderType value) { }

	[Address(RVA = "0x1E523A0", Offset = "0x1E517A0", Length = "0x8")]
	[Token(Token = "0x6000009")]
	public void set_color(Color value) { }

	[Address(RVA = "0x1D16090", Offset = "0x1D15490", Length = "0x4")]
	[Token(Token = "0x600000F")]
	public void set_flags(TileFlags value) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[Token(Token = "0x600000D")]
	public void set_gameObject(GameObject value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000007")]
	public void set_sprite(Sprite value) { }

	[Address(RVA = "0x31D0590", Offset = "0x31CF990", Length = "0x20")]
	[Token(Token = "0x600000B")]
	public void set_transform(Matrix4x4 value) { }

}

