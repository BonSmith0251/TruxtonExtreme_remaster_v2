namespace Unity.Hierarchy;

[NativeHeader("Modules/HierarchyCore/Public/HierarchyPropertyStorageType.h")]
[Token(Token = "0x2000024")]
public enum HierarchyPropertyStorageType : int
{
	Sparse = 0,
	Dense = 1,
	Blob = 2,
	Default = 1,
}

