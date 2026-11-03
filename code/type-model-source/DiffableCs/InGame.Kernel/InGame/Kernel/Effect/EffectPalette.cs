namespace InGame.Kernel.Effect;

[CreateAssetMenu(menuName = "KANAI/EffectPalette")]
[Token(Token = "0x2000233")]
public class EffectPalette : ScriptableObject
{
	[Token(Token = "0x2000234")]
	internal class Sheet
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001388")]
		public string effectName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001389")]
		public ID soundID; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400138A")]
		public int callRate; //Field offset: 0x1C

		[Address(RVA = "0x1D1A6D0", Offset = "0x1D19AD0", Length = "0x3D")]
		[Token(Token = "0x60010BD")]
		public Sheet() { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001387")]
	public List<Sheet> palette; //Field offset: 0x18

	[Address(RVA = "0x1D13640", Offset = "0x1D12A40", Length = "0x77")]
	[Token(Token = "0x60010BC")]
	public EffectPalette() { }

}

