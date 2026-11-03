namespace System.Diagnostics.Contracts;

[Token(Token = "0x2000590")]
public static class Contract
{

	[Address(RVA = "0x7AB410", Offset = "0x7AA810", Length = "0x207")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x600290E")]
	public static bool ForAll(IEnumerable<T> collection, Predicate<T> predicate) { }

}

