namespace System.Xml;

[Token(Token = "0x200003C")]
internal class SecureStringHasher : IEqualityComparer<String>
{
	[Token(Token = "0x200003D")]
	private sealed class HashCodeOfStringDelegate : MulticastDelegate
	{

		[Address(RVA = "0x24EA940", Offset = "0x24E9D40", Length = "0xB5")]
		[Token(Token = "0x60001A7")]
		public HashCodeOfStringDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x60001A8")]
		public override int Invoke(string s, int sLen, long additionalEntropy) { }

	}

	[Token(Token = "0x4000136")]
	private static HashCodeOfStringDelegate hashCodeDelegate; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000137")]
	private int hashCodeRandomizer; //Field offset: 0x10

	[Address(RVA = "0x24ED0B0", Offset = "0x24EC4B0", Length = "0x20")]
	[Token(Token = "0x60001A2")]
	public SecureStringHasher() { }

	[Address(RVA = "0x24ECD80", Offset = "0x24EC180", Length = "0x17")]
	[Token(Token = "0x60001A3")]
	public override bool Equals(string x, string y) { }

	[Address(RVA = "0x24ECFF0", Offset = "0x24EC3F0", Length = "0xB8")]
	[Token(Token = "0x60001A4")]
	public override int GetHashCode(string key) { }

	[Address(RVA = "0x24ECDA0", Offset = "0x24EC1A0", Length = "0x1CC")]
	[Token(Token = "0x60001A6")]
	private static HashCodeOfStringDelegate GetHashCodeDelegate() { }

	[Address(RVA = "0x24ECF70", Offset = "0x24EC370", Length = "0x70")]
	[Token(Token = "0x60001A5")]
	private static int GetHashCodeOfString(string key, int sLen, long additionalEntropy) { }

}

