namespace InGame.Kernel.Enemy;

[CreateAssetMenu(menuName = "InGame/BulletTemplateSelecter")]
[Token(Token = "0x2000157")]
public class BulletTemplateSelecter : ScriptableObject
{
	[Token(Token = "0x2000158")]
	internal class Sheet
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000998")]
		public PlayMode pmode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x4000999")]
		private string _btName; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Range(0, 1)]
		[Token(Token = "0x400099A")]
		public float _rate; //Field offset: 0x20

		[Token(Token = "0x170001C5")]
		public string BtName
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x6000A77")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x1D37C50", Offset = "0x1D37050", Length = "0x36")]
		[Token(Token = "0x6000A79")]
		public Sheet() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000A77")]
		public string get_BtName() { }

		[Address(RVA = "0x1D72B10", Offset = "0x1D71F10", Length = "0x7")]
		[Token(Token = "0x6000A78")]
		public bool IsHit(PlayMode tmode) { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000995")]
	public List<Sheet> btpalette; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000996")]
	public PlayMode _currentMode; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000997")]
	private List<Sheet> _currentSheets; //Field offset: 0x28

	[Address(RVA = "0x1D61420", Offset = "0x1D60820", Length = "0x77")]
	[Token(Token = "0x6000A76")]
	public BulletTemplateSelecter() { }

	[Address(RVA = "0x1D61030", Offset = "0x1D60430", Length = "0x1CD")]
	[Token(Token = "0x6000A73")]
	public string GetBT(float trate) { }

	[Address(RVA = "0x1D60E70", Offset = "0x1D60270", Length = "0x1BB")]
	[Token(Token = "0x6000A74")]
	public String[] GetBTS() { }

	[Address(RVA = "0x1D61200", Offset = "0x1D60600", Length = "0x189")]
	[Token(Token = "0x6000A75")]
	public List<Sheet> GetSheet(PlayMode tmode) { }

	[Address(RVA = "0x1D61390", Offset = "0x1D60790", Length = "0x87")]
	[Token(Token = "0x6000A72")]
	public void SetCurrentMode(PlayMode tmode) { }

}

