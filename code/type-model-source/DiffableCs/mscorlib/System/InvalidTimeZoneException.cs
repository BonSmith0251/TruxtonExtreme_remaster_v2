namespace System;

[Token(Token = "0x2000106")]
[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
public class InvalidTimeZoneException : Exception
{

	[Address(RVA = "0x2029110", Offset = "0x2028510", Length = "0x49")]
	[Token(Token = "0x6000825")]
	public InvalidTimeZoneException() { }

	[Address(RVA = "0x20290B0", Offset = "0x20284B0", Length = "0x59")]
	[Token(Token = "0x6000826")]
	public InvalidTimeZoneException(string message) { }

	[Address(RVA = "0x2029160", Offset = "0x2028560", Length = "0x74")]
	[Token(Token = "0x6000827")]
	protected InvalidTimeZoneException(SerializationInfo info, StreamingContext context) { }

}

