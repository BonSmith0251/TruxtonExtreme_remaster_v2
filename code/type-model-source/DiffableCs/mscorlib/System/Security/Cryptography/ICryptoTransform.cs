namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000304")]
public interface ICryptoTransform : IDisposable
{

	[Token(Token = "0x17000277")]
	public bool CanTransformMultipleBlocks
	{
		[Token(Token = "0x600189E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000275")]
	public int InputBlockSize
	{
		[Token(Token = "0x600189C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000276")]
	public int OutputBlockSize
	{
		[Token(Token = "0x600189D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600189E")]
	public bool get_CanTransformMultipleBlocks() { }

	[Token(Token = "0x600189C")]
	public int get_InputBlockSize() { }

	[Token(Token = "0x600189D")]
	public int get_OutputBlockSize() { }

	[Token(Token = "0x600189F")]
	public int TransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	[Token(Token = "0x60018A0")]
	public Byte[] TransformFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

