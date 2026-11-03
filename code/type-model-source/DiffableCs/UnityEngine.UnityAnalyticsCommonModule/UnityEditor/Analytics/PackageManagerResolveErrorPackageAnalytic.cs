namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x200001B")]
public class PackageManagerResolveErrorPackageAnalytic : PackageManagerBaseAnalytic
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000047")]
	public string reason; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000048")]
	public string action; //Field offset: 0x68

	[Address(RVA = "0x3478740", Offset = "0x3477B40", Length = "0x80")]
	[Token(Token = "0x6000030")]
	public PackageManagerResolveErrorPackageAnalytic() { }

	[Address(RVA = "0x3478690", Offset = "0x3477A90", Length = "0xAB")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000031")]
	internal static PackageManagerResolveErrorPackageAnalytic CreatePackageManagerResolveErrorPackageAnalytic() { }

}

