namespace AEAsAnimation;

[Token(Token = "0x200004C")]
public class AEMaterial
{
	[Token(Token = "0x200004D")]
	internal class Parameters
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001C7")]
		public string _Shader; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001C8")]
		public int _StencilComp; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40001C9")]
		public int _StencilReadMask; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001CA")]
		public int _Stencil; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40001CB")]
		public int _ColorMask; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001CC")]
		public int _UseUIAlphaClip; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40001CD")]
		public int _StencilOp; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001CE")]
		public int _StencilWriteMask; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40001CF")]
		public Color _Color; //Field offset: 0x34

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000140")]
		public Parameters() { }

		[Address(RVA = "0x5C5050", Offset = "0x5C4450", Length = "0x156")]
		[Token(Token = "0x600013E")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x5C51B0", Offset = "0x5C45B0", Length = "0x147")]
		[Token(Token = "0x600013F")]
		public virtual int GetHashCode() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C6")]
	private Dictionary<Parameters, Material> _cache; //Field offset: 0x10

	[Address(RVA = "0x5C3470", Offset = "0x5C2870", Length = "0x77")]
	[Token(Token = "0x600013D")]
	public AEMaterial() { }

	[Address(RVA = "0x5C3170", Offset = "0x5C2570", Length = "0x2FA")]
	[Token(Token = "0x600013C")]
	public Material Create(Parameters parameters) { }

}

