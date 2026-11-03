namespace InGame.Kernel.Param;

[CreateAssetMenu(menuName = "InGame/JetColor")]
[Token(Token = "0x200013F")]
public class PlayerJetColors : ScriptableObject
{
	[Token(Token = "0x2000140")]
	internal class Sheet
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000933")]
		public string objName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000934")]
		public MinMaxGradient jetColor; //Field offset: 0x18

		[Address(RVA = "0x1D39B10", Offset = "0x1D38F10", Length = "0x36")]
		[Token(Token = "0x6000A07")]
		public Sheet() { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000932")]
	public List<Sheet> palette; //Field offset: 0x18

	[Address(RVA = "0x1D727C0", Offset = "0x1D71BC0", Length = "0x77")]
	[Token(Token = "0x6000A06")]
	public PlayerJetColors() { }

	[Address(RVA = "0x1D725F0", Offset = "0x1D719F0", Length = "0x1CD")]
	[Token(Token = "0x6000A04")]
	public MinMaxGradient GetColor(string tname) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000A05")]
	public List<Sheet> Sheets() { }

}

