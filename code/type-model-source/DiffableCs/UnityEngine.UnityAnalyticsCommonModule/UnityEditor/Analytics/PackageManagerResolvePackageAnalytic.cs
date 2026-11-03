namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000018")]
public class PackageManagerResolvePackageAnalytic : PackageManagerBaseAnalytic
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400003F")]
	public String[] packages; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000040")]
	public String[] package_registries; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000041")]
	public String[] package_signatures; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000042")]
	public String[] package_sources; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000043")]
	public String[] package_types; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000044")]
	public String[] package_compliance_statuses; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000045")]
	public String[] package_signature_errorCodes; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000046")]
	public String[] package_publishing_channels; //Field offset: 0x98

	[Address(RVA = "0x3478870", Offset = "0x3477C70", Length = "0x80")]
	[Token(Token = "0x600002A")]
	public PackageManagerResolvePackageAnalytic() { }

	[Address(RVA = "0x34787C0", Offset = "0x3477BC0", Length = "0xAB")]
	[RequiredByNativeCode]
	[Token(Token = "0x600002B")]
	internal static PackageManagerResolvePackageAnalytic CreatePackageManagerResolvePackageAnalytic() { }

}

