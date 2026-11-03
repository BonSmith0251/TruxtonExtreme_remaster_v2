namespace UnityEngine.ResourceManagement.ResourceLocations;

[Token(Token = "0x200006E")]
public class ResourceLocationComparer : IEqualityComparer<IResourceLocation>
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000275")]
	public ResourceLocationComparer() { }

	[Address(RVA = "0x2E48B20", Offset = "0x2E47F20", Length = "0x42")]
	[Token(Token = "0x6000273")]
	public override bool Equals(IResourceLocation x, IResourceLocation y) { }

	[Address(RVA = "0x2E48B70", Offset = "0x2E47F70", Length = "0xA3")]
	[Token(Token = "0x6000274")]
	public override int GetHashCode(IResourceLocation obj) { }

}

