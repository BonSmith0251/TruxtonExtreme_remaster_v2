namespace OutGame.UI;

[Token(Token = "0x2000118")]
public class GalleryModelBase : MonoBehaviour
{
	[Token(Token = "0x2000119")]
	internal class ColorData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004B2")]
		public GameObject[] target; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004B3")]
		public String[] meshName; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004B4")]
		public Material[] material; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600070C")]
		public ColorData() { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40004AE")]
	private GameObject[] _damageObject; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40004AF")]
	private List<ColorData> _colorChangeData; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004B0")]
	private int _maxColor; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40004B1")]
	private int _nowColor; //Field offset: 0x34

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600070B")]
	public GalleryModelBase() { }

	[Address(RVA = "0x21EA7F0", Offset = "0x21E9BF0", Length = "0x8")]
	[Token(Token = "0x6000708")]
	public bool CanColorChange() { }

	[Address(RVA = "0x21EAD80", Offset = "0x21EA180", Length = "0x1C")]
	[Token(Token = "0x6000709")]
	public void nextColor() { }

	[Address(RVA = "0x21EA800", Offset = "0x21E9C00", Length = "0x2E5")]
	[Token(Token = "0x600070A")]
	public void SetColor(int color) { }

	[Address(RVA = "0x21EAAF0", Offset = "0x21E9EF0", Length = "0x281")]
	[Token(Token = "0x6000706")]
	private void Start() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000707")]
	private void Update() { }

}

