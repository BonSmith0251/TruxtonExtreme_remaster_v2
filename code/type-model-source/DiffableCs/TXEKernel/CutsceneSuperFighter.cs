//Type is in global namespace

[Token(Token = "0x2000002")]
public class CutsceneSuperFighter : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	internal enum MaterialType : int
	{
		Black = 0,
		Blue = 1,
		Gold = 2,
		Green = 3,
		Red = 4,
		Silver = 5,
	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000001")]
	private GameObject _superFighterPrefab; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000002")]
	private List<Material> _materials; //Field offset: 0x28

	[Address(RVA = "0x26D2C90", Offset = "0x26D2090", Length = "0x77")]
	[Token(Token = "0x6000004")]
	public CutsceneSuperFighter() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000001")]
	private void Awake() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000002")]
	public void Initialize() { }

	[Address(RVA = "0x26D2BD0", Offset = "0x26D1FD0", Length = "0xBF")]
	[Token(Token = "0x6000003")]
	public void ResetMaterial(MaterialType type) { }

}

