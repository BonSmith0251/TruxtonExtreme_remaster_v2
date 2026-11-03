namespace Unity.Hierarchy;

[Flags]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyNodeFlags.h")]
[Token(Token = "0x2000020")]
public enum HierarchyNodeFlags : uint
{
	None = 0,
	Expanded = 1,
	Selected = 2,
	Cut = 4,
	Hidden = 8,
}

