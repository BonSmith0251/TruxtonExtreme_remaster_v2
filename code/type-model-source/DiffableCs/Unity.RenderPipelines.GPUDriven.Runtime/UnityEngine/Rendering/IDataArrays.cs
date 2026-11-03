namespace UnityEngine.Rendering;

[Token(Token = "0x200007F")]
internal interface IDataArrays
{

	[Token(Token = "0x600028B")]
	public void Dispose() { }

	[Token(Token = "0x600028C")]
	public void Grow(int newCapacity) { }

	[Token(Token = "0x600028A")]
	public void Initialize(int initCapacity) { }

	[Token(Token = "0x600028D")]
	public void Remove(int index, int lastIndex) { }

	[Token(Token = "0x600028E")]
	public void SetDefault(int index) { }

}

