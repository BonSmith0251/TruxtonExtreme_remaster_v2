namespace UnityEngine.Rendering;

[NativeType(Header = "Runtime/2D/Sorting/SortingGroup.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x2000336")]
public sealed class SortingGroup : Behaviour
{

	[StaticAccessor("SortingGroup", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x170003B7")]
	internal static int invalidSortingGroupID
	{
		[Address(RVA = "0x3089AA0", Offset = "0x3088EA0", Length = "0x2A")]
		[Token(Token = "0x60019E5")]
		internal get { } //Length: 42
	}

	[Token(Token = "0x170003B8")]
	public int sortingLayerID
	{
		[Address(RVA = "0x3089B10", Offset = "0x3088F10", Length = "0x77")]
		[Token(Token = "0x60019E7")]
		 get { } //Length: 119
	}

	[Token(Token = "0x170003B9")]
	public int sortingOrder
	{
		[Address(RVA = "0x3089BD0", Offset = "0x3088FD0", Length = "0x77")]
		[Token(Token = "0x60019E8")]
		 get { } //Length: 119
	}

	[Address(RVA = "0x3089AA0", Offset = "0x3088EA0", Length = "0x2A")]
	[Token(Token = "0x60019E5")]
	internal static int get_invalidSortingGroupID() { }

	[Address(RVA = "0x3089B10", Offset = "0x3088F10", Length = "0x77")]
	[Token(Token = "0x60019E7")]
	public int get_sortingLayerID() { }

	[Address(RVA = "0x3089AD0", Offset = "0x3088ED0", Length = "0x33")]
	[Token(Token = "0x60019EA")]
	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3089BD0", Offset = "0x3088FD0", Length = "0x77")]
	[Token(Token = "0x60019E8")]
	public int get_sortingOrder() { }

	[Address(RVA = "0x3089B90", Offset = "0x3088F90", Length = "0x33")]
	[Token(Token = "0x60019EB")]
	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3089A40", Offset = "0x3088E40", Length = "0x5B")]
	[StaticAccessor("SortingGroup", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x60019E6")]
	internal static SortingGroup GetSortingGroupByIndex(int index) { }

	[Address(RVA = "0x3089A00", Offset = "0x3088E00", Length = "0x31")]
	[Token(Token = "0x60019E9")]
	private static IntPtr GetSortingGroupByIndex_Injected(int index) { }

}

