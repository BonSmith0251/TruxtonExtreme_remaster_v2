namespace System.Data;

[Token(Token = "0x2000078")]
public class PropertyCollection : Hashtable, ICloneable
{

	[Address(RVA = "0x234B0C0", Offset = "0x234A4C0", Length = "0x7")]
	[Token(Token = "0x6000672")]
	public PropertyCollection() { }

	[Address(RVA = "0x234B0D0", Offset = "0x234A4D0", Length = "0x1F")]
	[Token(Token = "0x6000673")]
	protected PropertyCollection(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x234AE60", Offset = "0x234A260", Length = "0x256")]
	[Token(Token = "0x6000674")]
	public virtual object Clone() { }

}

