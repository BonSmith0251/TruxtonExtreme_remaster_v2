namespace UnityEngine.Timeline;

[AttributeUsage(AttributeTargets::Class (4), Inherited = False)]
[Token(Token = "0x2000066")]
internal class SupportsChildTracksAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000169")]
	public readonly Type childType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400016A")]
	public readonly int levels; //Field offset: 0x18

	[Address(RVA = "0x5D2830", Offset = "0x5D1C30", Length = "0x42")]
	[Token(Token = "0x6000324")]
	public SupportsChildTracksAttribute(Type childType = null, int levels = 2147483647) { }

}

