//Type is in global namespace

[CreateAssetMenu(fileName = "SRPFogData00", menuName = "Rendering/CustomFeature/SRP Fog Data", order = 2000)]
[Token(Token = "0x2000002")]
public class SRPFogData : ScriptableObject
{
	[Token(Token = "0x2000003")]
	internal class FogData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000002")]
		public bool UseFog; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000003")]
		public Color FogColor; //Field offset: 0x14
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000004")]
		public FogMode FogMode; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000005")]
		public float FogStart; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000006")]
		public float FogEnd; //Field offset: 0x2C

		[Address(RVA = "0x2228420", Offset = "0x2227820", Length = "0x33")]
		[Token(Token = "0x6000004")]
		public FogData() { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000001")]
	private FogData _data; //Field offset: 0x18

	[Token(Token = "0x17000001")]
	public FogData Data
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000001")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x22284C0", Offset = "0x22278C0", Length = "0x83")]
	[Token(Token = "0x6000003")]
	public SRPFogData() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000001")]
	public FogData get_Data() { }

	[Address(RVA = "0x2228460", Offset = "0x2227860", Length = "0x57")]
	[Token(Token = "0x6000002")]
	public void SetData(bool use, Color col, FogMode mode, float start, float end) { }

}

