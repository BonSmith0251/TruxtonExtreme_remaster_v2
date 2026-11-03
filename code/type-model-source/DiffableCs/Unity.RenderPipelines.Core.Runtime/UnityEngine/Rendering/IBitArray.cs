namespace UnityEngine.Rendering;

[DefaultMember("Item")]
[Token(Token = "0x20001AE")]
public interface IBitArray
{

	[Token(Token = "0x1700019C")]
	public bool allFalse
	{
		[Token(Token = "0x6000CCA")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700019D")]
	public bool allTrue
	{
		[Token(Token = "0x6000CCB")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700019B")]
	public uint capacity
	{
		[Token(Token = "0x6000CC9")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700019F")]
	public string humanizedData
	{
		[Token(Token = "0x6000CCE")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700019E")]
	public bool Item
	{
		[Token(Token = "0x6000CCC")]
		 get { } //Length: 0
		[Token(Token = "0x6000CCD")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6000CCF")]
	public IBitArray BitAnd(IBitArray other) { }

	[Token(Token = "0x6000CD1")]
	public IBitArray BitNot() { }

	[Token(Token = "0x6000CD0")]
	public IBitArray BitOr(IBitArray other) { }

	[Token(Token = "0x6000CCA")]
	public bool get_allFalse() { }

	[Token(Token = "0x6000CCB")]
	public bool get_allTrue() { }

	[Token(Token = "0x6000CC9")]
	public uint get_capacity() { }

	[Token(Token = "0x6000CCE")]
	public string get_humanizedData() { }

	[Token(Token = "0x6000CCC")]
	public bool get_Item(uint index) { }

	[Token(Token = "0x6000CCD")]
	public void set_Item(uint index, bool value) { }

}

