namespace InGame.Kernel.Effect;

[CreateAssetMenu(menuName = "KANAI/AnimationPalette")]
[Token(Token = "0x2000230")]
public class AnimationPalette : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x2000232")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001386")]
		public string v; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60010BA")]
		public <>c__DisplayClass2_0() { }

		[Address(RVA = "0x1D1AA60", Offset = "0x1D19E60", Length = "0x37")]
		[Token(Token = "0x60010BB")]
		internal bool <GetClip>b__0(Sheet p) { }

	}

	[Token(Token = "0x2000231")]
	internal class Sheet
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001385")]
		public AnimationClip clipData; //Field offset: 0x10

		[Token(Token = "0x17000225")]
		public string clipName
		{
			[Address(RVA = "0x1D1A710", Offset = "0x1D19B10", Length = "0x1D")]
			[Token(Token = "0x60010B8")]
			 get { } //Length: 29
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60010B9")]
		public Sheet() { }

		[Address(RVA = "0x1D1A710", Offset = "0x1D19B10", Length = "0x1D")]
		[Token(Token = "0x60010B8")]
		public string get_clipName() { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001384")]
	public List<Sheet> palette; //Field offset: 0x18

	[Address(RVA = "0x1D130A0", Offset = "0x1D124A0", Length = "0x77")]
	[Token(Token = "0x60010B7")]
	public AnimationPalette() { }

	[Address(RVA = "0x1D12FB0", Offset = "0x1D123B0", Length = "0xEB")]
	[Token(Token = "0x60010B6")]
	public AnimationClip GetClip(string v) { }

}

