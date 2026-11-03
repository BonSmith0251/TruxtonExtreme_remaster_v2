namespace UnityEngine.Rendering;

[Token(Token = "0x2000080")]
internal struct EditorInstanceDataArrays : IDataArrays
{
	[IsReadOnly]
	[Token(Token = "0x2000081")]
	public struct ReadOnly
	{

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000294")]
		public ReadOnly(in CPUInstanceData instanceData) { }

	}


	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000290")]
	public override void Dispose() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000291")]
	public override void Grow(int newCapacity) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600028F")]
	public override void Initialize(int initCapacity) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000292")]
	public override void Remove(int index, int lastIndex) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000293")]
	public override void SetDefault(int index) { }

}

