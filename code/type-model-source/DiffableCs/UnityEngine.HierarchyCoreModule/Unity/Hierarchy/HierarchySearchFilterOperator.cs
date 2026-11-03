namespace Unity.Hierarchy;

[NativeHeader("Modules/HierarchyCore/Public/HierarchySearch.h")]
[Token(Token = "0x2000025")]
public enum HierarchySearchFilterOperator : int
{
	Equal = 0,
	Contains = 1,
	Greater = 2,
	GreaterOrEqual = 3,
	Lesser = 4,
	LesserOrEqual = 5,
	NotEqual = 6,
	Not = 7,
}

